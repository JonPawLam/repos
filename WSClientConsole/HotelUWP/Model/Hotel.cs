using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelUWP.Model
{
    class Hotel
    {
        public int ID { get; set; }
        public string HotelName { get; set; }
        public string HotelAddress { get; set; }

        public Hotel(string hotelName, string hotelAddress)
        {
            HotelName = hotelName;
            HotelAddress = hotelAddress;
        }

        public override string ToString()
        {
            return $"{nameof(ID)}: {ID}, {nameof(HotelName)}: {HotelName}, {nameof(HotelAddress)}: {HotelAddress}";
        }


    }
}
