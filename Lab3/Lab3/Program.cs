using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            int speedlimit = 35;
            int speed = 42;
            if (speed > speedlimit)
            {
                Console.WriteLine("SLOW NOW");
            }

            Boolean isTrue = true;
            if (isTrue == true)
            {
                Console.WriteLine("It's true");
            }
            else
            {
                Console.WriteLine("It's false");
            }

            int fahrenheit;
            int celsius;

            Console.Write("Please enter a fahrenheit temperature:");
            fahrenheit = Convert.ToInt32(Console.ReadLine());
            celsius = (fahrenheit - 32) * 5 / 9;

            Console.WriteLine("Temperature is {0} degrees celsius", celsius);
            if (fahrenheit > 90)
            {
                Console.WriteLine("It is hot");
            }
            if (fahrenheit < 40)
            {
                Console.WriteLine("It is cold");
            }

            int x;
            x = 0;
            while (x < 10)
            {
                x++;
                Console.Write("{0}, ", x);
            }
            Console.Write("\n");

            x = 65;
            while (x > 20)
            {
                x = x - 5;
                Console.Write("{0}, ", x);
            }
            Console.Write("\n");

            x = 8;
            while (x < 20)
            {
                x = x + 2;
                Console.Write("{0}, ", x);
            }
            Console.ReadKey();
        }
    }
}