using System;

namespace DoubleOpt
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a : ");
            double a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter b : ");
            double b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter c : ");
            double c = Convert.ToInt32(Console.ReadLine());
            double result = a + b * c;
            Console.WriteLine(" a + b * c = {0}", result);
            double result1 = a * b + c;
            Console.WriteLine(" a * b + c = {0}", result1);
            double result2 = c + a / b;
            Console.WriteLine(" c + a / b = {0}", result2);
            double result3 = a % b + c;
            Console.WriteLine(" a % b + c = {0}", result3);
        }
    }
}
