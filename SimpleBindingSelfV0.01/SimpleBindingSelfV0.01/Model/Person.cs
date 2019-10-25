using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.ApplicationModel.Email;


namespace SimpleBindingSelfV0._01.Model
{
    class Person : INotifyPropertyChanged
    {

        //Feels
        private string _ForNave;
        private string _EfterNavn;
        private int _alder;

        //constructor
        public Person(string fornavn, string efterNavn, int alder)
        {
            _ForNave = fornavn;
            _EfterNavn = efterNavn;
            _alder = alder;
        }


        //Property
        public string ForName
        {
            get => _ForNave;
            set => _ForNave = value;
        }

        public string Efternavn
        {
            get => _EfterNavn;
            set => _EfterNavn = value;
        }

        public int Alder
        {
            get => _alder;
            set => _alder = value;
        }


        //Metoder


        //Get
        public string GetForNavn()
        {
            return _ForNave;
        }


        public string GetEfterNavn()
        {
            return _EfterNavn;
        }

        public int GetAlder()
        {
            return _alder;
        }
        
        //Update

        public void UpdateForNavn(string fornavnUpdate)
        {
            _ForNave = fornavnUpdate;
        }

        public void UpdateEfterNavn(string EfternavnUpdate)
        {
            _EfterNavn = EfternavnUpdate;
        }

        public void AlderUpdate(int AlderUpdate)
        {
            _alder = AlderUpdate;
        }

    }
}