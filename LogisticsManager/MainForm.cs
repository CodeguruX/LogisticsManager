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
            try
            {

                Inventory<string, string, int> inventoryItem = new Inventory<string, string, int>()
                {
                    FirstProperty = textBox_InventoryName.Text,
                    SecondProperty = textBox_InventoryId.Text,
                    ThirdProperty = Int32.Parse(textBox_InventoryQuantity.Text)
                };

                if (inventoryItem.FirstProperty == "" || inventoryItem.SecondProperty == "" || textBox_InventoryQuantity.Text == "")
                {
                    throw new System.Exception();
                }

                checkedListBox_CurrentInventory.Items.Add(inventoryItem, false);
                checkedListBox_CurrentInventory.DisplayMember = "FirstProperty";
            }
            catch (Exception)
            {
                MessageBox.Show("Must Enter Inventory Name, ID, and Quantity", "Insufficient Data");
            }
            
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

        private void button_DeleteChecked_Click(object sender, EventArgs e)
        {
            foreach (var item in checkedListBox_CurrentInventory.CheckedItems.OfType<Inventory<string, string, int>>().ToList())
            {
                checkedListBox_CurrentInventory.Items.Remove(item);
            }
        }

        private void checkedListBox_CurrentInventory_SelectedIndexChanged(object sender, EventArgs e)
        {
            Inventory<string, string, int> selectedInventory;
            
            
            selectedInventory = (Inventory<string, string, int>)checkedListBox_CurrentInventory.SelectedItem;

            if (selectedInventory != null)
            {
                try
                {
                    this.textBox_InventoryCurrentNameOfSelectedItem.Text = selectedInventory.FirstProperty;
                }
                catch (Exception)
                {

                }

                try
                {
                    this.textBox_InventoryCurrentIdOfSelectedItem.Text = selectedInventory.SecondProperty;
                }
                catch (Exception)
                {

                }

                try
                {
                    this.textBox_InventoryCurrentQuantityOfSelectedItem.Text = selectedInventory.ThirdProperty.ToString();
                }
                catch (Exception)
                {

                }
            }
        }


        private void textBox_InventoryNewQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            // KeyChar 8 is backspace, allowing them to edit the number

            if (e.KeyChar != 8 && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void button_InventorySaveChangesToSelectedItem_Click(object sender, EventArgs e)
        {
            int i = 0;
            Inventory<string, string, int> selectedInventory = new Inventory<string, string, int>();

            try
            { 

                if ( textBox_InventoryNewName.Text == ""  || textBox_InventoryNewID.Text == "" || textBox_InventoryNewQuantity.Text == "")
                {
                    throw new System.Exception();
                }

                selectedInventory.FirstProperty = textBox_InventoryNewName.Text;
                selectedInventory.SecondProperty = textBox_InventoryNewID.Text;
                selectedInventory.ThirdProperty = Int32.Parse(textBox_InventoryNewQuantity.Text);

                i = this.checkedListBox_CurrentInventory.SelectedIndex;
                this.checkedListBox_CurrentInventory.Items[i] = selectedInventory;

                if (selectedInventory != null)
                {
                    try
                    {
                        textBox_InventoryCurrentNameOfSelectedItem.Text = selectedInventory.FirstProperty;
                    }
                    catch (Exception)
                    {

                    }

                    try
                    {
                        textBox_InventoryCurrentIdOfSelectedItem.Text = selectedInventory.SecondProperty;
                    }
                    catch (Exception)
                    {

                    }

                    try
                    {
                        textBox_InventoryCurrentQuantityOfSelectedItem.Text = selectedInventory.ThirdProperty.ToString();
                    }
                    catch (Exception)
                    {

                    }
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Must select a new Name, ID, and Quantity for the selected inventory item.", "Missing information");
            }

            
        }

        private void button_ClearAllNewValues_Click(object sender, EventArgs e)
        {
            textBox_InventoryNewName.Text = "";
            textBox_InventoryNewID.Text = "";
            textBox_InventoryNewQuantity.Text = "1";
        }
    }
}
