using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    class Train : Vehicle
    {
        public Train() : base(200, 200) { }

        public override void Move()
        {
            Console.WriteLine("Поїзд рухається по залізниці.");
        }

        public override void BoardPassengers(int passengers)
        {
            if (passengers <= Capacity)
            {
                Console.WriteLine($"Пасажири сіли в поїзд. Кількість пасажирів: {passengers}");
            }
            else
            {
                Console.WriteLine($"Помилка: недостатньо місць для {passengers} пасажирів.");
            }
        }
    }
}
