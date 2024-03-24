using System;
using System.Diagnostics;
using System.Runtime.ConstrainedExecution;

class Program
{
    static void Main(string[] args)
    {
        var rentalAgency = new RentalAgency();

        // Adding vehicles to the fleet
        rentalAgency.AddVehicle(new Car("Model S", "Tesla", 2020, 99.99m, 5, "Electric", "Automatic", true));
        rentalAgency.AddVehicle(new Truck("F-150", "Ford", 2019, 129.99m, 2.0m, "Pickup", true));
        rentalAgency.AddVehicle(new Motorcycle("Ninja ZX-6R", "Kawasaki", 2021, 69.99m, 636, "Petrol", true));

        Console.WriteLine("Fleet before renting:");
        rentalAgency.DisplayFleet();

        // Renting a vehicle
        Console.WriteLine("\nRenting a vehicle...");
        rentalAgency.RentVehicle("Model S");

        Console.WriteLine("\nFleet after renting:");
        rentalAgency.DisplayFleet();

        // Displaying total revenue
        Console.WriteLine($"\nTotal Revenue: {rentalAgency.TotalRevenue:C}");
    }
}
