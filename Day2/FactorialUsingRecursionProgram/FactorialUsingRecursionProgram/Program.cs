using System;

namespace FactorialUsingRecursionProgram
{
    class Program
    {
        static int factorial(int n)
        {
            if (n <= 1)
                return 1;
            return n * factorial(n - 1);
        }
        static void Main(string[] args)
        {
            int num, result;
            Console.WriteLine("Enter a non negative number :");
            num = Convert.ToInt32(Console.ReadLine());
            result = factorial(num);
            Console.WriteLine("{0}! = {1}",num,result);

        }
    }
}


/*****
 we take n=4
first iteration : if (4<=1) // false
                    return 4*fact(4-1) = 4*fact(3) = 4*(3*2*1) = 4 *6 =  24
                    n=3

second iteration : if (3<=1) //false
                    return 3*fact(3-1) = 3*fact(2) = 3*(2*1) = 3*2 = 6
                    n=2

Third iteration : if (2<=1) //false
                    return 2*fact(2-1) = 2*fact(1) = 2*(1*1) = 2*1 = 2
                    n=1

forth iteration : if (1<=1) //true
                    return 1    = 1
 */
