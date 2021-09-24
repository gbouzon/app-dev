using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthProfile
{
    class HealthProfile
    {
        //attributes
        private String firstName;
        private String lastName;
        private int birthYear;
        private int currentYear;
        private double height;
        private double weight;

        //constructor
        public HealthProfile(String firstName, String lastName, int birthYear, double weight, double height)
        {
            FirstName = firstName;
            LastName = lastName;
            BirthYear = birthYear;
            CurrentYear = currentYear;
            Weight = weight;
            Height = height;
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

        //method to calculate BMI
        public double CalculateBMI()
        {
            return Math.Round((weight * 703) / (Math.Pow(height, 2)), 2);
        }

        public String GetVerbalRating()
        {
            double bmi = CalculateBMI();

            if (bmi < 18.5)
                return "Underweight";
            else if (bmi < 25)
                return "Normal";
            else if (bmi < 30)
                return "Overweight";
            else
                return "Obese";
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
            Console.WriteLine(String.Format($"| {"Patient Height (in)", -20} | {Height, 25} |"));
            Console.WriteLine(String.Format($"| {"Patient Weight (lbs)", -20} | {Weight, 25} |"));
            Console.WriteLine(String.Format($"| {"Maximum Heart Rate", -20} | {MaxHeartRate, 25} |"));
            Console.WriteLine(String.Format($"| {"Target Heart Rate", -20} | {MinTargetRate + " - " + MaxTargetRate, 25} |"));
            Console.WriteLine(String.Format($"| {"BMI Numeric Value", -20} | {CalculateBMI(), 25} |"));
            Console.WriteLine(String.Format($"| {"BMI Text Value", -20} | {GetVerbalRating(), -25} |"));
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

        public double Weight
        {
            get
            {
                return weight;
            }
            set
            {
                weight = (value > 0) ? value : 0;
            }
        }

        public double Height
        {
            get
            {
                return height;
            }
            set
            {
                height = (value > 0) ? value : 0;
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

            //getting user's height in inches
            Console.WriteLine("Please enter your height in inches: ");
            double height = Convert.ToDouble(Console.ReadLine());

            //getting user's weight in pounds
            Console.WriteLine("Please enter your weight in pounds: ");
            double weight = Convert.ToDouble(Console.ReadLine());

            //creating HealthProfile object from entered information
            HealthProfile h2 = new HealthProfile(firstName, lastName, birthYear, weight, height);
            h2.DisplayPatientRecord();
        }
    }
}
