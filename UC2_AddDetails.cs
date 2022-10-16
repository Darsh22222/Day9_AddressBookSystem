using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystems
{
    class UC2_AddDetails
    {
        public static   List<UC1_ContactDetails> AddressBook = new List<UC1_ContactDetails>();

        public void EnterInput()

        {
            Console.WriteLine("enter how many contacts you want to add");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                UC1_ContactDetails contacts = new UC1_ContactDetails();

                Console.Write("Enter the First Name : ");
                contacts.FirstName = Console.ReadLine();


                Console.Write("Enter the last Name  : ");
                contacts.LastName = Console.ReadLine();

                Console.Write("Enter the address  : ");
                contacts.Address = Console.ReadLine();

                Console.Write("Enter the City  : ");
                contacts.City = Console.ReadLine();

                Console.WriteLine("Enter the state : ");
                contacts.State = Console.ReadLine();

                while (true)
                {
                    Console.Write("Enter Zip Code  : ");
                    string code = Console.ReadLine();

                    if (code.Length == 6)
                    {
                        contacts.Zip = code;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Enter a valid 6 digit Zip Code.");
                    }
                }

                while (true)
                {
                    Console.Write("Enter Your Phone Number: ");
                    string number = Console.ReadLine();

                    if (number.Length == 10)
                    {
                        contacts.PhoneNumber = number;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Enter a valid 10 digit Phone Number.");
                    }
                }

                while (true)
                {
                    Console.Write("Enter Your Email Address: ");
                    string mail = Console.ReadLine();

                    if (mail.Contains("@"))
                    {
                        contacts.Email = mail;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Enter a valid Email Address.");
                    }
                }

                AddressBook.Add(contacts);

                Console.WriteLine("..................");

            }

        }


        public void ViewTheDetails()
        {
            if (AddressBook.Count > 0)
            {
                foreach (var item in AddressBook)
                {
                    PrintTheDetails(item);

                }
            }
            else
            {
                Console.WriteLine("Address book is empty! ");

            }
        }

        public void PrintTheDetails(UC1_ContactDetails item)
        {
            Console.WriteLine("First Name :   " + item.FirstName);
            Console.WriteLine("Last Name :    " + item.LastName);
            Console.WriteLine("Address :      " + item.Address);
            Console.WriteLine("City    :      " + item.City);
            Console.WriteLine("State   :      " + item.State);
            Console.WriteLine("Zip     :      " + item.Zip);
            Console.WriteLine("Phone Number  : " + item.PhoneNumber);
            Console.WriteLine("email  :       " + item.Email);


        }


    }
}

