using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp1
{
    public partial class AbsenceForm : Form
    {
        public AbsenceForm()
        {
            InitializeComponent();
        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            try
            {
                int semaine = int.Parse(txtSemaine.Text);
                int id = int.Parse(txtID.Text);
                int nbrAbsences = int.Parse(txtNbrAbsences.Text);

                // Ajouter l'absence dans la base de données
                Absence absence = new Absence(semaine, id, nbrAbsences);
                absence.AjouterAbsence();

                MessageBox.Show("Absence enregistrée !");
                txtTotalAbsences.Text = GetTotalAbsences(id).ToString(); // Met à jour le total
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message);
            }
        }

        private int GetTotalAbsences(int id)
        {
            int total = 0;

            try
            {
                using (MySqlConnection conn = new Database().GetConnection())
                {
                    conn.Open();
                    string query = "SELECT SUM(Nbr_absences) FROM Absences WHERE ID = @id";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", id);

                        object result = cmd.ExecuteScalar();
                        if (result != DBNull.Value)
                        {
                            total = Convert.ToInt32(result);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors du calcul des absences : " + ex.Message);
            }

            return total;
        }
    }
}
