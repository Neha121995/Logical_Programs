using System;

namespace PrintKDWInStar
{
    class Program
    {
        public static void printKDW()
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 28; j++)
                {
                    if (j == 1 || (i == 3 && j == 2) || (i == 2 && j == 3) || (i == 1 && j == 4) || (i == 4 && j == 3) || (i == 5 && j == 4)
                        || j == 12 || j == 18 || (i == 3 && j >= 15 && j <= 15) || (i == 4 && j >= 14 && j <= 14) || (i == 4 && j >= 16 && j <= 16) ||
                        j == 23 || (j == 28 && i >= 2 && i <= 4) || (i == 1 && j >= 23 && j <= 26) || (i == 5 && j >= 23 && j <= 26))
                        Console.Write("*");
                    else

                        Console.Write(" ");

                }
                Console.WriteLine(" ");
            }
        }
        static void Main(string[] args)
        {
            printKDW();
        }
    }
}

