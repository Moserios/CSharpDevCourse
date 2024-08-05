using System.Diagnostics;
using System;
using DelegateClass;

namespace Delegates
{
    internal class Program
    {
        static void Main()
        {
            //create an obj of a class
            Sample s = new Sample();

            Console.WriteLine(" -- Single-cast delegate -- \n");
            //Single-cast delegate (contains reference of a single method)
            //create an obj of a delegate
            MyIntDelegate myDelegate;

            // add a method reference to a delegate
            myDelegate = new MyIntDelegate(s.Add);

            //invoke method using delegate object
            Console.WriteLine(myDelegate.Invoke(30, 170));

            Console.WriteLine("\n -- Multi-cast delegate -- \n");
            //Multi-cast delegate (contains reference of a few methods)
            MyPrintDelegate myPrintDelegate = s.PrintSum;
            myPrintDelegate += s.PrintMultiply;
            //MyPrintDelegate myPrintDelegate = new MyPrintDelegate(s.PrintSum, s.PrintMultiply);
            myPrintDelegate.Invoke(10, 90);

            Console.ReadKey();
        }
    }
}
