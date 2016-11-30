using System;
using ExtensionMethods;  



namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {

            string s = "Hello Extension Methods";
            int i = s.WordCount();


            System.Console.Write(i);





            // string[] products = {"Snickers Bar", "Puppy", "Cat", "Vegan Pizza", "Kevin Mack Sticker", "Vince Fabro Bobblehead", "SharePoint Rules Decal", "C# Coffee Mug", "Xbox One", "PS4"};

            // foreach (string product in products)
            // {
            //     System.Console.Write("");
            // }

            // Console.WriteLine(products[10]);
        }
    }
}

namespace ExtensionMethods
{
    public static class MyExtensions
    {
        public static int WordCount(this String str)
        {
            return str.Split(new char[] { ' ', '.', '?' },
                             StringSplitOptions.RemoveEmptyEntries).Length;
        }
    }
}
