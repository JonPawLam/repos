using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greve_test
{
    class RunMain
    {
        public ObservableCollection<Vandledning> vandledningsListe;







        public void runMainMeth()
        {

            Console.WriteLine("Hej Mor!");

            

            Vandledning vandledning = new Vandledning("Vejkode1", 1, "Type1", 1, 1);
            vandledningsListe.Add(vandledning);
            Vandledning vandledning = new Vandledning("Vejkode2", 1, "Type1", 1, 1);
            vandledningsListe.Add(vandledning);
            Vandledning vandledning = new Vandledning("Vejkode3", 1, "Type1", 1, 1);
            vandledningsListe.Add(vandledning);
            Vandledning vandledning = new Vandledning("Vejkode4", 1, "Type1", 1, 1);
            vandledningsListe.Add(vandledning);
            Vandledning vandledning = new Vandledning("Vejkode5", 1, "Type1", 1, 1);
            vandledningsListe.Add(vandledning);
            Vandledning vandledning = new Vandledning("Vejkode6", 1, "Type1", 1, 1);
            vandledningsListe.Add(vandledning);
            Vandledning vandledning = new Vandledning("Vejkode7", 1, "Type1", 1, 1);
            vandledningsListe.Add(vandledning);
            Vandledning vandledning = new Vandledning("Vejkode8", 1, "Type1", 1, 1);
            vandledningsListe.Add(vandledning);
            Vandledning vandledning = new Vandledning("Vejkode9", 1, "Type1", 1, 1);
            vandledningsListe.Add(vandledning);

            foreach (var vandledning in vandledningsListe)
            {
                Console.WriteLine(vandledning);
            }





            Console.ReadKey();


        }





    }
}
