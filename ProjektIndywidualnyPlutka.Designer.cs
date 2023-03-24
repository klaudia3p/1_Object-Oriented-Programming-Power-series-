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
            this.txtXd = new System.Windows.Forms.TextBox();
            this.txtXg = new System.Windows.Forms.TextBox();
            this.txtH = new System.Windows.Forms.TextBox();
            this.kpbtnAnimacja = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.kppbRysownica)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // kppbRysownica
            // 
            this.kppbRysownica.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.kppbRysownica.Location = new System.Drawing.Point(36, 96);
            this.kppbRysownica.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.kppbRysownica.Name = "kppbRysownica";
            this.kppbRysownica.Size = new System.Drawing.Size(476, 307);
            this.kppbRysownica.TabIndex = 0;
            this.kppbRysownica.TabStop = false;
            this.kppbRysownica.Paint += new System.Windows.Forms.PaintEventHandler(this.kppbRysownica_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(32, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Xd";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(216, 40);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Xg";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(417, 40);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 22);
            this.label3.TabIndex = 3;
            this.label3.Text = "h";
            // 
            // txtXd
            // 
            this.txtXd.Location = new System.Drawing.Point(68, 43);
            this.txtXd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtXd.Name = "txtXd";
            this.txtXd.Size = new System.Drawing.Size(100, 20);
            this.txtXd.TabIndex = 4;
            // 
            // txtXg
            // 
            this.txtXg.Location = new System.Drawing.Point(257, 43);
            this.txtXg.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtXg.Name = "txtXg";
            this.txtXg.Size = new System.Drawing.Size(100, 20);
            this.txtXg.TabIndex = 5;
            // 
            // txtH
            // 
            this.txtH.Location = new System.Drawing.Point(445, 43);
            this.txtH.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtH.Name = "txtH";
            this.txtH.Size = new System.Drawing.Size(100, 20);
            this.txtH.TabIndex = 6;
            // 
            // kpbtnAnimacja
            // 
            this.kpbtnAnimacja.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.kpbtnAnimacja.Location = new System.Drawing.Point(581, 58);
            this.kpbtnAnimacja.Name = "kpbtnAnimacja";
            this.kpbtnAnimacja.Size = new System.Drawing.Size(167, 81);
            this.kpbtnAnimacja.TabIndex = 7;
            this.kpbtnAnimacja.Text = "Animacja po lini toru";
            this.kpbtnAnimacja.UseVisualStyleBackColor = true;
            this.kpbtnAnimacja.Click += new System.EventHandler(this.kpbtnAnimacja_Click);
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
            this.Controls.Add(this.kpbtnAnimacja);
            this.Controls.Add(this.txtH);
            this.Controls.Add(this.txtXg);
            this.Controls.Add(this.txtXd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.kppbRysownica);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ProjektIndywidualnyPlutka";
            this.Text = "ProjektIndywidualnyNr1";
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
        private System.Windows.Forms.TextBox txtXd;
        private System.Windows.Forms.TextBox txtXg;
        private System.Windows.Forms.TextBox txtH;
        private System.Windows.Forms.Button kpbtnAnimacja;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Timer timer1;
    }
}