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
    a List of its current inventory. and the location (or customer)
    it is currently assigned to.
 */

namespace LogisticsManager
{
    public class Truck<T, D, P, L>
    {
        private T firstValue; // License Plate
        private D secondValue; // VIN Number
        private P thirdValue; // List of current inventory
        private L fourthValue; // Currently assigned customer


        public Truck(T first, D second, P third, L fourth)
        {
            firstValue = first;
            secondValue = second;
            thirdValue = third;
            fourthValue = fourth;
        }

        public T FirstProperty { get; set; }
        public D SecondProperty { get; set; }
        public P ThirdProperty { get; set; }
        public L FourthProperty { get; set; }

        public override string ToString()
        {
            return this.ToString();
        }
    }
}
