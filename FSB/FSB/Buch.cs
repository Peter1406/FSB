using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSB
{
    class Buch
    {
        private List<Freund> Freundesliste;
        public Buch()
        {

        }
        public void Freund_hinzufügen(String Vorname, String Nachname, String Straße, String Ort, String Augenfarbe, 
                                      String Hobbys, String Musikrichtung, String Lieblingsdino, String Lieblingsfarbe,
                                      String Lieblingsessen, int Hausnummer, int Größe, int Gewicht, DateTime GebDatum,
                                      DateTime Datum)
        {
            Freundesliste.Add(new Freund(Vorname, Nachname, Straße, Ort, Augenfarbe, Hobbys, Musikrichtung, Lieblingsdino,
                                         Lieblingsfarbe, Lieblingsessen, Hausnummer, Größe, Gewicht, GebDatum, Datum));
        }

        public List<Freund> ListeAusgeben()
        {
            return Freundesliste;
        }
    }
}
