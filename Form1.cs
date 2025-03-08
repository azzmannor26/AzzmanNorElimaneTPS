using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private Database db;
        private List<Eleve> eleves;

        public Form1()
        {
            InitializeComponent();
            db = new Database();
            LoadEleves();
        }

        private void LoadEleves()
        {
            eleves = new Eleve(0, "", "", "").Lister();
            dataGridView1.DataSource = eleves;
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            Eleve eleve = new Eleve(
                int.Parse(txtID.Text),
                txtNom.Text,
                txtPrenom.Text,
                txtGroupe.Text
            );

            eleve.ajouterEtudiant(eleve);
            LoadEleves();
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            Eleve eleve = new Eleve(
                int.Parse(txtID.Text),
                txtNom.Text,
                txtPrenom.Text,
                txtGroupe.Text
            );

            eleve.updateEtudiant(eleve);
            LoadEleves();
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtID.Text);
            new Eleve(0, "", "", "").deleteEtudiant(id);
            LoadEleves();
        }

        private void btnRechercher_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtID.Text);
            Eleve eleve = new Eleve(0, "", "", "").Rechercher(id);

            if (eleve != null)
            {
                txtNom.Text = eleve.nom;
                txtPrenom.Text = eleve.prenom;
                txtGroupe.Text = eleve.groupe;
            }
            else
            {
                MessageBox.Show("Élève non trouvé.");
            }
        }

        private void btnGestionAbsences_Click(object sender, EventArgs e)
        {
            AbsenceForm absenceForm = new AbsenceForm();
            absenceForm.Show();
        }
    }
}

