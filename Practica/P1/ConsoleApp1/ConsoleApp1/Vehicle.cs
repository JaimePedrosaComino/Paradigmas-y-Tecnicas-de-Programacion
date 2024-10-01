using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1
{
    internal class Vehicle
    {
        private string vehicle_type;
        private string vehicle_plate;
        private int vehicle_speed;

        public Vehicle(string vehicle_type, string vehicle_plate, int vehicle_speed)
        {
            this.vehicle_type = vehicle_type;
            this.vehicle_plate = vehicle_plate;
            this.vehicle_speed = vehicle_speed;
        }

        public override string ToString() 
        {
            return $"{GetVehicleType()} with plate {GetVehiclePlate()}";
        }

        public string GetVehicleType()
        { 
            return vehicle_type ; 
        }

        public string GetVehiclePlate()
        { 
            return vehicle_plate ; 
        }

        public int GetVehicleSpeed()
        { 
            return vehicle_speed; 
        }

        public void SetVehicleSpeed(int vehicle_speed)
        { 
            this.vehicle_speed = vehicle_speed;
        }
    }
}
