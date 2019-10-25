using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using France_Vacancis_1_sem__projeck_vJon0._1.Annotations;
using France_Vacancis_1_sem__projeck_vJon0._1.Model;


namespace France_Vacancis_1_sem__projeck_vJon0._1.ModelView
{
    class ViewModel : INotifyPropertyChanged
    {


        //Feels
        private ObservableCollection<LejlighederModel> _lejlighedersCollection;
        private ObservableCollection<Bruger> _BrugerCollection;


        //InotifyUpdater
        


        //ViewLejlighedKartotek
        public ObservableCollection<LejlighederModel> LejlighedCollection
        {
            get { return _lejlighedersCollection; }
            set { _lejlighedersCollection = value; }
        }

        public ObservableCollection<Bruger> BrugerCollection
        {
            get { return _BrugerCollection; }
            set { _BrugerCollection = value; }
        }

        public ViewModel()
        {
            _lejlighedersCollection = new ObservableCollection<LejlighederModel>();
            _BrugerCollection = new ObservableCollection<Bruger>();


            //TestLoop
            //-------------------------------------------------HJÆLP--------------------------------------------------------

            //Test Lejligheder
            _lejlighedersCollection.Add(new LejlighederModel(1, "Lejlighed1", 11111, "Danmark", "Danske Økonogiske æg, i nærheden", 11111));
            _lejlighedersCollection.Add(new LejlighederModel(2, "Lejlighed2", 22222, "Danmark", "Danske Økonogiske æg, i nærheden", 22222));
            _lejlighedersCollection.Add(new LejlighederModel(3, "Lejlighed3", 33333, "Danmark", "Danske Økonogiske æg, i nærheden", 33333));
            _lejlighedersCollection.Add(new LejlighederModel(4, "Lejlighed4", 44444, "Danmark", "Danske Økonogiske æg, i nærheden", 44444));

            //TestBruger
            _BrugerCollection.Add(new Bruger(1, "Bruger1", "Bruger@mail.com", 11111));
            _BrugerCollection.Add(new Bruger(2, "Bruger2", "Bruger@mail.com", 22222));
            _BrugerCollection.Add(new Bruger(3, "Bruger3", "Bruger@mail.com", 33333));
            _BrugerCollection.Add(new Bruger(4, "Bruger4", "Bruger@mail.com", 44444));

            //-------------------------------------------------HJÆLP SLUT--------------------------------------------------------

        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
