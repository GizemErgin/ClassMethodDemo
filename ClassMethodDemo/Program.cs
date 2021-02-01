using System;
using System.Collections.Generic;

namespace ClassMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            {
                customer1.CustomerId = 1;
                customer1.CustomerTcNumber = "11111111111";
                customer1.CustomerName = "Gizem";
                customer1.CustomerSurname = "Ergin";
            }

            Customer customer2 = new Customer();
            {
                customer2.CustomerId = 2;
                customer2.CustomerTcNumber = "22222222222";
                customer2.CustomerName = "Ece";
                customer2.CustomerSurname = "Güler";
            }

            Customer customer3 = new Customer();
            {
                customer3.CustomerId = 3;
                customer3.CustomerTcNumber = "33333333333";
                customer3.CustomerName = "Ezgi";
                customer3.CustomerSurname = "Demir";
            }

            Customer customer4 = new Customer();
            {
                customer4.CustomerId = 4;
                customer4.CustomerTcNumber = "44444444444";
                customer4.CustomerName = "Hanife";
                customer4.CustomerSurname = "Tuna";
            }

            Selection();















            void Selection()
            {
                Console.WriteLine("Select an Action \nAdded (a/A) -- Delete (d/D) -- Listing (l/L)");
                var pressed = Console.ReadLine();
                switch (pressed)
                {
                    case "a":
                    case "A":
                        {
                            Console.Clear();
                            Customer customer = new Customer();
                            Console.WriteLine("Customer Id: ");
                            customer.CustomerId = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("\nCustomer TC Number: ");
                            customer.CustomerTcNumber = Console.ReadLine();
                            Console.WriteLine("\nCustomer Name: ");
                            customer.CustomerName = Console.ReadLine();
                            Console.WriteLine("\nCustomer Surname: ");
                            customer.CustomerSurname = Console.ReadLine();

                            CustomerManager customerManager = new CustomerManager();
                            customerManager.Add(customer);
                            Console.WriteLine("");
                            Selection();
                            break;
                        }
                    case "d":
                    case "D":
                        {
                            Console.Clear();
                            CustomerManager customerManager = new CustomerManager();
                            Console.WriteLine("");
                            Selection();
                            break;
                        }
                    case "l":
                    case "L":
                        {
                            Console.Clear();
                            List<Customer> customers = new List<Customer> { customer1, customer2, customer3, customer4 };
                            CustomerManager customerManager = new CustomerManager();
                            customerManager.Listing(customers);
                            Console.WriteLine("");
                            Selection();
                            break;
                        }
                    default:
                        Environment.Exit(0);
                        break;
                }
            }




        }
    }
}
