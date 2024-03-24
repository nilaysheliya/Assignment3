public class Vehicle
{
    private string model;
    private string manufacturer;
    private int year;
    private decimal rentalPrice;

    public string Model { get => model; set => model = value; }
    public string Manufacturer { get => manufacturer; set => manufacturer = value; }
    public int Year { get => year; set => year = value; }
    public decimal RentalPrice { get => rentalPrice; set => rentalPrice = value; }

    public Vehicle(string model, string manufacturer, int year, decimal rentalPrice)
    {
        this.model = model;
        this.manufacturer = manufacturer;
        this.year = year;
        this.rentalPrice = rentalPrice;
    }

    public virtual void DisplayDetails()
    {
        Console.WriteLine($"Model: {Model}, Manufacturer: {Manufacturer}, Year: {Year}, Rental Price: {RentalPrice}");
    }
}
