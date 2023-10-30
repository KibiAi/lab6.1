using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Human
{
    public int Speed { get; set; }

    public Human(int speed)
    {
        Speed = speed;
    }

    public void Move()
    {
        Console.WriteLine("Людина рухається пішки.");
    }
}
