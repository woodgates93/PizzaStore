using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore
{
    public class Pizza
    {
        private int _productNo;
        private string _productName;
        private double _price;

        public int ProductNo { get { return _productNo; } set { _productNo = value; } }
        public double Price { get { return _price; } set { _price = value; } }
        public string ProductName { get { return _productName; } set { _productName = value; } }




       

        public double TotalPrice()
        {
            return _price + 40 * 1.25;

        }

        
        public Pizza(int ProductNo, string ProductName, double Price) 
        {
            _productNo = ProductNo;
            _price = Price;
            _productName = ProductName;
        }

        public override string ToString()
        {
            return $"{_productNo}. {_productName} That costs {_price}";
        }
    }

    
}
