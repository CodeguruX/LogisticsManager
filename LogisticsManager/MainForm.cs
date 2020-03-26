﻿using System;
using System.Linq;
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

                checkedListBox_TrucksInventoryInStock.Items.Add(inventoryItem, false);
                checkedListBox_TrucksInventoryInStock.DisplayMember = "FirstProperty";
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
                checkedListBox_TrucksInventoryInStock.Items.Remove(item);
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

        private void label_TrucksVinNumber_Click(object sender, EventArgs e)
        {
            // Code for generating random VIN numbers will be added at a later date.
        }

        private void checkedListBox_TrucksCurrentInventory_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Code for generating an item value preview on selection but before being checked will be added at a later date.
        }

        private void button_TruckSaveInfo_Click(object sender, EventArgs e)
        {
            foreach (var item in checkedListBox_CurrentInventory.Items.OfType<Inventory<string, string, int>>().ToList())
            {
                checkedListBox_TrucksInventoryInStock.Items.Add(item, false);
                checkedListBox_TrucksInventoryInStock.DisplayMember = "FirstProperty";
            }

            //checkedListBox_CurrentInventory.Items = checkedListBox_TrucksInventoryInStock.ob
        }

        private void button_TrucksMoveInventoryToTruck_Click(object sender, EventArgs e)
        {
            foreach (var item in checkedListBox_TrucksInventoryInStock.CheckedItems.OfType<Inventory<string, string, int>>().ToList())
            {
                checkedListBox_TrucksCurrentInventory.Items.Add(item, false);
                checkedListBox_TrucksCurrentInventory.DisplayMember = "FirstProperty";

                // Update the removal of the Inventory object from current stock on Inventory and Trucks tab

                checkedListBox_CurrentInventory.Items.Remove(item);
                checkedListBox_TrucksInventoryInStock.Items.Remove(item);
            }
        }

        private void button_TrucksMoveInventortyToStock_Click(object sender, EventArgs e)
        {
            foreach (var item in checkedListBox_TrucksCurrentInventory.CheckedItems.OfType<Inventory<string, string, int>>().ToList())
            {
                checkedListBox_CurrentInventory.Items.Add(item, false);
                checkedListBox_CurrentInventory.DisplayMember = "FirstProperty";

                checkedListBox_TrucksInventoryInStock.Items.Add(item, false);
                checkedListBox_TrucksInventoryInStock.DisplayMember = "FirstProperty";
                // Update the removal of the Inventory object from current stock on Inventory and Trucks tab


                checkedListBox_TrucksCurrentInventory.Items.Remove(item);
            }
        }
    }
}
