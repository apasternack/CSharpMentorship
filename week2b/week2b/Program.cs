using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week2b
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please enter a four digit year");

            int number = int.Parse(Console.ReadLine());

            if (number % 4 == 0  && )
            {
                Console.WriteLine("C#");
            }

            if (number % 5 == 0)
            {
                Console.WriteLine(".NET");
            }

            if (number % 3 == 0 && number % 5 == 0)
            {
                Console.WriteLine("C#.NET");
            }

            Console.ReadLine();


        }
    }
}
