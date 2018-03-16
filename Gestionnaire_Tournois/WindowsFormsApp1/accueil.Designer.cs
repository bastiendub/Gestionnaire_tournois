namespace WindowsFormsApp1
{
    partial class accueil
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnConsultation = new System.Windows.Forms.Button();
            this.lblNom = new System.Windows.Forms.Label();
            this.btnCreation = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnConsultation
            // 
            this.btnConsultation.Location = new System.Drawing.Point(340, 206);
            this.btnConsultation.Name = "btnConsultation";
            this.btnConsultation.Size = new System.Drawing.Size(130, 47);
            this.btnConsultation.TabIndex = 0;
            this.btnConsultation.Text = "Consulter un tournois";
            this.btnConsultation.UseVisualStyleBackColor = true;
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(13, 13);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(27, 13);
            this.lblNom.TabIndex = 1;
            this.lblNom.Text = "nom";
            // 
            // btnCreation
            // 
            this.btnCreation.Location = new System.Drawing.Point(340, 123);
            this.btnCreation.Name = "btnCreation";
            this.btnCreation.Size = new System.Drawing.Size(130, 42);
            this.btnCreation.TabIndex = 2;
            this.btnCreation.Text = "Créer un tournois";
            this.btnCreation.UseVisualStyleBackColor = true;
            this.btnCreation.Click += new System.EventHandler(this.btnCreation_Click);
            // 
            // accueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGreen;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.btnCreation);
            this.Controls.Add(this.lblNom);
            this.Controls.Add(this.btnConsultation);
            this.Name = "accueil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "accueil";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConsultation;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Button btnCreation;
    }
}