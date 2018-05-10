using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Person
    {
        public string Name;

        public void Introduce(string to)
        {
            Console.WriteLine("Hi {0}, I am {1}.", to, Name);
        }

        public static Person Parse(string str)
        {
            var person = new Person();
            person.Name = str;
            return person;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var person = new Classes.Person();
            person.Name = "Hector";
            person.Introduce("Loyda");

            var p = Person.Parse("Uthiball");
            p.Introduce("Lothar");

            var customer = new Customer(1, "John");
            Console.WriteLine("Customer ID {0}", customer.Id);
            Console.WriteLine("Customer Name {0}", customer.Name);
        }
    }
}
