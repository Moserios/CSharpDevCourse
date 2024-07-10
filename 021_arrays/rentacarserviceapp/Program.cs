using RentACarService;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Remoting.Lifetime;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
namespace RentACarService
{
    class Program
    {
        static void Main()
        {
           Car car1 = new Car("Ford", "C-MAX", 50, false);
           Car car2 = new Car("Hundai", "Santa Fe", 80, false);
           Car car3 = new Car("Toyota", "Prius", 60, false);
           Car car4 = new Car("VolksWagen", "Golf 5", 40, false);

            Car[] carlist = new Car[] { car1, car2, car3, car4 };

            Console.WriteLine("Welcome to the Rent a Car service!");

            private static void availableCars()
            {
                
                Console.WriteLine("\nCars available:");
                foreach (Car car in carlist)
                {
                    if (car.Rent() is false)
                    {
                        Console.WriteLine(car.CarInfo());
                        Console.WriteLine();
                    }
                }
            

            Console.WriteLine("Cars available:");

            
            Console.ReadKey();

        }
    }
}




//Create a Main method that does the following:

//Creates a collection of Car objects.

//Displays a menu with the following options:

//Rent a car: prompts the user for a car to rent, and calls the Rent method on that car.

//Return a car: prompts the user for a car to return, and calls the Return method on that car.

//View available cars: prints information about all cars that are not currently rented, using the PrintInfo method.

//Exit: ends the program.

//Repeat the menu until the user chooses to exit.



//Constraints
//Your program should meet the following constraints:

//The user interface should be clear and easy to use. Use descriptive menu options and clear prompts to guide the user through the program.

//The program should handle invalid user input gracefully. For example, if the user enters a non-existent car ID, the program should display an error message and return to the menu.

//The program should be well-organized and easy to read. Use meaningful variable names, clear formatting, and comments to make your code easy to understand.

//Your code should be properly documented with comments explaining the purpose and functionality all important pieces of the code.



//Example Output
//Here's an example of what your program output might look like:

//Welcome to the car rental system!
 
//Menu:
//1.Rent a car
//2. Return a car
//3. View available cars
//4. Exit
 
//Please enter your choice: 1


//Rent a Car:
//1.Toyota Corolla(Rental price: 50 / day) - Available
//2.Honda Civic(Rental price: 60 / day) - Available
//3.Ford Mustang(Rental price: 80 / day) - Available
//Please enter the ID of the car you want to rent: 1


//Rented the Toyota Corolla for $50/day.
 
//Menu:
//1.Rent a car
//2. Return a car
//3. View available cars
//4. Exit
 
//Please enter your choice: 1


//Rent a Car:
//1.Toyota Corolla(Rental price: 50 / day) - Rented
//2.Honda Civic(Rental price: 60 / day) - Available
//3.Ford Mustang(Rental price: 80 / day) - Available
//Please enter the ID of the car you want to rent: 1


//Sorry, the selected car is not available for rent.
 
//Menu:
//1.Rent a car
//2. Return a car
//3. View available cars
//4. Exit
 
//Please enter your choice: 3


//Available cars:
//1.Toyota Corolla(Rental price: 50 / day) - Rented
//2.Honda Civic(Rental price: 60 / day) - Available
//3.Ford Mustang(Rental price: 80 / day) - Available
//Menu:
//1.Rent a car
//2. Return a car
//3. View available cars
//4. Exit
 
//Please enter your choice: 1


//Rent a Car:
//1.Toyota Corolla(Rental price: 50 / day) - Rented
//2.Honda Civic(Rental price: 60 / day) - Available
//3.Ford Mustang(Rental price: 80 / day) - Available
//Please enter the ID of the car you want to rent: 4


//Sorry, the selected car is not available for rent.
 
//Menu:
//1.Rent a car
//2. Return a car
//3. View available cars
//4. Exit
 
//Please enter your choice: 2


//Return a Car:
//1.Toyota Corolla(Rental price: 50 / day) - Rented
//2.Honda Civic(Rental price: 60 / day) - Available
//3.Ford Mustang(Rental price: 80 / day) - Available
//Please enter the ID of the car you want to return: 1


//Returned the Toyota Corolla.
 
//Menu:
//1.Rent a car
//2. Return a car
//3. View available cars
//4. Exit
 
//Please enter your choice: 3


//Available cars:
//1.Toyota Corolla(Rental price: 50 / day) - Available
//2.Honda Civic(Rental price: 60 / day) - Available
//3.Ford Mustang(Rental price: 80 / day) - Available
//Menu:
//1.Rent a car
//2. Return a car
//3. View available cars
//4. Exit
 
//Please enter your choice: 4
//Thank you for using the car rental system!