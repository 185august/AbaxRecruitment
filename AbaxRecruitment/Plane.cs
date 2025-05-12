namespace AbaxRecruitment;

public class Plane : Vehicle
{
    public int Wingspan { get; }
    public int LoadWight { get; set; }
    public int Wight { get; set; }
    public string VehicleType { get; }

    public Plane(string registrationNumber, int power, int wingspan, int loadWight, int wight , string vehicleType) 
        : base(registrationNumber, power)
    {
        VehicleType = vehicleType;
        LoadWight = loadWight;
        Wight = wight;
        Wingspan = wingspan;
    }
    
    public override string GetInfo()
    {
        return $"{base.GetInfo()} wingspan: {Wingspan}, load wight: {LoadWight}tonn, wight: {Wight}tonn, plane type: {VehicleType}";
    }

    public override void Run()
    {
        Console.WriteLine("Flying");
    }
}