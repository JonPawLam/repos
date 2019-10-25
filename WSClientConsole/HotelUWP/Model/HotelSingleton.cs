using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelUWP.Model
{
    class HotelSingleton
    {
        private static HotelSingleton _instance = null;

        public static HotelSingleton Instance
        {
            get { return _instance ?? (_instance = new HotelSingleton()); }

        }

        public ObservableCollection<Hotel> Hotels { get; set; }

        private HotelSingleton()
        {
            Hotels = new ObservableCollection<Hotel>();

            Hotels.Add(new Hotel("Adresse1", "Name1"));
            Hotels.Add(new Hotel("Adresse2", "Name2"));
            Hotels.Add(new Hotel("Adresse3", "Name3"));
            Hotels.Add(new Hotel("Adresse4", "Name4"));
            Hotels.Add(new Hotel("Adresse5", "Name5"));
        }

        public void CreateHotel(Hotel addHotel)
        {
            Hotels.Add(addHotel);
            
        }



        public void RemoveEvent(Hotel removeEvent)
        {
            Hotels.Remove(removeEvent);
            
        }
    }
}
