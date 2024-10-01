using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class PoliceCar : Vehicle
    {
        private bool patrolling;
        private SpeedRadar radar;

        public PoliceCar(string vehiclePlate) : base(vehiclePlate, 'Police Car', 0)
        {
            patrolling = false;
            radar = new SpeedRadar();
            Console.WriteLine($"{ToString()}: Created.");
        }

        public bool onPatrol()
        {
            return patrolling;
        }

        public void measuredSpeed(Vehicle vehicle)
        {
            if (onPatrol())
            {
                int speed = radar.measuredSpeed(vehicle);
                string finalLine = "";
                if (speed > radar.GetMaximumSpeed)
                {
                    finalLine = "Catched above legal speed.";
                }
                else
                {
                    finalLine = "Driving legally.";
                }
                Console.WriteLine($"{ToString()}: Trigged radar. Result: {vehicle.ToString()} at {speed} km/h. {finalLine}");
            }
            else
            {
                Console.WriteLine($"{ToString()} has no active radar.2");
            }
    }
}
