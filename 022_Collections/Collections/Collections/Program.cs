using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.InteropServices;
using ECommerce;
using College;
using System.Security.Cryptography.X509Certificates;
using System.CodeDom;

namespace Collections
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("\n\n -- Lists -- \n\n");

            List<int> myIntList = new List<int>() { 10, 20, 30, 40,50};
            
            foreach (int i in myIntList)
            {
                Console.WriteLine(i);
            }

            for (int i = 0; i < myIntList.Count; i++)
            {
                Console.WriteLine(myIntList[i]);
            }
            Console.WriteLine();

            Console.WriteLine("Add(append) a values to a Lists");
            myIntList.Add(60);
            myIntList.Add(70);
            myIntList.Add(80);

            List<int> anotherList = new List<int>() { 110, 120, 130, 140, 150 };

            myIntList.AddRange(anotherList);

            Console.WriteLine("Insert values to the Lists");
            myIntList.Insert(8, 90);
            myIntList.InsertRange(9, new List<int>(){ 100, 101, 102,103,104,105,106,107,108,109, 115, 125, 135, 145, 150 });


            Console.WriteLine("RemoveAt");
            bool removed = myIntList.Remove(101);
            Console.WriteLine(removed);
            myIntList.RemoveAt(10);

            Console.WriteLine("RemoveRange");
            myIntList.RemoveRange(10,2);

            Console.WriteLine("RemoveAll");
            myIntList.RemoveAll(n => n < 110 && n > 100);
            //Console.WriteLine(removed);

            Console.WriteLine("Clear");
            //myIntList.Clear(); //removes all elements from the table

            Console.WriteLine("IndexOf");
            int myIndex = myIntList.IndexOf(108);
            Console.WriteLine($" IndexOf 108 is {myIndex}");
            myIndex = myIntList.IndexOf(150);
            Console.WriteLine($" IndexOf first occurance of 150 is {myIndex}");
            myIndex = myIntList.IndexOf(150,15);
            Console.WriteLine($" IndexOf second occurance of 150 is {myIndex}");
            Console.WriteLine("Sort collection");
            myIntList.Sort();
            myIndex = myIntList.BinarySearch(115);
            Console.WriteLine($" BinarySearch of 115 is {myIndex}");
            myIndex = myIntList.BinarySearch(122);
            Console.WriteLine($" BinarySearch of 122 is {myIndex}");

            bool valueFound = myIntList.Contains(115);
            Console.WriteLine($" Contains 115 is {valueFound}");


            Console.WriteLine("Reverse");
            myIntList.Reverse();
            for (int i = 0; i < myIntList.Count; i++)
            {
                Console.Write($"{myIntList[i]} ");
            }

            Console.WriteLine("\nSorted");
            myIntList.Sort();

            Console.WriteLine("\nToArray");
            int[] myIntArray = myIntList.ToArray();
            for (int i = 0; i < myIntArray.Length; i++)
            {
                Console.Write($"{myIntArray[i]} ");
            }

            Console.WriteLine("\nForEach + lambda");
            myIntList.ForEach(n => Console.Write($"{n} "));

            Console.WriteLine("\nExists");
            bool elExists = myIntList.Exists(n => n > 100 && n < 110);
            Console.WriteLine($"n > 100 && n < 110: {elExists}");
            elExists = myIntList.Exists(n => n >= 91 && n <= 110);
            Console.WriteLine($"n >= 91 && n <= 110: {elExists}");


            Console.WriteLine();
            Console.WriteLine("\nFind");
            int result = myIntList.Find(n => n >= 10 && n < 110);
            Console.WriteLine($"First found value: {result}");

            Console.WriteLine("\nFindLast");
            result = myIntList.FindLast(n => n >= 10 && n < 110);
            Console.WriteLine($"Last found value for n >= 10 && n < 110: {result}");

            Console.WriteLine("\nFindIndex");
            result = myIntList.FindIndex(n => n >= 10 && n < 110);
            Console.WriteLine($"First found index for n >= 10 && n < 110: {result}, value = {myIntList[result]}");

            Console.WriteLine("\nFindLastIndex");
            result = myIntList.FindLastIndex(n => n >= 10 && n < 110);
            Console.WriteLine($"Last found index for n >= 10 && n < 110: {result}, value = {myIntList[result]}");

            Console.WriteLine("\nFindAll");
            List<int> myResult = myIntList.FindAll(n => n >= 10 && n < 110);
            Console.WriteLine($"All found elements for n >= 10 && n < 110: {string.Join(" ",myResult)}");
            Console.Write("All found elements  for n >= 10 && n < 110 (by foreach loop): ");
            foreach (int i in myResult)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine("");

            Console.WriteLine("\nConvertAll");
            List<double> myConverted = myIntList.ConvertAll(n => Convert.ToDouble(n * 1.5));
            Console.WriteLine($"All original  values for n: {string.Join(" ", myIntList)}");
            Console.WriteLine($"All converted values for n: {string.Join(" ", myConverted)}");

            Console.WriteLine("\nConvertAll for complex logic with curly bracers and RETURN statement");
            List<string> myConvertedString = myIntList.ConvertAll(n =>
            {
                return Convert.ToString($"{myIntList.IndexOf(n)}:{n * 1.5}");
            });
            Console.WriteLine($"All changed values for n in format index:value: \n{string.Join(" ", myConvertedString)}");


            List<int> intCollection = new List<int>() { 1, 2, 3, 5, 9, 0 };
            List<string> strCollections = intCollection.ConvertAll(n =>
            {
                string word;
                switch (n)
                {
                    case 1: word = "One"; break;
                    case 2: word = "Two"; break;
                    case 3: word = "Three"; break;
                    case 4: word = "Four"; break;
                    case 5: word = "Five"; break;
                    case 6: word = "Six"; break;
                    case 7: word = "Seven"; break;
                    case 8: word = "Eight"; break;
                    case 9: word = "Nine"; break;
                    case 0: word = "Zero"; break;
                    default: word = ""; break;
                }
                return word;
            });
            Console.WriteLine();
            intCollection.ForEach(n => Console.Write($"{n} "));
            Console.WriteLine();
            Console.WriteLine($"{string.Join(" ", strCollections)}");

            Console.WriteLine("\n\n -- DICTIONARIES -- \n\n");

            Dictionary<int, string> employees = new Dictionary<int, string>()
            {
                { 0001, "Sergey"},
                { 00020, "Tatiana"},
                { 0003, "Eduard"},
                { 00040, "Andrey"},
                { 0005, "Anatoly"},
                { 00060, "Milos"}
            };
            employees.Add(52, "Svetlana");

            foreach (KeyValuePair<int, string> item in employees)
            {
                Console.WriteLine($"{item.Key} : {item.Value}");
            }

            Console.WriteLine(employees[1]);
            Dictionary<int,string>.KeyCollection myKeys = employees.Keys;
            foreach (int item in myKeys)
            {
                Console.WriteLine(item);
            }

            employees.Remove(60);
            //employees.Clear(); //removes all records

            bool a = employees.ContainsKey(60);
            bool b = employees.ContainsKey(20);
            bool c = employees.ContainsValue("Sergey");

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);



            Console.WriteLine("\n\n -- SORTEDLIST -- \n\n");

            SortedList<int, string> mySortedList = new SortedList<int, string>()
            {
                { 10, "Akvelon"},
                { 60, "Google"},
                { 50, "Microsoft"},
                { 40, "Dell"},
                { 30, "Apple"},
                { 20, "Meta"}
            };

            mySortedList.Add(15, "Luxoft");
            mySortedList.Add(55, "Wartsola");

            Console.WriteLine("\nLooping Key:Value pairs");
            foreach (KeyValuePair<int, string> item in mySortedList)
            { 
                Console.WriteLine(item.Key + " " + item.Value);
            }

            int indexOfKey = mySortedList.IndexOfKey(20);
            Console.WriteLine("Index of key 20: " + indexOfKey);


            Console.WriteLine("\nLooping the keys");
            foreach (int item in mySortedList.Keys)
            {
                Console.WriteLine("Key : " + item);
            }

            Console.WriteLine("\nLooping the values");
            foreach (string item in mySortedList.Values)
            {
                Console.WriteLine("Key : " + item);
            }



            Console.WriteLine("\n\n -- HASHTABLE COLLECTION -- \n\n");

            Hashtable myRolesHashtable = new Hashtable()
            {
                { 10, "QA"},
                { "60", "SDE"},
                { 50, "SDET"},
                { 41.21, "Stafing Manager"},
                { 'a', "PM"},
                { true, "PO"}
            };

            myRolesHashtable.Add(15, "CEO");
            myRolesHashtable.Add("boss", "Director");
            myRolesHashtable.Add("%$#", 1234567890.23);

            //returns object, not a value, cause value could be of any data type, thats why always use var datatype !!!
            Console.WriteLine($"\nLoop through the objects");
            foreach (var item in myRolesHashtable) 
            { 
                Console.Write($"{item} ");
            }

            Console.WriteLine($"\nLoop through the Hashtable keys");
            foreach (var item in myRolesHashtable.Keys)
            {
                Console.Write($"{item} ");
            }

            Console.WriteLine($"\nLoop through the Hashtable Values");
            foreach (var item in myRolesHashtable.Values)
            {
                Console.Write($"{item} ");
            }

            Console.WriteLine();
            // Use DictionaryEntry data type to get to the keys and values!!!
            foreach (DictionaryEntry item in myRolesHashtable)
            {
                Console.WriteLine($"{item.Key}:{item.Value} ");
            }
            Console.WriteLine();

            // Get value based on keys >> should check data type to use the value!!!

            foreach (DictionaryEntry item in myRolesHashtable)
            {
                //CheckType();
                if (item.Key is string)
                {
                    Console.WriteLine($"String: {Convert.ToString(item.Key)}");
                }
                else if (item.Key is int)
                {
                    Console.WriteLine($"Int: {Convert.ToInt32(item.Key)}");
                }
                else if (item.Key is double)
                {
                    Console.WriteLine($"Double: {Convert.ToDouble(item.Key)}");
                }
                else if (item.Key is char)
                {
                    Console.WriteLine($"Char: {Convert.ToChar(item.Key)}");
                }
                else if (item.Key is bool)
                {
                    Console.WriteLine($"Bool: {item.Key}");
                }
            }

            var o = 10;
            if (myRolesHashtable[o] is int)
            {
                var t = (int)myRolesHashtable[o];
                Console.WriteLine(t);
            }
            else if (myRolesHashtable[o] is string)
            {
                var t = Convert.ToString(myRolesHashtable[o]);
                Console.WriteLine(t);
            }

            elExists = myRolesHashtable.ContainsKey(20);
            Console.WriteLine(elExists);
            elExists = myRolesHashtable.ContainsValue("SDET");
            Console.WriteLine(elExists);




            Console.WriteLine("\n\n -- HASHSET -- \n\n");

            HashSet<string> myHashSet = new HashSet<string>()
            { 
                "My name is Sergey",
                "Nikita is my best friend",
                "Tania has a best smile ever",
                "Yulia is My crush",
                "My favorite job is testing, automation and improving the flow"
            };


            myHashSet.Add("My future position is a software developer");
            myHashSet.Add("I want a family");
            myHashSet.Add("I want to earn $5k per month and buy a house");
            myHashSet.Add("I want to know everything");
            myHashSet.Add("Good morning");
            myHashSet.Add("How are you");
            myHashSet.Add("Have a good day");
            myHashSet.Add("Good luck");
            myHashSet.Add("Here we go again");
            Console.WriteLine($"HashSet size: {myHashSet.Count}");
            myHashSet.Remove("Yulia is My crush");
            myHashSet.RemoveWhere(m => m.EndsWith("again"));

            

            Console.WriteLine($"HashSet size: {myHashSet.Count}");

            foreach (var message in myHashSet)
            {
                Console.WriteLine(message);
            }

            bool checkIfContains = myHashSet.Contains("Nikita is my best friend");
            Console.WriteLine(checkIfContains);

            HashSet<string> myNewHashSet = new HashSet<string>()
            { 
                "Akvelon is a great company",
                "We have a great developers",
                "We will conquer a new market",
                "Nikita is my best friend"
            };

            myHashSet.UnionWith(myNewHashSet);

            foreach (var message in myHashSet)
            {
                Console.WriteLine(message);
            }
            Console.WriteLine();
            HashSet<string> myCompareHashSet = myHashSet;
            //myCompareHashSet.UnionWith(myHashSet);
            myCompareHashSet.IntersectWith(myNewHashSet);
            foreach (var message in myCompareHashSet)
            {
                Console.WriteLine(message);
            }

            //myHashSet.Clear(); //clears hashset



            Console.WriteLine("\n\n -- ARRAYLIST -- \n\n");



            ArrayList myArrayList = new ArrayList()
            {
                    1,
                    'A',
                    "My string",
                    15.10,
                    true,
                    employees[20]
                    
            };

            Employee emp1 = new Employee() { ID = 1, FName = "Sergey", LName = "Molchun" };
            myArrayList.Add(emp1);
 

            Console.WriteLine(myArrayList.Count);

            foreach (var item in myArrayList)
            {
                if (item is Employee emp)
                {
                    Console.WriteLine($"{emp.ID} {emp.FName} {emp.LName}");
                }
                else if (item is Dictionary<int, string> dict)
                {
                    Console.WriteLine($"{dict.Keys} {dict.Values}");
                }
                else
                {
                    Console.WriteLine(item);
                }
            }




            Console.WriteLine("\n\n -- STACK -- ");
            Stack<int> myIntStack = new Stack<int>();
            myIntStack.Push(100);
            myIntStack.Push(200);
            myIntStack.Push(300);

            foreach (var item in myIntStack)
            { 
                Console.WriteLine(item);
            }

            Console.WriteLine();
            Stack<Employee> myEmpStack = new Stack<Employee>();
            myEmpStack.Push(new Employee() { Compensation = 10000});
            myEmpStack.Push(new Employee() { Compensation = 20000});
            myEmpStack.Push(new Employee() { Compensation = 30000});
            myEmpStack.Push(new Employee() { Compensation = 40000});
            myEmpStack.Push(new Employee() { Compensation = 50000});
            
            foreach (var item in myEmpStack)
            {
                Console.WriteLine(item.Compensation);
            }

            Employee stackEmp;

            Employee checkRecord = myEmpStack.Peek();
            Console.WriteLine("Top stack value is: " + checkRecord.Compensation);


            Console.WriteLine(myEmpStack.Count);
            int records = myEmpStack.Count;
            for (int i = 0; i < records; i++)
            {
                stackEmp = myEmpStack.Pop();
                Console.WriteLine($"{i} {stackEmp.Compensation}");
            }
            Console.WriteLine(myEmpStack.Count);



            Console.WriteLine("\n\n -- QUEUE -- ");
            Queue<string> myQueue = new Queue<string>();

            myQueue.Enqueue("Task5");
            myQueue.Enqueue("Task3");
            myQueue.Enqueue("Task1");
            myQueue.Enqueue("Task4");
            myQueue.Enqueue("Task2");

            Console.WriteLine($"\nCheckig the queue content");
            foreach (var item in myQueue)
            { 
                Console.WriteLine(item);
            }
            string peekElement = myQueue.Peek();
            Console.WriteLine($"Checking top element: {peekElement}");

            string dequeElement = myQueue.Dequeue();
            Console.WriteLine($"\nRetreaving element: {dequeElement}");
            dequeElement = myQueue.Dequeue();
            Console.WriteLine($"Retreaving element: {dequeElement}");
            dequeElement = myQueue.Dequeue();
            Console.WriteLine($"Retreaving element: {dequeElement}");
            myQueue.Enqueue("Task6");


            Console.WriteLine($"\nCheckig the queue content");
            foreach (var item in myQueue)
            {
                Console.WriteLine(item);
            }


            dequeElement = myQueue.Dequeue();
            Console.WriteLine($"\nRetreaving element: {dequeElement}");
            dequeElement = myQueue.Dequeue();
            Console.WriteLine($"Retreaving element: {dequeElement}");



            Console.WriteLine("\n\n -- COLLECTION OF OBJECTS -- ");

            List<Product> myProductsCollection = new List<Product>();
            string choice;
            do 
            {
                Console.Write("Enter Product ID: ");
                int.TryParse(Console.ReadLine(), out int pid);

                Console.Write("Enter Product Name: ");
                string pName = Console.ReadLine();

                Console.Write("Enter Product Price: ");
                double.TryParse(Console.ReadLine(), out double pprice);

                Console.Write("Enter manufacture date (YYYY-MM-DD): ");
                DateTime.TryParse(Console.ReadLine(), out DateTime pManufDate);

                Product product = new Product() 
                { 
                    ProductID = pid, 
                    ProductName = pName, 
                    Price = pprice, 
                    DateOfManufactute = pManufDate
                };

                myProductsCollection.Add(product);

                Console.WriteLine("Product added. \n\nDo you want to add another one? (Yes/No)");
                choice = Console.ReadLine();
            }
            while (choice != "No" && choice != "no" && choice != "n" && choice != "N");
            Console.WriteLine($"Products in collection: {myProductsCollection.Count}");

            Console.WriteLine("Products:");
            foreach (Product item in myProductsCollection)
            {
                Console.WriteLine(item.ProductID);
                Console.WriteLine(item.ProductName);
                Console.WriteLine(item.Price);
                Console.WriteLine(item.DateOfManufactute.ToShortDateString());
            }



            Console.WriteLine("\n\n -- COLLECTION OF OBJECTS and OBJECT RELATIOS -- ");

            Console.WriteLine("\nOne-to-One and One-to-Many relations");
            Student student = new Student()
            {
                RollNumber = 1,
                FName = "Sergey",
                LName = "Molchun",
                Email = "moser@email.com",
                PhoneNumber = "0123456789",
                branch = new Branch(),
                examinations = new List<Examination>()
            };

            student.branch.BranchName = "CS";
            student.branch.NumberOfSemesters = 4;
            student.examinations.Add(new Examination() { ExaminationName = "CS", Mark = 5, Month = 1, Year = 2023, SecuredMark = 95 });
            student.examinations.Add(new Examination() { ExaminationName = "C#", Mark = 5, Month = 1, Year = 2023, SecuredMark = 95 });
            student.examinations.Add(new Examination() { ExaminationName = "Python", Mark = 5, Month = 7, Year = 2022, SecuredMark = 95 });
            student.examinations.Add(new Examination() { ExaminationName = "DB", Mark = 5, Month = 7, Year = 2022, SecuredMark = 95 });

            Console.WriteLine($"" +
                $"Student No: {student.RollNumber}\n" +
                $"Name: {student.FName} {student.LName}\n" +
                $"Contacts: {student.Email} {student.PhoneNumber}\n" +
                $"Branch: {student.branch.BranchName} - {student.branch.NumberOfSemesters} semesters\n" +
                $"Examinations: {student.examinations.Count}: ");
            foreach(Examination item in student.examinations)    
            {
               Console.WriteLine($"Examinations: {item.ExaminationName}: {item.Mark} (rate: {item.SecuredMark}) {item.Year}-{item.Month}");
            }


            Console.WriteLine("\nMany-to-One relations");
            
            Department dept1 = new Department() { DepID = 1, DepName = "Development"};
            Employee empl1 = new Employee() { ID=1, FName="Peter", LName = "Smith", Compensation = 100000, dept = dept1};
            Employee empl2 = new Employee() { ID=2, FName="James", LName = "Gadought", Compensation = 120000, dept = dept1 };
            Employee empl3 = new Employee() { ID=3, FName="Mathew", LName = "Arnor", Compensation = 150000, dept = dept1 };
            Employee empl4 = new Employee() { ID=4, FName= "Andrew", LName = "Jones", Compensation = 110000, dept = dept1 };
            List<Employee> employeeList = new List<Employee>();
            employeeList.Add( empl1);
            employeeList.Add( empl2);
            employeeList.Add( empl3);
            employeeList.Add( empl4);
            foreach (Employee employee in employeeList) 
            {
                Console.WriteLine($"{employee.ID} {employee.FName} {employee.LName} {employee.dept.DepName}");
            }




            Console.WriteLine("\n\n -- COLLECTIONS HIERARCHY -- ");

            IEnumerable<string> messages; //created a RefVar of IEnumerable (parent of List) for code flexibility
            messages = new List<string>() {"First string", "Second string", "Third string" }; //assign object of child class to parent refVar
            Console.WriteLine($"IEnumerable:");
            foreach (string item in messages)
            {
                Console.WriteLine($"{item}");
            }


            Console.WriteLine("\n\n -- Iterator -- ");
            Sample s = new Sample();
            var enumerable1 = s.MyMethod();
            var enumerator1 = enumerable1.GetEnumerator();
            enumerator1.MoveNext();
            Console.WriteLine(enumerator1.Current);
            enumerator1.MoveNext();
            Console.WriteLine(enumerator1.Current);
            Console.WriteLine("\nUsing foreach loop:");

            foreach (var item in enumerable1)
            { 
                Console.WriteLine(item);
            }



            Console.WriteLine("\n\n -- Custom Collections -- ");
            CustomersList customersList = new CustomersList()
            { 
                new Customer(){ CustomerID = "C001", CustomerName = "Sergey M", CustomerEmail = "sm@gmaill.com", CustomerType=TypeOfCustomer.RegularDeveloper},
                new Customer(){ CustomerID = "B001", CustomerName = "Tania R", CustomerEmail = "tr@gmaill.com", CustomerType=TypeOfCustomer.ProjectManager},
            };

            Customer new_cust = new Customer()
            { CustomerID = "A001", CustomerName = "Irina S", CustomerEmail = "is@gmaill.com", CustomerType = TypeOfCustomer.DeparmentOfficer };
            customersList.Add(new_cust);
            Customer new_cust1 = new Customer()
            { CustomerID = "S001", CustomerName = "Sergey D", CustomerEmail = "sd@gmaill.com", CustomerType = TypeOfCustomer.CEO };
            customersList.Add(new_cust1);

            foreach (Customer cust in customersList)
            { 
                Console.WriteLine(cust.CustomerID + " " + cust.CustomerName + " " + cust.CustomerEmail + " " + cust.CustomerType); 
            }



            Console.WriteLine("\n\n -- Custom Collections based on ICollection -- ");
            CustomersCollectionList customersCollection = new CustomersCollectionList()
            {
                new Customer(){ CustomerID = "C101", CustomerName = "Sergey M", CustomerEmail = "sm@gmaill.com", CustomerType=TypeOfCustomer.RegularDeveloper},
                new Customer(){ CustomerID = "B101", CustomerName = "Tania R", CustomerEmail = "tr@gmaill.com", CustomerType=TypeOfCustomer.ProjectManager},
                new Customer(){ CustomerID = "C102", CustomerName = "Bogdan V", CustomerEmail = "bv@gmaill.com", CustomerType=TypeOfCustomer.RegularDeveloper}
            };
            Customer cust0 = new Customer()
            { CustomerID = "B102", CustomerName = "Eduard L", CustomerEmail = "el@gmaill.com", CustomerType = TypeOfCustomer.ProjectManager };
            customersCollection.Add(cust0);
            Customer cust1 = new Customer()
            { CustomerID = "A101", CustomerName = "Irina S", CustomerEmail = "is@gmaill.com", CustomerType = TypeOfCustomer.DeparmentOfficer };
            customersCollection.Add(cust1);
            Customer cust2 = new Customer()
            { CustomerID = "S101", CustomerName = "Sergey D", CustomerEmail = "sd@gmaill.com", CustomerType = TypeOfCustomer.CEO };
            customersCollection.Add(cust2);

            Console.WriteLine($"Customer Collections contains {cust0.CustomerName} : {customersCollection.Contains(cust0)}");

            foreach (Customer cust in customersCollection)
            {
                Console.WriteLine(cust.CustomerID + " " + cust.CustomerName + " " + cust.CustomerEmail + " " + cust.CustomerType);
            }

            var cust_rem = customersCollection.Find(x => x.CustomerName.StartsWith("Bogdan"));
            Console.WriteLine($"Removing element: {cust_rem.CustomerName}: {customersCollection.Remove(cust_rem)}");
            var find_cust = customersCollection.Find(cust => cust.CustomerName == "Tania R");
            Console.WriteLine($"Customer Collections contains {find_cust.CustomerName} : {customersCollection.Contains(find_cust)}");

            Console.WriteLine("\nSorting List objects by FNAME string field");
            CustomComparer customComparer = new CustomComparer();
            employeeList.Sort(customComparer);
            foreach (Employee cust in employeeList)
            {
                Console.WriteLine(cust.ID + " " + cust.FName + " " + cust.LName + " " + cust.dept);
            }

            Console.ReadKey();

        }                                    
    }

    /// <summary>
    /// -- Custom Collections section start --
    /// </summary>
    public enum TypeOfCustomer
    {
        RegularDeveloper, ProjectManager, DeparmentOfficer, CEO
    }

    public class Customer
    { 
        public string CustomerID { get; set; }                       
        public string CustomerName { get; set; }
        public string CustomerEmail { get; set; }
        public TypeOfCustomer CustomerType { get; set; }
    }

    public class CustomersList : IEnumerable
    { 
        private List<Customer> customersList = new List<Customer>();

        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < customersList.Count; i++)
            { 
                yield return customersList[i];
            }
        }

        public void Add(Customer cust)
        {
            if (cust.CustomerID.Length < 5)
            {
                customersList.Add(cust);
            }
            else 
            { 
                Console.WriteLine("CustomerID length exceeds max length");
            }
        }
    }

    public class CustomersCollectionList : ICollection<Customer>
    {
        private List<Customer> customers = new List<Customer>();

        public int Count => customers.Count;
        public bool IsReadOnly => false;


        IEnumerator IEnumerable.GetEnumerator()
        {
             return this.GetEnumerator();
        }

        public IEnumerator<Customer> GetEnumerator()
        {
            for (int i = 0; i < customers.Count; i++)
            {
                yield return customers[i];
            }
        }

        public void Add(Customer cust)
        {
            if (cust.CustomerID.Length < 5)
            {
                customers.Add(cust);
            }
            else
            {
                Console.WriteLine("CustomerID length exceeds max length");
            }
        }

        public void Clear()
        {
            customers.Clear();
        }

        public bool Contains(Customer item)
        {
            return customers.Contains(item);
        }

        public void CopyTo(Customer[] array, int arrayIndex)
        {
            customers.CopyTo(array, arrayIndex);
        }

        public bool Remove(Customer item)
        {
            return customers.Remove(item);
        }

        public Customer Find(Predicate<Customer> match)
        { 
            return customers.Find(match);
        }

        public List<Customer> FindAll(Predicate<Customer> match)
        { 
            return customers.FindAll(match);
        }
    }

    /// <summary>
    /// -- Custom Collections section end --
    /// </summary>

    public class Sample
    {
        public List<double> Price { get; set; } = new List<double>() { 5, 12.5, 25.2, 32, 7, 11};
        public IEnumerable<int> MyMethod()
        { 
            Console.WriteLine("Line 1");
            yield return 10;
            Console.WriteLine("Line 2");
            yield return 20;
        }
    }

    public class Employee
    {
       public int ID { set; get; }
       public string FName { set; get;}
       public string LName { set; get;}
       public int Compensation { set; get;}

        public Department dept { set; get;}
    }

    public class Department
    { 
        public int DepID { set; get;}
        public string DepName { set; get;}

    }

    class CustomComparer : IComparer<Employee>
    {
        public int Compare(Employee x, Employee y)
        { 
            return x.FName.CompareTo(y.FName);
        }
    }
}
