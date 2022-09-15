using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1._2
{
    class Plane : Vehicle
    {
        public double high { get; set; }
        public int numberPassengers { get; set; }

        public Plane(double xKoordinate, double yKoordinate, double price, string yearRelease, double high, int numberPassengers) 
            :base(xKoordinate, yKoordinate, price, yearRelease)
        {
            this.high = high;
            this.numberPassengers = numberPassengers;
        }
    }
}
