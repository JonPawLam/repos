using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjendomsMaegleren
{
    class KøberEmneKartotek
    {

        private List<KoeberEmne> _køberEmneList;


        public KøberEmneKartotek()
        {
            _køberEmneList = new List<KoeberEmne>();
        }

        //metoder
        public void addToKøberEmneKartotek(KoeberEmne koeberEmne)
        {
            _køberEmneList.Add(koeberEmne);
        }

        public List<KoeberEmne> GetAll()
        {
            foreach (var koeberEmne in _køberEmneList)
            {
                Console.WriteLine(koeberEmne.ToString());
            }
        
            return null;
        }

        public void Remove(int iD)
        {
            _køberEmneList.RemoveAt((iD));
        }

    }
}
