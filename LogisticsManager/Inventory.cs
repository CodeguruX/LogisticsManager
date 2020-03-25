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
    In this case, the Inventory class is made to be generic for future code changes. 
    There are far more attributes that can be listed about the item.
    
    The example program gives the option for an item code, item name, and item quantity. 
    Keeping types open will lessen the burden of code changes when more attributes are added.
    
    And minimal class changes will need to be made when said code is altered.
*/


namespace LogisticsManager
{
    public class Inventory<T, D, P>
    {
        private T firstValue;
        private D secondValue;
        private P thirdValue;

        public Inventory()
        {
        }

        public Inventory(T first, D second, P third)
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