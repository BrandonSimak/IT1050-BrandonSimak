using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             4 basic elements of the counter controlled repetition 
             1. the control variable declares the variable that will be used for calculating loops completed
             2. the initial value is what the control variable is set to equal
             3. the increment tells how the control variable will be changed each loop
             4. the loop continuation condition tells the loop when to stop looping

            the for loop uses a comparison to tell how many times it will execute a given piece of code
            the while loop on the other hand will continue repeating until a given statement is no longer true

            a do-while loop is usefull in situations where you want your code to run atleast once. while loops can run 0 times, do-while loops always run atleast once.
             */
            for (int i = 0; i < 100; i++)
            {
                if ((i % 2) == 0)
                {
                    Console.WriteLine("Even");
                }
                else
                {
                    Console.WriteLine("Odd");
                }
            }
            string temp;
            int num;
            Console.Write("Please input a temp: ");
            temp = Console.ReadLine();
            num = Convert.ToInt32(temp);
            if (num < 10)
            {
                Console.WriteLine("polar bear");
            }
            else
            {
                if (num < 20)
                {
                    Console.WriteLine("penguin");
                }
                else
                {
                    if (num < 40)
                    {
                        Console.WriteLine("moose");
                    }
                    else
                    {
                        if (num < 50)
                        {
                            Console.WriteLine("reindeer");
                        }
                        else
                        {
                            if (num < 60)
                            {
                                Console.WriteLine("deer");
                            }
                            else
                            {
                                if (num < 70)
                                {
                                    Console.WriteLine("turtle");
                                }
                                else
                                {
                                    if (num < 80)
                                    {
                                        Console.WriteLine("lion");
                                    }
                                    else
                                    {
                                        if (num < 90)
                                        {
                                            Console.WriteLine("fish");
                                        }
                                        else
                                        {
                                            Console.WriteLine("bug");
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }

            int x = 9;  ///code caused infinite loop due to no incrimentation happening
            while (x < 20)
            {
                x++;
                Console.WriteLine(x);
            }

            for (int i = 0; i < 101; i++) ///code was missing brackets
            {
                Console.WriteLine(i);
                Console.WriteLine("********");
            }

            Console.ReadKey();
        }
    }
}
