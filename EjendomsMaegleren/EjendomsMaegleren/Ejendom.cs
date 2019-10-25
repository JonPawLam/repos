using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjendomsMaegleren
{
    public class Ejendom
    {
        //instant field
        private int _ejenID;

        private string _ejenType;

        private string _ejenAdress;

        private double _ejenPrice;

        public double _ejenSize;

        // constructor

        public Ejendom(int ejenId, string ejenType, string ejenAdress, double ejenPrice, double ejenSize)
        {
            _ejenID = ejenId;
            _ejenType = ejenType;
            _ejenAdress = ejenAdress;
            _ejenPrice = ejenPrice;
            _ejenSize = ejenSize;
        }

        //properties

        public int ejenID
        {
            get { return _ejenID; }
        }

        public string ejenType
        {
            get { return _ejenType; }
        }
        public string ejenAdress
        {
            get { return _ejenAdress; }
        }
        public double ejenPrice
        {
            get { return _ejenPrice; }
        }
        public double ejenSize
        {
            get { return _ejenSize; }
        }


        //method

        public override string ToString()
        {
            return $"{nameof(ejenID)}: {ejenID}, {nameof(ejenType)}: {ejenType}, {nameof(ejenAdress)}: {ejenAdress}, {nameof(ejenPrice)}: {ejenPrice}, {nameof(ejenSize)}: {ejenSize}";
        }

    }
    
}
