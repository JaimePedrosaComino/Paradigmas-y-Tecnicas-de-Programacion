namespace Practice1
{
    internal class City
    {
        private List<Taxi> taxis;
        public PoliceStation PoliceStation { get; private set; }
        public string Name { get; private set; }

        public City(string name, PoliceStation policeStation)
        {
            Name = name;
            PoliceStation = policeStation;
            taxis = new List<Taxi>();
        }

        public void RegisterTaxi(Taxi taxi)
        {
            taxis.Add(taxi);
            Console.WriteLine($"Taxi with plate {taxi.GetPlate()} registered in {Name}.");
        }

        public void RemoveTaxi(string plate)
        {
            var taxiToRemove = taxis.FirstOrDefault(t => t.GetPlate() == plate);
            if (taxiToRemove != null)
            {
                taxis.Remove(taxiToRemove);
                Console.WriteLine($"Taxi with plate {plate} removed from {Name}.");
            }
        }
    }
}
