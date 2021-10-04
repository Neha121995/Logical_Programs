using System;

namespace repeatedNumber
{
    class Program
    {
        public void FindRepeatedNumber()
        {
            Console.WriteLine("Enter array size : ");
            int len = Convert.ToInt32(Console.ReadLine());

            int[] numbers = new int[len];

            Console.WriteLine("Enter Numbers : ");
            for (int i = 0; i < len; i++)
            {
                numbers[i] = Convert.ToInt32(Console.ReadLine());

            }

            Console.WriteLine("Repeated elements are : ");
            for (int i = 0; i < len; i++)
            {
                for (int j = i + 1; j < len; j++)
                {
                    if (numbers[i] == numbers[j])
                    {
                        Console.WriteLine(numbers[j]);
                        break;
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            Program repeatedNum = new Program();
            repeatedNum.FindRepeatedNumber();
        }
    }
}
