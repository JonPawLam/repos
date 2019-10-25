using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace EjendomsMaegleren
{
    class EjendomsKartotek
    {
        //feild
        private Dictionary<int, Ejendom> _ejendomsKatalog;

        //Construktor
        public EjendomsKartotek()
        {
            _ejendomsKatalog = new Dictionary<int, Ejendom>();
        }
        
        
        //metoder
        public void addTooEjdomsKatalog(Ejendom enEjendom)
        {
            if (!_ejendomsKatalog.ContainsKey(enEjendom.ejenID))
            {
                _ejendomsKatalog.Add(enEjendom.ejenID, enEjendom);
            }
        }

        public Ejendom Remove(int iD)
        {
            if (_ejendomsKatalog.ContainsKey(iD))
            {
                Ejendom ejendom = _ejendomsKatalog[iD];
                _ejendomsKatalog.Remove(iD);
                return ejendom;
            }
            Console.WriteLine("Eksistere ikke");
            return null;
        }


        public Ejendom GetEjendom(int nr)
        {
            if (_ejendomsKatalog.ContainsKey(nr))
            {
                return _ejendomsKatalog[nr];
            }

            return null;
        }

        public List<Ejendom> GetAll()
        {
            foreach (var ejendom in _ejendomsKatalog)
            {
                Console.WriteLine(ejendom.ToString());
            }
            return null;
        }


        //Søgning

        //public List<Ejendom> GetAll()
        //{
        //    foreach (var ejendom in _ejendomsKatalog)
        //    {
        //        Console.WriteLine(ejendom.ToString());
        //    }
        //    return null;
        //}


        public List<Ejendom> GetAllMaches(int maxPris, int minStørrelse)
        {
            List<Ejendom> søgningResultatEjendoms = new List<Ejendom>();

            int _maxPris = maxPris;
            int _minStørrelse = minStørrelse;

            foreach (Ejendom ejendom in _ejendomsKatalog.Values)
            {
                if (_maxPris < ejendom.ejenPrice || _minStørrelse > ejendom._ejenSize)
                {
                    søgningResultatEjendoms.Add(ejendom);
                    return søgningResultatEjendoms;
                }

            }

            return null;

        }


    }
}
