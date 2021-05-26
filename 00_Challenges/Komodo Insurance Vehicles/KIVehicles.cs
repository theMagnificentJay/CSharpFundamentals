using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00_Challenges
{
    public class Sedan : IKIVehicles
    {
        public string Make { get; }

        public string Model { get; }

        public string Color { get; }

        public bool IsStarted { get; private set; }
        public bool IsOff { get; private set; }
        public bool IsDriving { get; private set; }

        public Sedan(string color, string make, string model)
        {
            Color = color;
            Make = make;
            Model = model;
        }

        public string StartVehicle()
        {
            if (IsStarted)
            {
                return $"{Color} {Make} {Model} is already started.";
            }
            else
            {
                IsStarted = true;
                return $"Started {Color} {Make} {Model}.";
            }
        }
        public string TurnOffVehicle()
        {
            if (IsStarted)
            {
                IsStarted = false;
                // IsOff = true;
                return $"{Color} {Make} {Model} turned off.";
            }
            else
            {
                return $"{Color} {Make} {Model} already off.";
            }
        }
        public string StartDrivingVehicle()
        {
            if (IsDriving)
            {
                return $"{Color} {Make} {Model} already driving.";
            }
            else if (IsStarted)
            {
                IsDriving = true;
                return $"{Color} {Make} {Model} now driving.";
            }
            else
            {
                return $"Make sure {Color} {Make} {Model} is first ready to drive.";
            }
        }
    }

    public class SUV : IKIVehicles
    {
        public string Make { get; }

        public string Model { get; }

        public string Color { get; }

        public bool IsStarted { get; private set; }
        public bool IsOff { get; private set; }
        public bool IsDriving { get; private set; }
        public SUV(string color, string make, string model)
        {
            Color = color;
            Make = make;
            Model = model;
        }

        public string StartVehicle()
        {
            if (IsStarted)
            {
                return $"{Color} {Make} {Model} is already started.";
            }
            else
            {
                IsStarted = true;
                return $"Started {Color} {Make} {Model}.";
            }
        }
        public string TurnOffVehicle()
        {
            if (IsStarted)
            {
                IsStarted = false;
                // IsOff = true;
                return $"{Color} {Make} {Model} turned off.";
            }
            else
            {
                return $"{Color} {Make} {Model} already off.";
            }
        }
        public string StartDrivingVehicle()
        {
            if (IsDriving)
            {
                return $"{Color} {Make} {Model} already driving.";
            }
            else if (IsStarted)
            {
                IsDriving = true;
                return $"{Color} {Make} {Model} now driving.";
            }
            else
            {
                return $"Make sure {Color} {Make} {Model} is first ready to drive.";
            }
        }
    }

    public class Motorcycle : IKIVehicles
    {
        public string Make { get; }

        public string Model { get; }

        public string Color { get; }

        public bool IsStarted { get; private set; }
        public bool IsOff { get; private set; }
        public bool IsDriving { get; private set; }

        public Motorcycle(string color, string make, string model)
        {
            Color = color;
            Make = make;
            Model = model;
        }

        public string StartVehicle()
        {
            if (IsStarted)
            {
                return $"{Color} {Make} {Model} is already started.";
            }
            else
            {
                IsStarted = true;
                return $"Started {Color} {Make} {Model}.";
            }
        }
        public string TurnOffVehicle()
        {
            if (IsStarted)
            {
                IsStarted = false;
                // IsOff = true;
                return $"{Color} {Make} {Model} turned off.";
            }
            else
            {
                return $"{Color} {Make} {Model} already off.";
            }
        }
        public string StartDrivingVehicle()
        {
            if (IsDriving)
            {
                return $"{Color} {Make} {Model} already driving.";
            }
            else if (IsStarted)
            {
                IsDriving = true;
                return $"{Color} {Make} {Model} now driving.";
            }
            else
            {
                return $"Make sure {Color} {Make} {Model} is first ready to drive.";
            }
        }
    }

    public class Truck : IKIVehicles
    {
        public string Make { get; }

        public string Model { get; }

        public string Color { get; }

        public bool IsStarted { get; private set; }
        public bool IsOff { get; private set; }
        public bool IsDriving { get; private set; }

        public Truck(string color, string make, string model)
        {
            Color = color;
            Make = make;
            Model = model;
        }

        public string StartVehicle()
        {
            if (IsStarted)
            {
                return $"{Color} {Make} {Model} is already started.";
            }
            else
            {
                IsStarted = true;
                return $"Started {Color} {Make} {Model}.";
            }
        }
        public string TurnOffVehicle()
        {
            if (IsStarted)
            {
                IsStarted = false;
                // IsOff = true;
                return $"{Color} {Make} {Model} turned off.";
            }
            else
            {
                return $"{Color} {Make} {Model} already off.";
            }
        }
        public string StartDrivingVehicle()
        {
            if (IsDriving)
            {
                return $"{Color} {Make} {Model} already driving.";
            }
            else if (IsStarted)
            {
                IsDriving = true;
                return $"{Color} {Make} {Model} now driving.";
            }
            else
            {
                return $"Make sure {Color} {Make} {Model} is first ready to drive.";
            }
        }
    }

    public class Coupe : IKIVehicles
    {
        public string Make { get; }

        public string Model { get; }

        public string Color { get; }

        public bool IsStarted { get; private set; }
        public bool IsOff { get; private set; }
        public bool IsDriving { get; private set; }

        public Coupe(string color, string make, string model)
        {
            Color = color;
            Make = make;
            Model = model;
        }

        public string StartVehicle()
        {
            if (IsStarted)
            {
                return $"{Color} {Make} {Model} is already started.";
            }
            else
            {
                IsStarted = true;
                return $"Started {Color} {Make} {Model}.";
            }
        }
        public string TurnOffVehicle()
        {
            if (IsStarted)
            {
                IsStarted = false;
                // IsOff = true;
                return $"{Color} {Make} {Model} turned off.";
            }
            else
            {
                return $"{Color} {Make} {Model} already off.";
            }
        }
        public string StartDrivingVehicle()
        {
            if (IsDriving)
            {
                return $"{Color} {Make} {Model} already driving.";
            }
            else if (IsStarted)
            {
                IsDriving = true;
                return $"{Color} {Make} {Model} now driving.";
            }
            else
            {
                return $"Make sure {Color} {Make} {Model} is first ready to drive.";
            }
        }
    }

    public class Van : IKIVehicles
    {
        public string Make { get; }

        public string Model { get; }

        public string Color { get; }

        public bool IsStarted { get; private set; }
        public bool IsOff { get; private set; }
        public bool IsDriving { get; private set; }

        public Van(string color, string make, string model)
        {
            Color = color;
            Make = make;
            Model = model;
        }

        public string StartVehicle()
        {
            if (IsStarted)
            {
                return $"{Color} {Make} {Model} is already started.";
            }
            else
            {
                IsStarted = true;
                return $"Started {Color} {Make} {Model}.";
            }
        }
        public string TurnOffVehicle()
        {
            if (IsStarted)
            {
                IsStarted = false;
                // IsOff = true;
                return $"{Color} {Make} {Model} turned off.";
            }
            else
            {
                return $"{Color} {Make} {Model} already off.";
            }
        }
        public string StartDrivingVehicle()
        {
            if (IsDriving)
            {
                return $"{Color} {Make} {Model} already driving.";
            }
            else if (IsStarted)
            {
                IsDriving = true;
                return $"{Color} {Make} {Model} now driving.";
            }
            else
            {
                return $"Make sure {Color} {Make} {Model} is first ready to drive.";
            }
        }
    }
}
