using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1._2
{
    class Car: Vehicle
    {

        public Car(double xKoordinate, double yKoordinate, double price, string yearRelease)
            : base(xKoordinate, yKoordinate, price, yearRelease)
        {        }

    }
}
