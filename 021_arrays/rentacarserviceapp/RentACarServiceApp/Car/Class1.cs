﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Lifetime;
using System.Text;
using System.Threading.Tasks;

namespace RentACarService
{
    public class Car
    {
        private string make;
        private string model;
        private decimal rentalPrice;
        private bool rented;

        public Car(string make, string model, decimal rentalPrice, bool rented)
        {
            this.make = make;
            this.model = model;
            this.rentalPrice = rentalPrice;
            this.rented = rented;
        }

        public string Make
        {
            get
            { return this.make; }
            set
            { this.make = make; }
        }
        public string Model
        {
            get
            { return this.model; }
            set
            { this.model = model; }
        }
        public decimal RentalPrice
        {
            get
            { return this.RentalPrice; }
            set
            { this.rentalPrice = rentalPrice; }
        }
        public bool Rented 
        {
            get
            { return this.rented; }
            set
            { this.rented = rented; }
        }

        public bool Rent()
        {
            if (this.rented is false)
            {
                this.rented = true;
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Return()
        {
            if (this.rented)
            {
                this.rented = false;
                return true;
            }
            else
            {
                return false;
            }
        }

        public string CarInfo()
        {
            string carAvailability = "";
            
                if (this.rented)
                carAvailability = "Rented";
                else
                carAvailability = "Available";
            
            return
                $"{this.make} {this.model}  (Rental price: {this.rentalPrice}/day) - {carAvailability}.";
        }
    }
}



//You should create a Car class that has private fields for the make, model, rental price, and availability status(rented or not rented), as well as public methods for renting and returning a car, and printing information about a car.

//Your program should also include a Main method that creates a collection of Car objects, and allows the user to rent and return cars, as well as view information about available cars.



//Requirements
//Your program should meet the following requirements:

//Create a Car class with the following private fields:

//make(string)

//model(string)

//rentalPrice(decimal)

//rented(bool)



//Create the following public methods in the Car class:

//Rent: sets the rented field to true if the car is not currently rented, and returns true if the rental was successful. If the car is already rented, it should display an error message and return false.

//Return: sets the rented field to false if the car is currently rented, and returns true if the return was successful. If the car is not currently rented, it should display an error message and return false.

//PrintInfo: prints the car's make, model, rental price, and availability status (based on the rented field) to the console.


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