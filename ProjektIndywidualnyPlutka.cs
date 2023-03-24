﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Xml.Linq;

namespace ProjektNr1_Plutka_62026
{
    public partial class ProjektIndywidualnyPlutka : Form
    {
        const int kpMargines = 10;
        const int kpPromieńOA = 5; //OA= Obiekt Animowany

        const float kpDGprzedziałuX = float.MinValue;
        const float kpGGprzedziałuX = float.MaxValue;
        public float kpXd;
        public float kpXg;
        float kph;
        int kpLiczbaPrzedziałówH;
        Graphics kpRysownica;
        Pen kpPióroXY;
        Pen kpPióroLiniToru;

        int kpIndexPOA; //POA= Połozenie animacji
        int kpMaxIndexPOA;
        float[,] kpTWS;
        static ProjektIndywidualnyPlutka kpUchwytFormularza;


        public ProjektIndywidualnyPlutka()
        {
            InitializeComponent();
            this.Location = new Point(Screen.PrimaryScreen.Bounds.Left + kpMargines,
                Screen.PrimaryScreen.Bounds.Top + kpMargines);
            this.Width = (int)(Screen.PrimaryScreen.Bounds.Width * 0.85F);
            this.Height = (int)(Screen.PrimaryScreen.Bounds.Height * 0.7F);
            this.StartPosition = FormStartPosition.Manual;
            kpUchwytFormularza = this;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            kppbRysownica.BackColor = Color.LightSkyBlue;
            kppbRysownica.BorderStyle = BorderStyle.Fixed3D;
            kppbRysownica.Image = new Bitmap(kppbRysownica.Width, kppbRysownica.Height);
            kpRysownica = Graphics.FromImage(kppbRysownica.Image);

            kpPióroXY = new Pen(Color.Blue, 0.5F);
            kpPióroXY.StartCap = LineCap.Flat;
            kpPióroXY.EndCap = LineCap.ArrowAnchor;
            AdjustableArrowCap kpdużeGrotyStrzałek = new AdjustableArrowCap(3, 5);
            kpPióroXY.StartCap = LineCap.Square;
            kpPióroXY.CustomEndCap = kpdużeGrotyStrzałek;

            kpPióroLiniToru = new Pen(Color.Black, 1.5F);
            kpPióroLiniToru.DashStyle = DashStyle.Dot;
        }

        private void ProjektIndywidualnyPlutka_Load(object sender, EventArgs e)
        {
            kppbRysownica.Location = new Point(this.Left + 10, this.Top + 80);
            kppbRysownica.Width = (int)(this.Width * 0.3F);
            kppbRysownica.Height = (int)(this.Height * 0.5F);
            kpbtnAnimacja.Location = new Point(kppbRysownica.Left + kppbRysownica.Width
                + kpMargines,
                kppbRysownica.Top);
        }

        private void ProjektIndywidualnyPlutka_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult OknoMessage = MessageBox.Show("Czy rzeczywiście chcesz " +
                "zamknąć projekt indywidualny?",
                this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (OknoMessage == DialogResult.Yes)
            {
                foreach (Form Formularz in Application.OpenForms)
                    if (Formularz.Name == "KokpitPlutka")
                    {
                        this.Hide();
                        Formularz.Show();
                        return;
                    }
                MessageBox.Show("UWAGA wystąpiła awaria działania programu i musi on '" +
                    "zostać zamknięty", this.Text, MessageBoxButtons.OK, 
                    MessageBoxIcon.Information);
            }
            else
                e.Cancel = true;
        }

        static class kpPrzeliczanieWspółrzędnych
        {
            static float kpSx, kpSy;
            static float kpDx, kpDy;
            static int kpXe_min, kpXe_max, kpYe_min, kpYe_max;
            public static float kpXmin
            {
                get;
                private set;
            }
            public static float kpXmax
            {
                get;
                private set;
            }
            public static float kpYmin
            {
                get;
                private set;
            }
            public static float kpYmax
            {
                get;
                private set;
            }
            
            static kpPrzeliczanieWspółrzędnych()
            {
                kpXmin = kpUchwytFormularza.kpXd;
                kpXmax = kpUchwytFormularza.kpXg;
                kpYmin = kpEkstremumIndywidualne.kpMinSx(kpUchwytFormularza.kpTWS);
                kpYmax = kpEkstremumIndywidualne.kpMaxSx(kpUchwytFormularza.kpTWS);
                
                kpXe_min = kpMargines;
                kpXe_max = kpUchwytFormularza.kppbRysownica.Width - (kpMargines + kpMargines);
                kpYe_min = kpMargines;
                kpYe_max = kpUchwytFormularza.kppbRysownica.Height - (kpMargines + kpMargines);
               
                kpSx = (kpXe_max - kpXe_min) / (kpXmax - kpXmin);
                kpSy = (kpYe_max - kpYe_min) / (kpYmax - kpYmin);
                kpDx = kpXe_min - kpXmin * kpSx;
                kpDy = kpYe_min - kpYmin * kpSy;
            }
            public static int kpWspX(float x)
            {
                return (int)(kpSx * x + kpDx);
            }
            static public int kpWspY(float y)
            {
                return (int)(kpSy * y + kpDy);
            }
        }


        bool kpPobierzDaneWejściowe(out float kpXd, out float kpXg, out float kph)
        {
            kpXd = kpXg = kph = 0.0F;
            if (!float.TryParse(txtXd.Text, out kpXd))
            {
                errorProvider1.SetError(txtXd, "ERROR: w zapisie wartości Xd " +
                    "wystąpił niedozwolony znak");
                return false;
            }
            if ((kpXd < kpDGprzedziałuX) || (kpXd > kpGGprzedziałuX))
            {
                errorProvider1.SetError(txtXd, "ERROR: podana wartosc Xd wykracza " +
                    "poza przedział zbieżności szeregu");
                return false;
            }

            if (!float.TryParse(txtXg.Text, out kpXg))
            {
                errorProvider1.SetError(txtXg, "ERROR: w zapisie wartości Xg " +
                    "wystąpił niedozwolony znak");
                return false;
            }
            if ((kpXg < kpDGprzedziałuX) || (kpXg > kpGGprzedziałuX))
            {
                //wystapil blad
                errorProvider1.SetError(txtXg, "ERROR: podana wartosc Xg wykracza " +
                    "poza przedział zbieżności szeregu");
                return false;
            }
            if (kpXd > kpXg)
            {
                errorProvider1.SetError(txtXg, "ERROR: nie jest spełniony warunek " +
                    "nakładany na granicę przedziału zmian wartości zmiennej X: Xd<Xg");
                return false;
            } 
            if (!float.TryParse(txtH.Text, out kph))
            {
                errorProvider1.SetError(txtH, "ERROR: w zapisie wartości h " +
                    "wystąpił niedozwolony znak");
                return false;
            }
            if ((kph <= 0.0F) || (kph >= 1.0F))
            {
                errorProvider1.SetError(txtH, "ERROR: podana wartosc h nie " +
                    "spełnia warunku wejsciowego: 0<h<1.0");
                return false;
            }
            return true;
        }

        void kpTablicowanieSzeregu(float[,] kpTWS, float kpXd, float kpXg, float kph)
        {
            float kpX;
            int i;
            for (kpX = kpXd, i = 0; i < kpTWS.GetLength(0); kpX = kpXd + i * kph, i++)
            {
                kpTWS[i, 0] = kpX;
                kpTWS[i, 1] = kpObliczenieWartościSzeregu(kpX);

            }

        }

        float kpObliczenieWartościSzeregu(float kpx)
        {
            const float Eps = 0.000001F;
            float kpw, kpS;
            int k;

            kpw = 1;
            k = 0;
            kpS = kpw;
            while (Math.Abs(kpw) > Eps)
            {
                k++;
                kpw = kpw * ((-1.0F) * kpx * kpx) / (float)(2 * k * (2 * k + 1));
                kpS = kpS + kpw;
            }

            return kpS;
        }

        private void kpbtnAnimacja_Click(object sender, EventArgs e)
        {
            errorProvider1.Dispose();
            if (!kpPobierzDaneWejściowe(out kpXd, out kpXg, out kph))
            {
                errorProvider1.SetError(txtXd, "ERROR: wystąpił niedozwolony znak");
                return; 
            }
            kpLiczbaPrzedziałówH = (int)((kpXg - kpXd) / kph) + 1;
            kpTWS = new float[kpLiczbaPrzedziałówH, 2];
            kpTablicowanieSzeregu(kpTWS, kpXd, kpXg, kph);
            kpIndexPOA = 0;
            kpMaxIndexPOA = kpTWS.GetLength(0) - 1;
            timer1.Enabled = true;
            kpbtnAnimacja.Enabled = false;
        }

        private void kppbRysownica_Paint(object sender, PaintEventArgs e)
        {
            if (kpTWS is null)
                return;
            kpRysownica.Clear(Color.LightSkyBlue);

            kpRysownica.DrawLine(kpPióroXY,
                kpPrzeliczanieWspółrzędnych.kpWspX(0),
                kpPrzeliczanieWspółrzędnych.kpWspY(kpPrzeliczanieWspółrzędnych.kpYmax),

                kpPrzeliczanieWspółrzędnych.kpWspX(0),
                kpPrzeliczanieWspółrzędnych.kpWspY(kpPrzeliczanieWspółrzędnych.kpYmin));
            //wykreslenie osi x
            kpRysownica.DrawLine(kpPióroXY,
                kpPrzeliczanieWspółrzędnych.kpWspX(kpPrzeliczanieWspółrzędnych.kpXmin),
                kpPrzeliczanieWspółrzędnych.kpWspY(0),

                 kpPrzeliczanieWspółrzędnych.kpWspX(kpPrzeliczanieWspółrzędnych.kpXmax),
                 kpPrzeliczanieWspółrzędnych.kpWspY(0));
            //wykreslenie lini toru
            for (int j = 0; j < kpTWS.GetLength(0) - 1; j++)
                kpRysownica.DrawLine(kpPióroLiniToru,
                    kpPrzeliczanieWspółrzędnych.kpWspX(kpTWS[j, 0]),
                    kpPrzeliczanieWspółrzędnych.kpWspY(kpTWS[j, 1]),

                    kpPrzeliczanieWspółrzędnych.kpWspX(kpTWS[j + 1, 0]),
                    kpPrzeliczanieWspółrzędnych.kpWspY(kpTWS[j + 1, 1])
                 );
            //wykreslenie OA(Obiektu Animowanego)
            kpRysownica.FillEllipse(Brushes.Yellow,
                  kpPrzeliczanieWspółrzędnych.kpWspX(kpTWS[kpIndexPOA, 0]) - kpPromieńOA,
                  kpPrzeliczanieWspółrzędnych.kpWspY(kpTWS[kpIndexPOA, 1]) - kpPromieńOA,
                  2 * kpPromieńOA, 2 * kpPromieńOA
                );

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (kpIndexPOA >= kpMaxIndexPOA)
                kpIndexPOA = 0;
            else
                kpIndexPOA++;
            kppbRysownica.Refresh();
        }

        private void kolorTłaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
