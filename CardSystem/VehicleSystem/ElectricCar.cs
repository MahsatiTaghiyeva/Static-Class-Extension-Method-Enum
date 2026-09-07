public class ElectricCar : Vehicle
{
    public double BatteryCapacityKWh { get; set; }
    public double BatteryKWh { get; set; }
    public double ConsumptionKWhPer100Km { get; set; }

    public ElectricCar(
        string brand,
        string model,
        int year,
        double batteryCapacityKWh,
        double consumptionKWhPer100Km,
        double initialBatteryKWh
    ) : base(brand, model, year)
    {
        if (batteryCapacityKWh <= 0)
        {
            throw new ArgumentException("Battery capacity 0-dan böyük olmalıdır.");
        }

        if (consumptionKWhPer100Km <= 0)
        {
            throw new ArgumentException("Consumption 0-dan böyük olmalıdır.");
        }

        if (initialBatteryKWh < 0 ||
            initialBatteryKWh > batteryCapacityKWh)
        {
            throw new ArgumentException("Initial battery düzgün deyil.");
        }

        BatteryCapacityKWh = batteryCapacityKWh;
        ConsumptionKWhPer100Km = consumptionKWhPer100Km;
        BatteryKWh = initialBatteryKWh;
    }

    public bool Charge(double kwh)
    {
        if (kwh <= 0 || BatteryKWh + kwh > BatteryCapacityKWh)
        {
            return false;
        }

        BatteryKWh += kwh;
        return true;
    }

    public override bool Drive(int km)
    {
        if (km <= 0 || !IsRunning)
        {
            return false;
        }

        double requiredKWh =
            (km / 100.0) * ConsumptionKWhPer100Km;

        if (BatteryKWh < requiredKWh)
        {
            return false;
        }

        BatteryKWh -= requiredKWh;
        MileageKm += km;

        return true;
    }

    public override void VehicleInfo()
    {
        Console.WriteLine($"Type: ElectricCar");
        Console.WriteLine($"Brand: {Brand}");
        Console.WriteLine($"Model: {Model}");
        Console.WriteLine($"Year: {Year}");
        Console.WriteLine($"Mileage: {MileageKm} km");
        Console.WriteLine($"Running: {(IsRunning ? "Yes" : "No")}");
        Console.WriteLine(
            $"Battery: {BatteryKWh:F1}kWh / {BatteryCapacityKWh:F1}kWh"
        );
    }
}