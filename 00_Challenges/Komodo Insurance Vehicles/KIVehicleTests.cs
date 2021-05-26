using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace _00_Challenges
{
    [TestClass]
    public class KIVehicleTests
    {
        [TestMethod]
        public void StartVehicleTest()
        {
            Sedan vehicle = new Sedan("Black", "Dodge", "Charger");
            var output = vehicle.StartVehicle();
            Console.WriteLine(output);

            Console.WriteLine("Vehicle is started: " + vehicle.IsStarted);
            Assert.IsTrue(vehicle.IsStarted);
        }

        [TestMethod]
        public void TurnOffVehicleTest()
        {
            Sedan vehicle = new Sedan("Black", "Dodge", "Charger");
            var output = vehicle.TurnOffVehicle();
            Console.WriteLine(output);

            Console.WriteLine("Vehicle is on: " + vehicle.IsStarted);
            Assert.IsFalse(vehicle.IsStarted);
        }

        [TestMethod]
        public void StartDrivingVehicleTest()
        {
            Sedan vehicle = new Sedan("Black", "Dodge", "Charger");
            vehicle.StartVehicle();
            var output = vehicle.StartDrivingVehicle();
            Console.WriteLine(output);

            Console.WriteLine("Vehicle is driving: " + vehicle.IsDriving);
            Assert.IsTrue(vehicle.IsDriving);
        }
    }
}
