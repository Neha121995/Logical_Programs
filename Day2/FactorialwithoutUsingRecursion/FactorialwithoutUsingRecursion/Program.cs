using System;

namespace FactorialwithoutUsingRecursion
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, fact = 1;
            Console.WriteLine("Enter a number :");
            num = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= num; i++)
            {
                fact = fact * i;
            }

            Console.WriteLine("Factorial of " + num + " is :" + fact);
            Console.ReadLine();
        }
    }
}


/* 
 * take a num = 4 fact= 1
 1st iteration =  i=1; 1<=4;   //true
                    fact = 1*1 = 1 fact=1

2nd iteration = i=2; 2<=4;  //true
                    fact = 1*2 = 2

3rd iteration = i=3; 3<=4;  //true
                    fact = 2*3 = 6

4rd iteration = i=4; 4<=4;  //true
                    fact = 6*4 = 24
 
 */