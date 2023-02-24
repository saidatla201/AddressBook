using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    internal class AddressBook
    {
        //storing in user defiened data type list
        List<Contact> data = new List<Contact>();
        public void CreateContacts()
        {

            
            Contact contact = new Contact();
            
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

            data.Add(contact); //contact added in generic list

        }
        public void DisplayContact()
        {
            CreateContacts(); //before display contact details need to take user details
            Console.WriteLine("\nHere is the contact details saved.\n");
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

        public void EditContact()
        {
            DisplayContact(); //to edit the contact need to save the contact details first
            Console.WriteLine("\nTo Edit Contact Enter  First Name\n");
            string name = Console.ReadLine();
            foreach (var record in data)
            {
                if (record.FirstName == name)
                {
                    Console.WriteLine("Contact Found...Enter the option to Edit the Contact: ");
                    Console.WriteLine("1 to Change First name \n2 to Change Last name \n3 to Change Address  \n4 to Change City  \n5 to Change State  \n6 to Change Zip  \n7 to Change Phonenumber  \n8 to Change Email \n9 Exit");
                    int Check = Convert.ToInt32(Console.ReadLine());
                    switch (Check)
                    {
                        case 1:
                            Console.WriteLine("Enter the New First Name: ");
                            record.FirstName = Console.ReadLine();
                            DisplayContact();
                            break;
                        case 2:
                            Console.WriteLine("Enter the New Last Name: ");
                            record.LastName = Console.ReadLine();
                            DisplayContact();
                            break;
                        case 3:
                            Console.WriteLine("Enter the New Address: ");
                            record.Address = Console.ReadLine();
                            break;
                        case 4:
                            Console.WriteLine("Enter the New City: ");
                            record.City = Console.ReadLine();
                            break;
                        case 5:
                            Console.WriteLine("Enter the New State: ");
                            record.State = Console.ReadLine();
                            break;
                        case 6:
                            Console.WriteLine("Enter the New Pin Code: ");
                            record.ZIPCode = Convert.ToInt32(Console.ReadLine());
                            break;
                        case 7:
                            Console.WriteLine("Enter the New Phone Number: ");
                            record.PhoneNumber = Convert.ToInt64(Console.ReadLine());
                            break;
                        case 8:
                            Console.WriteLine("Enter the New Email: ");
                            record.Email = Console.ReadLine();
                            break;
                        case 9:
                            return;
                    }
                }
                else
                {
                    Console.WriteLine("Contact Not Found. Enter the valid name!");
                }
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

