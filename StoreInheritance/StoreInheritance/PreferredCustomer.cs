using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreInheritance
{
    public class PreferredCustomer : Customer
    {
        //attributes
        private decimal purchaseAmount;
        private int discountLevel;

        //constructor
        public PreferredCustomer(string lastName, string firstName, string address, string phoneNumber, int customerNumber,
            bool isInMailingList, decimal purchaseAmount) : base(lastName, firstName, address, phoneNumber,
                customerNumber, isInMailingList)
        {
            PurchaseAmount = purchaseAmount;
            DiscountLevel = discountLevel; 
        }

        //method to display patient data in tabular format
        public override void DisplayData()
        {
            string mailingList = (IsInMailingList) ? "Yes" : "No";

            Console.WriteLine($"|-------------------------------------------------------|");
            Console.WriteLine($"|                    PREFERRED CUSTOMER                 |");
            Console.WriteLine($"|-------------------------------------------------------|");
            Console.WriteLine(String.Format($"| {"Customer Number",-20} | {CustomerNumber,30} |"));
            Console.WriteLine(String.Format($"| {"Last Name",-20} | {LastName,-30} |"));
            Console.WriteLine(String.Format($"| {"First Name",-20} | {FirstName,-30} |"));
            Console.WriteLine(String.Format($"| {"Address",-20} | {Address,-30} |"));
            Console.WriteLine(String.Format($"| {"Phone Number",-20} | {PhoneNumber,30} |"));
            Console.WriteLine(String.Format($"| {"Mailing List",-20} | {mailingList,-30} |"));
            Console.WriteLine(String.Format($"| {"Purchase Amount",-20} | {"$" + PurchaseAmount,30} |"));
            Console.WriteLine(String.Format($"| {"Discount Level",-20} | {DiscountLevel,29}% |"));
            Console.WriteLine($"|-------------------------------------------------------|");
        }

        //properties

        public decimal PurchaseAmount
        {
            get
            {
                return purchaseAmount;
            }
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException(nameof(value), value, $"{nameof(purchaseAmount)} should" +
                        $"be a positive integer value");

                purchaseAmount = value;
            }
        }

        public int DiscountLevel
        {
            get
            {
                return discountLevel;
            }
            set
            {
                if (purchaseAmount >= 2000)
                    discountLevel = 10;
                else if (purchaseAmount >= 1500)
                    discountLevel = 7;
                else if (purchaseAmount >= 1000)
                    discountLevel = 6;
                else if (purchaseAmount >= 500)
                    discountLevel = 5;
                else
                    discountLevel = 0;
            }
        }
    }
}