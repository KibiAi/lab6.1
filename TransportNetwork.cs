using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6
{
    public class TransportNetwork
    {
        private List<Vehicle> vehicles;

        public TransportNetwork()
        {
            vehicles = new List<Vehicle>();
        }

        public void AddVehicle(Vehicle vehicle)
        {
            vehicles.Add(vehicle);
        }

        public void ControlTraffic()
        {
            foreach (Vehicle vehicle in vehicles)
            {
                vehicle.Move();
            }
        }
    }
}