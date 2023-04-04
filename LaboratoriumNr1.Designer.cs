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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.kpstylLiniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kpliniaKreskowaDashToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kpliniaKreskowoKropkowaDashDotToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kpliniaKreskowoKropkowaKropkowaDashDotDotToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kpliniaKropkowaDotToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kpciagłaSolidToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kpgrubośćLiniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kptoolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.kptoolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.kptoolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.kptoolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.kptoolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.kpkolorLiniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kpkoloryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pbRysownica)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbRysownica
            // 
            this.pbRysownica.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pbRysownica.Location = new System.Drawing.Point(36, 144);
            this.pbRysownica.Name = "pbRysownica";
            this.pbRysownica.Size = new System.Drawing.Size(752, 506);
            this.pbRysownica.TabIndex = 0;
            this.pbRysownica.TabStop = false;
            this.pbRysownica.Click += new System.EventHandler(this.pbRysownica_Click);
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
            this.btnAnimacja.Location = new System.Drawing.Point(794, 170);
            this.btnAnimacja.Name = "btnAnimacja";
            this.btnAnimacja.Size = new System.Drawing.Size(213, 74);
            this.btnAnimacja.TabIndex = 7;
            this.btnAnimacja.Text = "Animacja po lini toru";
            this.btnAnimacja.UseVisualStyleBackColor = true;
            this.btnAnimacja.Click += new System.EventHandler(this.btnAnimacja_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kpstylLiniToolStripMenuItem,
            this.kpgrubośćLiniToolStripMenuItem,
            this.kpkolorLiniToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1089, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // kpstylLiniToolStripMenuItem
            // 
            this.kpstylLiniToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kpliniaKreskowaDashToolStripMenuItem,
            this.kpliniaKreskowoKropkowaDashDotToolStripMenuItem,
            this.kpliniaKreskowoKropkowaKropkowaDashDotDotToolStripMenuItem,
            this.kpliniaKropkowaDotToolStripMenuItem,
            this.kpciagłaSolidToolStripMenuItem});
            this.kpstylLiniToolStripMenuItem.Name = "kpstylLiniToolStripMenuItem";
            this.kpstylLiniToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.kpstylLiniToolStripMenuItem.Text = "Styl lini";
            // 
            // kpliniaKreskowaDashToolStripMenuItem
            // 
            this.kpliniaKreskowaDashToolStripMenuItem.Name = "kpliniaKreskowaDashToolStripMenuItem";
            this.kpliniaKreskowaDashToolStripMenuItem.Size = new System.Drawing.Size(328, 22);
            this.kpliniaKreskowaDashToolStripMenuItem.Text = "Linia kreskowa(Dash)";
            this.kpliniaKreskowaDashToolStripMenuItem.Click += new System.EventHandler(this.liniaKreskowaDashToolStripMenuItem_Click);
            // 
            // kpliniaKreskowoKropkowaDashDotToolStripMenuItem
            // 
            this.kpliniaKreskowoKropkowaDashDotToolStripMenuItem.Name = "kpliniaKreskowoKropkowaDashDotToolStripMenuItem";
            this.kpliniaKreskowoKropkowaDashDotToolStripMenuItem.Size = new System.Drawing.Size(328, 22);
            this.kpliniaKreskowoKropkowaDashDotToolStripMenuItem.Text = "Linia kreskowoKropkowa(DashDot)";
            this.kpliniaKreskowoKropkowaDashDotToolStripMenuItem.Click += new System.EventHandler(this.liniaKreskowoKropkowaDashDotToolStripMenuItem_Click);
            // 
            // kpliniaKreskowoKropkowaKropkowaDashDotDotToolStripMenuItem
            // 
            this.kpliniaKreskowoKropkowaKropkowaDashDotDotToolStripMenuItem.Name = "kpliniaKreskowoKropkowaKropkowaDashDotDotToolStripMenuItem";
            this.kpliniaKreskowoKropkowaKropkowaDashDotDotToolStripMenuItem.Size = new System.Drawing.Size(328, 22);
            this.kpliniaKreskowoKropkowaKropkowaDashDotDotToolStripMenuItem.Text = "LiniaKreskowoKropkowaKropkowa(DashDotDot)";
            this.kpliniaKreskowoKropkowaKropkowaDashDotDotToolStripMenuItem.Click += new System.EventHandler(this.liniaKreskowoKropkowaKropkowaDashDotDotToolStripMenuItem_Click);
            // 
            // kpliniaKropkowaDotToolStripMenuItem
            // 
            this.kpliniaKropkowaDotToolStripMenuItem.Name = "kpliniaKropkowaDotToolStripMenuItem";
            this.kpliniaKropkowaDotToolStripMenuItem.Size = new System.Drawing.Size(328, 22);
            this.kpliniaKropkowaDotToolStripMenuItem.Text = "LiniaKropkowa(Dot)";
            this.kpliniaKropkowaDotToolStripMenuItem.Click += new System.EventHandler(this.liniaKropkowaDotToolStripMenuItem_Click);
            // 
            // kpciagłaSolidToolStripMenuItem
            // 
            this.kpciagłaSolidToolStripMenuItem.Name = "kpciagłaSolidToolStripMenuItem";
            this.kpciagłaSolidToolStripMenuItem.Size = new System.Drawing.Size(328, 22);
            this.kpciagłaSolidToolStripMenuItem.Text = "Ciagła(Solid)";
            this.kpciagłaSolidToolStripMenuItem.Click += new System.EventHandler(this.ciagłaSolidToolStripMenuItem_Click);
            // 
            // kpgrubośćLiniToolStripMenuItem
            // 
            this.kpgrubośćLiniToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kptoolStripMenuItem2,
            this.kptoolStripMenuItem3,
            this.kptoolStripMenuItem4,
            this.kptoolStripMenuItem5,
            this.kptoolStripMenuItem6});
            this.kpgrubośćLiniToolStripMenuItem.Name = "kpgrubośćLiniToolStripMenuItem";
            this.kpgrubośćLiniToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.kpgrubośćLiniToolStripMenuItem.Text = "Grubość lini";
            this.kpgrubośćLiniToolStripMenuItem.Click += new System.EventHandler(this.grubośćLiniToolStripMenuItem_Click);
            // 
            // kptoolStripMenuItem2
            // 
            this.kptoolStripMenuItem2.Name = "kptoolStripMenuItem2";
            this.kptoolStripMenuItem2.Size = new System.Drawing.Size(80, 22);
            this.kptoolStripMenuItem2.Text = "1";
            this.kptoolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // kptoolStripMenuItem3
            // 
            this.kptoolStripMenuItem3.Name = "kptoolStripMenuItem3";
            this.kptoolStripMenuItem3.Size = new System.Drawing.Size(80, 22);
            this.kptoolStripMenuItem3.Text = "2";
            this.kptoolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // kptoolStripMenuItem4
            // 
            this.kptoolStripMenuItem4.Name = "kptoolStripMenuItem4";
            this.kptoolStripMenuItem4.Size = new System.Drawing.Size(80, 22);
            this.kptoolStripMenuItem4.Text = "3";
            this.kptoolStripMenuItem4.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
            // 
            // kptoolStripMenuItem5
            // 
            this.kptoolStripMenuItem5.Name = "kptoolStripMenuItem5";
            this.kptoolStripMenuItem5.Size = new System.Drawing.Size(80, 22);
            this.kptoolStripMenuItem5.Text = "4";
            this.kptoolStripMenuItem5.Click += new System.EventHandler(this.toolStripMenuItem5_Click);
            // 
            // kptoolStripMenuItem6
            // 
            this.kptoolStripMenuItem6.Name = "kptoolStripMenuItem6";
            this.kptoolStripMenuItem6.Size = new System.Drawing.Size(80, 22);
            this.kptoolStripMenuItem6.Text = "5";
            this.kptoolStripMenuItem6.Click += new System.EventHandler(this.toolStripMenuItem6_Click);
            // 
            // kpkolorLiniToolStripMenuItem
            // 
            this.kpkolorLiniToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kpkoloryToolStripMenuItem});
            this.kpkolorLiniToolStripMenuItem.Name = "kpkolorLiniToolStripMenuItem";
            this.kpkolorLiniToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.kpkolorLiniToolStripMenuItem.Text = "Kolor Lini";
            // 
            // kpkoloryToolStripMenuItem
            // 
            this.kpkoloryToolStripMenuItem.Name = "kpkoloryToolStripMenuItem";
            this.kpkoloryToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.kpkoloryToolStripMenuItem.Text = "Kolory";
            this.kpkoloryToolStripMenuItem.Click += new System.EventHandler(this.koloryToolStripMenuItem_Click);
            // 
            // LaboratoriumNr1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1089, 746);
            this.Controls.Add(this.btnAnimacja);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtH);
            this.Controls.Add(this.txtXg);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtXd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbRysownica);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "LaboratoriumNr1";
            this.Text = "LaboratoriumNr1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LaboratoriumNr1_FormClosing);
            this.Load += new System.EventHandler(this.LaboratoriumNr1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbRysownica)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem kpstylLiniToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kpgrubośćLiniToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kptoolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem kptoolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem kptoolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem kptoolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem kptoolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem kpkolorLiniToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kpkoloryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kpliniaKreskowaDashToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kpliniaKreskowoKropkowaDashDotToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kpliniaKreskowoKropkowaKropkowaDashDotDotToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kpliniaKropkowaDotToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kpciagłaSolidToolStripMenuItem;
    }
}