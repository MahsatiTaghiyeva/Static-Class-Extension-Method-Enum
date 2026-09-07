public class Car : Vehicle
{
    public double FuelCapacityLiters { get; set; }
    public double FuelLiters { get; set; }
    public double FuelConsumptionPer100Km { get; set; }

    public Car(
        string brand,
        string model,
        int year,
        double fuelCapacityLiters,
        double fuelConsumptionPer100Km,
        double initialFuelLiters
    ) : base(brand, model, year)
    {
        if (fuelCapacityLiters <= 0)
        {
            throw new ArgumentException("Fuel capacity 0-dan böyük olmalıdır.");
        }

        if (fuelConsumptionPer100Km <= 0)
        {
            throw new ArgumentException("Fuel consumption 0-dan böyük olmalıdır.");
        }

        if (initialFuelLiters < 0 || initialFuelLiters > fuelCapacityLiters)
        {
            throw new ArgumentException("Initial fuel düzgün deyil.");
        }

        FuelCapacityLiters = fuelCapacityLiters;
        FuelConsumptionPer100Km = fuelConsumptionPer100Km;
        FuelLiters = initialFuelLiters;
    }

    public bool Refuel(double liters)
    {
        if (liters <= 0 || FuelLiters + liters > FuelCapacityLiters)
        {
            return false;
        }

        FuelLiters += liters;
        return true;
    }

    public override bool Drive(int km)
    {
        if (km <= 0 || !IsRunning)
        {
            return false;
        }

        double requiredLiters =
            (km / 100.0) * FuelConsumptionPer100Km;

        if (FuelLiters < requiredLiters)
        {
            return false;
        }

        FuelLiters -= requiredLiters;
        MileageKm += km;

        return true;
    }

    public override void VehicleInfo()
    {
        Console.WriteLine($"Type: Car");
        Console.WriteLine($"Brand: {Brand}");
        Console.WriteLine($"Model: {Model}");
        Console.WriteLine($"Year: {Year}");
        Console.WriteLine($"Mileage: {MileageKm} km");
        Console.WriteLine($"Running: {(IsRunning ? "Yes" : "No")}");
        Console.WriteLine(
            $"Fuel: {FuelLiters:F1}L / {FuelCapacityLiters:F1}L"
        );
    }
}