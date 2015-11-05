using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FSB
{
    public partial class BuchForm : Form
    {
        private Buch Buch;
        public BuchForm(Buch Buch)
        {
            InitializeComponent();
            this.Buch = Buch;
            init();
        }

        private void einstellungenToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void Einstellungen_Opening(object sender, CancelEventArgs e)
        {

        }

        private void freundHinzufügenToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void dateiToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void skinsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void über_mich_button_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
        }

        private void init()
        {
            foreach(Freund Freund in Buch.Freundesliste)
            {
                string title = Freund.Vorname +" "+ Freund.Nachname;
                TabPage myTabPage = new TabPage(title);
                tabControl1.TabPages.Add(title);
            }
        }

        private void Freund_hinzufügen_btn_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 2;
        }

        private void tbVorname_Enter(object sender, EventArgs e)
        {
            tbVorname.Text = "";
        }

        private void tbNachname_Enter(object sender, EventArgs e)
        {
            tbNachname.Text = "";
        }

        private void mtbGeburtsdatum_Enter(object sender, EventArgs e)
        {
            mtbGeburtsdatum.Mask = "00.00.0000";
        }

        private void mtbGeburtsdatum_Leave(object sender, EventArgs e)
        {
            if (mtbGeburtsdatum.Text == "  ,  ,")
            {
                mtbGeburtsdatum.Mask = "";
                mtbGeburtsdatum.Text = "Geburtsdatum";
            }
        }

        private void tbNachname_Leave(object sender, EventArgs e)
        {
            if(tbNachname.Text == "")
            {
                tbNachname.Text = "Nachname";
            }
        }

        private void tbVorname_Leave(object sender, EventArgs e)
        {
            if(tbVorname.Text == "")
            {
                tbVorname.Text = "Vorname";
            }
        }

        private void mtbGewicht_Enter(object sender, EventArgs e)
        {
            mtbGewicht.Mask = "000 kg";
        }

        private void mtbGewicht_Leave(object sender, EventArgs e)
        {
            if (mtbGewicht.Text == "    kg")
            {
                mtbGewicht.Mask = "";
                mtbGewicht.Text = "Gewicht";
            }
        }

        private void mtbGröße_Leave(object sender, EventArgs e)
        {
            if (mtbGröße.Text == "    cm")
            {
                mtbGröße.Mask = "";
                mtbGröße.Text = "Größe";
            }
        }

        private void mtbGröße_Enter(object sender, EventArgs e)
        {
            mtbGröße.Mask = "000 cm";
        }

        private void tbAugenfarbe_Enter(object sender, EventArgs e)
        {
            tbAugenfarbe.Text = "";
        }

        private void tbAugenfarbe_Leave(object sender, EventArgs e)
        {
            if(tbAugenfarbe.Text == "")
            {
                tbAugenfarbe.Text = "Augenfarbe";
            }
        }
    }
}
