using System;

namespace division
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1;
            int number2;
            int result;

            Console.Write("Enter your first number: ");
            number1 = Int32.Parse(Console.ReadLine());

            Console.Write("Please Enter your Second number: ");
            number2 = Int32.Parse(Console.ReadLine());

            result = number1 / number2;
            Console.WriteLine("Your result is "+ result);
        }
    }
}
