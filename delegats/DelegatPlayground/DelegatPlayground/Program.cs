//using System;
//using System.Collections.Generic;
//using System.IO;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace DelegateAppl
//{
//    class PrintString
//    {
//        static FileStream fs;
//        static StreamWriter sw;

//        // delegate declaration
//        public delegate void printString(string s);

//        // this method prints to the console
//        public static void WriteToScreen(string str)
//        {
//            Console.WriteLine("The String is: {0}", str);
//        }

//        //this method prints to a file
//        public static void WriteToFile(string s)
//        {
//            fs = new FileStream("./message.txt",
//            FileMode.Append, FileAccess.Write);
//            sw = new StreamWriter(fs);
//            sw.WriteLine(s);
//            sw.Flush();
//            sw.Close();
//            fs.Close();
//        }

//        // this method takes the delegate as parameter and uses it to
//        // call the methods as required
//        public static void sendString(printString ps)
//        {
//            ps("Hello World Look at me using delegates like a ninja");
//        }

//        public delegate double MyFunction(double x);

//        public static double Diff(double x, MyFunction f)
//        {
//            double h = 0.0000001;

//            return (f(x + h) - f(x)) / h;
//        }

//        public static double MyFunctionMethod(double x)
//        {
//            // Can add more complicated logic here
//            return x + 10;
//        }

//        public static void Client()
//        {
//            double result = Diff(1.234, x => x * 456.1234);
//            Console.WriteLine("Result 1 is: {0}", result);
//            double secondResult = Diff(2.345, MyFunctionMethod);
//            Console.WriteLine("Result 2 is: {0}", secondResult);

//        }




//        static void Main(string[] args)
//        {
//            printString ps1 = new printString(WriteToScreen);
//            printString ps2 = new printString(WriteToFile);
//            //sendString(ps1);
//            //sendString(ps2);
//            //Console.ReadKey();
//            Client();
//            Console.ReadKey();

//        }
//    }
//}
