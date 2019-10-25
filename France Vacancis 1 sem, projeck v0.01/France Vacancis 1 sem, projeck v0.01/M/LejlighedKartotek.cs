using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.ApplicationModel.Appointments.AppointmentsProvider;

namespace France_Vacancis_1_sem__projeck_v0._01.M
{
    class LejlighedKartotek 
    {
        
        //Feels
        private Dictionary<int, Lejligheder> _LejlighedsKartotek;
        int _TTLK_tal;

        //Construktor
        public LejlighedKartotek(Dictionary<int, Lejligheder> lejlighedsKartotek)
        {
            _LejlighedsKartotek = new Dictionary<int, Lejligheder>();
        }

        //Metoder
        public void TilføjTilLejlighedsKartotek(Lejligheder lejlighed)
        {
           _LejlighedsKartotek.Add(0,lejlighed);
            _TTLK_tal++;
        }







    }
}
