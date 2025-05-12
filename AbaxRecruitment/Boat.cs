namespace AbaxRecruitment;

public class Boat : VehicleWithSpeed
{
    public int Weight { get; set; }
    
    public Boat(string registrationNumber, int power, int maxSpeed, string color, int weight) 
        : base(registrationNumber, power, maxSpeed, color, speedMeasurementType:"knopp")
    {
        Weight = weight;
    }
    public override string GetInfo()
    {
        return $"{base.GetInfo()} weight: {Weight}kg {Color}";
    }

}