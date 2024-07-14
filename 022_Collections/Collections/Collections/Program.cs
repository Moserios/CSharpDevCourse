using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.InteropServices;

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

            

            Console.ReadKey();

        }
    }

    public class Employee
    {
       public string FName { set; get;}
       public string LName { set; get;}
       public int ID { set; get;}
       public int Compensation { set; get;}
    }
}
