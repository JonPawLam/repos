using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using HotelUWP.Annotations;
using HotelUWP.Common;
using HotelUWP.Handler;
using HotelUWP.Model;

namespace HotelUWP.ViewModel
{
    class HotelViewModel : INotifyPropertyChanged
    {

        private ICommand _deleteHotelCommand;

        private ICommand _SelectedEventCommand;

        private ICommand _CreateHotel;

        private Hotel _SelectedHotel;
        

        public string HotelName { get; set; }

        public string HotelAddress { get; set; }
        
        public Handler.HotelHandler Handler { get; set; }
        
        public Hotel SelectedHotel
        {
            get { return _SelectedHotel}
            set
            {
                _SelectedHotel = value;
                OnPropertyChanged();
            }

        }




        // SelectedHotelCommand
        public ICommand SelectedHotelCommand
        {
            get
            {
                return _SelectedEventCommand ?? (_SelectedEventCommand =
                           new RelayArgCommand<Hotel>(ev => Handler.SetSelectedHotel(ev)));
            }
            set
            {
                _SelectedEventCommand = value; 

            }
            
        }


        //Create Hotel
        public ICommand CreateHotel
        {
            get { return _CreateHotel ?? (_CreateHotel = new RelayCommand(Handler.CreateHotel)); }
        }


        //Constructor
        public HotelSingleton HotelSingleton { get; set; }

        public HotelViewModel()
        {
            Handler = new HotelHandler(this);
            HotelSingleton = HotelSingleton.Instance;

        }

        //Delete Hotel
        //public ICommand DeleteHotelCommand
        //{
        //    get { return _deleteHotelCommand ?? (_deleteHotelCommand = new RelayArgCommand(EventHandler))}

        //}


        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
