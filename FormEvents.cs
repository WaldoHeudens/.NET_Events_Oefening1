using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Events_Oefening1
{
    // Definieer een gedelegeerde die gebruik zal worden als model voor events
    public delegate void ToonVolgende(string boodschap);

    public partial class FormEvents : Form
    {
        Stapel<String> stapel = new Stapel<String>();

        public FormEvents()
        {
            InitializeComponent();
        }

        // Een methode die toegekend kan worden aan een event gebaseerd op gedelegeerde ToonVolgende
        private void ToonInTextBox(string boodschap)
        {
            tbMessage.Text = boodschap + " [" + stapel.ToonVolgende() + "]";
        }

        // Een methode die toegekend kan worden aan een event gebaseerd op gedelegeerde ToonVolgende
        private void ToonInMessageBox(string boodschap)
        {
            MessageBox.Show(boodschap + " [" + stapel.ToonVolgende()+ "]");
        }


        private void btToevoegen_Click(object sender, EventArgs e)
        {
            stapel.Toevoegen(tbInput.Text);
            tbInput.Text = "";
        }

        private void btVerwijderen_Click(object sender, EventArgs e)
        {
            stapel.Verwijderen();
        }

        private void btLeegmaken_Click(object sender, EventArgs e)
        {
            stapel.Leegmaken();
        }

        private void btToon_Click(object sender, EventArgs e)
        {
            tbInput.Text = stapel.ToString();
        }

        // Toevoegen of verwijderen van een methode uit de event-lijst op basis van een checkbox
        // (De checkbox stond niet in de expliciete opgave.)
        private void cbTekstveld_Click(object sender, EventArgs e)
        {
            if (cbTekstveld.Checked)
                stapel.StapelIsGewijzigd += new ToonVolgende(ToonInTextBox);
            else
                stapel.StapelIsGewijzigd -= new ToonVolgende(ToonInTextBox);
        }

        // Toevoegen of verwijderen van een methode uit de event-lijst op basis van een checkbox
        // (De checkbox stond niet in de expliciete opgave.)
        private void cbMessageBox_Click(object sender, EventArgs e)
        {
            if (cbTekstveld.Checked)
                stapel.StapelIsGewijzigd += new ToonVolgende(ToonInMessageBox);
            else
                stapel.StapelIsGewijzigd -= new ToonVolgende(ToonInMessageBox);

        }
    }
}
