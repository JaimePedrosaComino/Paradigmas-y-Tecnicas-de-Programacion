using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Practice1
{
    internal class PoliceStation
    {
        private List<PoliceCar> policeCars;
        public string Name { get; private set; }

        public PoliceStation(string name)
        {
            Name = name;
            policeCars = new List<PoliceCar>();
        }

        public void RegisterPoliceCar(PoliceCar car)
        {
            policeCars.Add(car);
            Console.WriteLine($"Police car {car.GetPlate()} registered at {Name} station.");
        }

        public void ActivateAlert(string offendingPlate)
        {
            Console.WriteLine($"Alert: Vehicle with plate {offendingPlate} detected speeding!");
            foreach (var car in policeCars)
            {
                if (car.IsPursuing())
                {
                    car.PursueVehicle(offendingPlate);
                }
            }
        }
    }
}
