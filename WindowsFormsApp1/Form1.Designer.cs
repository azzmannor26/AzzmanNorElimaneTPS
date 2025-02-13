namespace WindowsFormsApp1
{
    partial class Form1
    {
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nbr;
        private System.Windows.Forms.TextBox totalText;
        private System.Windows.Forms.Button button1;

        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nbr = new System.Windows.Forms.TextBox();
            this.totalText = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // label1
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 20);
            this.label1.Text = "Nombre de photocopies:";

            // label2
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 20);
            this.label2.Text = "Total à payer:";

            // nbr (TextBox for input)
            this.nbr.Location = new System.Drawing.Point(250, 50);
            this.nbr.Name = "nbr";
            this.nbr.Size = new System.Drawing.Size(100, 26);

            // totalText (TextBox for output)
            this.totalText.Location = new System.Drawing.Point(250, 100);
            this.totalText.Name = "totalText";
            this.totalText.ReadOnly = true;
            this.totalText.Size = new System.Drawing.Size(100, 26);

            // button1 (Calculate Button)
            this.button1.Location = new System.Drawing.Point(150, 150);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 30);
            this.button1.Text = "Calculer";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);

            // Form1
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 250);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nbr);
            this.Controls.Add(this.totalText);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Facture Photocopies";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
