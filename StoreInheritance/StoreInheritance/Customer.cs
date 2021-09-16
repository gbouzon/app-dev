using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreInheritance
{
    public class Customer : Person
    {
        //attributes
        protected int customerNumber;
        protected bool isInMailingList;

        //constructor
        public Customer(string lastName, string firstName, string address, string phoneNumber, int customerNumber,
            bool isInMailingList) : base(lastName, firstName, address, phoneNumber)
        {
            CustomerNumber = customerNumber;
            IsInMailingList = isInMailingList;
        }

        //method to display patient data in tabular format
        public override void DisplayData()
        {
            string mailingList = (IsInMailingList) ? "Yes" : "No";

            Console.WriteLine($"|-------------------------------------------------------|");
            Console.WriteLine($"|                        CUSTOMER                       |");
            Console.WriteLine($"|-------------------------------------------------------|");
            Console.WriteLine(String.Format($"| {"Customer Number", -20} | {CustomerNumber, 30} |"));
            Console.WriteLine(String.Format($"| {"Last Name", -20} | {LastName, -30} |"));
            Console.WriteLine(String.Format($"| {"First Name", -20} | {FirstName, -30} |"));
            Console.WriteLine(String.Format($"| {"Address", -20} | {Address, -30} |"));
            Console.WriteLine(String.Format($"| {"Phone Number", -20} | {PhoneNumber, 30} |"));
            Console.WriteLine(String.Format($"| {"Mailing List", -20} | {mailingList, -30} |"));
            Console.WriteLine($"|-------------------------------------------------------|");
        }

        //properties

        public int CustomerNumber
        {
            get
            {
                return customerNumber;
            }
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException(nameof(value), value, $"{nameof(customerNumber)} should" +
                        $"be a positive integer value");

                customerNumber = value;
            }
        }

        public bool IsInMailingList
        {
            get
            {
                return isInMailingList;
            }
            set
            {
                isInMailingList = value;
            }
        }
    }
}
