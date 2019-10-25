using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace EjendomsMaegleren
{
    class Program
    {
        static void Main(string[] args)
        {
            // The code provided will print ‘Hello World’ to the console.
            // Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.

            //Loop
            bool _loop = true;
            string _userInput;

            EjendomsKartotek ejendomskartalog1 = new EjendomsKartotek();
            List<KoeberEmne> alleKoeber = new List<KoeberEmne>();
            KøberEmneKartotek køberEmneKartotek = new KøberEmneKartotek();


            while (_loop == true)
            {
                Console.WriteLine(
                    "Create standart House Press: 1         Add new Apartment Press: 2          Remove Apartment Press:3          Print alle ejendome  Press:4          Tilføj standart købere  Press:5\n" +
                    "            Add Buyers Press:6       Print out all buyers Press:7             Remove buyers Press:8                                                                 Escape Press:9");
                Console.WriteLine();

                _userInput = Console.ReadLine();

                //Create standart House 
                
                if (_userInput == "1")
                {
                    Console.Clear();


                    Ejendom ejendom1 = new Ejendom(1, "Lejlighed", "road1", 30000, 30);
                    Ejendom ejendom2 = new Ejendom(2, "Lejlighed", "road1a", 20000, 20);
                    Ejendom ejendom3 = new Ejendom(3, "Hus", "road13", 3000000, 260);
                    Ejendom ejendom4 = new Ejendom(4, "Hus", "road14", 4000000, 320);

                    ejendomskartalog1.addTooEjdomsKatalog(ejendom1);
                    ejendomskartalog1.addTooEjdomsKatalog(ejendom2);
                    ejendomskartalog1.addTooEjdomsKatalog(ejendom3);
                    ejendomskartalog1.addTooEjdomsKatalog(ejendom4);
                }

                //Add new Apartment

                else if (_userInput == "2")
                {
                    //UserInput
                    Console.WriteLine("Giv Id:");
                    int _ejendomID = (Convert.ToInt32(Console.ReadLine()));
                    Console.WriteLine("Giv Type (hus,Lej mm.):");
                    string _ejenType = Console.ReadLine();
                    Console.WriteLine("Giv Adresse:");
                    string _ejenAdresse = Console.ReadLine();
                    Console.WriteLine("Giv pris:");
                    double _ejenPrice = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Giv størrelse:");
                    double _ejenStørrelse = Convert.ToDouble(Console.ReadLine());

                    Ejendom ejendom = new Ejendom(_ejendomID, _ejenType, _ejenAdresse, _ejenPrice, _ejenStørrelse);
                    ejendomskartalog1.addTooEjdomsKatalog(ejendom);

                    Console.WriteLine();

                }

                //Remove Apartment
                else if (_userInput == "3")
                {

                    Console.WriteLine("Choose ID to remove");
                    int iD = Convert.ToInt32(Console.ReadLine());
                    ejendomskartalog1.Remove(iD);
                }

                //Print out all Appartment
                else if (_userInput == "4")
                {
                    Console.WriteLine(ejendomskartalog1.GetAll());
                }

                //Tilføj standart købere
                else if (_userInput == "5")
                {
                    KoeberEmne koeberEmne1 = new KoeberEmne(1, "Peter1", "peterAdresse1", "peterMobil1", "peterEmail1",
                        10, 10000);
                    KoeberEmne koeberEmne2 = new KoeberEmne(2, "Peter2", "peterAdresse2", "peterMobil2", "peterEmail2",
                        50, 50000);
                    KoeberEmne koeberEmne3 = new KoeberEmne(3, "Peter3", "peterAdresse3", "peterMobil3", "peterEmail3",
                        200, 20000000);
                    KoeberEmne koeberEmne4 = new KoeberEmne(4, "Peter4", "peterAdresse4", "peterMobil4", "peterEmail4",
                        400, 40000000);

                    køberEmneKartotek.addToKøberEmneKartotek(koeberEmne1);
                    køberEmneKartotek.addToKøberEmneKartotek(koeberEmne2);
                    køberEmneKartotek.addToKøberEmneKartotek(koeberEmne3);
                    køberEmneKartotek.addToKøberEmneKartotek(koeberEmne4);
                }

                //Tilføj Købere
                else if (_userInput == "6")
                {
                    Console.WriteLine("Giv Id:");
                    int _køberID = (Convert.ToInt32(Console.ReadLine()));

                    Console.WriteLine("Giv Navn");
                    string _køberName = Console.ReadLine();

                    Console.WriteLine("Angiv mobil");
                    string _køberMobil = Console.ReadLine();

                    Console.WriteLine("Angiv Email:");
                    string _køberEmail = Console.ReadLine();

                    Console.WriteLine("Angiv Adresse:");
                    string _køberAdresse = Console.ReadLine();

                    Console.WriteLine("Angiv MinStørelse");
                    double _køberMinStørelse = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Angiv maxPris");
                    double _køberMaxPris = Convert.ToDouble(Console.ReadLine());

                    KoeberEmne køberEmne = new KoeberEmne( _køberID, _køberName, _køberAdresse , _køberMobil, _køberEmail, _køberMinStørelse, _køberMaxPris);
                    køberEmneKartotek.addToKøberEmneKartotek(køberEmne);
                    
                }

                //Print alle købere
                else if (_userInput == "7")
                {

                    køberEmneKartotek.GetAll();
                }

                //remove Buyers
                else if (_userInput == "8")
                {
                    _userInput = Console.ReadLine();
                    køberEmneKartotek.Remove(Convert.ToInt32(_userInput));

                }

                //Console.WriteLine("Max Pris");
                //int _userChoiseMP;
                //_userChoiseMP = Convert.ToInt32(Console.ReadLine());
                //Console.WriteLine("Min Størrelse");
                //int _userChoiseMS;
                //_userChoiseMS = Convert.ToInt32(Console.ReadLine());


                //List<Ejendom> søgningResultatEjendoms = new List<Ejendom>();

                //søgningResultatEjendoms = ejendomskartalog1.GetAllMaches(_userChoiseMP, _userChoiseMS);

                //Exit
                else if (_userInput == "9")
                {
                    _loop = false;
                }
                //Bruger Fejl
                else
                {
                    Console.WriteLine("Fejl, intast 1,2 eller 3.");
                }
                

            }
        }
    }
}

