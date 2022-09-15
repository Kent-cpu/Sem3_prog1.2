using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1._2
{
    class Vehicle
    {
        public double xKoordinate { get; set; }
        public double yKoordinate { get; set; }
        public double price { get; set; }
        public string yearRelease { get; set; }


        public Vehicle(double xKoordinate, double yKoordinate, double price, string yearRelease)
        {
            this.xKoordinate = xKoordinate;
            this.yKoordinate = yKoordinate;
            this.price = price;
            this.yearRelease = yearRelease;
        }
    }
}
