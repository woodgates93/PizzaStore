using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore
{
    public class Customer
    { 
        public int CustomerNumber { get; set; }
        public string Name { get; set; }
        public string Mobil { get; set; }

        public Customer()
        {

        }


        public Customer(int customerNumber, string name, string mobil) 
        {
            CustomerNumber = customerNumber;
            Name = name;
            Mobil = mobil;

        }

        public override string ToString()
        {
            return $"{{{nameof(CustomerNumber)} = {CustomerNumber.ToString()}, {nameof(Name)} = {Name}, {nameof(Mobil)} = {Mobil}}}";

        }
    }   
}
