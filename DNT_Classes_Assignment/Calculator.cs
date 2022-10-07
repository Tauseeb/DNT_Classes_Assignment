using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNT_Classes_Assignment
{   
    internal class Calculator
    {
        int num1, num2, result;

        public void UserInput()
        {
            Console.Write("Please Enter First Number: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please Enter Second Number: ");
            num2=Convert .ToInt32(Console.ReadLine());
            Console.WriteLine("\n");
            
        }
        public void Addition()
        {
            UserInput();
            result = num1 + num2;
            Console.Write("The Addition Value is: " + result);
            Console.WriteLine("\n");
            
        }

        public void Subtract()
        {
            UserInput();
            result = num1 - num2;
            Console.Write("The Subtract Value is: " + result);
            Console.WriteLine("\n");
        }

        public void Multiply()
        {
            UserInput();
            result=num1 * num2;
            Console.Write("The Multiplication Value is: " + result);
            Console.WriteLine("\n");
        }

        public void Divide()
        {
            UserInput();
            result=num1 / num2;
            Console.Write("The Division Value is: " + result);
            Console.WriteLine("\n");
        }
        public static void Main()
        {
            Calculator cal = new Calculator();
            cal.Addition();
            cal.Subtract();
            cal.Multiply();
            cal.Divide();

            Console.ReadLine();
        }
    }
}
