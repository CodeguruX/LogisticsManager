using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
    The Truck class, like all other classes in this example program, 
    will remain generic for the same reason of code management.

    It may easily be expanded upon later to have many other attributes
    that one would find useful to list about a delivery truck.

    Here, we're sticking to license plate number, vin number,
    and the make/model of the vehicle.
 */

namespace LogisticsManager
{
    public class Truck<T, D, P>
    {
        private T firstValue; // License Plate
        private D secondValue; // VIN Number
        private P thirdValue; // Make and Model of Vehicle

        public Truck(T first, D second, P third)
        {
            firstValue = first;
            secondValue = second;
            thirdValue = third;
        }

        public T FirstProperty { get; set; }
        public D SecondProperty { get; set; }
        public P ThirdProperty { get; set; }
    }
}
