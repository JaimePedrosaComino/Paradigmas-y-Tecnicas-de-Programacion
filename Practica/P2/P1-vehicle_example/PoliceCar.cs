namespace Practice1
{
    class PoliceCar : Vehicle
    {
        private const string typeOfVehicle = "Police Car";
        private bool isPatrolling;
        private bool isPursuing;
        private SpeedRadar speedRadar;
        private PoliceStation policeStation;

        public PoliceCar(string plate, PoliceStation station) : base(typeOfVehicle, plate)
        {
            isPatrolling = false;
            isPursuing = false;
            speedRadar = new SpeedRadar();
            policeStation = station;
            policeStation.RegisterPoliceCar(this);
        }

        public void UseRadar(Vehicle vehicle)
        {
            if (isPatrolling)
            {
                speedRadar.TriggerRadar(vehicle);
                string measurement = speedRadar.GetLastReading();
                Console.WriteLine(WriteMessage($"Triggered radar. Result: {measurement}"));
                if (speedRadar.IsAboveLegalSpeed())
                {
                    policeStation.ActivateAlert(vehicle.GetPlate());
                    PursueVehicle(vehicle.GetPlate());
                }
            }
            else
            {
                Console.WriteLine(WriteMessage("has no active radar."));
            }
        }

        public void PursueVehicle(string offendingPlate)
        {
            if (isPatrolling && !isPursuing)
            {
                isPursuing = true;
                Console.WriteLine(WriteMessage($"is now pursuing vehicle with plate {offendingPlate}."));
            }
        }

        public bool IsPursuing()
        {
            return isPursuing;
        }

        public void StartPatrolling()
        {
            if (!isPatrolling)
            {
                isPatrolling = true;
                Console.WriteLine(WriteMessage("started patrolling."));
            }
            else
            {
                Console.WriteLine(WriteMessage("is already patrolling."));
            }
        }

        public void EndPatrolling()
        {
            if (isPatrolling)
            {
                isPatrolling = false;
                Console.WriteLine(WriteMessage("stopped patrolling."));
                isPursuing = false;
            }
            else
            {
                Console.WriteLine(WriteMessage("was not patrolling."));
            }
        }

        public void PrintRadarHistory()
        {
            Console.WriteLine(WriteMessage("Report radar speed history:"));
            foreach (float speed in speedRadar.SpeedHistory)
            {
                Console.WriteLine(speed);
            }
        }
    }
}
