using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BæverKompaniet
{
    class Lejligheder
    {

        public string LejlighederNavn { get; set; }

        public double Priser { get; set; }

        public int Størrelse { get; set; }

        public double Værelser { get; set; }


        public Lejligheder(string lejlighederNavn, double priser, int størrelse, double værelser)
        {
            LejlighederNavn = lejlighederNavn;
            Priser = priser;
            Størrelse = størrelse;
            Værelser = værelser;
        }

        public override string ToString()
        {
            return $"{nameof(LejlighederNavn)}: {LejlighederNavn}, {nameof(Priser)}: {Priser}, {nameof(Størrelse)}: {Størrelse}, {nameof(Værelser)}: {Værelser}";
        }
    }
}
