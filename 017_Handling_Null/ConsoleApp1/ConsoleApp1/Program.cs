using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Person
    {
        public int? NoOfChildren;
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person() { NoOfChildren = 2};
            Person p2 = new Person() { NoOfChildren = null};
            Person p3 = new Person();
  
            int x = p1.NoOfChildren.Value;

            if (p1.NoOfChildren.HasValue)
            {
                int y = p1.NoOfChildren.Value;
                Console.WriteLine(p1.NoOfChildren.HasValue?p1.NoOfChildren:0);
            }

            if (p2.NoOfChildren != null)
            {
                Console.WriteLine(p2.NoOfChildren.Value);
            }

            //non-coalescing operator instead of IF
            Console.WriteLine(p2.NoOfChildren.HasValue ? p2.NoOfChildren : 99);
            //shorter version
            Console.WriteLine(p2.NoOfChildren??99);

            //non-propagation operator
            p3.NoOfChildren = null;
            Console.WriteLine(p3?.NoOfChildren);

            p3.NoOfChildren = 3;
            Console.WriteLine(p3?.NoOfChildren);

            Console.ReadKey();

        }
    }
}
