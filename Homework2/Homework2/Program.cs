using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2
{
    class Program
    {
        static void Main(string[] args)
        {

            //Application Variables
            bool anotherCalculation = true;
            string anotherCalculationUserResponse;
            double yearsTravlerTravels;
            bool validtime = false;
            double velocityInFractionOfSpeedOfLight;
            bool validVelocity = false;
            double timeDialation = -1;
            const double SPEED_OF_LIGHT = 299792458;

            Console.WriteLine("Welcome to dialations in time!\n"
                   + "The program where you can determine how many years you have aged\n"
                   + "while your brother has been away speeding around the universe\n");

            while (anotherCalculation)
            {
                //Collecting user data
                Console.WriteLine("Please enter the time your brother is traveling in years");
                yearsTravlerTravels = double.Parse(Console.ReadLine());

                if (yearsTravlerTravels <= 0)
                {
                    while (!validtime)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("That isn't an amount of time silly!  Enter a number of years greater than 0");
                        Console.ForegroundColor = ConsoleColor.White;
                        yearsTravlerTravels = double.Parse(Console.ReadLine());

                        validtime = yearsTravlerTravels <= 0 ? false : true;
                    }
                }


                Console.WriteLine("Please enter the velocity he is traveling at as a fraction of the speed of light.\n"
                                    + "For example, if he is traveling at a speed that is 65% the speed of light, enter .65");
                velocityInFractionOfSpeedOfLight = double.Parse(Console.ReadLine());

                if (velocityInFractionOfSpeedOfLight <= 0 || velocityInFractionOfSpeedOfLight >= 1)
                {
                    while (!validVelocity)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Invalid velocity.  Please enter a double larger than 0 and less than 1");
                        Console.ForegroundColor = ConsoleColor.White;
                        velocityInFractionOfSpeedOfLight = double.Parse(Console.ReadLine());

                        validVelocity = (velocityInFractionOfSpeedOfLight <= 0 || velocityInFractionOfSpeedOfLight >= 1) ? false : true;
                    }
                }


                //  Business/Science logic

                timeDialation = yearsTravlerTravels / Math.Sqrt(1 - (((velocityInFractionOfSpeedOfLight * SPEED_OF_LIGHT) * (velocityInFractionOfSpeedOfLight * SPEED_OF_LIGHT))
                                                                        / (SPEED_OF_LIGHT * SPEED_OF_LIGHT)));

                Console.WriteLine("\n     t = Stationary Observer Time in Years:\n");
                Console.WriteLine("{0, 19}\n", yearsTravlerTravels);
                Console.WriteLine("     c = Speed of Light:\n");
                Console.WriteLine("{0, 28:#,#} m/s ({1:#,#.##} km/s)\n", SPEED_OF_LIGHT, SPEED_OF_LIGHT / 1000);
                Console.WriteLine("     v = Ship Velocity ({0:#0.00%} of c):\n", velocityInFractionOfSpeedOfLight);
                Console.WriteLine("{0, 25:0.###E+0} m/s\n", SPEED_OF_LIGHT * velocityInFractionOfSpeedOfLight);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("     t' = Time Dialation: {0:.###} years\n", timeDialation);
                Console.ForegroundColor = ConsoleColor.White;
           
                Console.WriteLine("Would you like to run another calculation? Y/N");
                anotherCalculationUserResponse = Console.ReadLine();
                if (anotherCalculationUserResponse.ToLower().Equals("n")) anotherCalculation = false;
               
            }

            Console.ReadLine();

        }
    }
}
