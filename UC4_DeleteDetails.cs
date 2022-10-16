using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystems
{
    class UC4_DeleteDetails
    {
        public void DeletetheName()
        {
            if (UC2_AddDetails.AddressBook.Count > 0)
            {
                Console.Write("Enter name of contact you want to delete: ");
                string deleteName = Console.ReadLine();


                foreach (var item in UC2_AddDetails.AddressBook)
                {
                    if (deleteName.ToLower() == item.FirstName.ToLower())
                    {
                        UC2_AddDetails.AddressBook.Remove(item);
                        Console.WriteLine(deleteName + "'s Contact is successfully deleted.");
                        break;
                    }

                    else
                    {
                        Console.WriteLine(deleteName + " does not exist in Address Book.");
                    }
                }
            }

            else
            {
                Console.WriteLine("Address Book is empty.");
            }
        }
    }
}
