using System.Collections.Generic;
using System;

public class RentalAgency
{
    public List<Vehicle> Fleet = new List<Vehicle>();
    public decimal TotalRevenue { get; private set; }

    public void AddVehicle(Vehicle vehicle)
    {
        Fleet.Add(vehicle);
    }

    public bool RemoveVehicle(Vehicle vehicle)
    {
        return Fleet.Remove(vehicle);
    }

    public void RentVehicle(Vehicle vehicle, int days)
    {
        if (Fleet.Contains(vehicle))
        {
            TotalRevenue += vehicle.RentalPrice * days;
            Console.WriteLine($"Vehicle rented for {days} days. Total cost: {vehicle.RentalPrice * days}");
        }
        else
        {
            Console.WriteLine("Vehicle not available in the fleet.");
        }
    }
}
