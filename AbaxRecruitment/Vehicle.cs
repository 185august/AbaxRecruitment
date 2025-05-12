namespace AbaxRecruitment;

public abstract class Vehicle
{
    public string RegistrationNumber { get; }
    public int Power { get; }
 

    protected Vehicle(string registrationNumber, int power)
    {
        RegistrationNumber = registrationNumber;
        Power = power;
    }

    public virtual string GetInfo()
    {
        return $"Registration number: {RegistrationNumber}, {Power}kw effect, ";
    }

    public abstract void Run();
}