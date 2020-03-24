using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogisticsManager
{
    public partial class form_LogisticsManagerMain : Form
    {
        public form_LogisticsManagerMain()
        {
            InitializeComponent();
        }

        private void button_SubmitInventory_Click(object sender, EventArgs e)
        {
            
            Inventory<string, string, int> inventoryItem = new Inventory<string, string, int>();

            inventoryItem.FirstProperty = textBox_InventoryName.Text;
            inventoryItem.SecondProperty = textBox_InventoryId.Text;
            inventoryItem.ThirdProperty = Int32.Parse(textBox_InventoryQuantity.Text);

            label_InventoryName.Text = inventoryItem.FirstProperty + "-" + inventoryItem.SecondProperty + "-" + inventoryItem.ThirdProperty;
        }

        private void textBox_InventoryQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            // KeyChar 8 is backspace, allowing them to edit the number

            if (e.KeyChar != 8 && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void button_ClearAll_Click(object sender, EventArgs e)
        {
            textBox_InventoryId.Text = "";
            textBox_InventoryName.Text = "";
            textBox_InventoryQuantity.Text = "1";
        }
    }
}
