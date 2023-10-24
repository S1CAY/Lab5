using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    abstract class Vehicle
    {
        public double Speed { get; set; }
        public int Capacity { get; set; }

        public Vehicle(double speed, int capacity)
        {
            Speed = speed;
            Capacity = capacity;
        }

        public abstract void Move();

        public virtual void BoardPassengers(int passengers)
        {
            if (passengers <= Capacity)
            {
                Console.WriteLine($"Посадили {passengers} пасажирів.");
            }
            else
            {
                Console.WriteLine($"Помилка: недостатньо місць для {passengers} пасажирів.");
            }
        }

        public virtual void DisembarkPassengers(int passengers)
        {
            if (passengers <= Capacity)
            {
                Console.WriteLine($"Висадили {passengers} пасажирів.");
            }
            else
            {
                Console.WriteLine($"Помилка: неможливо висадити {passengers} пасажирів.");
            }
        }
    }

}
