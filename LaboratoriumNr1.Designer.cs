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
            this.label1 = new System.Windows.Forms.Label();
            this.txtXd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtXg = new System.Windows.Forms.TextBox();
            this.txtH = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAnimacja = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbRysownica)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // pbRysownica
            // 
            this.pbRysownica.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pbRysownica.Location = new System.Drawing.Point(36, 144);
            this.pbRysownica.Name = "pbRysownica";
            this.pbRysownica.Size = new System.Drawing.Size(809, 506);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(64, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Xd";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtXd
            // 
            this.txtXd.Location = new System.Drawing.Point(115, 66);
            this.txtXd.Name = "txtXd";
            this.txtXd.Size = new System.Drawing.Size(152, 20);
            this.txtXd.TabIndex = 2;
            this.txtXd.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(363, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Xg";
            // 
            // txtXg
            // 
            this.txtXg.Location = new System.Drawing.Point(405, 71);
            this.txtXg.Name = "txtXg";
            this.txtXg.Size = new System.Drawing.Size(131, 20);
            this.txtXg.TabIndex = 4;
            // 
            // txtH
            // 
            this.txtH.Location = new System.Drawing.Point(632, 71);
            this.txtH.Name = "txtH";
            this.txtH.Size = new System.Drawing.Size(136, 20);
            this.txtH.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(596, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "h";
            // 
            // btnAnimacja
            // 
            this.btnAnimacja.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAnimacja.Location = new System.Drawing.Point(892, 96);
            this.btnAnimacja.Name = "btnAnimacja";
            this.btnAnimacja.Size = new System.Drawing.Size(213, 74);
            this.btnAnimacja.TabIndex = 7;
            this.btnAnimacja.Text = "Animacja po lini toru";
            this.btnAnimacja.UseVisualStyleBackColor = true;
            this.btnAnimacja.Click += new System.EventHandler(this.btnAnimacja_Click);
            // 
            // LaboratoriumNr1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1151, 746);
            this.Controls.Add(this.btnAnimacja);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtH);
            this.Controls.Add(this.txtXg);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtXd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbRysownica);
            this.Name = "LaboratoriumNr1";
            this.Text = "LaboratoriumNr1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LaboratoriumNr1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pbRysownica)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbRysownica;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox txtXd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAnimacja;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtH;
        private System.Windows.Forms.TextBox txtXg;
        private System.Windows.Forms.Label label2;
    }
}