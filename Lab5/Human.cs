using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    class Human
    {
        public double Speed { get; set; }

        public Human(double speed)
        {
            Speed = speed;
        }

        public void Move()
        {
            Console.WriteLine("Людина рухається пішки.");
        }
    }
}
