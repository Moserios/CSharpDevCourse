using System;


namespace DelegateClass
{
    public class Sample
    {
        public int Add(int a, int b)
        {
            int c = a + b;
            return c;
        }

        //target method 1
        public void PrintSum(double a, double b)
        {
            double c = a + b;
            Console.WriteLine($"Addition result: {a} + {b} = {c}");
        }

        //target method 2
        public void PrintMultiply(double a, double b)
        {
            double c = a * b;
            Console.WriteLine($"Multiplication result: {a} * {b} = {c}");
        }
    }
}
