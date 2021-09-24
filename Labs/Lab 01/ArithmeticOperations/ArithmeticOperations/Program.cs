using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArithmeticOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum, difference, product, quotient, remainder;

            int number1 = 15;
            int number2 = 3;

            sum = number1 + number2;
            difference = number1 - number2;
            product = number1 * number2;
            quotient = number1 / number2;
            remainder = number1 % number2;

            Console.WriteLine($"The sum of {number1} and {number2} is {sum}.");
            Console.WriteLine($"The difference between {number1} and {number2} is {difference}.");
            Console.WriteLine($"The product of the multiplication between {number1} and {number2} is {product}.");
            Console.WriteLine($"The quotient of the division between {number1} by {number2} is {quotient}.");
            Console.WriteLine($"The remainder of the division between {number1} by {number2} is {remainder}.");
        }
    }
}
