namespace ProjektNr1_Plutka_62026
{
    partial class LaboratoriumNr1
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
            this.components = new System.ComponentModel.Container();
            this.pbRysownica = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbRysownica)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // pbRysownica
            // 
            this.pbRysownica.Location = new System.Drawing.Point(155, 169);
            this.pbRysownica.Name = "pbRysownica";
            this.pbRysownica.Size = new System.Drawing.Size(718, 469);
            this.pbRysownica.TabIndex = 0;
            this.pbRysownica.TabStop = false;
            this.pbRysownica.Paint += new System.Windows.Forms.PaintEventHandler(this.pbRysownica_Paint);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // LaboratoriumNr1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1151, 746);
            this.Controls.Add(this.pbRysownica);
            this.Name = "LaboratoriumNr1";
            this.Text = "LaboratoriumNr1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LaboratoriumNr1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pbRysownica)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbRysownica;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}