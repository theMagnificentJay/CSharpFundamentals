using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00_Challenges
{
    public interface IKIVehicles
    {
        string Make { get; }
        string Model { get; }
        string Color { get; }
        bool IsStarted { get; }
        bool IsOff { get; }
        bool IsDriving { get; }

        string StartVehicle();

        string TurnOffVehicle();

        string StartDrivingVehicle();
    }
}
