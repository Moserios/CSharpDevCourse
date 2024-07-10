using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using RentACarService;

namespace RentACarServiceApp
{
    internal class Program
    {
        public static void RentACar(Car[] carlist)
            {
            int rentChoice = -1;
            int counter = 0;
            Console.Clear();
            Console.WriteLine("\nAvailable cars:");
            foreach (Car car in carlist)
            {
                Console.WriteLine($"{counter + 1}. {car.CarInfo()}");
                counter++;
            }
            do
            {
                Console.Write("\nPlease enter car ID: ");
                bool success = int.TryParse(Console.ReadLine(), out rentChoice);
            } while ((rentChoice - 1) > carlist.Length || (rentChoice - 1) < 0);

            if (carlist[rentChoice - 1].Rented == false)
            {
                bool isCarRented = carlist[rentChoice - 1].Rent();
                //Console.WriteLine($"Is car rented: {isCarRented}");
                //Console.WriteLine($"Is car rented: {carlist[rentChoice - 1].Rented}");
                if (isCarRented == true)
                {
                    Console.WriteLine($"Car {carlist[rentChoice - 1].Make} {carlist[rentChoice - 1].Make} successfully rented.");
                }
                else
                {
                    Console.WriteLine($"Something is wrong!!!");
                }
            }
            else 
            {
                Console.WriteLine($"Sorry {carlist[rentChoice - 1].Make} {carlist[rentChoice - 1].Model} is not available for rent.");
            }
            
            Console.WriteLine($"Press any key to return to main menu.");
            Console.ReadKey();

        }
         
        public static void ReturnACar(Car[] carlist)
        {
            int returnChoice = -1;
            int counter = 0;
            Console.Clear();
            Console.WriteLine("\nReturn a car:");
            
            int totalCarsRented = 0;
            foreach (Car car in carlist)
            {
                if (car.Rented is true)
                {
                    totalCarsRented++;
                }
            }

            Car[] rentedCars = new Car[totalCarsRented];
            int newArrayCounter = 0;
            for (int i = 0; i < carlist.Length; i++)
            {
                if (carlist[i].Rented == true)
                {
                    rentedCars[newArrayCounter] = carlist[i];
                    newArrayCounter++;
                }
            }

            foreach (Car car in rentedCars)
            {
                    Console.WriteLine($"{counter + 1}. {car.CarInfo()}");
                    counter++;
            }

            do
            {
                Console.Write("\nPlease enter car ID you want to return: ");
                bool success = int.TryParse(Console.ReadLine(), out returnChoice);
            }while ((returnChoice - 1) > rentedCars.Length || (returnChoice - 1) < 0);


            if (rentedCars[returnChoice - 1].Rented is true)
            {
                rentedCars[returnChoice - 1].Return();
                Console.WriteLine($"Car {rentedCars[returnChoice - 1].Make} {rentedCars[returnChoice - 1].Make} successfully returned.");
            }
            else
            {
                Console.WriteLine($"Sorry {rentedCars[returnChoice - 1].Make} {rentedCars[returnChoice - 1].Model} is not rented.");
            }
            Console.WriteLine($"Press any key to return to main menu.");
            Console.ReadKey();

        }


        public static void ViewCars(Car[] carlist)
        {
            int counter = 0;
            Console.Clear();
            Console.WriteLine("\nCars available:");
            foreach (Car car in carlist)
            {
                if (car.Rented is false)
                {
                    Console.WriteLine($"{counter + 1}. {car.CarInfo()}");
                    counter++;
                }
            }
            Console.WriteLine($"Press any key to return to main menu.");
            Console.ReadKey();
        }

        static void Main()
        {
            Car car1 = new Car("Ford", "C-MAX", 50, false);
            Car car2 = new Car("Hundai", "Santa Fe", 80, false);
            Car car3 = new Car("Toyota", "Prius", 60, false);
            Car car4 = new Car("VolksWagen", "Golf 5", 40, false);
            Car car5 = new Car("Lexus", "RX 400", 90, false);
            Car[] carlist = new Car[] { car1, car2, car3, car4, car5 };
             

            int userChoice = -1;
            do
            {
                Console.Clear();
                Console.WriteLine("Welcome to the car rental system!");
                Console.WriteLine("\n -- Menu -- ");
                Console.WriteLine("\n1. Rent a car");
                Console.WriteLine("2. Return a car");
                Console.WriteLine("3. View available cars");
                Console.WriteLine("4. Exit");
                Console.Write("\n\nPlease enter your choice: ");
                bool success = int.TryParse(Console.ReadLine(), out userChoice);

                switch (userChoice)
                {
                    case 1:
                        RentACar(carlist);
                        break;
                    case 2:
                        ReturnACar(carlist);
                        break;
                    case 3:
                        ViewCars(carlist);
                        break;
                }
            }
            while (userChoice != 4); 

            Console.WriteLine("\nThank you! Visit again.");
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