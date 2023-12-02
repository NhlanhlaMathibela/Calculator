using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOne,numberTwo,result;
            string answer;

            Console.WriteLine("Hello, I can calculate anything for you");
            Console.WriteLine("Enter number one: ");
            numberOne=Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Enter number two: ");
            numberTwo=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Choose your operation: ");
            Console.WriteLine("Enter a for Addition, s for Subtraction, m for multiplication or d for division");

            answer = Console.ReadLine();

            if (answer== "a")
            {
                result = numberOne + numberTwo;
            }
            else if (answer== "s")
            {
                result = numberTwo - numberOne;
            }
            else if(answer== "m") 
            {
                result = numberOne *  numberTwo;
            }
            else
            {
                result = numberOne / numberTwo;
            }
            Console.WriteLine("Answer = "+ result);
            Console.WriteLine("Thank you for using the calculator");
            Console.ReadKey();

        }
    }
}
