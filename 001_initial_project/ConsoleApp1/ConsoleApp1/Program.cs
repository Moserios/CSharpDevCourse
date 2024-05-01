using System;
using System.Net.NetworkInformation;
using System.Reflection;

class CsharpSection2
{

    // Variables, Operations, Conditions, Control statements (Loops+)
    static void Main(string[] args)
    {
        // Calculate Circumference for radius
        float r = 5;
        float PI = 3.14159f;
        float circ = PI * r * r;
        System.Console.WriteLine("Circumference of the radius 5 is: " + circ);

        // Convert man's height in feet and inches to centimeters
        //Formula:
        //1 inch = 2.54 cm
        //1 feet = 12 inches
        float inch_cm = 2.54f;
        float feet_cm = inch_cm * 12;
        int height_inches = 1;
        int height_feet = 6;

        float cm_height = height_feet * feet_cm + height_inches * inch_cm;
        System.Console.WriteLine("Height of 6 feet 1 inch is " + cm_height + " cm.");


        //Write a C# program to get nearest thousand of given integer number.
        //If the number's last three digits are greater than or equal to 500; it should "round up" the number.
        //If the number's last three digits are less than 500; it should "round down" the number.
        //If the number is less than 500; it should round up to 1000.

        System.Console.WriteLine("Enter any number. Last 3 digits will be rounded.");
        string number = System.Console.ReadLine();
        double fnumber = Convert.ToDouble(number);
        double last3digits = fnumber / 1000;
        int left_digits = (int)(fnumber / 1000);
        int three_digits = (int)((last3digits - left_digits) * 1000);
        int rounded = (three_digits >= 500) ? 1000 : 0;
        System.Console.WriteLine(left_digits * 1000 + rounded);


        //Write a C# program to print the number of years, days, hours, minutes, seconds - based on given number of seconds.
        System.Console.WriteLine("Enter any number of seconds to convert to Years, Days, Hours, Minutes, Seconds.");
        string secondsGiven = System.Console.ReadLine();
        decimal secNumber = Convert.ToDecimal(secondsGiven);
        decimal secLeft = secNumber;

        int secInYear = 60 * 60 * 24 * 365;
        int secInDay = 60 * 60 * 24;
        int secInHour = 60 * 60;
        int secInMinute = 60;

        decimal years = (int)(secLeft / secInYear);
        secLeft -= secInYear * years;

        int days = (int)(secLeft / secInDay);
        secLeft -= secInDay * days;

        int hours = (int)(secLeft / secInHour);
        secLeft -= secInHour * hours;

        int minutes = (int)(secLeft / secInMinute);
        secLeft -= secInMinute * minutes;

        System.Console.WriteLine("The given number " + secNumber + " of seconds is equivalent to "
            + years + " years, "
            + days + " days, "
            + hours + " hours, "
            + minutes + " minutes, "
            + secLeft + " seconds.");
        System.Console.ReadKey();


        // Create a conditional check of the height
        //Height categories:
        //Height is less than 150 cm = "Dwarf"
        //Height is between 150 cm and 165 cm = "Average height"
        //Height is between 165 cm and 195 cm = "Tall"
        //Height is above 195 cm = "Abnormal height"

        //Note: 1 inch = 2.54 centimeter
        //You need to convert the input value(inches) into centimeters.

        System.Console.WriteLine("Enter a height of the create in INCHES to define what is it?");
        double inch_height = Convert.ToDouble(System.Console.ReadLine());
        double inchCm = 2.54;
        double height = inch_height * inchCm;

        if (height < 150)
        {
            System.Console.WriteLine("Dwarf");
        }
        else if (height >= 150 && height < 165)
        {
            System.Console.WriteLine("Average height");
        }
        else if (height >= 165 && height < 195)
        {
            System.Console.WriteLine("Tall");
        }
        else
        {
            System.Console.WriteLine("Abnormal height");
        }

        System.Console.ReadKey();


        //Write a C# program to find out largest number among three numbers, using "if".

        System.Console.WriteLine("Enter first of three numbers to compare");
        double first = Convert.ToDouble(System.Console.ReadLine());
        System.Console.WriteLine("Enter second of three numbers to compare");
        double second = Convert.ToDouble(System.Console.ReadLine());
        System.Console.WriteLine("Enter third of three numbers to compare");
        double third = Convert.ToDouble(System.Console.ReadLine());

        if (first > second && first > third)
        {
            System.Console.WriteLine("The biggest number is " + first);
        }
        else if (second > first && second > third)
        {
            System.Console.WriteLine("The biggest number is " + second);
        }
        else
        {
            System.Console.WriteLine("The biggest number is " + third);
        }
        System.Console.ReadKey();


        //Write a C# program to print the following output by using 'for' loop, 'break' and 'continue' statements

        //Each number should be printed by using the loop variable.
        //Don't print full line at-a-time as string.
        //For example, don't write statements as:
        //System.Console.WriteLine("1 2 3 4 7 8 9 10");
        //Use for loop, break and continue statements to bring the output.

        //Write a C# program to print the following output:
        //1 2 3 4 7 8 9 10
        //1 2 3 4 7 8 9 10
        //1 2 3 4 7 8 9 10
        //10 9 8 7 6 5 4 3 2 1
        //10 9 8 7 6 5 4 3 2 1
        //10 9 8 7 6 5 4 3
        //10 9 8 7 6 5 4 3 2 1
        //1 2 3 4 5 6 7 9 10

        int i;
        int j;
        int l = 11;

        for (i = 1; i <= 8; i++)
        {
            for (j = 1; j <= 10; j++)
            {
                if (i <= 3)
                {
                    if (j >= 5 && j <= 6)
                    {
                        continue;
                    }
                    System.Console.Write(j + " ");
                }
                else if (i == 8)
                {
                    if (j == 8)
                    { 
                        continue; 
                    }
                    System.Console.Write(j + " ");
                }
                else
                {
                    if ( i == 6 && j >= 9 )
                    {
                        break;
                    }
                    System.Console.Write(( l - j ) + " ");
                }
            }
            System.Console.WriteLine();
        }
        System.Console.ReadKey();
    }

}