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
            this.kpbtnReset = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.stylLiniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dashToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dotToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.solidToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.koloryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kolorFormularzaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kolorLiniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kolorRysownicyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grubośćLiniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.kppbRysownica)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.menuStrip1.SuspendLayout();
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
            this.kppbRysownica.Click += new System.EventHandler(this.kppbRysownica_Click);
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
            // kpbtnReset
            // 
            this.kpbtnReset.Location = new System.Drawing.Point(593, 226);
            this.kpbtnReset.Name = "kpbtnReset";
            this.kpbtnReset.Size = new System.Drawing.Size(156, 50);
            this.kpbtnReset.TabIndex = 11;
            this.kpbtnReset.Text = "Reset";
            this.kpbtnReset.UseVisualStyleBackColor = true;
            this.kpbtnReset.Click += new System.EventHandler(this.kpbtnReset_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stylLiniToolStripMenuItem,
            this.koloryToolStripMenuItem,
            this.grubośćLiniToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // stylLiniToolStripMenuItem
            // 
            this.stylLiniToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dashToolStripMenuItem,
            this.dotToolStripMenuItem,
            this.solidToolStripMenuItem});
            this.stylLiniToolStripMenuItem.Name = "stylLiniToolStripMenuItem";
            this.stylLiniToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.stylLiniToolStripMenuItem.Text = "Styl lini";
            // 
            // dashToolStripMenuItem
            // 
            this.dashToolStripMenuItem.Name = "dashToolStripMenuItem";
            this.dashToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.dashToolStripMenuItem.Text = "Dash";
            this.dashToolStripMenuItem.Click += new System.EventHandler(this.dashToolStripMenuItem_Click);
            // 
            // dotToolStripMenuItem
            // 
            this.dotToolStripMenuItem.Name = "dotToolStripMenuItem";
            this.dotToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.dotToolStripMenuItem.Text = "Dot";
            this.dotToolStripMenuItem.Click += new System.EventHandler(this.dotToolStripMenuItem_Click);
            // 
            // solidToolStripMenuItem
            // 
            this.solidToolStripMenuItem.Name = "solidToolStripMenuItem";
            this.solidToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.solidToolStripMenuItem.Text = "Solid";
            this.solidToolStripMenuItem.Click += new System.EventHandler(this.solidToolStripMenuItem_Click);
            // 
            // koloryToolStripMenuItem
            // 
            this.koloryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kolorFormularzaToolStripMenuItem,
            this.kolorLiniToolStripMenuItem,
            this.kolorRysownicyToolStripMenuItem});
            this.koloryToolStripMenuItem.Name = "koloryToolStripMenuItem";
            this.koloryToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.koloryToolStripMenuItem.Text = "Kolory";
            // 
            // kolorFormularzaToolStripMenuItem
            // 
            this.kolorFormularzaToolStripMenuItem.Name = "kolorFormularzaToolStripMenuItem";
            this.kolorFormularzaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.kolorFormularzaToolStripMenuItem.Text = "Kolor formularza";
            this.kolorFormularzaToolStripMenuItem.Click += new System.EventHandler(this.kolorFormularzaToolStripMenuItem_Click);
            // 
            // kolorLiniToolStripMenuItem
            // 
            this.kolorLiniToolStripMenuItem.Name = "kolorLiniToolStripMenuItem";
            this.kolorLiniToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.kolorLiniToolStripMenuItem.Text = "Kolor lini";
            this.kolorLiniToolStripMenuItem.Click += new System.EventHandler(this.kolorLiniToolStripMenuItem_Click);
            // 
            // kolorRysownicyToolStripMenuItem
            // 
            this.kolorRysownicyToolStripMenuItem.Name = "kolorRysownicyToolStripMenuItem";
            this.kolorRysownicyToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.kolorRysownicyToolStripMenuItem.Text = "Kolor rysownicy";
            this.kolorRysownicyToolStripMenuItem.Click += new System.EventHandler(this.kolorRysownicyToolStripMenuItem_Click);
            // 
            // grubośćLiniToolStripMenuItem
            // 
            this.grubośćLiniToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4,
            this.toolStripMenuItem5,
            this.toolStripMenuItem6});
            this.grubośćLiniToolStripMenuItem.Name = "grubośćLiniToolStripMenuItem";
            this.grubośćLiniToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.grubośćLiniToolStripMenuItem.Text = "Grubość lini";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem2.Text = "1";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem3.Text = "2";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem4.Text = "3";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem5.Text = "4";
            this.toolStripMenuItem5.Click += new System.EventHandler(this.toolStripMenuItem5_Click);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem6.Text = "5";
            this.toolStripMenuItem6.Click += new System.EventHandler(this.toolStripMenuItem6_Click);
            // 
            // ProjektIndywidualnyPlutka
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.kpbtnReset);
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
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
        private System.Windows.Forms.Button kpbtnReset;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem stylLiniToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dashToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dotToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem solidToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem koloryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kolorFormularzaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kolorLiniToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kolorRysownicyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem grubośćLiniToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
    }
}