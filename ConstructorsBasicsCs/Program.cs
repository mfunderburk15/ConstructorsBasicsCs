using System;

namespace ConstructorsBasicsCs
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer(1, "Masen");
            Console.WriteLine(customer.Id);
            Console.WriteLine(customer.Name);


        }
    }
}
