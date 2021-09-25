using System;

namespace Distance
{
    class Program
    {
        public void FindDistance()
        {


            Console.WriteLine("Finding distance between two points\n");
            int x, y;

            Console.WriteLine("Enter value of x = ");
            x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter value of y = ");
            y = Convert.ToInt32(Console.ReadLine());


            double distance = Math.Sqrt(Math.Pow(x, x) + Math.Pow(y, y));

            Console.WriteLine("Distace from (0,0) is  " + (x, y) + "is  " + distance);

        }
    }
}
