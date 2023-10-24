using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    class TransportNetwork
    {
        private List<Vehicle> vehicles;
        private Route currentRoute;

        public TransportNetwork()
        {
            vehicles = new List<Vehicle>();
            currentRoute = null;
        }

        public void AddVehicle(Vehicle vehicle)
        {
            vehicles.Add(vehicle);
        }

        public void SetRoute(Route route)
        {
            currentRoute = route;
        }

        public void MoveVehicles()
        {
            if (currentRoute != null)
            {
                foreach (var vehicle in vehicles)
                {
                    Console.WriteLine($"Транспортний засіб {vehicle.GetType().Name} рухається з точки {currentRoute.StartPoint} до {currentRoute.EndPoint}.");
                    vehicle.Move();
                    vehicle.DisembarkPassengers(5);
                    vehicle.BoardPassengers(10);
                }
            }
            else
            {
                Console.WriteLine("Помилка: маршрут не визначений.");
            }
        }
    }

}
