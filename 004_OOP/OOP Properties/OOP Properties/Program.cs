//Create a C# program with a class called DebitCard with a property called "Pin" with validations in the set accessor.
//The Pin should be exactly 4 digits or 6 digits.
//If the supplied pin is invalid, it shows error message.


//Examples:
//Pin = "1234"-- > valid
//Pin = "1234ef"-- > invalid
//Pin = "123456"-- > valid
//Pin = "0"-- > invalid
//Pin = "a4"-- > invalid

public class Program
{
    public static void Main()
    {
        DebitCard card1 = new DebitCard("1234");
        DebitCard card2 = new DebitCard("1234ef");
        DebitCard card3 = new DebitCard("123456");
        DebitCard card4 = new DebitCard("0");
        DebitCard card5 = new DebitCard("a4");
        System.Console.ReadKey();
    }
}

