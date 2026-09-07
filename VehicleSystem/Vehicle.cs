public class Vehicle
{
    public string Brand { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }
    public int MileageKm { get; set; }
    public bool IsRunning { get; set; }

    public Vehicle(string brand, string model, int year)
    {
        Brand = brand;
        Model = model;

        if (year < 1886)
        {
            throw new ArgumentException("Year 1886-dan kiçik ola bilməz.");
        }

        Year = year;
        MileageKm = 0;
        IsRunning = false;
    }

    public void StartEngine()
    {
        IsRunning = true;
        Console.WriteLine("Engine started.");
    }

    public void StopEngine()
    {
        IsRunning = false;
        Console.WriteLine("Engine stopped.");
    }

    public virtual bool Drive(int km)
    {
        if (km <= 0 || !IsRunning)
        {
            return false;
        }

        MileageKm += km;
        return true;
    }

    public virtual void VehicleInfo()
    {
        Console.WriteLine($"Type: Vehicle");
        Console.WriteLine($"Brand: {Brand}");
        Console.WriteLine($"Model: {Model}");
        Console.WriteLine($"Year: {Year}");
        Console.WriteLine($"Mileage: {MileageKm} km");
        Console.WriteLine($"Running: {(IsRunning ? "Yes" : "No")}");
    }
}