using System;

namespace ConsoleAppFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Good Morning");
            Console.WriteLine("How Are You?");
            Console.WriteLine("-------------------------------------------------------");
            var text = Convert.ToString(Console.ReadLine());
            // Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine("Good! Lets Take One Exercise!");
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine("Enter First Number");
            Console.WriteLine("-------------------------------------------------------");
            var num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second Number");
            Console.WriteLine("-------------------------------------------------------");
            var num2 = Convert.ToInt32(Console.ReadLine());
            int sum = num1 + num2;
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine("Addition is: {0}", sum);
            Console.WriteLine("-------------------------------------------------------");
        }
    }
}