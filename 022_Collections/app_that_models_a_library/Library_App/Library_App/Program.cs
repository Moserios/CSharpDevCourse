using System;
using System.Collections.Generic;



//Create an application that models a library. The library has different types of items such as books, DVDs, and CDs. Your task is to create interfaces and classes that represent these items, and implement methods that are appropriate for each item.


//Requirements
//Your implementation should meet the following requirements:
//All classes should implement the appropriate interfaces in a way that is appropriate for that item.
//The Library class should have the specified properties and methods.
//You should demonstrate that your implementation works by adding items to the library, borrowing and returning them, and printing out information about all items in the library.


//Sample output:

//CD: Abbey Road by The Beatles (borrowed by John Smith)
//DVD: The Shawshank Redemption directed by Frank Darabont (0 min)
//Book: Harry Potter and the Philosopher's Stone by J.K. Rowling (ISBN: 9780747532743)


//Part 1: Create Interfaces
//First, create the following interfaces:

//ILoanable: defines the properties and methods that an item that can be borrowed should have. This should include properties such as LoanPeriod and Borrower, as well as methods such as Borrow and Return.
interface ILoanable
{ 
    int LoanPeriod { get; }

    string Borrower { get; set; }

    void Borrow(string Name, int LoanForDays);
    void Return();
}

//IPrintable: defines the method Print, which should print out information about the item.
interface IPrintable
{ 
    void Print();
}

//Part 2: Create Classes
//Each class should implement the ILoanable and IPrintable interfaces in a way that is appropriate for that item.
//Next, create classes that implement the ILoanable and IPrintable interfaces for the following types of items:
//Book: has properties such as Author, Title, and ISBN, and should be loanable for 21 days.

class Book : ILoanable, IPrintable
{
    public Book(string Title, string Author, string ISBN, string Borrower = "")
    {
        this.Title = Title;
        this.Author = Author;
        this.ISBN = ISBN;
        this.Borrower = Borrower;
    }

    private string whoBorrowed;
    private int maxLoanPeriodDays = 21;

    public string Author { get; set; }
    public string Title { get; set; }
    public string ISBN { get; set; }
    public int LoanPeriod
    {
        get
        {
            return maxLoanPeriodDays;
        }
    }


    public string Borrower 
    { 
        get
        { 
            return this.whoBorrowed; 
        }
        set
        {
            this.whoBorrowed = value; 
        } 
    }

    public void Borrow(string Name, int LoanForDays)
    {
        if (this.Borrower == "" && LoanForDays <= maxLoanPeriodDays)
        {
            this.Borrower = Name;
        }
        else if (this.Borrower == "" && LoanForDays > maxLoanPeriodDays)
        {
            Console.WriteLine($"{Name}! Book can't be borrowed more then {maxLoanPeriodDays} days.");
        }
        else
        {
            Console.WriteLine($"Book is already borrowed by {Borrower}.");
        }
    }

    public void Return()
    {
        if (this.Borrower != "")
        {
            Console.WriteLine($"Book {this.Title} returned by {this.Borrower}.");
            this.Borrower = "";
        }
        else 
        {
            Console.WriteLine("Book is not borrowed yet.");
        }
    }

    public void Print()
    {
        if (this.Borrower != "")
        {
            Console.WriteLine($"Book: {this.Title}. {this.Author}. ISBN: {this.ISBN}. Borrower: {this.Borrower}");
        }
        else 
        { 
            Console.WriteLine($"Book: {this.Title}. {this.Author}. ISBN: {this.ISBN}."); 
        }
    }
}
//DVD: has properties such as Director, Title, and LengthInMinutes, and should be loanable for 7 days.
class DVD : ILoanable, IPrintable
{
    public DVD(string Title, string Director, int LengthInMinutes, string Borrower = "")
    {
        this.Title = Title;
        this.Director = Director;
        this.LengthInMinutes = LengthInMinutes;
        this.Borrower = Borrower;
    }
    private string whoBorrowed;
    private int maxLoanPeriodDays = 7;
    public string Director { get; set; }
    public string Title { get; set; }
    public int LengthInMinutes { get; set; }
    public int LoanPeriod
    {
        get
        {
            return maxLoanPeriodDays;
        }
    }
public string Borrower
    {
        get
        {
            return this.whoBorrowed;
        }
        set
        {
            this.whoBorrowed = value;
        }
    }

    public void Borrow(string Name, int LoanForDays)
    {
        if (this.Borrower == "" && LoanForDays <= maxLoanPeriodDays)
        {
            this.Borrower = Name;
        }
        else if (this.Borrower == "" && LoanForDays > maxLoanPeriodDays)
        {
            Console.WriteLine($"{Name}! DVD can't be borrowed more then {maxLoanPeriodDays} days.");
        }
        else
        {
            Console.WriteLine($"DVD is already borrowed by {Borrower}.");
        }
    }

    public void Return()
    {
        if (this.Borrower != "")
        {
            Console.WriteLine($"DVD {this.Title} returned by {this.Borrower}.");
            this.Borrower = "";
        }
        else
        {
            Console.WriteLine("DVD is not borrowed yet.");
        }
    }
        public void Print()
    {
        if (this.Borrower != "")
        {
            Console.WriteLine($"DVD: {this.Title}. {this.Director}. Minutes: {this.LengthInMinutes}. Borrower: {this.Borrower}");
        }
        else
        {
            Console.WriteLine($"DVD: {this.Title}. {this.Director}. Minutes: {this.LengthInMinutes}.");
        }
    }
}



//CD: has properties such as Artist, Title, and NumberOfTracks, and should be loanable for 14 days.
class CD : ILoanable, IPrintable
{
    public CD(string Title, string Artist, int NumberOfTracks, string Borrower = "")
    {
        this.Title = Title;
        this.Artist = Artist;
        this.NumberOfTracks = NumberOfTracks;
        this.Borrower = Borrower;
    }
    private string whoBorrowed;
    private int maxLoanPeriodDays = 14;
    public string Artist { get; set; }
    public string Title { get; set; }
    public int NumberOfTracks { get; set; }
    public int LoanPeriod 
    {
        get
        {
            return maxLoanPeriodDays;
        }
    //    set; 
    }
    public string Borrower
    {
        get
        {
            return this.whoBorrowed;
        }
        set
        {
            this.whoBorrowed = value;
        }
    }

    public void Borrow(string Name, int LoanForDays)
    {
        if (this.Borrower == "" && LoanForDays <= maxLoanPeriodDays)
        {
            this.Borrower = Name;
        }
        else if (this.Borrower == "" && LoanForDays > maxLoanPeriodDays)
        {
            Console.WriteLine($"{Name}! CD can't be borrowed more then {maxLoanPeriodDays} days.");
        }
        else
        {
            Console.WriteLine($"CD is already borrowed by {Borrower}.");
        }
    }

    public void Return()
    {
        if (this.Borrower != "")
        {
            Console.WriteLine($"CD {this.Title} returned by {this.Borrower}.");
            this.Borrower = "";
        }
        else
        {
            Console.WriteLine("CD is not borrowed yet.");
        }
    }
    public void Print()
    {
        if (this.Borrower != "")
        {
            Console.WriteLine($"CD: {this.Title}. {this.Artist}. Tracks: {this.NumberOfTracks}. Borrower: {this.Borrower}");
        }
        else
        {
            Console.WriteLine($"CD: {this.Title}. {this.Artist}. Tracks: {this.NumberOfTracks}.");
        }
    }
}




//Part 3: Create a Library Class
//Create a Library class that has the following properties and methods:
//Items: a list of items in the library.
//AddItem: a method that adds an item to the library.
//RemoveItem: a method that removes an item from the library.
//PrintLibrary: a method that prints out information about all items in the library.
class Library
{ 
    private List<IPrintable> LibraryItems = new List<IPrintable>();
    
    public void AddItem(IPrintable item)
    { 
        LibraryItems.Add(item);
        Console.WriteLine($"Item {item} added to the library.");
    }
    public void RemoveItem(IPrintable item)
    {
        if (LibraryItems.Contains(item))
        { 
            LibraryItems.Remove(item);
            Console.WriteLine($"Item {item} removed from the library.");
        }
        else
        { 
            Console.WriteLine($"There is no such item as {item} in the library.");
        }
    }

    public void PrintLibrary()
    {
        foreach (IPrintable item in LibraryItems)
        {
            item.Print();
        }
    }

}


//Part 4: Test Your Implementation
//In the Main method, create an instance of the Library class and add some Book, DVD, and CD objects to the library. Test that you can borrow and return items, and print out information about all items in the library.

namespace Library_App
{
    internal class Program
    {
        static void Main()
        {
            Library myLibrary = new Library();
            Book b1 = new Book("LOTR", "Tolkien", "FKJSDHF1293874");
            Book b2 = new Book("Davinchi code", "Brown", "FKJSDHF1293835");
            Book b3 = new Book("Twilight", "Mayers", "SMKJSDHF1293835");
            Book b4 = new Book("Harry Potter", "Rowling", "JRKJSDHF1293835");

            DVD d1 = new DVD("Star Wars 1", "Luckas", 123);
            DVD d2 = new DVD("My fair lady", "Cukor", 186);
            DVD d3 = new DVD("Hello Dolly", "Kelly", 148);
            DVD d4 = new DVD("Wally", "Stanton", 97);

            CD c1 = new CD("Queen. The Best", "Queen", 53);
            CD c2 = new CD("The Beatles. The Best", "Beatles", 36);
            CD c3 = new CD("ABBA. The Best", "ABBA", 30);
            CD c4 = new CD("Carpenters. The Best", "Carpenters", 20);
            myLibrary.AddItem(b1);
            myLibrary.AddItem(b2);
            myLibrary.AddItem(b3);
            myLibrary.AddItem(b4);
            myLibrary.AddItem(d1);
            myLibrary.AddItem(d2);
            myLibrary.AddItem(d3);
            myLibrary.AddItem(d4);
            myLibrary.AddItem(c1);
            myLibrary.AddItem(c2);
            myLibrary.AddItem(c3);
            myLibrary.AddItem(c4);

            
            myLibrary.PrintLibrary();
            Console.WriteLine();
            b1.Borrow("Sergey", 10);
            b1.Borrow("Misha", 30);
            b3.Borrow("Tania", 30);
            Console.WriteLine(b1.Borrower);
            d1.Borrow("Egor", 10);
            d3.Borrow("Sergey", 5);
            c1.Borrow("Sergey", 12);
            c2.Borrow("Sergey", 2);
            c4.Borrow("Sergey", 20);
            b1.Return();
            Console.WriteLine();
            myLibrary.PrintLibrary();

            Console.ReadKey();


        }
    }
}

