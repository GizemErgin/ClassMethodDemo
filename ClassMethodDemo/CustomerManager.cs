using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMethodDemo
{
    class CustomerManager
    {
       public void Add(Customer customer)
        {
            Console.WriteLine("\nSuccessfully added to the customer list: "+ customer.CustomerName+" "+customer.CustomerSurname);
        }

        public void Delete(Customer customer)
        {
            Console.WriteLine("\nSuccessfully deleted from the customer list: "+ customer.CustomerName+" "+customer.CustomerSurname);
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
