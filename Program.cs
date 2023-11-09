using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Part2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Write a program for first 10 natural numbers.
            int i = 10;
            Console.WriteLine("First 10 natural numbers");
            for ( i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }

            //Write a program for first 10 even natual numbers in While loop.
            int num = 1;
            Console.WriteLine("Start of while loop");
            Console.WriteLine("First 10 even natural numbers");
            while (num<=20)
            {
                if (num % 2 == 0)
                {
                    Console.WriteLine(num);
                    
                }
                num++;

            }

            // Write a program for forst 10 odd natural numbera using Do while loop.
            int n = 1;
            Console.WriteLine("First 10 odd natural numbers");
            do
            {
                if (n % 2 != 0)
                {
                    Console.WriteLine(n);
                }
                n++;
            }
            while (n <= 20);
            Console.WriteLine("End of do while loop");
            Console.ReadKey();
        }
    }
}
