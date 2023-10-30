using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6
{
    public class Train : Vehicle
    {
        public Train() : base(120, 200) { }

        public override void Move()
        {
            Console.WriteLine("Поїзд прямує по рельсам.");
        }
    }
}