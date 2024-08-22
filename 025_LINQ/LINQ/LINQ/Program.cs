using System;
using System.Collections.Generic;
using System.Linq;


namespace LINQ
{
    class Employee
    {
        public int EmpID { get; set; }
        public string EmpName { get; set; }
        public string EmpJob { get; set; }
        public string EmpCity { get; set; }
        public double EmpSalary { get; set; }
    }

    class Person
    { 
        public string PersonName { get; set; }
    }

    internal class Program
    {
        static void Main()
        {
           List<Employee> employees = new List<Employee>()
           { 
            new Employee(){ EmpID = 101, EmpName = "Sergey", EmpJob = "Automation Engineer", EmpCity = "Belgrade", EmpSalary = 3500},
            new Employee(){ EmpID = 102, EmpName = "Eduard", EmpJob = "Delivery Manager", EmpCity = "Belgrade", EmpSalary = 5000},
            new Employee(){ EmpID = 103, EmpName = "Anatoly", EmpJob = "Software Developer", EmpCity = "Ivanovo", EmpSalary = 5500},
            new Employee(){ EmpID = 104, EmpName = "Ludmila", EmpJob = "Staffing Manager", EmpCity = "Yerevan", EmpSalary = 5000},
            new Employee(){ EmpID = 105, EmpName = "Alexandr", EmpJob = "Vice Director", EmpCity = "Lisbon", EmpSalary = 6000},
            new Employee(){ EmpID = 106, EmpName = "Andrey", EmpJob = "Software Developer", EmpCity = "Zagreb", EmpSalary = 5000}
           };

            Console.WriteLine("Show only where Salary >= 5000");
            var result = employees.Where(emp => emp.EmpSalary >= 5000);
            foreach(Employee emp in result)
            { 
                Console.WriteLine($"{emp.EmpID}, {emp.EmpName}, {emp.EmpJob}, {emp.EmpCity}, {emp.EmpSalary}");
            }

            Console.WriteLine("\nShow only where Job == Software Developer");
            var result2 = employees.Where(emp => emp.EmpJob == "Software Developer");
            foreach (Employee emp in result2)
            {
                Console.WriteLine($"{emp.EmpID}, {emp.EmpName}, {emp.EmpJob}, {emp.EmpCity}, {emp.EmpSalary}");
            }


            Console.WriteLine("\nOrder by Name");
            var result3 = employees.OrderBy(emp => emp.EmpName);
            foreach (Employee emp in result3)
            {
                Console.WriteLine($"{emp.EmpID}, {emp.EmpName}, {emp.EmpJob}, {emp.EmpCity}, {emp.EmpSalary}");
            }

            Console.WriteLine("\nOrder by Salary Descending, if Salary is equal then order by Job");
            var result4 = employees.OrderBy (emp => emp.EmpSalary).ThenBy(emp => emp.EmpJob);
            foreach (Employee emp in result4)
            {
                Console.WriteLine($"{emp.EmpID}, {emp.EmpName}, {emp.EmpJob}, {emp.EmpCity}, {emp.EmpSalary}");
            }

            //First
            Console.WriteLine("\nShow first matching with salary == 5000 via List index");
            List<Employee> result5 = employees.Where(emp => emp.EmpSalary == 5000).ToList();
            Console.WriteLine($"{result5[0].EmpID}, {result5[0].EmpName}, {result5[0].EmpJob}, {result5[0].EmpCity}, {result5[0].EmpSalary}");

            //FirstOrDefault
            Console.WriteLine("\nShow first matching with salary == 6500 via FirstOrDefault"); //if "First" used if no result will be exception, while FirstOrDefault returns "null" if no records found
            Employee result6 = employees.FirstOrDefault(emp => emp.EmpSalary == 6500);
            if (result6 != null)
            {
                Console.WriteLine($"{result6.EmpID}, {result6.EmpName}, {result6.EmpJob}, {result6.EmpCity}, {result6.EmpSalary}");
            }
            else { Console.WriteLine($"There is no record matching criteria"); }


            //LastOrDefault
            Console.WriteLine("\nShow last matching with salary == 5000 via LastOrDefault"); //if "Last" used if no result will be exception, while LastOrDefault returns "null" if no records found
            Employee result7 = employees.LastOrDefault(emp => emp.EmpSalary == 5000);
            if (result7 != null)
            {
                Console.WriteLine($"{result7.EmpID}, {result7.EmpName}, {result7.EmpJob}, {result7.EmpCity}, {result7.EmpSalary}");
            }
            else { Console.WriteLine($"There is no record matching criteria"); }


            //ElementAtOrDefault
            Console.WriteLine("\nShow second employee with salary == 5000"); 
            Employee result8 = employees.Where(emp => emp.EmpSalary == 5000).ElementAtOrDefault(1); //index from the results
            if (result8 != null)
            {
                Console.WriteLine($"{result8.EmpID}, {result8.EmpName}, {result8.EmpJob}, {result8.EmpCity}, {result8.EmpSalary}");
            }
            else { Console.WriteLine($"There is no record matching criteria"); }


            //SingleOrDefault
            Console.WriteLine("\nShow single matching with salary == 6000 via SingleOrDefault"); //if "Single" used if no result or more than one result will be exception, while SingleOrDefault returns "null" instead of exception
            Employee result9 = employees.SingleOrDefault(emp => emp.EmpSalary == 6000);
            if (result9 != null)
            {
                Console.WriteLine($"{result9.EmpID}, {result9.EmpName}, {result9.EmpJob}, {result9.EmpCity}, {result9.EmpSalary}");
            }
            else { Console.WriteLine($"There is no record matching criteria"); }


            //Select
            Console.WriteLine("\nSelect - creates a new collection of values for each element of another collection. HElps convert collections"); 
            IEnumerable<double> selected = employees.Select(emp => 10.5); //creates 10.5 value in new collection for each elemnt in another collection
            foreach (double item in selected)
            {
                Console.WriteLine(item);
            }

            IEnumerable<Person> selected2 = employees.Select(emp => new Person() { PersonName = emp.EmpName} ); //creates 10.5 value in new collection for each elemnt in another collection
            
            foreach (Person item in selected2)
            {
                Console.WriteLine(item.PersonName);
            }


            //Average, Min, Max, Count, Sum
            Console.WriteLine("\nAggregation - Average, Min, Max, Count, Sum");
            double SalaryMax = employees.Max(emp => emp.EmpSalary);
            double SalaryMin = employees.Min(emp => emp.EmpSalary);
            double SalaryAvg = employees.Average(emp => emp.EmpSalary); 
            double SalarySum = employees.Sum(emp => emp.EmpSalary);
            double SalaryCount = employees.Count();
            Console.WriteLine($"Salary Max {SalaryMax}");
            Console.WriteLine($"Salary Min {SalaryMin}");
            Console.WriteLine($"Salary Average {SalaryAvg}");
            Console.WriteLine($"Salary Sum {SalarySum}");
            Console.WriteLine($"Salary Count {SalaryCount}");
            


            Console.ReadKey();
        }
    }
}
