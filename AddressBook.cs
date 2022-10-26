using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    public class AddressBook
    {

        private List<Contact> addressBook;

        public AddressBook()
        {
            addressBook = new List<Contact>();
        }

        public AddressBook(string firstName, string lastName, string address, string city, string state, string zip, string phoneNumber, string email)
        {
            this.addressBook = new List<Contact>();
            Contact contact = new Contact() { FirstName = firstName, LastName = lastName, Address = address, City = city, State = state, Zip = zip, PhoneNumber = phoneNumber, Email = email };
            addressBook.Add(contact);
        }


        public void AddContact()
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
            Console.WriteLine("Enter phone number: ");
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

            addressBook.Add(contact);
        }


        public void EditContact()
        {

            Console.WriteLine("Enter first name: ");
            string fName = Console.ReadLine();
            Console.WriteLine("Enter last name: ");
            string lName = Console.ReadLine();

            for (int i = 0; i < addressBook.Count; i++)
            {
                Contact contact = addressBook[i];
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
                            addressBook[i].FirstName = Console.ReadLine();
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


        public void DeleteContact()
        {
            Console.WriteLine("Enter first name: ");
            string fName = Console.ReadLine();
            Console.WriteLine("Enter last name: ");
            string lName = Console.ReadLine();

            
            foreach (Contact contact in addressBook.ToList())
            {
                if (contact.FirstName == fName && contact.LastName == lName)
                {
                    addressBook.Remove(contact);
                }
            }

        }


        public void Display()
        {
            Console.WriteLine("=============================");
            Console.WriteLine("All contacts in address book");
            Console.WriteLine("=============================");

            foreach (Contact contact in addressBook)
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
