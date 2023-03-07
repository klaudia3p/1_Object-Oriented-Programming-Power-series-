namespace ProjektNr1_Plutka_62026
{
    partial class KokpitPlutka
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btnLaboratoriumNr1 = new System.Windows.Forms.Button();
            this.btnProjektNr1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(227, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(296, 72);
            this.label1.TabIndex = 0;
            this.label1.Text = "Animacja Komputerowa \r\npo lini toru wyznaczonego przez \r\nwykres szeregu potęgoweg" +
    "o\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnLaboratoriumNr1
            // 
            this.btnLaboratoriumNr1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnLaboratoriumNr1.Location = new System.Drawing.Point(66, 157);
            this.btnLaboratoriumNr1.Name = "btnLaboratoriumNr1";
            this.btnLaboratoriumNr1.Size = new System.Drawing.Size(243, 98);
            this.btnLaboratoriumNr1.TabIndex = 1;
            this.btnLaboratoriumNr1.Text = "Laboratorium Nr1\r\nSzereg Laboratoryjny";
            this.btnLaboratoriumNr1.UseVisualStyleBackColor = true;
            this.btnLaboratoriumNr1.Click += new System.EventHandler(this.btnLaboratoriumNr1_Click);
            // 
            // btnProjektNr1
            // 
            this.btnProjektNr1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnProjektNr1.Location = new System.Drawing.Point(432, 157);
            this.btnProjektNr1.Name = "btnProjektNr1";
            this.btnProjektNr1.Size = new System.Drawing.Size(237, 98);
            this.btnProjektNr1.TabIndex = 2;
            this.btnProjektNr1.Text = "Projekt Nr1\r\nSzereg Indywidualny\r\n";
            this.btnProjektNr1.UseVisualStyleBackColor = true;
            this.btnProjektNr1.Click += new System.EventHandler(this.btnProjektNr1_Click);
            // 
            // KokpitPlutka
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnProjektNr1);
            this.Controls.Add(this.btnLaboratoriumNr1);
            this.Controls.Add(this.label1);
            this.Name = "KokpitPlutka";
            this.Text = "Animacja Komputerowa";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.KokpitPlutka_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLaboratoriumNr1;
        private System.Windows.Forms.Button btnProjektNr1;
    }
}

