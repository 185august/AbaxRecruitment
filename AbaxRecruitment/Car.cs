namespace AbaxRecruitment;

public class Car : VehicleWithSpeed
{
    private bool IsLightVehicle { get; }
    public Car(string registrationNumber, int power, int maxSpeed, string color, string vehicleType) 
        : base(registrationNumber, power, maxSpeed, color, speedMeasurementType:"km/h")
    {
        IsLightVehicle = vehicleType == "light";
    }
    
    public override string GetInfo()
    {
        return $"{base.GetInfo()} {base.GetColor()}, {(IsLightVehicle? "Light vehicle": "")} ";
    }

    public bool CompareVehicle(Car vehicle)
    {
        return IsLightVehicle == vehicle.IsLightVehicle;
    }
    public override void Run()
    {
        Console.WriteLine("Driving");
    }
}