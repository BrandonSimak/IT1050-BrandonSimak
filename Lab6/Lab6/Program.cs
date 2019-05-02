using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 
             A one-dimensional array p contains four elements. 
             The array access expressions to access each of the elements in p are data type, name, rank and values.
             */
            string[] months = new[] {"january", "february", "march", "april", "may", "june", "july", "august", "september", "october", "november", "december"};
            int h = 0;
            foreach (string m in months)
            {
                h++;
                Console.WriteLine("month[{0}]= {1}", h, m);
            }

            string[] seasons = new[] { "summer", "fall", "winter", "spring"};
            foreach (string m in seasons)
            {
                Console.WriteLine(m);
            }

            int[] ran = new int[1000]; 
            Random random = new Random();
            int randomNumber;
            foreach (int r in ran)
            {
                randomNumber = random.Next(0, 100);
                Console.Write("{0} ", randomNumber);
            }

            string[] names = { "Al Dente", "Anna Graham", "Earle Bird", "Ginger Rayle", "Iona Ford" };
            int i = 0;
            while (i < names.Length)
            {
                i++;
                Console.WriteLine(names[i-1]);
            }

            int[] ran1 = new int[3];
            Random random1 = new Random();
            int randomNumber1;
            foreach (int r in ran)
            {
                i = random.Next(0, 5);
                randomNumber1 = random.Next(0, 100);
                Console.WriteLine("{0,2}. {1}", i, names[i]);
            }

            string[] names1 = { "Al Dente", "Anna Graham", "Earle Bird", "Ginger Rayle", "Iona Ford" };
            foreach (string t in names1)
            {
                Console.WriteLine(t);
            }

            Console.ReadKey();
        }
    }
}
