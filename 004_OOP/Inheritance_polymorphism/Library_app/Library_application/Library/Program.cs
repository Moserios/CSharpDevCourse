//Part 3: Test Your Implementation
//This Main() method creates objects of the CD, DVD, and Book classes and sets their properties to some example values.
//It then calls the Print() method on each object to display information about it.
//Invoke other methods such as Borrow() and Return() on applicable objects.

public class Program
{
    public static void Main()
    {
        Book book1 = new Book("Tolkien", "Lord of the Rings", "Story about magic powers in fantasy world of MiddleEarth", 21);
        CD cd1 = new CD("Queen", "Innuendo", "Pop Rock album, one of the best of Queen", 14);
        DVD dvd1 = new DVD("Audrey Hepburn", "How to steal a million", "Art crime comedy", 7);

        //BOOK
        System.Console.WriteLine(book1.Print());
        System.Console.WriteLine(book1.Borrower);
        book1.Return();
        book1.Borrow("Sergey", 21, "1990-10-10");
        System.Console.WriteLine(book1.Print());
        System.Console.WriteLine(book1.Borrower);
        book1.Borrow("Moser", 21, "2024-06-09");
        book1.Return();

        //CD
        System.Console.WriteLine(cd1.Print());
        cd1.Return();
        cd1.Borrow("Mahdi", 15, "1970-10-10");
        System.Console.WriteLine(cd1.MaxLoanPeriod);
        cd1.Borrow("Mahdi", 14, "1970-10-10");


        //DVD
        System.Console.WriteLine(dvd1.Print());
        dvd1.Return();
        System.Console.WriteLine(dvd1.MaxLoanPeriod);
        dvd1.Borrow("Satia", 7, "2024-06-09");
        dvd1.Print();

        System.Console.ReadKey();
    }
}

