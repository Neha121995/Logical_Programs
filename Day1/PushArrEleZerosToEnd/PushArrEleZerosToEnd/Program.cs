using System;

namespace PushArrEleZerosToEnd
{
    class Program
    {
        static void pushZerosToEnd(int[] arr, int n)
        {
            int count = 0;

            for (int i = 0; i < n; i++)
                if (arr[i] != 0)

                    arr[count++] = arr[i];

            while (count < n)
                arr[count++] = 0;
        }
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Enter the size of array = ");
            n = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[n];

            Console.WriteLine("Enter the elements of an array");
            for (int i = 0; i < n; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            pushZerosToEnd(arr, n);
            Console.WriteLine("Array after pushing all zeros to the back: ");
            for (int i = 0; i < n; i++)
                Console.Write(arr[i] + " ");
        }
    }
}
