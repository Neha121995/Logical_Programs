using System;

namespace PrimeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int cnt = 0;
            Console.WriteLine("Enter a First number :");
            int f_range = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter a Second number : ");
            int s_range = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Prime numbers between {0} and {1} are : ",f_range,s_range);

            for (int i = 1; i < s_range; i++)
            {
                for (int j = 1; j < s_range; j++)
                {
                    if (i%j == 0)
                    {
                        cnt++;
                    }
                }
                if (cnt == 2)
                {
                    Console.WriteLine(i);
                }
                cnt = 0;
            }
        }
    }
}
