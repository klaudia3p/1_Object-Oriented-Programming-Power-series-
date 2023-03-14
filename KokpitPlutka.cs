using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjektNr1_Plutka_62026
{
    public partial class KokpitPlutka : Form
    {
        public KokpitPlutka()
        {
            InitializeComponent();
        }

        private void btnLaboratoriumNr1_Click(object sender, EventArgs e)
        {
            //sprawdzenie czy formularz Lab1 byl juz utworzony
            foreach (Form Formularz in Application.OpenForms)
                //sprawdzenie czy jest to poszukiwany formularz Lab1
                if (Formularz.Name == "LaboratoriumNr1")
                {
                    //egzemplarz formularza Lab1 byl juz utworzony
                    this.Hide();
                    //odsloniecie znalezionego formularza
                    Formularz.Show();
                    //bezwarunkowe wyjscie  z metody obslugi zdarzenia click
                    return;
                }
            //formularz Lab1 nie został znaleziony w openforms
            //utworzenie egzemplarza formularza lab1
            LaboratoriumNr1 FormLaboratoriumNr1 = new LaboratoriumNr1();
            this.Hide();
            //odsloniecie nowo utworzonego egzemplarza
            FormLaboratoriumNr1.Show();
        }

        private void btnProjektNr1_Click(object sender, EventArgs e)
        {
            //sprawdzenie czy formularz Lab1 byl juz utworzony
            foreach (Form Formularz in Application.OpenForms)
                //sprawdzenie czy jest to poszukiwany formularz Lab1
                if (Formularz.Name == "ProjektIndywidualnyPlutka")
                {
                    //egzemplarz formularza Lab1 byl juz utworzony
                    this.Hide();
                    //odsloniecie znalezionego formularza
                    Formularz.Show();
                    return;
                }

            //formularz Lab1 nie został znaleziony w openforms
            //utworzenie egzemplarza formularzala
            //lab1
            ProjektIndywidualnyPlutka FormProjektIndywidualnyPlutka = new ProjektIndywidualnyPlutka();
            this.Hide();
            //odsloniecie nowo utworzonego egzemplarza
            FormProjektIndywidualnyPlutka.Show();
        }

        private void KokpitPlutka_FormClosing(object sender, FormClosingEventArgs e)
        {
            //utworzenie okna dialogowego dla uzytkownika
            DialogResult OknoMessage = MessageBox.Show("Czy rzeczywiście chcesz zamknąć formularz głowny i zakończyć działanie programu?",
                this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //sprawdzenie decyzji uzywtkownika
            if (OknoMessage == DialogResult.Yes)
                //zamkniecie
                Application.ExitThread();
            else
                //anulowanie
                e.Cancel = true;
        }
    }
}
