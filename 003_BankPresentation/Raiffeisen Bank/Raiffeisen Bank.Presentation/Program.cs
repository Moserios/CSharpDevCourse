using System;

class Programm
{
    static void Main()
    {
        // Display the title
        System.Console.WriteLine("************ Raiffeisen Bank ************");
        System.Console.WriteLine(":: Login Page ::");

        //declare variables to store username and password
        string userName = null, password = null;

        //read username from keyboard
        System.Console.Write("Username: ");
        userName = System.Console.ReadLine();

        //read password from keyboard only if username is entered
        if (userName != "")
        {
            System.Console.Write("Password: ");
            password = System.Console.ReadLine();
        }

        //check username and password
        if (userName == "admin" && password == "manager")
        {
            int userMenuChoice = -1;
            do
            {
                System.Console.Clear();
                //declare variable to store user chioce

                System.Console.WriteLine("::System Menu::");
                System.Console.WriteLine("1.Customers");
                System.Console.WriteLine("2.Accounts");
                System.Console.WriteLine("3.Funds transfer");
                System.Console.WriteLine("4.Funds transfer statement");
                System.Console.WriteLine("5.Account statement");
                System.Console.WriteLine("6.Loans");
                System.Console.WriteLine("0.Exit");

                System.Console.Write("Enter a choice: ");
                userMenuChoice = int.Parse(System.Console.ReadLine());

                //switch-case to check menu choice

                switch (userMenuChoice)
                {
                    case 1: CustomersMenu();
                        break;
                    case 2: AccountsMenu();
                        break;
                    case 3: //Todo
                        break;
                    case 4: //Todo
                        break;
                    case 5: //Todo
                        break;
                    case 6: //Todo
                        break;
                }
            } while (userMenuChoice != 0);
        }
        else 
        {
            System.Console.WriteLine("Invalid username or password");
        }

        //about to exit
        System.Console.WriteLine("Thank you! Visit again.");
        System.Console.ReadKey();


    }

    static void CustomersMenu()
    {
        //declare user menu choice variable
        int userMenuChoice = -1;
        do
        {
            System.Console.Clear();
            System.Console.WriteLine("::System Menu >> Customers Menu::");
            System.Console.WriteLine("1.View Customers");
            System.Console.WriteLine("2.Add Customer");
            System.Console.WriteLine("3.Update Customer");
            System.Console.WriteLine("4.Delete Customer");
            System.Console.WriteLine("0.Return to Main Menu");
            System.Console.WriteLine("");

            //User choice
            System.Console.Write("Enter choice: ");
            userMenuChoice = int.Parse(System.Console.ReadLine());

        } while (userMenuChoice != 0);

    }

    static void AccountsMenu()
    {
        //declare user menu choice variable
        int userMenuChoice = -1;
        do
        {
            System.Console.Clear();
            System.Console.WriteLine("::System Menu >> Accounts Menu::");
            System.Console.WriteLine("1.View Accounts");
            System.Console.WriteLine("2.Add Account");
            System.Console.WriteLine("3.Update Account");
            System.Console.WriteLine("4.Delete Account");
            System.Console.WriteLine("0.Return to Main Menu");
            System.Console.WriteLine("");

            //User choice
            System.Console.Write("Enter choice: ");
            userMenuChoice = int.Parse(System.Console.ReadLine());

        } while (userMenuChoice != 0);

    }
}