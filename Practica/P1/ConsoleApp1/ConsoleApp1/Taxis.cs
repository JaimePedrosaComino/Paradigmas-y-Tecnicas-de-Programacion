using Practica1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_1
{
    internal class Taxi : Vehicle
    {
        private bool with_passengers;
        public Taxi(string vehicle_plate) : base(vehicle_plate, "Taxi", 0)
        {
            with_passengers = false;
            SetVehicleSpeed(45);
            Console.WriteLine($"{ToString()}: Created");
        }

        public bool OnRide()
        { 
            return with_passengers; 
        }

        public void SetPassengers(bool passengers)
        {
            with_passengers = passengers;
        }

        public void StartRide()
        {
            string result_line = "";
            if (OnRide())
            {
                result_line = "is already in a ride.";
            }
            else 
            {
                SetVehicleSpeed(100);
                SetPassengers(true);
                result_line = "starting a ride.";
            }
            Console.WriteLine($"{ToString()}: {result_line}");
        }

        public void StopRide()
        {
            string result_line = "";
            if (OnRide())
            {
                SetVehicleSpeed(45);
                SetPassengers(false);
                result_line = "finished the ride.";
            }
            Console.WriteLine($"{ToString()}: {result_line}");
        }
    }
}
