using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    internal class AddressBook
    {
        public static void CreateContacts()
        {
            //Creating a object to access non-static method (Contact Class)
            Contact contact = new Contact();
            //reading data and storing in set method/properties 
            Console.Write("Enter First Name : ");
            contact.FirstName = Console.ReadLine();
            //Last Name 
            Console.Write("Enter Last Name : ");
            contact.LastName = Console.ReadLine();
            //Address
            Console.Write("Enter Address : ");
            contact.Address = Console.ReadLine();
            //City
            Console.Write("Enter City Name : ");
            contact.City = Console.ReadLine();
            //State Name 
            Console.Write("Enter State Name : ");
            contact.State = Console.ReadLine();
            //ZIP Code
            Console.Write("Enter ZIP Code : ");
            contact.ZIPCode = Convert.ToInt32(Console.ReadLine());
            //Phone Number
            Console.Write("Enter Phone Number : ");
            contact.PhoneNumber = Convert.ToInt64(Console.ReadLine());
            //Email Id :
            Console.Write("Enter Email Id : ");
            contact.Email = Console.ReadLine();
            Console.WriteLine("\nContact Added Succesfully....!\n");

            //storing in user defiened data type list
            List<Contact> data = new List<Contact>();
            data.Add(contact); //Add is a method in List

            Console.WriteLine("Here is the Contact Details Saved\n");

            foreach (Contact record in data)
            {
                Console.WriteLine("First Name : " + record.FirstName);
                Console.WriteLine("Last Name : " + record.LastName);
                Console.WriteLine("Address : " + record.Address);
                Console.WriteLine("City : " + record.City);
                Console.WriteLine("State : " + record.State);
                Console.WriteLine("ZIP Code : " + record.ZIPCode);
                Console.WriteLine("Phone Number : " + record.PhoneNumber);
                Console.WriteLine("Email Id : " + record.Email);
            }
        }
    }
    public class Contact
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int ZIPCode { get; set; }
        public long PhoneNumber { get; set; }
        public string Email { get; set; }
    }
}

