using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//dodanie nowej przestreni nazw dla grafiki 2D
using System.Drawing.Drawing2D;
using System.Xml.Linq;

namespace ProjektNr1_Plutka_62026
{
    public partial class LaboratoriumNr1 : Form
    {
        //deklaracja stałych pomocniczych 
        const int Margines = 10;
        const int PromieńOA = 5; //OA= Obiekt Animowany
        //deklaracje pomocnicze
        float Xd, Xg, h;
        Graphics Rysownica;
        int IndexPOA; //POA= Połozenie animacji
        int MaxIndexPOA;
        float[,] TWS;
        Pen PióroXY = new Pen(Color.Blue, 0.5f);
        Pen PióroLiniToru;
        //deklaracja zmiennej referencyjnej egzemplarza formularza
        static LaboratoriumNr1 UchwytFormularza;


        public LaboratoriumNr1()
        {
            InitializeComponent();
            UchwytFormularza = this;
            //wstępna sformatowanie kontrolki picture box
            pbRysownica.BackColor = Color.LightSkyBlue;
            pbRysownica.BorderStyle = BorderStyle.Fixed3D;
            //utworzenie bit mapy i podpiecie jej  do kontrolki picture box
            pbRysownica.Image = new Bitmap(pbRysownica.Width, pbRysownica.Height);
                //utworzenie egzemplarza powierzchni graficznej
            Rysownica = Graphics.FromImage(pbRysownica.Image);
            //utworzenie i sformatowanie pióraPióroLiniToru
            PióroLiniToru = new Pen(Color.Black, 1);
            PióroLiniToru.DashStyle = DashStyle.Dot;

        }

        private void LaboratoriumNr1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //utworzenie okna dialogowego dla uzytkownika
            DialogResult OknoMessage = MessageBox.Show("Czy rzeczywiście chcesz zamknąć formularz laboratoryjny?",
                this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //sprawdzenie decyzji uzywtkownika
            if (OknoMessage == DialogResult.Yes)
            {
                foreach (Form Formularz in Application.OpenForms)
                    if (Formularz.Name == "KokpitPlutka")
                    {
                        this.Hide();
                        Formularz.Show();
                        return;
                    }
                //gdu sterowanie zostanie przekazane tutaj bedzie to oznaczało awarie
                MessageBox.Show("UWAGA wystąpiła awaria działania programu i musi on zostać zamknięty", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                //zamkniecie formularza i calego programu
            }
            else
                e.Cancel = true;
        }

        //deklaracja klasy statycznej udistepniajacej  metody WspX, WspY
        static public class PrzeliczanieWspółrzędnych
        {
            //deklaracja zmiennych dla przechowania wyznaczonych wartosci współczynników w skali dla osi X oraz Y
            //a takze wektory przesuniecia wzdłuz osi X oraz osi Y
            static float Sx, Sy;
            static float Dx, Dy;
            //deklaracja zmeinnych opisujących rozmiar powierzchni graficznej kontrolki Picture Box
            static int Xe_min, Xe_max, Ye_min, Ye_max;
            //delaracja właściwości(kontrolowanych zmiennych) pisujących rozmiar powierzchni rzeczywistej lini toru
            public static float Xmin
            {
                get;
                private set;
            }
            public static float Xmax
            {
                get;
                private set;
            }
            public static float Ymin
            {
                get;
                private set;
            }
            public static float Ymax
            {
                get;
                private set;
            }
            //deklaracja kontstruktora który ustali wartosci dla zadeklarowanych zmiennych i właściwości
            static PrzeliczanieWspółrzędnych()
            {
                //okreslenie rozmiarów powierzchni rzeczywistych lini toru
                Xmin = UchwytFormularza.Xd;
                Xmax = UchwytFormularza.Xg;
                Ymin = EkstremumSzeregu.MinSx(UchwytFormularza.TWS);
                Ymax = EkstremumSzeregu.MaxSx(UchwytFormularza.TWS);
                //okreslenie rozmiarów powierzchni graficznej na BitMapie (na kontrolce Picture Box)
                Xe_min = Margines;
                Xe_max = UchwytFormularza.pbRysownica.Width - (Margines + Margines);
                Ye_min = Margines;
                Ye_max = UchwytFormularza.pbRysownica.Height - (Margines + Margines);
                //wyznaczenie wspolczynnikow w skali po osi X oraz osi Y
                Sx = (Xe_max- Xe_min)/(Xmax- Xmin);
                Sy = (Ye_max-Ye_min)/(Ymax- Ymin);
                Dx = Xe_min - Xmin * Sx;
                Dy = Ye_min - Ymin * Sy;
            }
            //deklaracja metod udostepniajacych klase przelicznaiewpsolrzednycj
            public static int WspX(float x)
            {
                return (int)(x * Sx + Dx);
            }
            static public int WspY(float y)
            {
                return (int)(y * Sy + Dy);
            }
        }
        private void pbRysownica_Paint(object sender, PaintEventArgs e)
        {
            //dla bezpieczenstwa sprawdzamy czy istnieje egzemplarz tablicy TWS
            if (TWS is null)
                return;
            //wyczyszczenie powiezrchni graficznej
            Rysownica.Clear(Color.LightSkyBlue);
            //ponowne wykreslenie obrazu
            //wykreslenie osi y
            Rysownica.DrawLine(PióroXY,
                PrzeliczanieWspółrzędnych.WspX(0),
                PrzeliczanieWspółrzędnych.WspY(PrzeliczanieWspółrzędnych.Ymin),

                 PrzeliczanieWspółrzędnych.WspX(0),
                PrzeliczanieWspółrzędnych.WspY(PrzeliczanieWspółrzędnych.Ymax));
            //wykreslenie osi x
            Rysownica.DrawLine(PióroXY,
                PrzeliczanieWspółrzędnych.WspY(PrzeliczanieWspółrzędnych.Xmin),
                 PrzeliczanieWspółrzędnych.WspY(0),

                 PrzeliczanieWspółrzędnych.WspX(PrzeliczanieWspółrzędnych.Xmax),
                 PrzeliczanieWspółrzędnych.WspY(0));
            //wykreslenie lini toru
            for (int j = 0; j < TWS.GetLength(0) - 1; j++)
                Rysownica.DrawLine(PióroLiniToru,
                    PrzeliczanieWspółrzędnych.WspX(TWS[j, 0]),
                    PrzeliczanieWspółrzędnych.WspY(TWS[j, 1]),

                    PrzeliczanieWspółrzędnych.WspX(TWS[j + 1, 0]),
                    PrzeliczanieWspółrzędnych.WspY(TWS[j + 1, 1])
                 );
            //wykreslenie OA(Obiektu Animowanego)
            Rysownica.FillEllipse(Brushes.Yellow,
                  PrzeliczanieWspółrzędnych.WspX(TWS[IndexPOA, 0])-PromieńOA,
                  PrzeliczanieWspółrzędnych.WspY(TWS[IndexPOA, 1]) - PromieńOA,
                  2*PromieńOA, 2*PromieńOA
                );

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //sprawdzenie czy obiekt animowany juz doszedl do prawej krawedzi 
            if (IndexPOA >= MaxIndexPOA)
                //przestwienie obiektu animowanego na poczatek lini toru
                IndexPOA = 0;
            else
                IndexPOA++;
            //odswiezenie powierzchni graficznej (ponowne jej odrysownaie)
            pbRysownica.Refresh();
        }
    }
}
