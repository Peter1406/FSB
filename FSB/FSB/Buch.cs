using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSB
{
    public class Buch
    {
        private List<Freund> freundesliste;
        public Buch()
        {
            freundesliste = new List<Freund>();
            freundesliste.Add(new Freund());
        }
        public void Freund_hinzufügen(String Vorname, String Nachname, String Straße, String Ort, String Haarfarbe, String Augenfarbe, 
                                      String Hobbys, String Musikrichtung, String Lieblingsdino, String Lieblingsfarbe,
                                      String Lieblingsessen, int Hausnummer, int Größe, int Gewicht, DateTime GebDatum,
                                      DateTime Datum)
        {
            freundesliste.Add(new Freund(Vorname, Nachname, Straße, Ort, Haarfarbe, Augenfarbe, Hobbys, Musikrichtung, Lieblingsdino,
                                         Lieblingsfarbe, Lieblingsessen, Hausnummer, Größe, Gewicht, GebDatum, Datum));
        }



        public List<Freund> Freundesliste
        {
            get { return freundesliste; }
        }
        
    }
}
