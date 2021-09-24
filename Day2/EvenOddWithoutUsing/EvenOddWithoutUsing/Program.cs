using System;

namespace EvenOddWithoutUsing
{
    class Program
    {
        static int isEven(int num) // 10
        {
            return (num & 1); // 0
        }
        public static void Main(String[] args)
        {
            Console.WriteLine("Enter a number ::");
            int num = int.Parse(Console.ReadLine());
            if (isEven(num) == 0) // 0 == 0
                Console.Write("Number is Even");
            else
                Console.Write("Number is Odd");
        }
    }
}
