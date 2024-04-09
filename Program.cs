using Mediator1;

public class Program
{
    public static void Main()
    {
        IControlTower controlTower = new ControlTower();

        //Register 2 runways
        controlTower.RegisterRunway(new Runway("R1"));
        controlTower.RegisterRunway(new Runway("R2"));

        var airplane1 = new Airplane("JK", controlTower);
        var airplane2 = new Airplane("TM", controlTower);

        airplane1.RequestLanding();
        airplane2.RequestLanding();

        Console.ReadKey();
    }

}
