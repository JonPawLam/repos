using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Configuration;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using WebServerHotel;


namespace WSClientConsole
{
    class Program
    {
        static void Main(string[] args)
        {

            


            const string serverURL = "http://localhost:55000";
            HttpClientHandler handler = new HttpClientHandler();
            handler.UseDefaultCredentials = true;
            using (var client = new HttpClient(handler))

            {

                client.BaseAddress = new Uri(serverURL);
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));




                bool loop = true;
                string userImput;

                while (loop== true)
                {


                    Console.WriteLine("Print all hotels Press: P     Add Hotel Press: A         Delete press: D         Exit Program: X");
                    Console.WriteLine("-------------------------------------------------------------------------------------------------");

                    userImput = Console.ReadLine();

                    //Print all hotels
                    if (userImput == "P")

                    { 
                    


                    try
                    {
                    var responce = client.GetAsync("api/hotels").Result;
                    //Wrong
                    if (responce.IsSuccessStatusCode)
                    {
                        var hotels = responce.Content.ReadAsAsync<IEnumerable<Hotel>>().Result;
                        foreach (var hotel in hotels)
                        {
                            Console.WriteLine(hotel);
                        }
                    }
                    }

                    catch (Exception e)
                    {
                    Console.WriteLine(e);
                    throw;
                    }

                    }

                    //Create

                    if (userImput == "A")
                    {
                        Console.WriteLine("Add hotel");

                        Console.WriteLine("Hotel name?");
                        string _hotelname = Console.ReadLine();
                        Console.WriteLine("Street name?");
                        string _hotelAddress = Console.ReadLine();

                        Hotel hotel = new Hotel(){ HotelName = _hotelname , HotelAddress = _hotelAddress};


                        client.PostAsJsonAsync("api/hotels", hotel);


                    }

                    //Delete hotel

                        if (userImput == "D")
                    {
                        Console.WriteLine("Choose hotel ID to delete");
                        client.DeleteAsync("api/hotels/" + Convert.ToString(Console.ReadLine()));

                        //client.DeleteAsync("api/hotels/9");

                    }

                    if (userImput == "X")
                    {
                        loop = false;
                    }

                }
            }
        }
    }
}
