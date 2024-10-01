using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Taxi: Vehicle
    {
        private bool withPassengers;
        public Taxi (string vehiclePlate) : base (vehiclePlate, "Taxi", 0)
        {
            withPassengers = false;
            SetVehicleSpeed(45);
            Console.WriteLine($"{ToString()}: Created");
        }

        public bool onRide() 
        { 
            return withPassengers; 
        }

        public void setPassengers(bool withPassengers)
        { 
            this.withPassengers = withPassengers;
        }

        public void StartRide()
        {
            string finalLine = "";
            if (onRide())
            {
                finalLine = "is already in a ride.";
            }
            else 
            {
                SetVehicleSpeed(100);
                setPassengers(true);
                finalLine = "starting a ride.";
            }
            Console.WriteLine($"{ToString()}: {finalLine}");
        }

        public void StopRide()
        {
            string finalLine = "";
            if (onRide())
            {
                SetVehicleSpeed(45);
                setPassengers(false);
                finalLine = "finishes the ride.";
            }
            Console.WriteLine($"{ToString()}: {finalLine}");
        }
    }
}
