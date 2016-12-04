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
//             Type testType = typeof(TestClass);
//             // ConstructorInfo ctor = testType.GetConstructor(System.Type.EmptyTypes);
//             ConstructorInfo ctor = testType.GetConstructor(new[] { typeof(int)});
//             if (ctor != null)
//             {
//                 object instance = ctor.Invoke(new object[] {420});
//                 // object instance = ctor.Invoke(null);
//                 MethodInfo methodInfo = testType.GetMethod("TestMethod");
//                 Console.WriteLine(methodInfo.Invoke(instance, new object[] { 10, 20 }));
//             }
//             Console.ReadKey();
//         }
//     }

//     public class TestClass
//     {
//         private int testValue = 42;

//         public TestClass()
//         {

//         }
//         public TestClass(int x)
//         {
//             testValue = x;
//         }

//         public int TestMethod(int numberToAdd, int numberToMultiply)
//         {
//             return this.testValue + numberToAdd * numberToMultiply;
//         }



//     }
// }