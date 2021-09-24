using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeartRates
{
    class HeartRates
    {
        //attributes
        private String firstName;
        private String lastName;
        private int birthYear;
        private int currentYear;

        //constructor
        public HeartRates(String firstName, String lastName, int birthYear)
        {
            FirstName = firstName;
            LastName = lastName;
            BirthYear = birthYear;
            CurrentYear = DateTime.Now.Year;
        }

        //property that calculates the age
        public int Age
        {
            get
            {
                return currentYear - birthYear;
            }
        }

        //property that calculates max heart rate
        public int MaxHeartRate
        {
            get
            {
                return 220 - Age;
            }
        }

        //property that calculates minimum target heart rate
        public int MinTargetRate
        {
            get
            {
                return (int) (0.5 * MaxHeartRate);
            }
        }

        //property that calculates maximum target heart rate
        public int MaxTargetRate
        {
            get
            {
                return (int) (0.85 * MaxHeartRate);
            }
        }

        //method to display patient data in tabular format
        public void DisplayPatientRecord()
        {
            Console.WriteLine($"|--------------------------------------------------|");
            Console.WriteLine($"|            PATIENT HEART RATE RECORD             |");
            Console.WriteLine($"|--------------------------------------------------|");
            Console.WriteLine(String.Format($"| {"Patient Name", -20} | {LastName + ", " + FirstName, -25} |"));
            Console.WriteLine(String.Format($"| {"Patient Birth Year", -20} | {BirthYear, 25} |"));
            Console.WriteLine(String.Format($"| {"Patient Age", -20} | {Age, 25} |"));
            Console.WriteLine(String.Format($"| {"Maximum Heart Rate", -20} | {MaxHeartRate, 25} |"));
            Console.WriteLine(String.Format($"| {"Target Heart Rate", -20} | {MinTargetRate + " - " + MaxTargetRate, 25} |"));
            Console.WriteLine($"|--------------------------------------------------|");
        }

        //properties

        public String FirstName
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

        public String LastName
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

        public int BirthYear
        {
            get
            {
                return birthYear;
            }
            set
            {
                birthYear = (value > 0) ? value : 0;
            }
        }

        public int CurrentYear
        {
            get
            {
                return currentYear;
            }
            set
            {
                currentYear = DateTime.Now.Year;
            }
        }
    }

    class Driver
    {
        static void Main(string[] args)
        {
            //getting user's first name
            Console.WriteLine("Please enter your first name: ");
            String firstName = Console.ReadLine();

            //getting user's last name
            Console.WriteLine("Please enter your last name: ");
            String lastName = Console.ReadLine();

            //getting user's year of birth
            Console.WriteLine("Please enter your year of birth: ");
            int birthYear = Convert.ToInt32(Console.ReadLine());

            //creating HeartRates object from entered information
            HeartRates h1 = new HeartRates(firstName, lastName, birthYear);
            h1.DisplayPatientRecord();
        }
    }
}