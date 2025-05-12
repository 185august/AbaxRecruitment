using AbaxRecruitment;

var car1 = new Car("NF123456", 147, 200, "green", "light");
var car2 = new Car("NF654321", 150, 195, "blue", "light");
var plane = new Plane( "LN1234", 1000, 30, 2,10, "Jet plane");
var boat = new Boat("ABC123", 100, 30, "BrownOrange", 500);

Console.WriteLine(car1.GetInfo());
Console.WriteLine(car2.GetInfo());
Console.WriteLine($"Are the two cars the same type? {car1.CompareVehicle(car2)}");
Console.WriteLine(plane.GetInfo());
plane.Run();
car1.Run();
Console.WriteLine(boat.GetInfo());