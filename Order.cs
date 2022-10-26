using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore
{
    public class Order
    {

 

        
        private Customer _customer;

        private Pizza _pizza;

        


        

        public Order (Customer customer, Pizza pizza)
        {
          
            _customer = customer;
            _pizza = pizza;
        }
        
        public override string ToString()
        {
            return $"Kunden er {_customer} og har købt pizzaen {_pizza}.";
        }
    }
}
