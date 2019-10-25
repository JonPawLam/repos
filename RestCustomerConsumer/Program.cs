using System;
using System.Collections;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Net.Http;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace RestCustomerConsumer
{
    class Program
    {
        //------------------See list off Customers-----------------------
        public static async Task<IList<Customer>> GetCustomersAsync()
        {

            using (HttpClient client = new HttpClient())
            {
                string content = await client.GetStringAsync("https://localhost:44308/api/customer");
                IList<Customer> cList = JsonConvert.DeserializeObject<IList<Customer>>(content);
                return cList;
            }
        }

        //-----------------------Remove a customer by ID-----------------------
        public static async Task<IList<Customer>> DeleteCustomerAsync(int id)
        {
            using (HttpClient client = new HttpClient())
            {
                await client.DeleteAsync("https://localhost:44308/api/Customer/" + id);
                string content = await client.GetStringAsync("https://localhost:44308/api/Customer");
                IList<Customer> cList = JsonConvert.DeserializeObject<IList<Customer>>(content);
                return cList;
            }
        }
        

        //-----------------------CreateNewConsumer-----------------------
        public static async Task<IList<Customer>> CreateCustomerAsync(Customer customer)
        {
            using (HttpClient client = new HttpClient())
            {
                
                HttpContent newCustomer = new StringContent(JsonConvert.SerializeObject(customer),Encoding.UTF8, "application/Json");

                await client.PostAsync("https://localhost:44308/api/Customer", newCustomer);
                string content = await client.GetStringAsync("https://localhost:44308/api/Customer");
                IList<Customer> cList = JsonConvert.DeserializeObject<IList<Customer>>(content);
                return cList;
            }
        }




        //-----------------------PutConsumer-----------------------
        public static async Task<IList<Customer>> PutCustomerAsync(Customer customer)
        {
            using (HttpClient client = new HttpClient())
            {

                HttpContent newCustomer = new StringContent(JsonConvert.SerializeObject(customer), Encoding.UTF8, "application/Json");
                await client.PutAsync("https://localhost:44308/api/Customer/" + customer.Id, newCustomer);
                

                string content = await client.GetStringAsync("https://localhost:44308/api/Customer");
                IList<Customer> cList = JsonConvert.DeserializeObject<IList<Customer>>(content);
                return cList;
            }
        }



        static void Main(string[] args)
        {
            string userChoice;

            //-----------//See list off Customers//-------------
            var result = GetCustomersAsync().Result;
            Console.WriteLine("Customer Creation Terminal");
            foreach (var Customer in result)
            {
                Console.WriteLine(Customer);
            }
            //-----------//Remove a customer by ID//--------------
            Console.WriteLine("Delete");

            userChoice = Console.ReadLine();
            var result2 = DeleteCustomerAsync(Convert.ToInt32(userChoice)).Result;
            foreach (var sCustomer in result2)
            {
                Console.WriteLine(sCustomer);
            }

            //------------//InsertCustomer//-----------------------
            Console.WriteLine("InsertCustomer");

            var addResult = CreateCustomerAsync(new Customer(99, "firstName99", "lastname99", 99)).Result;
            foreach (var customer in addResult)
            {
                Console.WriteLine(customer);
            }


            //---------------------------------------------
            Console.WriteLine("UpdateCustomer");

            var putResult = PutCustomerAsync(new Customer(99, "PutFirstName99", "PutLastname99", 99)).Result;
            foreach (var customer in putResult)
            {
                Console.WriteLine(customer);
            }

            Console.ReadKey();
        }

    }
}
