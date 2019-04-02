using System;

namespace Lab2
{
    public class Addition
    {
        public static void Main( string[] args )
        {
            int number1;
            int number2;
            int product;

            Console.Write("Enter first integer: ");
            number1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter second integer: ");
            number2 = Convert.ToInt32(Console.ReadLine());

            product = number1 * number2;

            Console.WriteLine("Product is {0}", product);

            Console.WriteLine("{0}\n{1}", "Hello World", "From Brandon Simak");
            Console.WriteLine("{0}\t{1}", "Hello World", "From Brandon Simak");
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
            /*
            a) A c# application executes line by line one at a time.
            b) An integer type variable is a whole number while double and floating-point variables are for handling decimals.
            c) An example of a method would be the Main method.
            d) Public, private
            e) Classes are used to define the default of something, objects are built from classes but can be altered. You can only have one instance of a class because changing it would make it a new class.
            */
        }
    }
}
