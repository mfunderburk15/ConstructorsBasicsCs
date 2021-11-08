using System;
using System.Collections.Generic;

namespace ConstructorsBasicsCs
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer(1, "Masen");

            Order order = new Order();

            

            Console.WriteLine(customer.Id);
            Console.WriteLine(customer.Name);


        }
    }
}
