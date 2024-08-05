using System;
using System.Collections.Generic;


namespace ConsoleApp1
{
    class CustomFinder
    {
        List<int> result = new List<int>();
        public List<int> FindLargest(List<List<int>> collections)
        {
            int maxValue = 0;
            foreach (var c in collections) 
            {
                foreach (var item in c)
                {
                    if (c.IndexOf(item) == 0)
                        maxValue = item;
                    else if (item > maxValue)
                    {
                        maxValue = item;
                    }
                }
                result.Add(maxValue);
            }
            return result;
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            CustomFinder myFinds = new CustomFinder();

            List<int> result = myFinds.FindLargest(new List<List<int>>() {
            new List<int>( ) { 67, 100, 23 },
            new List<int>( ) { 80, 99, 750, 99 },
             new List<int>( ) { 888, 333, 9898 } });  //should return new List<int>( ) { 100, 750, 9898 }

            foreach (int item in result)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}

//Create a C# program that contains a method that finds large numbers of a group of collections respectively.

//Method Signature:  List<int> FindLargest(List<List<int>> collections)

//The method receives a list of List collections and returns a collection that contains largest of those collections.

//Example:
//FindLargest(new List<List<int>>() {
//new List<int>( ) { 67, 100, 23 },
//new List<int>( ) { 80, 99, 750, 99 },
// new List<int>( ) { 888, 333, 9898 } });  //should return new List<int>( ) { 100, 750, 9898 }

//Note: Don't use LINQ.
