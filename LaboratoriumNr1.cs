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
    public partial class LaboratoriumNr1 : Form
    {
        public LaboratoriumNr1()
        {
            InitializeComponent();
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
    }
}
