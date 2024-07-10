using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace GenericClassesAndMethods
{


    internal class Program
    {
        //Part 2: Create a Generic Method
        //Create a generic method Swap<T>(ref T a, ref T b) that takes two parameters of type T by reference and swaps their values.




        static void Main()
        {
            //Part 3: Test Your Code
            //Create a console application and use it to test your Database<TKey, TValue> class and Swap<T> method.

            //In the Main method of the console application, create a Database<int, string> object and add some key-value pairs to it. Then, use the Remove method to remove one of the pairs, and use the TryGetValue method to retrieve the value associated with another key. Print the number of key-value pairs in the database using the Count property.

            Database<int, string> base1 = new Database<int, string>();
            base1.Add(1, "One");
            base1.Add(2, "Two");
            base1.Add(3, "Three");
            base1.Add(4, "Four");
            base1.TryGetValue(3, out string returnValue);
            Console.WriteLine($"Returned value for key 3 is: {returnValue}.");
            base1.Add(5, "Five");
            base1.ArrayContent();
            base1.Remove(3);
            base1.Remove(2);
            base1.Remove(4);
            base1.Remove(1);
            base1.ArrayContent();
            Console.WriteLine($"Elements count: {base1.Count}");
            Console.WriteLine();


            //Next, create two variables of type int and swap their values using the Swap< int > method.Then, create two variables of a custom class of your choice and swap their values using the Swap< T > method.
            int a = 2, b = 4;
            Console.WriteLine($"a: {a}, b: {b}");
            base1.Swap(ref a, ref b);
            Console.WriteLine($"After Swap: a={a}, b={b}");
            Console.ReadKey();


            //Sample output:

            //A pair of key/value has been added to the database.
            //A pair of key/value has been added to the database.
            //A pair of key/value has been added to the database.
            //A pair of key/value has been added to the database.
            //Before remove:
            //Count: 4
            //Value for key 2: Two
            //After remove:
            //Count: 3
            //a = 2, b = 1
            //c1.Value = 2, c2.Value = 1

        }
    }


    //Assignment: Custom Generic Classes and Generic Methods
    //In this assignment, you will create a custom implementation of a key-value database using arrays.You will create a Database<TKey, TValue> class that provides basic functionality for adding, removing, and retrieving key-value pairs.

    //The Database<TKey, TValue> class should use two arrays to store the keys and values. When a new key- value pair is added to the database, it should be appended to the end of the arrays. If the arrays are full, they should be resized to twice their current size.

    //Part 1: Create a Custom Generic Class
    //Create a Database<TKey, TValue> class that implements a simple key-value database using two arrays. This class should have the following methods:
    class Database<TKey, TValue>
    {
        public TKey[] key = new TKey[2];
        public TValue[] value = new TValue[2];
        private int index = 0;
        private int arraysLength = 2;

        //void Add(TKey key, TValue value): adds a new key- value pair to the database.

        public void Swap<T>(ref T a, ref T b)
        {
            T c = a;
            a = b;
            b = c;
        }
        public void Resize()
        {
            //If the number of elements in the arrays falls below one-fourth of the array capacity,
            //the arrays should be resized to half their current size.
            int arraySize = arraysLength;
            if (this.index * 2 > this.key.Length)
            {
              //  Console.WriteLine($"Before resize length: {arraysLength}");
                Array.Resize(ref this.key, this.key.Length * 2);
                Array.Resize(ref this.value, this.value.Length * 2);
                this.arraysLength = this.key.Length;
                //Console.WriteLine($"Array resized from {arraySize} to {arraysLength}");
            }
            else if (this.index * 4 < this.key.Length)
            {
                //Console.WriteLine($"Before resize length: {arraysLength}");
                Array.Resize(ref this.key, this.key.Length / 2);
                Array.Resize(ref this.value, this.value.Length / 2);
                this.arraysLength = this.key.Length;

            }
            Console.WriteLine($"Array resized from {arraySize} to {arraysLength}");
        }

        public void Add(TKey addKey, TValue addValue)
        {

            this.key[index] = addKey;
            this.value[index] = addValue;
            index++;
            Console.WriteLine($"A pair of {addKey} / {addValue} added to DB. Index: {this.index}, array length: {this.arraysLength}");
            Resize();
        }

        //bool Remove(TKey key): removes the key-value pair with the specified key from the database.
        //Returns true if the pair was removed, false otherwise.

        //When a key-value pair is removed, the class should search the keys array for the key to remove.
        //If the key is found, the corresponding value should be removed from the values array,
        //and the remaining elements should be shifted to the left to fill the gap.

        public bool Remove(TKey removeKey)
        {
            int removeIndex = -1;

            try
            {
                removeIndex = Array.IndexOf(this.key, removeKey);
            }
            catch
            {
                Console.WriteLine($"Required Key {removeKey} is not found!");
            }

            if (removeIndex == -1)
            {
                return false;
            }
            else
            {
                TValue removeValue = this.value[removeIndex];
                for (int i = removeIndex; i < arraysLength - 1; i++)
                {
                    this.key[i] = this.key[i + 1];
                    this.value[i] = this.value[i + 1];
                }
                this.index--;
                //Console.WriteLine($"index: {this.index}");
                Console.WriteLine($"A pair of {removeKey} / {removeValue} removed from DB. Index: {this.index}, array length: {this.arraysLength}");
                Resize();
                return true;
            }
        }

        public void ArrayContent() 
        {
            for (int i = 0; i < this.value.Length; i++)
            {
                Console.Write($"{this.key[i]}:{this.value[i]}  ");
            }
            Console.WriteLine();
        }

        //The TryGetValue method should search the keys array for the specified key and return the corresponding value if it is found.
        //bool TryGetValue(TKey key, out TValue value): retrieves the value associated with the specified key.
        //Returns true if the key was found, false otherwise.
        public bool TryGetValue(TKey key, out TValue value)
        {
            int keyIndex = -1;
            keyIndex = Array.IndexOf(this.key, key);
            if (keyIndex == -1)
            {
                value = default(TValue);
                return false;
            }
            else
            {
                value = this.value[keyIndex];
                return true;
            }
        }


        //int Count { get; }: returns the number of key-value pairs in the database.
        public int Count
        { get
            {
                //string state = $"Array length: {this.key.Length}, elements: {this.index - 1}.";
                return this.index;
            }
        }
    }
}


