public class RentalAgency
{
    private List<Vehicle> fleet = new List<Vehicle>();
    public decimal TotalRevenue { get; private set; }

    public void AddVehicle(Vehicle vehicle)
    {
        fleet.Add(vehicle);
    }

    public bool RemoveVehicle(Vehicle vehicle)
    {
        return fleet.Remove(vehicle);
    }

    public void RentVehicle(string model)
    {
        var vehicle = fleet.FirstOrDefault(v => v.Model == model);
        if (vehicle != null)
        {
            fleet.Remove(vehicle);
            TotalRevenue += vehicle.RentalPrice;
            Console.WriteLine($"{model} has been rented.");
        }
        else
        {
            Console.WriteLine($"{model} is not available for rent.");
        }
    }

    public void DisplayFleet()
    {
        foreach (var vehicle in fleet)
        {
            vehicle.DisplayDetails();
        }
    }
}
