using System;
using System.Diagnostics;
using System.Runtime.ConstrainedExecution;

class Program
{
    static void Main(string[] args)
    {
        // Create instances of each vehicle type
        Car car = new Car("Model 251", "Toyota", 2024, 150, 5, "Electric", "Automatic", true);
        Truck truck = new Truck("Ford Focus", "Ford", 2019, 150, 1000, "Pickup", true);
        Motorcycle motorcycle = new Motorcycle("S-351", "Mitsubishi", 2022, 100, 650, "Petrol", true);

        // Create an instance of the RentalAgency
        RentalAgency rentalAgency = new RentalAgency();
        rentalAgency.AddVehicle(car);
        rentalAgency.AddVehicle(truck);
        rentalAgency.AddVehicle(motorcycle);

        // Display details of each vehicle in the fleet
        foreach (Vehicle vehicle in rentalAgency.Fleet)
        {
            vehicle.DisplayDetails();
            Console.WriteLine();
        }

        // Example of renting a vehicle and updating total revenue
        int rentalDays = 5; // Example: renting the car for 5 days. Adjust this value as needed.

        rentalAgency.RentVehicle(car, rentalDays);
        Console.WriteLine($"Total Revenue: {rentalAgency.TotalRevenue}\n");

        // Example of removing a vehicle from the fleet
        rentalAgency.RemoveVehicle(truck);

        // Update the display of the fleet after removing the truck
        Console.WriteLine("Updated Fleet:");
        foreach (Vehicle vehicle in rentalAgency.Fleet)
        {
            vehicle.DisplayDetails();
            Console.WriteLine();
        }

    }
}
