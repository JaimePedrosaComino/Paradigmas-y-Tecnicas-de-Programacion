﻿namespace Practice1
{
    class SpeedRadar : IMessageWritter
    {
        private string plate;
        private float speed;
        private float legalSpeed = 50.0f;
        public List<float> SpeedHistory { get; private set; }

        public SpeedRadar()
        {
            plate = "";
            speed = 0f;
            SpeedHistory = new List<float>();
        }

        public void TriggerRadar(Vehicle vehicle)
        {
            plate = vehicle.GetPlate();
            speed = vehicle.GetSpeed();
            SpeedHistory.Add(speed);
        }

        public string GetLastReading()
        {
            if (speed > legalSpeed)
            {
                return WriteMessage("Caught above legal speed.");
            }
            else
            {
                return WriteMessage("Driving legally.");
            }
        }

        public bool IsAboveLegalSpeed()
        {
            return speed > legalSpeed;
        }

        public virtual string WriteMessage(string radarReading)
        {
            return $"Vehicle with plate {plate} at {speed} km/h. {radarReading}";
        }
    }
}
