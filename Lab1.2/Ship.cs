using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1._2
{
    class Ship: Vehicle
    {
        public int numberPassengers { get; set; }
        public string homePort { get; set; }

        public Ship(double xKoordinate, double yKoordinate, double price, string yearRelease, int numberPassengers, string homePort)
            : base(xKoordinate, yKoordinate, price, yearRelease)
        {
            this.numberPassengers = numberPassengers;
            this.homePort = homePort;
        }
    }
}
