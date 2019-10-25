using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Evolution
{
    class Map
    {
        public List<int> _map = new List<int>();
        private int _X = 100;
        private int _y = 100;

        private int _intet = 0;

        public Map()
        {
            
        }

        public void MapUpdate()
        {
            foreach (int VARIABLE in _map)
            {
                console.writeline("0");
            }


        }

        public void MapStart()
        {
            for (int i = 0; i < 100; i++)
            {
                _map.Add(_intet);
            }

        }
        
    }
}
