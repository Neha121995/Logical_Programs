using System;
using System.Linq;

public class Example
{
    public static bool checkEquality<T>(T[] name1, T[] name2)
    {
        return Enumerable.SequenceEqual(name1, name2);
    }

    public static void Main(String[] args)
	{
        int lengthOfArray1;
        Console.WriteLine("Enter the size of array :: ");
        lengthOfArray1 = Convert.ToInt32(Console.ReadLine());

        int[] list = new int[lengthOfArray1];

        Console.WriteLine("Enter the elements of an array");
        for (int i = 0; i < lengthOfArray1; i++)
        {
            list[i] = Convert.ToInt32(Console.ReadLine());
        }

        int lengthOfArray2;
        Console.WriteLine("Enter the size of array :: ");
        lengthOfArray2 = Convert.ToInt32(Console.ReadLine());

        int[] list1 = new int[lengthOfArray2];

        Console.WriteLine("Enter the elements of an array");
        for (int i = 0; i < lengthOfArray2; i++)
        {
            list[i] = Convert.ToInt32(Console.ReadLine());
        }
        //      int[] arr1 = { 1, 2, 3, 4, 5 };
        //int[] arr2 = { 1, 2, 3, 4, 5 , 6, 7 };

  //      string[] name1 = { "Neha", "Karan", "Pranav" };
		//string[] name2 = { "Neha", "Karan", "Pranav", "priya" };


		if (checkEquality(list,list1))
		{
			Console.WriteLine("Both arrays are equal");
		}
		else
		{
			Console.WriteLine("Both arrays are not equal");
		}
	}
}
