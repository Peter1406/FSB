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
        #region FreundHinzufügenDaten


        private void tbVorname_Enter(object sender, EventArgs e)
        {
            if (tbVorname.Text == "Vorname")
            {
                tbVorname.Text = "";
            }
        }

        private void tbNachname_Enter(object sender, EventArgs e)
        {
            if (tbNachname.Text == "Nachname")
            {
                tbNachname.Text = "";
            }
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
            if (tbAugenfarbe.Text == "Augenfarbe")
            {
                tbAugenfarbe.Text = "";
            }
        }

        private void tbAugenfarbe_Leave(object sender, EventArgs e)
        {
            if(tbAugenfarbe.Text == "")
            {
                tbAugenfarbe.Text = "Augenfarbe";
            }
        }

        private void tbHobbys_Enter(object sender, EventArgs e)
        {
            if (tbHobbys.Text == "Hobbys")
            {
                tbHobbys.Text = "";
            }
        }

        private void tbHobbys_Leave(object sender, EventArgs e)
        {
            if (tbHobbys.Text == "")
            {
                tbHobbys.Text = "Hobbys";
            }
        }

        private void tbMusikrichtung_Enter(object sender, EventArgs e)
        {
            if(tbMusikrichtung.Text == "Musikrichtung")
            {
                tbMusikrichtung.Text = "";
            }
        }

        private void tbMusikrichtung_Leave(object sender, EventArgs e)
        {
            if(tbMusikrichtung.Text == "")
            {
                tbMusikrichtung.Text = "Musikrichtung";
            }
        }

        private void tbLieblingsdino_Enter(object sender, EventArgs e)
        {
            if(tbLieblingsdino.Text =="Lieblingsdino")
            {
                tbLieblingsdino.Text = "";
            }
        }

        private void tbLieblingsdino_Leave(object sender, EventArgs e)
        {
            if(tbLieblingsdino.Text == "")
            {
                tbLieblingsdino.Text = "Lieblingsdino";
            }
        }

        private void tbLieblingsfarbe_Leave(object sender, EventArgs e)
        {
            if(tbLieblingsfarbe.Text == "")
            {
                tbLieblingsfarbe.Text = "Lieblingsfarbe";
            }
        }

        private void tbLieblingsfarbe_Enter(object sender, EventArgs e)
        {
            if(tbLieblingsfarbe.Text =="Lieblingsfarbe")
            {
                tbLieblingsfarbe.Text = "";
            }
        }

        private void tbLieblingsessen_Leave(object sender, EventArgs e)
        {
            if(tbLieblingsessen.Text =="")
            {
                tbLieblingsessen.Text = "Lieblingsessen";
            }
        }

        private void tbLieblingsessen_Enter(object sender, EventArgs e)
        {
            if(tbLieblingsessen.Text =="Lieblingsessen")
            {
                tbLieblingsessen.Text = "";
            }
        }

        private void tbHaarfarbe_Leave(object sender, EventArgs e)
        {
            if(tbHaarfarbe.Text == "")
            {
                tbHaarfarbe.Text = "Haarfarbe";
            }
        }

        private void tbHaarfarbe_Enter(object sender, EventArgs e)
        {
            if(tbHaarfarbe.Text == "Haarfarbe")
            {
                tbHaarfarbe.Text = "";
            }
        }

        private void tbOrt_Leave(object sender, EventArgs e)
        {
            if(tbOrt.Text == "")
            {
                tbOrt.Text = "Ort";
            }
        }

        private void tbOrt_Enter(object sender, EventArgs e)
        {
            if(tbOrt.Text =="Ort")
            {
                tbOrt.Text = "";
            }
        }

        private void tbStraße_Leave(object sender, EventArgs e)
        {
            if(tbStraße.Text == "")
            {
                tbStraße.Text = "Straße";
            }
        }

        private void tbStraße_Enter(object sender, EventArgs e)
        {
            if(tbStraße.Text == "Straße")
            {
                tbStraße.Text = "";
            }
        }

        private void tbHausnummer_Leave(object sender, EventArgs e)
        {
            if(tbHausnummer.Text == "")
            {
                tbHausnummer.Text = "Hausnummer";
            }
        }

        private void tbHausnummer_Enter(object sender, EventArgs e)
        {
            if(tbHausnummer.Text =="Hausnummer")
            {
                tbHausnummer.Text = "";
            }
        }
        #endregion
    }
}
