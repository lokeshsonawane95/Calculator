// See https://aka.ms/new-console-template for more information
using System;
namespace Calculator
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Calculate cal = new Calculate();
            Console.WriteLine("Enter 1st number : ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 2nd number : ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Addition {0} + {1} = {2}", num1, num2, cal.addition(num1, num2));
        }
    }
}