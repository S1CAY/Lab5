using System;
using System.Collections.Generic;

namespace Lab5
{

    class Program
    {
        static void Main(string[] args)
        {
            TransportNetwork network = new TransportNetwork();

            Car car = new Car();
            Bus bus = new Bus();
            Train train = new Train();

            network.AddVehicle(car);
            network.AddVehicle(bus);
            network.AddVehicle(train);

            Route route = new Route("Пункт A", "Пункт B");
            network.SetRoute(route);

            network.MoveVehicles();
        }
    }
}