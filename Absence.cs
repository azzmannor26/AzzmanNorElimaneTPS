using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp1
{
    internal class Absence
    {
        public int Num_semaine {  get; set; }
        public int id { get; set; }
        public int Nbr_absences { get; set; }
        private Database db;

        public Absence (int Num_semaine, int id,int Nbr_absences)
        {
            this.Num_semaine = Num_semaine;
            this.id = id;
            this.Nbr_absences += Nbr_absences;
            db = new Database();
        }

        // ✅ 1. Ajouter une absence
        public void AjouterAbsence()
        {
            try
            {
                using (MySqlConnection conn = db.GetConnection())
                {
                    conn.Open();
                    string query = "INSERT INTO Absences (Num_semaine, ID, Nbr_absences) VALUES (@numSemaine, @id, @nbrAbsences)";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@numSemaine", Num_semaine);
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.Parameters.AddWithValue("@nbrAbsences", Nbr_absences);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            Console.WriteLine("Absence ajoutée avec succès !");
                        }
                        else
                        {
                            Console.WriteLine("Erreur : Aucune absence ajoutée.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erreur : " + ex.Message);
            }
        }


    }
}
