using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookPractice
{
    public class MultipleAddressBooks
    {

        private Dictionary<string, List<Contact>> addressBooksMap;
        

        public MultipleAddressBooks()
        {
            addressBooksMap = new Dictionary<string, List<Contact>>();
        }

        public void AddAddressBook()
        {
            Console.WriteLine("Enter a name for new address book: ");
            string newAddressBookName = Console.ReadLine();

            if (newAddressBookName != null)
            {
                this.addressBooksMap.Add(newAddressBookName, new List<Contact>());
            }
        }

        public void AddContact()
        {
            Console.WriteLine("Which address book so you want to add your contact to?");
            string targetAddressBook = Console.ReadLine();

            if (addressBooksMap.ContainsKey(targetAddressBook) && targetAddressBook != null)
            {
                Console.WriteLine("Enter first name: ");
                string firstName = Console.ReadLine();
                Console.WriteLine("Enter second name: ");
                string lastName = Console.ReadLine();
                Console.WriteLine("Enter address: ");
                string address = Console.ReadLine();
                Console.WriteLine("Enter city: ");
                string city = Console.ReadLine();
                Console.WriteLine("Enter state: ");
                string state = Console.ReadLine();
                Console.WriteLine("Enter zip: ");
                string zip = Console.ReadLine();
                Console.WriteLine("Enter phoneNumber: ");
                string phoneNumber = Console.ReadLine();
                Console.WriteLine("Enter email: ");
                string email = Console.ReadLine();

                Contact contact = new Contact();
                contact.FirstName = firstName;
                contact.LastName = lastName;
                contact.Address = address;
                contact.City = city;
                contact.State = state;
                contact.Zip = zip;
                contact.PhoneNumber = phoneNumber;
                contact.Email = email;

                addressBooksMap[targetAddressBook].Add(contact);

            }
            else
            {
                Console.WriteLine("Address book doesn't exist");
            }

        }

        public void EditContact()
        {
            Console.WriteLine("Enter the name of address book in which contact is saved:");
            string targetAddressBook = Console.ReadLine();

            if(addressBooksMap.ContainsKey(targetAddressBook) && targetAddressBook != null)
            {
                Console.WriteLine("Enter first name: ");
                string fName = Console.ReadLine();
                Console.WriteLine("Enter last name: ");
                string lName = Console.ReadLine();

                for (int i = 0; i < addressBooksMap[targetAddressBook].Count; i++)
                {
                    Contact contact = addressBooksMap[targetAddressBook][i];
                    if (contact.FirstName == fName && contact.LastName == lName)
                    {
                        Console.WriteLine("Select one of the edit options below:");
                        Console.WriteLine("#1 - first name");
                        Console.WriteLine("#2 - last name");
                        Console.WriteLine("#3 - address");
                        Console.WriteLine("#4 - city");
                        Console.WriteLine("#5 - state");
                        Console.WriteLine("#6 - zip");
                        Console.WriteLine("#7 - phone number");
                        Console.WriteLine("#8 - email");
                        Console.WriteLine("Enter your choice: ");
                        string choice = Console.ReadLine();

                        switch (choice)
                        {
                            case "1":
                                Console.WriteLine("Enter new first name: ");
                                addressBooksMap[targetAddressBook][i].FirstName = Console.ReadLine();
                                break;
                            case "2":
                                Console.WriteLine("Enter new last name: ");
                                contact.LastName = Console.ReadLine();
                                break;
                            case "3":
                                Console.WriteLine("Enter new address: ");
                                contact.Address = Console.ReadLine();
                                break;
                            case "4":
                                Console.WriteLine("Enter new city: ");
                                contact.City = Console.ReadLine();
                                break;
                            case "5":
                                Console.WriteLine("Enter new state: ");
                                contact.State = Console.ReadLine();
                                break;
                            case "6":
                                Console.WriteLine("Enter new zip: ");
                                contact.Zip = Console.ReadLine();
                                break;
                            case "7":
                                Console.WriteLine("Enter new phone number: ");
                                contact.PhoneNumber = Console.ReadLine();
                                break;
                            case "8":
                                Console.WriteLine("Enter new email: ");
                                contact.Email = Console.ReadLine();
                                break;
                            default:
                                Console.WriteLine("Invalid option");
                                break;
                        }

                    }
                }

            }


        }



        public void DeleteContact()
        {
            Console.WriteLine("Enter the name of address book in which contact is saved:");
            string targetAddressBook = Console.ReadLine();

            if (addressBooksMap.ContainsKey(targetAddressBook) && targetAddressBook != null)
            {
                Console.WriteLine("Enter first name: ");
                string fName = Console.ReadLine();
                Console.WriteLine("Enter last name: ");
                string lName = Console.ReadLine();

                for (int i = 0; i < addressBooksMap[targetAddressBook].Count; i++)
                {
                    if (addressBooksMap[targetAddressBook][i].FirstName == fName && addressBooksMap[targetAddressBook][i].LastName == lName)
                    {
                        addressBooksMap[targetAddressBook].Remove(addressBooksMap[targetAddressBook][i]);
                    }
                }

            }

        }

        public void Display()
        {
            foreach (KeyValuePair<string, List<Contact>> item in addressBooksMap)
            {
                Console.WriteLine("===============================");
                Console.WriteLine("Name of address book: " + item.Key);
                Console.WriteLine("===============================");
                List<Contact> list = item.Value;
                foreach (Contact contact in list.ToList())
                {
                    Console.WriteLine("-----------------------------");
                    Console.WriteLine("First name: " + contact.FirstName);
                    Console.WriteLine("Last name: " + contact.LastName);
                    Console.WriteLine("Address: " + contact.Address);
                    Console.WriteLine("City: " + contact.City);
                    Console.WriteLine("State: " + contact.State);
                    Console.WriteLine("Zip: " + contact.Zip);
                    Console.WriteLine("Phone number: " + contact.PhoneNumber);
                    Console.WriteLine("Email: " + contact.Email);
                    Console.WriteLine("-----------------------------");
                }

            }
        }



    }
}
