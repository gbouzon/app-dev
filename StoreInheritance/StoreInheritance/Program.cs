using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreInheritance
{
    class Program
    {
        //method to get a valid answer for mailing list option aka yes or no
        public static bool RetrieveMailingListOption()
        {
            bool isInMailingList = false;
            bool isValidOption;
            String mailingList;

            do
            {
                Console.WriteLine("Please enter 'Y' if you would like to be on the mailing list and 'N' if otherwise");
                mailingList = Console.ReadLine();
                if (mailingList.ToUpper().Equals("Y") || mailingList.ToUpper().Equals("YES"))
                {
                    isValidOption = true;
                    isInMailingList = true;
                }
                else if (mailingList.ToUpper().Equals("N") || mailingList.ToUpper().Equals("NO"))
                {
                    isValidOption = true;
                    isInMailingList = false;
                }
                else
                    isValidOption = false;
                
            } while (!isValidOption);

            return isInMailingList;
        }

        static void Main(string[] args)
        {
            //getting user's first name
            Console.WriteLine("Please enter your first name: ");
            String firstName = Console.ReadLine();

            //getting user's last name
            Console.WriteLine("Please enter your last name: ");
            String lastName = Console.ReadLine();

            //getting user's address
            Console.WriteLine("Please enter your address: ");
            String address = Console.ReadLine();

            //getting user's phone number
            Console.WriteLine("Please enter your phone number: ");
            String phoneNumber = Console.ReadLine();

            //getting user's customer number
            Console.WriteLine("Please enter your customer number: ");
            int customerNumber = Convert.ToInt32(Console.ReadLine());

            //getting user mailing list thingy
            bool isInMailingList = RetrieveMailingListOption();

            //getting total purchase amount
            Console.WriteLine("Please enter your total purchase amount: ");
            decimal purchaseAmount = Convert.ToDecimal(Console.ReadLine());

            //creating Person object from entered information
            Person person = new Person(lastName, firstName, address, phoneNumber);
            person.DisplayData();

            //creating Customer object from entered information
            Customer customer = new Customer(lastName, firstName, address, phoneNumber, customerNumber, isInMailingList);
            customer.DisplayData();

            //creating PreferredCustomer object from entered info
            PreferredCustomer customer2 = new PreferredCustomer(lastName, firstName, address, phoneNumber, customerNumber, isInMailingList, purchaseAmount);
            customer2.DisplayData();
        }
    }
}