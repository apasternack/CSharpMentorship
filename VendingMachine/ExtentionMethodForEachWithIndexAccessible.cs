// using ExtensionMethods;




// namespace ConsoleApplication
// {
//     public class Program
//     {
//         public static void Main(string[] args)
//         {

//             string[] products = {"Snickers Bar", "Puppy", "Cat", "Vegan Pizza", "Kevin Mack Sticker", "Vince Fabro Bobblehead", "SharePoint Rules Decal", "C# Coffee Mug", "Xbox One", "PS4"};
//             products.Each((str, n) =>
//             {
//                 System.Console.Write("{0} at index {1}\n", str, n);

//             });

//         }
//     }
// }

// namespace ExtensionMethods
// {
//     using System;
//     using System.Collections.Generic;

//     public static class MyExtensions
//     {
//         public static int WordCount(this String str)
//         {
//             return str.Split(new char[] { ' ', '.', '?' },
//                              StringSplitOptions.RemoveEmptyEntries).Length;
//         }

//         public static void Each<T>(this IEnumerable<T> ie, Action<T, int> action)
//         {
//             var i = 0;
//             foreach (var e in ie) action(e, i++);
//         }
//     }
// }
