using System;

namespace PrintThreeNames
{
    class Program
    {
        static void Main(string[] arguments)
        {

            string[] arr = { "Alice","Bob","Carol" };
            Console.WriteLine("Hi " + arr[2] + "," + arr[1] + ", and " + arr[0]);

            foreach (String arg in Environment.GetCommandLineArgs())
            {
                Console.Write(arg);
            }
            Console.ReadKey();

            //Console.WriteLine("Hello World");
            //Car obj = new Car()
            //{
            //    name = "BMW",
            //    color = "Black",
            //    milege = 46,
            //    engine = "V8",
            //    noOfWheels = 5
            //};
            ////obj.name = "BMW";
            ////obj.run();
            //Console.WriteLine(obj.name );
            //Console.WriteLine(obj.color );
            //Console.WriteLine(obj.milege);
            //Console.WriteLine(obj.engine);
            //Console.WriteLine(obj.noOfWheels);




            //Console.WriteLine("Enter num1");
            //int num1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter num2");
            //int num2 = int.Parse(Console.ReadLine());
            //int sum = num1 + num2;
            //Console.WriteLine("Sum : {0} ", sum);

            //Console.WriteLine("Enter first name");
            //string fname = Console.ReadLine();
            //Console.WriteLine("Enter last name");
            //string lname = Console.ReadLine();
            ////Console.WriteLine("Your first name is : " + fname);
            //Console.WriteLine("Your full name is : {0} {1}", fname, lname);


        }
    }
}
