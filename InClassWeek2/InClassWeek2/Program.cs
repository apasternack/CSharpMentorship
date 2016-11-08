using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InClassWeek2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a whole number");

            int number = int.Parse(Console.ReadLine());

            if (number % 3 == 0 && number % 5 == 0)
            {
                Console.WriteLine("C#.NET");
            }
            else
            {
                if (number % 3 == 0)
                {
                    Console.WriteLine("C#");
                }

                if (number % 5 == 0)
                {
                    Console.WriteLine(".NET");
                }
            }



            Console.ReadLine();

        }
    }
}
