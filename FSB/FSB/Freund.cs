using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSB
{
    class Freund
    {
        public String Vorname, Nachname, Straße, Ort, Augenfarbe, Hobbys, Musikrichtung, Lieblingsdino, Lieblingsfarbe, Lieblingsessen;
        public int Hausnummer, Größe, Gewicht;
        public DateTime GebDatum, Datum;

        public Freund(String Vorname, String Nachname, String Straße, String Ort, String Augenfarbe,
                                      String Hobbys, String Musikrichtung, String Lieblingsdino, String Lieblingsfarbe,
                                      String Lieblingsessen, int Hausnummer, int Größe, int Gewicht, DateTime GebDatum,
                                      DateTime Datum)
        {
            this.Vorname = Vorname; this.Nachname = Nachname; this.Straße = Straße; this.Ort = Ort; 
            this.Augenfarbe = Augenfarbe; this.Hobbys = Hobbys; this.Musikrichtung = Musikrichtung; 
            this.Lieblingsdino = Lieblingsdino; this.Lieblingsfarbe = Lieblingsfarbe; 
            this.Lieblingsessen = Lieblingsessen; this.Hausnummer = Hausnummer; this.Größe = Größe;
            this.Gewicht = Gewicht; this.GebDatum = GebDatum; this.Datum = Datum;
        }
    }
}
