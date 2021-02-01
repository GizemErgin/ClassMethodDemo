using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMethodDemo
{
    class CustomerManager
    {
       public void Add(Customer customer)
        {
            Console.WriteLine("Customer Id: ");
            customer.CustomerId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nCustomer TC Number: ");
            customer.CustomerTcNumber = Console.ReadLine();
            Console.WriteLine("\nCustomer Name: ");
            customer.CustomerName = Console.ReadLine();
            Console.WriteLine("\nCustomer Surname: ");
            customer.CustomerSurname = Console.ReadLine();

            Console.WriteLine("\nSuccessfully added to the customer list: "+ customer.CustomerName+" "+customer.CustomerSurname);
        }

        {
        }

        public void Listing(List<Customer> customers)
        {

            foreach (var customer in customers)
            {
                Console.WriteLine("ID: "+customer.CustomerId + " \nTC Number: "+customer.CustomerTcNumber
                    + "\nName Surname: "+customer.CustomerName + " "+customer.CustomerSurname);
                Console.WriteLine("----------------");
            }


        }

        


    }
}
