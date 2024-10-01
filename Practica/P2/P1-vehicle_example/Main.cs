namespace Practice1
{
    internal class Program
    {
        static void Main()
        {
            PoliceStation station = new PoliceStation("Central Station");
            City city = new City("Metropolis", station);

            Taxi taxi1 = new Taxi("0001 AAA");
            Taxi taxi2 = new Taxi("0002 BBB");
            city.RegisterTaxi(taxi1);
            city.RegisterTaxi(taxi2);

            PoliceCar policeCar1 = new PoliceCar("0001 CNP", station);
            PoliceCar policeCar2 = new PoliceCar("0002 CNP", station);

            policeCar1.StartPatrolling();
            policeCar1.UseRadar(taxi1);

            taxi2.StartRide();
            policeCar2.UseRadar(taxi2);
            policeCar2.StartPatrolling();
            policeCar2.UseRadar(taxi2);
            taxi2.StopRide();
            policeCar2.EndPatrolling();

            taxi1.StartRide();
            policeCar1.UseRadar(taxi1);
            taxi1.StopRide();
            policeCar1.EndPatrolling();

            policeCar1.PrintRadarHistory();
            policeCar2.PrintRadarHistory();
        }
    }
}
