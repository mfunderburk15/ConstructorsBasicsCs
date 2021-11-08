using System;

namespace ConstructorsBasicsCs
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            Console.WriteLine(customer.Id);
            Console.WriteLine(customer.Name);


        }
    }
}
