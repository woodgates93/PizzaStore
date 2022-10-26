using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore
{
    public class CustomerFile
    {
        private readonly List<Customer> _customers;

        public CustomerFile()
        {
            _customers = new List<Customer>();
        }

        public void Add(Customer customer)
        {
            _customers.Add(customer);
        }

        public List<Customer> GetAll()
        {
            return new List<Customer>(_customers);
        }

        public Customer GetByNumber(int customerNumber)
        {
            foreach (Customer c in _customers)
            {
                if (c.CustomerNumber == customerNumber)
                {
                    return c;
                }
            }

            return null;
        }

        public Customer GetByName(string name)
        {
            foreach (Customer c in _customers)
            {
                if(c.Name == name)
                {
                    return c;
                }
            }

            return null;
        }

        public Customer Update(Customer customer)
        {
            Customer foundcustomer = GetByNumber(customer.CustomerNumber);
            if(foundcustomer != null)
            {
                foundcustomer.Name = customer.Name;
                foundcustomer.Mobil = customer.Mobil;
            }
            return foundcustomer;
        }

        public void Delete(Customer customer)
        {
            _customers.Remove(customer);
           
        }
        public override string ToString()
        {
            return $"All customers in customerfiles = {string.Join(", ", _customers)}";
        }
    }
}
