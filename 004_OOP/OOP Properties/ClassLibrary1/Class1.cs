//Create a C# program with a class called DebitCard with a property called "Pin" with validations in the set accessor.
//The Pin should be exactly 4 digits or 6 digits.
//If the supplied pin is invalid, it shows error message.


//Examples:
//Pin = "1234"-- > valid
//Pin = "1234ef"-- > invalid
//Pin = "123456"-- > valid
//Pin = "0"-- > invalid
//Pin = "a4"-- > invalid

using System.Diagnostics.Tracing;
using System.Net.NetworkInformation;

public class DebitCard
{
    private int _pin;

    public string Pin
    {
        
        get { return System.Convert.ToString(_pin); }
    
        set 
        {
            bool a = int.TryParse(value, out int validPin);

            if (value.Length == 4 || value.Length == 6)
                if (a is true)
                {
                    _pin = validPin;
                    System.Console.WriteLine($"{value} --> valid");
                }
                else
                {
                    System.Console.WriteLine($"{value} --> invalid");
                }
            else 
            {
                System.Console.WriteLine($"{value} --> invalid");
            }
        }

    }

    public DebitCard(string pin)
    {
        this.Pin = pin;
    }

}