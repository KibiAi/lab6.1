using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6
{
    public class Bus : Vehicle
    {
        public Bus() : base(60, 40) { }

        public override void Move()
        {
            Console.WriteLine("Автобус їде з пасажирами.");
        }
    }
}
