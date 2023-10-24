using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    class Bus : Vehicle
    {
        public Bus() : base(80, 30) { }

        public override void Move()
        {
            Console.WriteLine("Автобус перевозить пасажирів.");
        }
    }
}
