using ExtensionMethods;
using System;
// using System.Media;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {

            int userSelection;
            string userSelectionString;

            string[] products = { "Snickers Bar", "Puppy", "Cat", "Vegan Pizza", "Kevin Mack Sticker", "Vince Fabro Bobblehead", "SharePoint Rules Decal", "C# Coffee Mug", "Xbox One", "PS4" };

            Console.Write("\nWelcome to THE VENDING MACHINE OF VENDING MACHINES\n\n");


            products.Each((str, n) =>
            {
                System.Console.Write("{1} - {0}\n", str, n);
            });

            Console.Write("\nPlease enter number of product you would like to purchase\n\n");

            userSelectionString = Console.ReadLine();

            try
            {
                userSelection = Int32.Parse(userSelectionString);
            }
            catch (FormatException e)
            {
                Console.Write("\nInvaild selection!!\n{0}\n\n", e.Message);
                return;
            }

            try
            {
                Console.Write("Dispensing {0}", products[userSelection]);
            }
            catch (IndexOutOfRangeException e)
            {
                Console.Write("\nInvaild selection, Security has been called!!\n{0}\n\n", e.Message);
                // var alarmPlayer = new SoundPlayer(Environment.CurrentDirectory + @”\alarm.wav”);
                // alarmPlayer.Play();
                return;

            }



        }
    }
}

namespace ExtensionMethods
{
    using System;
    using System.Collections.Generic;

    public static class MyExtensions
    {
        public static int WordCount(this String str)
        {
            return str.Split(new char[] { ' ', '.', '?' },
                             StringSplitOptions.RemoveEmptyEntries).Length;
        }

        public static void Each<T>(this IEnumerable<T> ie, Action<T, int> action)
        {
            var i = 0;
            foreach (var e in ie) action(e, i++);
        }
    }
}