using System;

namespace Homework2Params
{
    class Program
    {

        const double SPEED_OF_LIGHT = 299792458;

        static void Main(string[] args)
        {
            //Application Variables
            bool anotherCalculation = true;
            string anotherCalculationUserResponse;
            string[] userInputStringArray;
            double[] yearsTravlerTravels;
            bool validtime = true;
            double[] velocityInFractionOfSpeedOfLight;
            bool validVelocity = true;
            double[] timeDialation = null;
            string value;

            Console.WriteLine("Welcome to dialations in time!\n"
                   + "The program where you can determine how many years you have aged\n"
                   + "while your brother has been away speeding around the universe\n");

            while (anotherCalculation)
            {
                //Collecting user data
                Console.WriteLine("Please enter the time your brother is traveling in years.  You can enter multiple values each delimited with a comma");

                value = Console.ReadLine();
                userInputStringArray = value.Split(',');
                yearsTravlerTravels = Array.ConvertAll(userInputStringArray, double.Parse);


                validtime = isTimeValid(yearsTravlerTravels);
                while (!validtime)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("At least one of your entries isn't a real amount of time!  All years you enter must be greater than 0");
                    Console.ForegroundColor = ConsoleColor.White;
                    value = Console.ReadLine();
                    userInputStringArray = value.Split(',');
                    yearsTravlerTravels = Array.ConvertAll(userInputStringArray, double.Parse);
                    validtime = isTimeValid(yearsTravlerTravels);
                }
                
                Console.WriteLine("Please enter the velocity he is traveling at as a fraction of the speed of light.\n"
                    + "For example, if he is traveling at a speed that is 65% the speed of light, enter .65\n"
                    + "You must enter the same number of values you entered for years, each delimited with a comma." );

                value = Console.ReadLine();
                userInputStringArray = value.Split(',');
                velocityInFractionOfSpeedOfLight = Array.ConvertAll(userInputStringArray, double.Parse);

                validVelocity = isVelocityValid(velocityInFractionOfSpeedOfLight, velocityInFractionOfSpeedOfLight.Length, yearsTravlerTravels.Length);
                while (!validVelocity)
                {
                    value = Console.ReadLine();
                    userInputStringArray = value.Split(',');
                    velocityInFractionOfSpeedOfLight = Array.ConvertAll(userInputStringArray, double.Parse);
                    validVelocity = isVelocityValid(velocityInFractionOfSpeedOfLight, velocityInFractionOfSpeedOfLight.Length, yearsTravlerTravels.Length);
                }

                timeDialation = new double[velocityInFractionOfSpeedOfLight.Length];
                for (int i = 0; i < velocityInFractionOfSpeedOfLight.Length; i++)
                {
                    timeDialation[i] = yearsTravlerTravels[i] / Math.Sqrt(1 - (((velocityInFractionOfSpeedOfLight[i] * SPEED_OF_LIGHT) * (velocityInFractionOfSpeedOfLight[i] * SPEED_OF_LIGHT))
                                                                              / (SPEED_OF_LIGHT * SPEED_OF_LIGHT)));
                }

                for (int i = 0; i < velocityInFractionOfSpeedOfLight.Length; i++)
                {
                    Console.WriteLine("\n     t = Stationary Observer Time in Years:\n");
                    Console.WriteLine("{0, 19}\n", yearsTravlerTravels[i]);
                    Console.WriteLine("     c = Speed of Light:\n");
                    Console.WriteLine("{0, 28:#,#} m/s ({1:#,#.##} km/s)\n", SPEED_OF_LIGHT, SPEED_OF_LIGHT / 1000);
                    Console.WriteLine("     v = Ship Velocity ({0:#0.00%} of c):\n", velocityInFractionOfSpeedOfLight[i]);
                    Console.WriteLine("{0, 25:0.###E+0} m/s\n", SPEED_OF_LIGHT * velocityInFractionOfSpeedOfLight[i]);
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("     t' = Time Dialation: {0:.###} years\n", timeDialation[i]);
                    Console.ForegroundColor = ConsoleColor.White;

                    Console.WriteLine("\n\n\nFor next Calculation, press ENTER");
                    Console.ReadLine();
                }

                Console.WriteLine("Would you like to run another calculation? Y/N");
                anotherCalculationUserResponse = Console.ReadLine();
                if (anotherCalculationUserResponse.ToLower().Equals("n")) anotherCalculation = false;
            }
        }

        public static bool isTimeValid(double[] yearsTravlerTravels)
        {
            foreach (double year in yearsTravlerTravels)
            {
                if (year <= 0)
                {
                    return false;
                }
            }
            return true;
        }

        public static bool isVelocityValid(double[] velocities, int velocityEntries, int timeEntries)
        {
            if (velocityEntries != timeEntries)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("You must enter the same number of values of velocities as you entered for times for traveling\n"
                                    + "Please enter {0} velocities delimited with a comma", timeEntries);
                Console.ForegroundColor = ConsoleColor.White;
                return false;
            }
            foreach (double velocity in velocities)
            {
                if (velocity <= 0 || velocity >= 1)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("At least one of your entries is not between 0 and 1!  All entries must be greater than 0 and less than 1.");
                    Console.ForegroundColor = ConsoleColor.White;
                    return false;
                }
            }
            return true;
        }

    }
}
