using lab6;

class Program
{
    static void Main()
    {
        TransportNetwork network = new TransportNetwork();
        Car car = new Car();
        Bus bus = new Bus();
        Train train = new Train();

        network.AddVehicle(car);
        network.AddVehicle(bus);
        network.AddVehicle(train);

        network.ControlTraffic();

        Route route = new Route("Місто Київ", "Місто Львів");
        route.CalculateOptimalRoute(car);

        Human person = new Human(5);
        person.Move();

        Console.ReadLine();
    }
}