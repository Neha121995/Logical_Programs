using System;

namespace IntOpt
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a : ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter b : ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter c : ");
            int c = Convert.ToInt32(Console.ReadLine());
            int result = a + b * c;
            Console.WriteLine(" a + b * c = {0}",result);
            int result1 = a * b + c;
            Console.WriteLine(" a * b + c = {0}", result1);
            int result2 = c + a / b;
            Console.WriteLine(" c + a / b = {0}", result2);
            int result3 = a % b + c;
            Console.WriteLine(" a % b + c = {0}", result3);
        }
    }
}
