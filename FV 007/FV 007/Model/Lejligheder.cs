using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FV_007.Model
{
    class Lejligheder
    {
        //                  Feels
        private int _lejlighedID;
        private string _lejlighedName;
        private double _lejlighedPris;
        private string _land;
        private string _lejlighedInfo;
        private int _l1ejlighed_KVM;

        //                  Construktor
        public Lejligheder(int lejlighedId, string lejlighedName, double lejlighedPris, string land, string lejlighedInfo, int l1EjlighedKvm)
        {
            _lejlighedID = lejlighedId;
            _lejlighedName = lejlighedName;
            _lejlighedPris = lejlighedPris;
            _land = land;
            _lejlighedInfo = lejlighedInfo;
            _l1ejlighed_KVM = l1EjlighedKvm;
        }



        //                  Prop
        public int LejlighedId
        {
            get => _lejlighedID;
            set => _lejlighedID = value;
        }

        public string LejlighedName
        {
            get => _lejlighedName;
            set => _lejlighedName = value;
        }

        public double LejlighedPris
        {
            get => _lejlighedPris;
            set => _lejlighedPris = value;
        }

        public string Land
        {
            get => _land;
            set => _land = value;
        }

        public string LejlighedInfo
        {
            get => _lejlighedInfo;
            set => _lejlighedInfo = value;
        }

        public int L1EjlighedKvm
        {
            get => _l1ejlighed_KVM;
            set => _l1ejlighed_KVM = value;
        }


        //                  Metoder



        //ToString
        public override string ToString()
        {
            return $"{nameof(LejlighedId)}: {LejlighedId}, {nameof(LejlighedName)}: {LejlighedName}, {nameof(LejlighedPris)}: {LejlighedPris}, {nameof(Land)}: {Land}, {nameof(LejlighedInfo)}: {LejlighedInfo}, {nameof(L1EjlighedKvm)}: {L1EjlighedKvm}";
        }



    }
}
