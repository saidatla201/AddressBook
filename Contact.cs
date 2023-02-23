using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    public  class Contact
    {
        public void contact()
        {
            Console.Write("Enter the First name :");
            string Firstname = Console.ReadLine();
            Console.Write("Enter the Last name :");
            string Lastname = Console.ReadLine();
            Console.Write("Enter the Address :");
            string Address = Console.ReadLine();
            Console.Write("Enter the State name :");
            string Statename = Console.ReadLine();
            Console.Write("Enter the District name :");
            string District = Console.ReadLine();
            Console.Write("Enter the Zip Code :");
            int Zipcode = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter your Phone Number :");
            long  PhoneNum = Convert.ToInt32(Console.ReadLine());





        }
    }
}
