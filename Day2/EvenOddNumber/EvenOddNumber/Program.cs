using System;

namespace EvenOddNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter any number ::");
            int num = int.Parse(Console.ReadLine()); // 16

            if ((num / 2)*2 == num) //16 / 2 = 8  //8*2 = 16 // 16==16
            {
                Console.WriteLine("Number is Even");
            }else
            {
                Console.WriteLine("Number is Odd");
            }
        }
    }
}
