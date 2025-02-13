using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int nombrePhotocopies;
            if (int.TryParse(nbr.Text, out nombrePhotocopies) && nombrePhotocopies >= 0)
            {
                double total = CalculerFacture(nombrePhotocopies);
                totalText.Text = total.ToString("F2") + " Dhs";
            }
            else
            {
                MessageBox.Show("Veuillez entrer un nombre valide de photocopies.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private double CalculerFacture(int nombrePhotocopies)
        {
            double total = 0;
            if (nombrePhotocopies <= 10)
            {
                total = nombrePhotocopies * 0.5;
            }
            else if (nombrePhotocopies <= 30)
            {
                total = (10 * 0.5) + ((nombrePhotocopies - 10) * 0.25);
            }
            else
            {
                total = (10 * 0.5) + (20 * 0.25) + ((nombrePhotocopies - 30) * 0.1);
            }
            return total;
        }
    }
}
