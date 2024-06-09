//Create an application that models a library. The library has different types of items such as books, DVDs, and CDs. Your task is to create interfaces and classes that represent these items, and implement methods that are appropriate for each item.

//Part 1: Create Interfaces
//First, create the following interfaces:

//ILoanable: defines the properties and methods that an item that can be borrowed should have.
//This should include properties such as LoanPeriod and Borrower, as well as methods such as Borrow and Return.

using System;

interface ILonable
{
    string Title { get; set; }
    string Creator { get; set; }
    string Description { get; set; }
    int MaxLoanPeriod { get; set; }
    DateTime BorrowDate { get; set; }
    string Borrower { get; set; }
    void Borrow(string borrower, int borrowPeriod, string borrowDate);
    void Return();

}

//IPrintable: defines the method Print, which should print out information about the item.
interface IPrintable
{
    string Print();
}


//Part 2: Create Classes
//Next, create classes that implement the ILoanable and IPrintable interfaces for the following types of items:
//Book: has properties such as Author, Title, and ISBN, and should be loanable for 21 days.
//DVD: has properties such as Director, Title, and LengthInMinutes, and should be loanable for 7 days.
//CD: has properties such as Artist, Title, and NumberOfTracks, and should be loanable for 14 days.
//Each class should implement the ILoanable and IPrintable interfaces in a way that is appropriate for that item.

public abstract class Item : ILonable, IPrintable
{
    internal string _author = "";
    internal string _title = "";
    internal string _description = "";
    internal int _maxLoanPeriod;
    internal int _borrowPeriod;
    internal DateTime _borrowDate;
    internal string _borrower = "Library";


    public string Creator
    {
        get { return _author; }
        set { _author = value; }
    }
    public string Title
    {
        get { return _title; }
        set { _title = value; }
    }
    public string Description
    {
        get { return _description; }
        set { _description = value; }
    }
    public int MaxLoanPeriod
    {
        get
        { return _maxLoanPeriod; }
        set
        {
            if (value <= 21)
            { _maxLoanPeriod = value; }
            else
            { _maxLoanPeriod = 21; }
        }
    }
    public int BorrowPeriod
    {
        get
        { return this._borrowPeriod; }
        set
        {
            if (value <= this.MaxLoanPeriod)
            {
                this._borrowPeriod = value;
            }
            else
            {
                _borrowPeriod = MaxLoanPeriod;
            }
        }
    }
    public DateTime BorrowDate
    {
        get
        { return _borrowDate; }
        set
        { _borrowDate = value; }
    }

    public string Borrower
    {
        set
        { _borrower = value; }
        get
        {
            if (this._borrowDate.ToString().Length > 1)
            { return this._borrower; }
            else { return $"In the library"; }
        }
    }

    public Item(string Author, string Title, string Description, int MaxBorrowPeriod)
    {
        this.Creator = Author;
        this.Title = Title;
        this.Description = Description;
        this.MaxLoanPeriod = MaxBorrowPeriod;
    }

    public void Borrow(string borrower, int borrowPeriod, string borrowDate)
    {
        if (this.Borrower != "Library")
        { System.Console.WriteLine($"Sorry. You can't borrow this item, it's still borrowed by {this.Borrower}.\n");  }
        else if (borrowPeriod <= this.MaxLoanPeriod)
        {
            this.Borrower = borrower;
            this.BorrowPeriod = borrowPeriod;
            this.BorrowDate = Convert.ToDateTime(borrowDate);
            System.Console.WriteLine($"{this.Title} is successfully borrowed by " +
                $"{this.Borrower} " +
                $"for {this.BorrowPeriod} days " +
                $"starting from {this.BorrowDate}.\n");
        }
        else
        {
            System.Console.WriteLine($"Sorry. You can't borrow this item longer than {this.MaxLoanPeriod} days.\n");
        }
    }

    public void Return()
    {
        if (this.Borrower != "Library")
        {
            this.Borrower = "Library";
            this.BorrowPeriod = 0;
            this.BorrowDate = Convert.ToDateTime("1970-01-01");
            System.Console.WriteLine($"{this.Title} successfully returned to the library.\n");
        }
        else 
        {
            System.Console.WriteLine($"{this.Title} already in the library.\n");
        }
    }

    public virtual string Print()
    {
        if (this._borrower != "Library")
        {
            string text = $"{this.Title}\n" +
                $"by {this._author}\n" +
                $"{this._description}\n" +
                $"is borrowed by {this.Borrower}\n" +
                $"on {this.BorrowDate}\n" +
                $"for {this._borrowPeriod} days.\n";
            return text;
        }
        else
        {
            string text = $"{this.Title}\n" +
                 $"by {this._author}\n" +
                 $"{this._description}\n" +
                 $"is in the library.\n";
            return text;
        }
    }
}

public class Book : Item
{
    public Book(
        string Author,
        string Title,
        string Description,
        int MaxBorrowPeriod) :
    base(Author, Title, Description, MaxBorrowPeriod)

    {
        this.Creator = Author;
        this.Title = Title;
        this.Description = Description;
        this.MaxLoanPeriod = MaxBorrowPeriod;
    }

    public override string Print()
    {
        string newText = $"Book\n{base.Print()}";
        System.Console.WriteLine(newText);
        return null;
    }
}

public class CD : Item
{
    public CD(
        string Author,
        string Title,
        string Description,
        int MaxBorrowPeriod) :
    base(Author, Title, Description, MaxBorrowPeriod)

    {
        this.Creator = Author;
        this.Title = Title;
        this.Description = Description;
        this.MaxLoanPeriod = MaxBorrowPeriod;
    }

    public override string Print()
    {
        string newText = $"CD\n{base.Print()}";
        System.Console.WriteLine(newText);
        return null;
    }
}

public class DVD : Item
{
    public DVD(
        string Author,
        string Title,
        string Description,
        int MaxBorrowPeriod) :
    base(Author, Title, Description, MaxBorrowPeriod)

    {
        this.Creator = Author;
        this.Title = Title;
        this.Description = Description;
        this.MaxLoanPeriod = MaxBorrowPeriod;
    }
    public override string Print()
    {
        string newText = $"DVD\n{base.Print()}";
        System.Console.WriteLine(newText);
        return null;
    }
}