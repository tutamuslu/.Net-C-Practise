using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
           

            CustomerManager custonerManager = new CustomerManager();
            custonerManager.Add();
            custonerManager.Update();

            ProductManager productManager = new ProductManager(); 
            productManager.Add();
            productManager.Update();

            Customer customer = new Customer();
            customer.Name = "Tuğba";
            customer.Address = "Adress";
            customer.City = "London";

            Console.WriteLine(customer.Name + " "+ customer.Address);
            

            Console.ReadLine();
        }
    }
}
