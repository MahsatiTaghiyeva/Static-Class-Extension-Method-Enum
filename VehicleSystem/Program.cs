Car car = new Car(
    "Toyota",
    "Corolla",
    2018,
    50,
    7.5,
    20
);

car.VehicleInfo();

car.StartEngine();

Console.WriteLine($"Drive: {car.Drive(100)}");

car.VehicleInfo();

Console.WriteLine($"Refuel: {car.Refuel(10)}");

car.VehicleInfo();

car.StopEngine();

Console.WriteLine("--------------------------------");

ElectricCar electricCar = new ElectricCar(
    "Tesla",
    "Model 3",
    2023,
    60,
    15,
    30
);

electricCar.VehicleInfo();

electricCar.StartEngine();

Console.WriteLine($"Drive: {electricCar.Drive(120)}");

electricCar.VehicleInfo();

Console.WriteLine($"Charge: {electricCar.Charge(10)}");

electricCar.VehicleInfo();

electricCar.StopEngine();

Console.WriteLine("--------------------------------");

// POLYMORPHISM

Vehicle v = new ElectricCar(
    "BMW",
    "i4",
    2024,
    80,
    18,
    50
);

v.StartEngine();

Console.WriteLine($"Drive with polymorphism: {v.Drive(120)}");

v.VehicleInfo();

v.StopEngine();