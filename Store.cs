using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore
{
    public class Store
    {

        public void Start()
        {
            Console.WriteLine("Velkommen til Big Mamma Pizza");

            Customer customer1 = new Customer(1, "Jeppe", "+4593846");
            Customer customer2 = new Customer(2, "Ulla", "+4582376");
            Customer customer3 = new Customer(3, "Molly", "+4577328");

            CustomerFile customerFile = new CustomerFile();

            customerFile.Add(customer1);
            customerFile.Add(customer2);
            customerFile.Add(customer3);

            Console.WriteLine();
            Console.WriteLine("print out all customers:");
            foreach (Customer c in customerFile.GetAll())
            {
                Console.WriteLine("   " +c);
            }
            Console.WriteLine();
            Console.WriteLine("Update customer info:");
            customer3.Name = "Åsse";
            customerFile.Update(customer3);
            Console.WriteLine("    " + customerFile.GetByNumber(3));

            Console.WriteLine();
            Console.WriteLine("Deleteing customer:");
            customerFile.Delete(customer2);
            Console.WriteLine($"You are about to delete customer: {customer2.Name} with Customer Number {customer2.CustomerNumber}");
            Customer deletedCustomer = customerFile.GetByNumber(2);
            if(deletedCustomer is null)
            {
                Console.WriteLine("   " + "the Customer have been removed");
            }
            else
            {
                Console.WriteLine("    " + "Something went wrong" + deletedCustomer);
            }

            Console.WriteLine() ;
            Console.WriteLine();


            Pizza pizza1 = new Pizza(8, "Hawaii", 89.50);
            Pizza pizza2 = new Pizza(9, "Anders And", 79.50);
            Pizza pizza3 = new Pizza(10, "Løven", 68.95);

            PizzaMenu pizzaMenu = new PizzaMenu();
            pizzaMenu.Add(pizza1);
            pizzaMenu.Add(pizza2);
            pizzaMenu.Add(pizza3);

            Console.WriteLine("Adding new pizza:");
            Pizza pizza4 = new Pizza(11, "Såby Special", 99.50);
            pizzaMenu.Add(pizza4);
            Console.WriteLine("   " + pizzaMenu.GetByNo(11));


            Console.WriteLine();
            Console.WriteLine("Update the name of the Pizza");
            pizza4.ProductName = "Juventus";
            pizzaMenu.Update(pizza4);
            Console.WriteLine("    " + pizzaMenu.GetByNo(11));

            Console.WriteLine();
            Console.WriteLine("Deleting a Pizza");
            pizzaMenu.Delete(pizza1);
            Pizza deletedPizza = pizzaMenu.GetByNo(8);
       
                if (deletedPizza is null)
                {
                    Console.WriteLine("   " + "The pizza have been removed from the menu");
                }
                else
                {
                    Console.WriteLine("    " + "Something went wrong " + deletedPizza);
                }
           












        }
    }
}
