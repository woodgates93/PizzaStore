using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore
{
    public class PizzaMenu
    {
        private readonly Dictionary<int , Pizza> _pizza;

        public PizzaMenu()
        {
            _pizza = new Dictionary<int, Pizza>();
        }

        public void Add(Pizza pizza)
        {
            _pizza.Add(pizza.ProductNo, pizza);
        }

        public List<Pizza> GetAll()
        {
            return new List<Pizza>(_pizza.Values);
        }

        public Pizza GetByNo(int productNo)
        {
            return _pizza[productNo];
        }

        public void Update(Pizza pizza)
        {
            _pizza[pizza.ProductNo] = pizza;
        }
        public void Delete(Pizza pizza)
        {
            _pizza.Remove(pizza.ProductNo);
        }
    }
}
