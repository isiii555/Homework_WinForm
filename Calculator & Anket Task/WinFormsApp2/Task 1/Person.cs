using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp2
{
    public class Person
    {

        public Person() { }
        public Person(string name, string surname, string dad, string country, string city, string number, DateTime date, string gender)
        {
            Name = name;
            Surname = surname;
            Dad = dad;
            Country = country;
            City = city;
            Number = number;
            Date = date;
            Gender = gender;
        }

        public string Name { get; set; }

        public string Surname { get; set; }

        public string Dad { get; set; }

        public string Country { get; set; }

        public string City { get; set; }

        public string Number { get; set; }

        public DateTime Date { get; set; }

        public string Gender { get; set; }


    }
}
