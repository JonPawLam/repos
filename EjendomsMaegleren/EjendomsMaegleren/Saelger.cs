using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjendomsMaegleren
{
    class Saelger
    {
        //Field
        private int _id;
        private string _name;
        private string _adresse;
        private string _mobil;
        private string _email;

        //Construktor

        public Saelger(int id, string name, string adresse, string mobil, string email)
        {
            _id = id;
            _name = name;
            _adresse = adresse;
            _mobil = mobil;
            _email = email;
        }

        //properties

        public int Id
        {
            get { return _id; }
        }

        public string Name
        {
            get { return _name; }
        }

        public string adresse
        {
            get { return _adresse; }
        }

        public string mobil
        {
            get { return _mobil; }
        }

        public string email
        {
            get { return _email; }
        }

        //Metoder
        public override string ToString()
        {
            return $"{nameof(Id)}: {Id}, {nameof(Name)}: {Name}, {nameof(adresse)}: {adresse}, {nameof(mobil)}: {mobil}, {nameof(email)}: {email}";
        }

        
    }
}
