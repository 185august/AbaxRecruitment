namespace AbaxRecruitment;

public class VehicleWithSpeed : Vehicle
{
    public int MaxSpeed { get; set; }
    public string Color { get; set; }
    public string SpeedMeasurementType { get; set; }
    
    protected VehicleWithSpeed(string registrationNumber, int power, int maxSpeed, string color, string speedMeasurementType) : base(registrationNumber, power)
    {
        MaxSpeed = maxSpeed;
        Color = color;
        SpeedMeasurementType = speedMeasurementType;
    }
    public override string GetInfo() => 
        $"{base.GetInfo()}, max speed: {MaxSpeed}{SpeedMeasurementType}";

    public string GetColor() => 
        $"color: {Color}";

    public override void Run() => 
        Console.WriteLine("Running");
}