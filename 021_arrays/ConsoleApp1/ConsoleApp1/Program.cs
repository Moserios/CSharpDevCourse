using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] MyIntArray1 = new int[5];
            MyIntArray1[0] = 1;
            int[] MyIntArray2 = new int[] { 1,2,3,4,5,6,7,8,9,10, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            string[] MyStrArray1 = new string[] { "one", "two", "three", "four", "five"};

            //operate indexes
            for (int i = 0; i < MyIntArray1.Length; i++)
            {
                Console.WriteLine(MyIntArray1[i]);
                Console.WriteLine(MyIntArray2[i]);
                Console.WriteLine(MyStrArray1[i]);
                Console.WriteLine();
            }

            //reverce order
            for (int i = MyIntArray1.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(MyIntArray1[i]);
                Console.WriteLine(MyIntArray2[i]);
                Console.WriteLine(MyStrArray1[i]);
                Console.WriteLine();
            }

            //operate values
            foreach (int i in MyIntArray1)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();
            foreach (int i in MyIntArray2)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();
            foreach (string i in MyStrArray1)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();

            //Array Methods
            //IndexOf

            int n = Array.IndexOf(MyIntArray2, 5); //returns index of first occurance of '5'
            Console.WriteLine(n);

            n = Array.IndexOf(MyIntArray2, 5, 6); //returns index of second occurance of '5' cause started search from index 6!
            Console.WriteLine(n);
            Console.WriteLine();

            //BinarySearch
            Console.WriteLine("Binary Search");
            int[] MyIntArray3 = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14,15, 16, 17, 18, 19, 20 };
            int n1 = Array.BinarySearch(MyIntArray3, 5);
            int n2 = Array.BinarySearch(MyIntArray3, 19);
            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine();


            //clear
            int[] MyIntArray4 = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
            Array.Clear(MyIntArray4, 5, 7);
            Console.Write("Clearing the array: ");
            foreach (int i in MyIntArray4)
            {
                Console.Write($" {i}");
            }
            Console.WriteLine();

            //Resize
            Array.Resize(ref MyIntArray4, 15);
            Console.Write("Array resized: ");
            foreach (int i in MyIntArray4)
            {
                Console.Write($" {i}");
            }
            Console.WriteLine();

            //Sort
            int[] MyIntArray5 = new int[] { 1, 12, 3, 14, 5, 16, 7, 18, 9, 20, 11, 2, 13, 4, 15, 6, 17, 8, 19, 2 };
            Console.Write("Array unsorted: ");
            foreach (int i in MyIntArray5)
            {
                Console.Write($" {i}");
            }
            Console.WriteLine();
            Array.Sort(MyIntArray5);
            Console.Write("Array sorted: ");
            foreach (int i in MyIntArray5)
            {
                Console.Write($" {i}");
            }
            Console.WriteLine();

            //Reverse
            Array.Reverse(MyIntArray5);
            Console.Write("Array reversed: ");
            foreach (int i in MyIntArray5)
            {
                Console.Write($" {i}");
            }
            Console.WriteLine();


            //Multi-demetional array
            Console.WriteLine("Two-demetional array: [5,3]");
            int[,] td = new int[5, 3]
                {
                { 10, 20, 30}, 
                { 40, 50, 60},
                { 70, 80, 90},
                { 100, 110, 120},
                { 130, 140, 150}
                };
                        

            Console.Write("Array content: ");
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 3; j++)
                { 
                    Console.Write(td[i,j] + " "); 
                }
            }
            Console.WriteLine();
            Console.Write("Array content: ");
            foreach (int i in td)
            {
                Console.Write($" {i}");
            }
            Console.WriteLine();


            //Jagged array
            Console.WriteLine("Jagged array: [5],[] //5rows with cunstom element number in each row");
            int[][] ja = new int[5][];
            ja[0] = new int[2] { 1,2};
            ja[1] = new int[1] { 1};
            ja[2] = new int[3] { 1,2,3};
            ja[3] = new int[0] { };
            ja[4] = new int[4] { 1,2,3,4};
            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Elements in the row {i}: ");
                for (int j = 0; j < ja[i].Length; j++) 
                {
                    Console.Write(ja[i][j]);
                }
                Console.WriteLine() ;
            }

            //CopyTo
            Console.WriteLine("CopyTo");
            int[] MyIntArray6 = new int[35];
            MyIntArray5.CopyTo(MyIntArray6, 10); // shallow copy
            Console.Write("Copied to a new array: ");
            foreach (int i in MyIntArray6)
            { 
                Console.Write($" {i}");
            }
            Console.WriteLine();

            Console.WriteLine("Clone");
            //int[] MyIntArray7 = (int[])MyIntArray5.Clone();
            var MyIntArray7 = (int[])MyIntArray5.Clone(); //shallow copy
            Console.WriteLine(MyIntArray7[5]);
            MyIntArray7[5] = 155;
            Console.Write("Cloned to a new array: ");
            foreach (int i in MyIntArray7)
            {
                Console.Write($" {i}");
            }
            Console.WriteLine();

            //deep copy
            Console.WriteLine("Deep Copy");
            Employee emp1 = new Employee() { EmployeeName="Sergey", Role="Developer"};
            Employee emp2 = new Employee() { EmployeeName="Tania", Role="Devivery Manager"};
            Employee emp3 = new Employee() { EmployeeName="Nikita", Role="Developer"};
            Employee emp4 = new Employee() { EmployeeName="Egor", Role="Developer"};
            Employee emp5 = new Employee() { EmployeeName="Nina", Role="Office Manager"};
            Employee emp6 = new Employee() { EmployeeName="Zarina", Role="HR"};

            Employee[] employees = new Employee[] { emp1, emp2, emp3, emp4, emp5, emp6 };
            Employee[] employees2 = new Employee[employees.Length];
            for (int i = 0; i < employees.Length; i++)
            {
                var result = employees[i].Clone();
                employees2[i] = (Employee)result;
            }
            employees[4].EmployeeName = "Valeria";
            employees[4].Role = "HR";
            Console.WriteLine($"Name: {employees[4].EmployeeName}, Role: {employees[4].Role}.");
            Console.WriteLine($"Name: {employees2[4].EmployeeName}, Role: {employees2[4].Role}.");

            Console.ReadKey();

        }
    }

    class Employee : ICloneable
    { 
        public string EmployeeName { get; set; }
        public string Role { get; set; }

        public object Clone()
        { 
            Employee new_one = new Employee() { EmployeeName = this.EmployeeName, Role = this.Role};
            return new_one;
        }
    }
}
