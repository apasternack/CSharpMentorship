// using System;
// using System.Collections.Generic;
// using System.Text;
// using System.Reflection;

// namespace ReflectionTest
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             // Assembly assembly = Assembly.GetExecutingAssembly();
//             Assembly assembly = typeof(Program).GetTypeInfo().Assembly;

//             Type[] assemblyTypes = assembly.GetTypes();
//             foreach(Type t in assemblyTypes)
//                 Console.WriteLine(t.Name);
//             Console.ReadKey();
//         }
//     }

//     class DummyClass
//     {
//         //Just here to make the output a tad less boring :)
//     }

//         class VerbumTuMaterClass
//     {
//         //Just here to make the output a tad less boring and refine those latin skills and cred your mom:)
//     }
// }