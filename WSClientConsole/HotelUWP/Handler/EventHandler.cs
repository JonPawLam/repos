using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelUWP.Model;
using HotelUWP.ViewModel;

namespace HotelUWP.Handler
{
    class HotelHandler
    {
        public HotelViewModel HotelViewModel { get; set; }

        public HotelHandler(HotelViewModel hotelViewModel)
        {
            HotelViewModel = hotelViewModel;

        }

        public void CreateHotel()
        {
            Hotel newHotel = new Hotel( HotelViewModel.HotelName, HotelViewModel.HotelAddress );
            HotelViewModel.HotelSingleton.CreateHotel(newHotel);
        }

        public void SetSelectedHotel(Hotel selectedHotel)
        {
            HotelViewModel.

        }

        //public void DeleteHotel()
        //{
        //    HotelViewModel.HotelSingleton.RemoveEvent(HotelViewModel.SelectedEvent);
        //}

    }
}
