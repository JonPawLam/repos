using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FV_007.Model
{
    class Kontakt
    {
         //Feels
        private int _kontaktID;
        private string _KontaktName;
        private string _KontaktAdresse;
        private string _KontaktMail;
        private int _KontaktTLF;

        //Construcktor

        public Kontakt(int kontaktId, string kontaktName, string kontaktAdresse, string kontaktMail, int kontaktTlf)
        {
            _kontaktID = kontaktId;
            _KontaktName = kontaktName;
            _KontaktAdresse = kontaktAdresse;
            _KontaktMail = kontaktMail;
            _KontaktTLF = kontaktTlf;
        }

        //Prop
        public int KontaktId
        {
            get => _kontaktID;
            set => _kontaktID = value;
        }

        public string KontaktName
        {
            get => _KontaktName;
            set => _KontaktName = value;
        }

        public string KontaktAdresse
        {
            get => _KontaktAdresse;
            set => _KontaktAdresse = value;
        }

        public string KontaktMail
        {
            get => _KontaktMail;
            set => _KontaktMail = value;
        }

        public int KontaktTlf
        {
            get => _KontaktTLF;
            set => _KontaktTLF = value;
        }




        //                  Metoder

        //Update

        public void UpdateKontaktId(int i)
        {
            _kontaktID = i;
        }

        public void UpdateKontaktName(string s)
        {
            _KontaktName = s;
        }

        public void UpdateKontaktAdresse(string s)
        {
            _KontaktAdresse = s;
        }

        public void UpdateKontaktMail(string s)
        {
            _KontaktMail = s;
        }

        public void UpdateKontaktTLF(int i)
        {
            _KontaktTLF = i;
        }


        //ToString
        public override string ToString()
        {
            return $"{nameof(KontaktId)}: {KontaktId}, {nameof(KontaktName)}: {KontaktName}, {nameof(KontaktAdresse)}: {KontaktAdresse}, {nameof(KontaktMail)}: {KontaktMail}, {nameof(KontaktTlf)}: {KontaktTlf}";
        }
    }
}
