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

        }
    }
}
