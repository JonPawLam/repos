using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjendomsMaegleren
{
    class KoeberEmne : Saelger
    {
        //feilds
        private double _minStørrelse;
        private double _maxpris;
        private int _id;
        private string _name;
        private string _adresse;
        private string _mobil;
        private string _email;


        //properties
        public double Minstørrelse
        {
            get { return _minStørrelse; }
        }
        
        public double MaxPris
        {
            get { return _maxpris; }
        }

        

        //Construktor
        public KoeberEmne(int id, string name, string adresse, string mobil, string email, double minStørrelse, double maxpris) : base(id, name, adresse, mobil, email)
        {
            _minStørrelse = minStørrelse;
            _maxpris = maxpris;
            _id = id;
            _name = name;
            _adresse = adresse;
            _mobil = mobil;
            _email = email;
        }

        // Motoder
        
        
        //ToString
        public override string ToString()
        {
            return $"{base.ToString()}, {nameof(Minstørrelse)}: {Minstørrelse}, {nameof(MaxPris)}: {MaxPris}";
        }
    }
}
