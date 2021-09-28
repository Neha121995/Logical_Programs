using System;

namespace PowerOf2
{
    class Program
    {
        public void printPowerOfTwo()
        {
            int Num;
            Console.WriteLine("Enter number till which you want to print power of 2 : ");
            Num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();
            for (int i = 1; i <= Num; i++)
            {
                double Power = Math.Pow(2, i);
                Console.WriteLine(Power);
            }
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            p.printPowerOfTwo();

            Console.ReadLine();
        }

    }
}
