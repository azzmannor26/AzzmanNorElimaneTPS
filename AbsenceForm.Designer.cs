namespace WindowsFormsApp1
{
    partial class AbsenceForm
    {
        private System.ComponentModel.IContainer components = null;

        // UI Elements
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblNbrAbsences;
        private System.Windows.Forms.Label lblSemaine;
        private System.Windows.Forms.Label lblTotalAbsences;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtNbrAbsences;
        private System.Windows.Forms.TextBox txtSemaine;
        private System.Windows.Forms.TextBox txtTotalAbsences;
        private System.Windows.Forms.Button btnEnregistrer;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        /// <summary>
        /// Required method for Designer support
        /// </summary>
        private void InitializeComponent()
        {
            this.lblID = new System.Windows.Forms.Label();
            this.lblNbrAbsences = new System.Windows.Forms.Label();
            this.lblSemaine = new System.Windows.Forms.Label();
            this.lblTotalAbsences = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtNbrAbsences = new System.Windows.Forms.TextBox();
            this.txtSemaine = new System.Windows.Forms.TextBox();
            this.txtTotalAbsences = new System.Windows.Forms.TextBox();
            this.btnEnregistrer = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // Label ID
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(20, 20);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(21, 13);
            this.lblID.Text = "ID:";

            // TextBox ID
            this.txtID.Location = new System.Drawing.Point(120, 20);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 20);

            // Label Nbr Absences
            this.lblNbrAbsences.AutoSize = true;
            this.lblNbrAbsences.Location = new System.Drawing.Point(20, 50);
            this.lblNbrAbsences.Name = "lblNbrAbsences";
            this.lblNbrAbsences.Size = new System.Drawing.Size(80, 13);
            this.lblNbrAbsences.Text = "Nbr Absences:";

            // TextBox Nbr Absences
            this.txtNbrAbsences.Location = new System.Drawing.Point(120, 50);
            this.txtNbrAbsences.Name = "txtNbrAbsences";
            this.txtNbrAbsences.Size = new System.Drawing.Size(100, 20);

            // Label Semaine
            this.lblSemaine.AutoSize = true;
            this.lblSemaine.Location = new System.Drawing.Point(20, 80);
            this.lblSemaine.Name = "lblSemaine";
            this.lblSemaine.Size = new System.Drawing.Size(52, 13);
            this.lblSemaine.Text = "Semaine:";

            // TextBox Semaine
            this.txtSemaine.Location = new System.Drawing.Point(120, 80);
            this.txtSemaine.Name = "txtSemaine";
            this.txtSemaine.Size = new System.Drawing.Size(100, 20);

            // Label Total Absences
            this.lblTotalAbsences.AutoSize = true;
            this.lblTotalAbsences.Location = new System.Drawing.Point(20, 110);
            this.lblTotalAbsences.Name = "lblTotalAbsences";
            this.lblTotalAbsences.Size = new System.Drawing.Size(85, 13);
            this.lblTotalAbsences.Text = "Total Absences:";

            // TextBox Total Absences
            this.txtTotalAbsences.Location = new System.Drawing.Point(120, 110);
            this.txtTotalAbsences.Name = "txtTotalAbsences";
            this.txtTotalAbsences.Size = new System.Drawing.Size(100, 20);
            this.txtTotalAbsences.ReadOnly = true;

            // Button Enregistrer
            this.btnEnregistrer.Location = new System.Drawing.Point(120, 140);
            this.btnEnregistrer.Name = "btnEnregistrer";
            this.btnEnregistrer.Size = new System.Drawing.Size(100, 23);
            this.btnEnregistrer.Text = "Enregistrer";
            this.btnEnregistrer.UseVisualStyleBackColor = true;
            this.btnEnregistrer.Click += new System.EventHandler(this.btnEnregistrer_Click);

            // AbsenceForm
            this.ClientSize = new System.Drawing.Size(300, 200);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblNbrAbsences);
            this.Controls.Add(this.txtNbrAbsences);
            this.Controls.Add(this.lblSemaine);
            this.Controls.Add(this.txtSemaine);
            this.Controls.Add(this.lblTotalAbsences);
            this.Controls.Add(this.txtTotalAbsences);
            this.Controls.Add(this.btnEnregistrer);
            this.Name = "AbsenceForm";
            this.Text = "Absence";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
