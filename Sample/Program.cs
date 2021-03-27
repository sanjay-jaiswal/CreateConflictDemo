using System;

namespace Sample
{
    class Program
    {
        public static int Sum(int val1, int val2)
        {
            int Result;
            Result = val1 + val2;
            return Result;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("---Creating conflict between local and remote---\n");
            Console.WriteLine("This is conflict demo programmm");

            Console.Write("Enter first integer value: ");
            int v1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second integer value: ");
            int v2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Sum of two numbers is : {0}", Sum(v1, v2));

        }
    }
}
