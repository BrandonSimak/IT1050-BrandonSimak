using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidTerm
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             while statements are a control structure that will repeat until a certain condition is no longer true
             do while statements are the same except it will always execute at least once
             for statements repeat based on parameters set in the header
             */
            bool keeplooping = false;
            while (keeplooping == true) 
            {
                Console.WriteLine("h");
            }
            int x = 2;
            int ctrl = 2; 
            while (ctrl <= 64)
            {
                Console.WriteLine("[{0}] ctrl = {1}", x, ctrl);
                x = x + 2;
                ctrl = ctrl + 1; 
            }

            for (x = 49; x > 0; x--)
            {
                if (x > 1)
                {
                    Console.Write("{0},", x);
                }
                else
                {
                    Console.Write("{0}", x);
                }
            }

            Console.WriteLine();

            x = 1;
            while (x < 22)
            {
                Console.Write("{0} ", x);
                x = x + 2;
            }

            /*
             The output of the example code would be a single * symbol, if the code was a while loop instead of a do while loop there would be no output

            we can combine multiple booleans together using comparitive functions such as &&
             */

            bool icyrain = false;
            bool tornadowarning = false;
            if (icyrain == false && tornadowarning == false)
            {
                Console.WriteLine("lets go outside");
            }

            int i = 0;
            while (i < 6)
            {
                if (i == 0)
                {
                    Console.WriteLine("123454321");
                    i++;
                }
                else if (i == 1)
                {
                    Console.WriteLine(" 1234321 ");
                    i++;
                }
                else if (i == 2)
                {
                    Console.WriteLine("  12321 ");
                    i++;
                }
                else if (i == 3)
                {
                    Console.WriteLine("   121 ");
                    i++;
                }
                else if (i == 4)
                {
                    Console.WriteLine("    1 ");
                    i++;
                }
            }

            Console.ReadKey();
        }
    }
}
