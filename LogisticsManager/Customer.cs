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
    The customer class is a good example of why generics are important to
    this program and in general. 
    
    At a minimum, we'll have to have a company name, address, a list of their
    current inventory, and a list of which trucks are carrying their cargo.

    We assume one truck is delivering for one company per trip, regardless
    of where they start and end their delivery.

    Companies, however, are going to need to be able to hold a list of one to
    many trucks that could be delivering their goods. With the medium scope of
    this project, we assume they are delivering to main company warehouses.

    If this project were to expand further, it would need to keep track of each
    building a company has, the address of each building, the inventory each
    building has, and a myriad of other relevant information. 

    Constructing it in this loose, generic fashion allows for further expansion
    of the program with minimal coding. It also makes possible to quickly
    customize any class code in order to better serve the needs of the customer
    in a more agile fashion. The program functions as it is, the customer can
    gain business value from it, and any upgrades they want can be delivered in
    a manner where it is already compatable with their current software and they
    can better choose in what direction the program should function based on newly
    added, fully functional, and integrated code modules.
*/

namespace LogisticsManager
{

    public class Customer<T, D, P, L, R>
    {
        private T firstValue; // Company Name
        private D secondValue; // Company ID
        private P thirdValue; // Address
        private L fourthValue; // List of currently employed trucks and the good they are carrying
        private R fifthValue; // List of the current inventory that the company has in stock


        public Customer(T first, D second, P third, L fourth, R fifth)
        {
            firstValue = first;
            secondValue = second;
            thirdValue = third;
            fourthValue = fourth;
            fifthValue = fifth;
        }

        public T FirstProperty { get; set; }
        public D SecondProperty { get; set; }
        public P ThirdProperty { get; set; }
        public L FourthProperty { get; set; }
        public R FifthProperty { get; set; }

        // L and R will be of List types so they are not to be used with the overridden ToString() method

        public override string ToString()
        {
            return this.ToString();
        }
    }
}