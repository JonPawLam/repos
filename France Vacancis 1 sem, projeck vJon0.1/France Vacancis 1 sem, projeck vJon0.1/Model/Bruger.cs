using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace France_Vacancis_1_sem__projeck_vJon0._1.Model
{
    class Bruger
    {
        //          Feels
        private int _brugerID;
        private string _brugerName;
        private string _brugerMail;
        private int _brugerMobil;


        //          Con
        public Bruger(int brugerId, string brugerName, string brugerMail, int brugerMobil)
        {
            _brugerID = brugerId;
            _brugerName = brugerName;
            _brugerMail = brugerMail;
            _brugerMobil = brugerMobil;
        }


        //          Prop

        public int BrugerId
        {
            get => _brugerID;
            set => _brugerID = value;
        }

        public string BrugerName
        {
            get => _brugerName;
            set => _brugerName = value;
        }

        public string BrugerMail
        {
            get => _brugerMail;
            set => _brugerMail = value;
        }

        public int BrugerMobil
        {
            get => _brugerMobil;
            set => _brugerMobil = value;
        }


        //          Metoder


        //Tostring
        public override string ToString()
        {
            return $"{nameof(BrugerId)}: {BrugerId}, {nameof(BrugerName)}: {BrugerName}, {nameof(BrugerMail)}: {BrugerMail}, {nameof(BrugerMobil)}: {BrugerMobil}";
        }
    }
}
