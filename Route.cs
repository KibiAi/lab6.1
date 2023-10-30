using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6
{
    public class Route
    {
        public string StartPoint { get; set; }
        public string EndPoint { get; set; }

        public Route(string startPoint, string endPoint)
        {
            StartPoint = startPoint;
            EndPoint = endPoint;
        }

        public void CalculateOptimalRoute(Vehicle vehicle)
        {
            if (vehicle is Car)
            {
                Console.WriteLine($"Розрахований оптимальний маршрут для автомобіля з {StartPoint} до {EndPoint}.");
            }
            else if (vehicle is Bus)
            {
                Console.WriteLine($"Розрахований оптимальний маршрут для автобуса з {StartPoint} до {EndPoint}.");
            }
            else if (vehicle is Train)
            {
                Console.WriteLine($"Розрахований оптимальний маршрут для поїзда з {StartPoint} до {EndPoint}.");
            }
        }
    }
}