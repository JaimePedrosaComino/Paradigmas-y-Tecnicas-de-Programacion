using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Vehicle
    {
        private string vehicleType;
        private string vehiclePlate;
        private int vehicleSpeed;

        public Vehicle(string vehicleType, string vehiclePlate, int vehicleSpeed)
        {
            this.vehicleType = vehicleType;
            this.vehiclePlate = vehiclePlate;
            this.vehicleSpeed = vehicleSpeed;
        }

        public override string ToString()
        { 
            return $"{GetVehicleType()} with plate {GetVehiclePlate()}";
        }

        public string GetVehicleType()
        { 
            return vehicleType; 
        }

        public string GetVehiclePlate()
        {
            return vehiclePlate;
        }

        public int GetVehicleSpeed()
        {
            return vehicleSpeed;
        }

        public void SetVehicleSpeed(int vehicleSpeed)
        { 
            this.vehicleSpeed = vehicleSpeed;
        }
    }
}
