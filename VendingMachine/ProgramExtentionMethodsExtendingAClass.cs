// using System;
// using ExtensionMethods;  



// namespace ConsoleApplication
// {
//     public class Program
//     {
//         public static void Main(string[] args)
//         {

//             string s = "Hello Extension Methods";
//             int i = s.WordCount();


//             System.Console.Write(i);

//         }
//     }
// }

// namespace ExtensionMethods
// {
//     public static class MyExtensions
//     {
//         public static int WordCount(this String str)
//         {
//             return str.Split(new char[] { ' ', '.', '?' },
//                              StringSplitOptions.RemoveEmptyEntries).Length;
//         }
//     }
// }
