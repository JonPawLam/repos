using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using RestCustomerService.Model;

namespace RestCustomerService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        public static List<Customer> cList = new List<Customer>()
        {
            new Customer(1, "2firstname", "2Lastname", 2010),
            new Customer(2, "2firstname", "2Lastname", 2005),
            new Customer(3, "3firstname", "3Lastname", 2010),
        };



    public void CustomerTestAdd()
        {

        }

        // GET: api/Customer
        [HttpGet]
        public List<Customer> Get()  // or public IEnumerable<string> Get()
        {
            return cList; //cList
        }
        
        // GET: api/Customer/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            foreach (var Customer in cList)
            {
                if (id == Customer.Id)
                {
                    return Customer.ToString();
                }
            }

            return "Fejl";
        }

        // POST: api/Customer
        [HttpPost]
        public void Post(Customer costumer)
        {
            cList.Add(costumer);
        }

        // PUT: api/Customer/5
        [HttpPut("{id}")]
        public void Put(Customer costumer, int id)
        {
            int index=cList.FindIndex(x => x.Id ==id);
            cList[index] = costumer;

        }

        // DELETE: api/Customer/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            foreach (var Customer in cList)
            {
                if (id == Customer.Id)
                {
                   cList.Remove(Customer);
                }
            }
        }
    }
}
