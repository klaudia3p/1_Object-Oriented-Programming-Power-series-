namespace ProjektNr1_Plutka_62026
{
    partial class ProjektIndywidualnyPlutka
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
            this.kppbRysownica = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtXd = new System.Windows.Forms.TextBox();
            this.txtXg = new System.Windows.Forms.TextBox();
            this.txtH = new System.Windows.Forms.TextBox();
            this.kpbtnAnimacja = new System.Windows.Forms.Button();
            this.kpbtnWizualizacjaTabelaryczna = new System.Windows.Forms.Button();
            this.kpbtnWizualizacjaGraficzna = new System.Windows.Forms.Button();
            this.kpbtnReset = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.kppbRysownica)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // kppbRysownica
            // 
            this.kppbRysownica.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.kppbRysownica.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.kppbRysownica.Location = new System.Drawing.Point(39, 111);
            this.kppbRysownica.Name = "kppbRysownica";
            this.kppbRysownica.Size = new System.Drawing.Size(486, 307);
            this.kppbRysownica.TabIndex = 0;
            this.kppbRysownica.TabStop = false;
            this.kppbRysownica.Paint += new System.Windows.Forms.PaintEventHandler(this.kppbRysownica_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Przedział wartości zmiennej niezależenej x:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Xd";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(225, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Xg";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(422, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "h";
            // 
            // txtXd
            // 
            this.txtXd.Location = new System.Drawing.Point(62, 52);
            this.txtXd.Name = "txtXd";
            this.txtXd.Size = new System.Drawing.Size(100, 20);
            this.txtXd.TabIndex = 5;
            // 
            // txtXg
            // 
            this.txtXg.Location = new System.Drawing.Point(251, 52);
            this.txtXg.Name = "txtXg";
            this.txtXg.Size = new System.Drawing.Size(100, 20);
            this.txtXg.TabIndex = 6;
            // 
            // txtH
            // 
            this.txtH.Location = new System.Drawing.Point(441, 52);
            this.txtH.Name = "txtH";
            this.txtH.Size = new System.Drawing.Size(100, 20);
            this.txtH.TabIndex = 7;
            // 
            // kpbtnAnimacja
            // 
            this.kpbtnAnimacja.Location = new System.Drawing.Point(593, 94);
            this.kpbtnAnimacja.Name = "kpbtnAnimacja";
            this.kpbtnAnimacja.Size = new System.Drawing.Size(156, 54);
            this.kpbtnAnimacja.TabIndex = 8;
            this.kpbtnAnimacja.Text = "Animacja po lini toru";
            this.kpbtnAnimacja.UseVisualStyleBackColor = true;
            this.kpbtnAnimacja.Click += new System.EventHandler(this.kpbtnAnimacja_Click);
            // 
            // kpbtnWizualizacjaTabelaryczna
            // 
            this.kpbtnWizualizacjaTabelaryczna.Location = new System.Drawing.Point(593, 174);
            this.kpbtnWizualizacjaTabelaryczna.Name = "kpbtnWizualizacjaTabelaryczna";
            this.kpbtnWizualizacjaTabelaryczna.Size = new System.Drawing.Size(156, 54);
            this.kpbtnWizualizacjaTabelaryczna.TabIndex = 9;
            this.kpbtnWizualizacjaTabelaryczna.Text = "Wizualizacja Tabelaryczna";
            this.kpbtnWizualizacjaTabelaryczna.UseVisualStyleBackColor = true;
            // 
            // kpbtnWizualizacjaGraficzna
            // 
            this.kpbtnWizualizacjaGraficzna.Location = new System.Drawing.Point(593, 250);
            this.kpbtnWizualizacjaGraficzna.Name = "kpbtnWizualizacjaGraficzna";
            this.kpbtnWizualizacjaGraficzna.Size = new System.Drawing.Size(156, 54);
            this.kpbtnWizualizacjaGraficzna.TabIndex = 10;
            this.kpbtnWizualizacjaGraficzna.Text = "Wizualizacja Graficzna";
            this.kpbtnWizualizacjaGraficzna.UseVisualStyleBackColor = true;
            // 
            // kpbtnReset
            // 
            this.kpbtnReset.Location = new System.Drawing.Point(593, 331);
            this.kpbtnReset.Name = "kpbtnReset";
            this.kpbtnReset.Size = new System.Drawing.Size(156, 50);
            this.kpbtnReset.TabIndex = 11;
            this.kpbtnReset.Text = "Reset";
            this.kpbtnReset.UseVisualStyleBackColor = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ProjektIndywidualnyPlutka
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.kpbtnReset);
            this.Controls.Add(this.kpbtnWizualizacjaGraficzna);
            this.Controls.Add(this.kpbtnWizualizacjaTabelaryczna);
            this.Controls.Add(this.kpbtnAnimacja);
            this.Controls.Add(this.txtH);
            this.Controls.Add(this.txtXg);
            this.Controls.Add(this.txtXd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.kppbRysownica);
            this.Name = "ProjektIndywidualnyPlutka";
            this.Text = "ProjektIndywidualnyPlutka";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ProjektIndywidualnyPlutka_FormClosing);
            this.Load += new System.EventHandler(this.ProjektIndywidualnyPlutka_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kppbRysownica)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox kppbRysownica;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtXd;
        private System.Windows.Forms.TextBox txtXg;
        private System.Windows.Forms.TextBox txtH;
        private System.Windows.Forms.Button kpbtnAnimacja;
        private System.Windows.Forms.Button kpbtnWizualizacjaTabelaryczna;
        private System.Windows.Forms.Button kpbtnWizualizacjaGraficzna;
        private System.Windows.Forms.Button kpbtnReset;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Timer timer1;
    }
}