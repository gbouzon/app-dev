using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreInheritance
{
    public class Person
    {
        //attributes
        protected string lastName;
        protected string firstName;
        protected string address;
        protected string phoneNumber;

        //constructor
        public Person(string lastName, string firstName, string address, string phoneNumber)
        {
            LastName = lastName;
            FirstName = firstName;
            Address = address;
            PhoneNumber = phoneNumber;
        }

        //method to display patient data in tabular format
        public virtual void DisplayData()
        {
            Console.WriteLine($"|-------------------------------------------------------|");
            Console.WriteLine($"|                        PERSON                         |");
            Console.WriteLine($"|-------------------------------------------------------|");
            Console.WriteLine(String.Format($"| {"Last Name", -20} | {LastName, -30} |"));
            Console.WriteLine(String.Format($"| {"First Name", -20} | {FirstName, -30} |"));
            Console.WriteLine(String.Format($"| {"Address", -20} | {Address, -30} |"));
            Console.WriteLine(String.Format($"| {"Phone Number", -20} | {PhoneNumber, 30} |"));
            Console.WriteLine($"|-------------------------------------------------------|");
        }

        //properties

        public string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                lastName = value;
            }
        }

        public string FirstName
        {
            get
            {
                return firstName;
            }
            set
            {
                firstName = value;
            }
        }

        public string Address
        {
            get
            {
                return address;
            }
            set
            {
                address = value;
            }
        }

        public string PhoneNumber
        {
            get
            {
                return phoneNumber;
            }
            set
            {
                phoneNumber = value;
            }
        }
    }
}
