using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;

namespace ReflectionTest
{
    class Program
    {
        static void Main(string[] args)
        {
            public delegate double MyFunction(double x);

            public double Diff(double x, MyFunction f)
            {
                double h = 0.0000001;

                return (f(x + h) - f(x)) / h;
            }

            public double MyFunctionMethod(double x)
            {
                // Can add more complicated logic here
                return x + 10;
            }

            public void Client()
            {
                double result = Diff(1.234, x => x * 456.1234);
                double secondResult = Diff(2.345, MyFunctionMethod);
            }
        }
    }
}