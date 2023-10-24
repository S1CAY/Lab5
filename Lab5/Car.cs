using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    class Car : Vehicle
    {
        public Car() : base(120, 4) { }

        public override void Move()
        {
            Console.WriteLine("Автомобіль рухається по дорозі.");
        }
    }
}
