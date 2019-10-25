using System;
using System.Collections.Generic;
using System.Text;

namespace RestCustomerConsumer
{
    class Customer
    {
        //Feels

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Year { get; set; }
        public static int NextId { get; set;}
        public int Id { get; set; }

        //Construktor
        public Customer(int id, string firstName, string lastName, int year)
        {
            NextId = id;
            FirstName = firstName;
            LastName = lastName;
            Year = year;
            NextId++;
            Id = id;
        }

        public Customer()
        {

        }

        public override string ToString()
        {
            return $"{nameof(FirstName)}: {FirstName}, {nameof(LastName)}: {LastName}, {nameof(Year)}: {Year}";
        }
    }
}
