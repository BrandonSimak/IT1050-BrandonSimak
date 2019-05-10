using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }

    public class Book
    {
        public string Title, Author, Year;
        public void Display()
        {
            Console.WriteLine("{0}, {1}", Title, Author);
        }
    }

    public class BookTest
    {
        Book book = new Book()
        {
            Title = h,
            Author = h,
            Year = h,
        };
    }
}

/*
 3.	the instance is called an object

4.	constructor overloading

5.	because exceptions can prevent your code from running

6.	private/public will tell the program whether or not the code in the method can be accessed by anyone

7.	composition is the information the program stores about the object

8.	abstraction is when a programm ignores any irrelevant or unused data pieces


     */
