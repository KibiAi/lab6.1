using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6
{
    public class Car : Vehicle
    {
        public Car() : base(100, 5) { }

        public override void Move()
        {
            Console.WriteLine("Автомобіль їде по дорозі.");
        }
    }
}