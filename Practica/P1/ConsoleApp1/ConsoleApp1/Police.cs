using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1
{
    internal class Police : Vehicle
    {
        private bool onPatrol;
        private Radar radar;
        public Police(string vehicle_plate) : base(vehicle_plate, "Police Car", 0)
        {
            onPatrol = false;
            radar = new Radar();
            Console.WriteLine($"{ToString()}: Created");
        }

        public void measured_Speed(Vehicle vehicle)
        {
            if (onPatrol)
            {
                int speed = radar.measured_Speed(vehicle);
                string result_line = "";
                if (speed > radar.GetMaximumLegalSpeed())
                {
                    result_line = "Catched above legal speed.";
                }
                else
                {
                    result_line = "Driving legally.";
                }
                Console.WriteLine($"{ToString()}: Triggered radar. Result: {vehicle.ToString()} at {speed} km/h. {result_line}");
            }
            else
            {
                Console.WriteLine($"{ToString()}: has no active radar.");
            }
        }

        public bool OnPatrol() 
        { 
            return onPatrol; 
        }
        public void PatrolStart()
        {
            string result_line = "";
            if (onPatrol)
            {
                result_line = "is already patrolling";

            }
            else
            {
                onPatrol = true;
                result_line = "started patrolling";
            }
            Console.WriteLine($"{ToString()}: {result_line}");
        }
        public void PatrolStop()
        {
            string result_line = "";
            if (onPatrol)
            {
                onPatrol = false;
                result_line = "stopped patrolling";
            }
            else
            {
                result_line = "wasn't patrolling";
            }
            Console.WriteLine($"{ToString()}: {result_line}");
        }

        public void SpeedHistory()
        {
            List<int> list = radar.GetMeasuredSpeeds();
            Console.WriteLine($"{ToString()}: Report radar history:");
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }
        }
    }
}
