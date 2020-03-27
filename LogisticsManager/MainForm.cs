using System;
using System.Collections;
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
                Inventory <string, string, int> inventoryItem = new Inventory<string, string, int>()
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

                checkedListBox_TruckInventoryInStock.Items.Add(inventoryItem, false);
                checkedListBox_TruckInventoryInStock.DisplayMember = "FirstProperty";
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
            foreach (var item in checkedListBox_CurrentInventory.CheckedItems.OfType<Inventory <string, string, int>>().ToList())
            {
                checkedListBox_CurrentInventory.Items.Remove(item);
                checkedListBox_TruckInventoryInStock.Items.Remove(item);
            }
        }

        private void checkedListBox_CurrentInventory_SelectedIndexChanged(object sender, EventArgs e)
        {
            Inventory<string, string, int> selectedInventory;

            selectedInventory = (Inventory <string, string, int>)checkedListBox_CurrentInventory.SelectedItem;

            if (selectedInventory != null)
            {

                this.textBox_InventoryCurrentNameOfSelectedItem.Text = selectedInventory.FirstProperty;
                this.textBox_InventoryCurrentIdOfSelectedItem.Text = selectedInventory.SecondProperty;
                this.textBox_InventoryCurrentQuantityOfSelectedItem.Text = selectedInventory.ThirdProperty.ToString();


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
            Inventory <string, string, int> selectedInventory = new Inventory <string, string, int>();

            try
            {
                if (textBox_InventoryNewName.Text == "" || textBox_InventoryNewID.Text == "" || textBox_InventoryNewQuantity.Text == "")
                {
                    throw new System.Exception();
                }

                selectedInventory.FirstProperty = textBox_InventoryNewName.Text;
                selectedInventory.SecondProperty = textBox_InventoryNewID.Text;
                selectedInventory.ThirdProperty = Int32.Parse(textBox_InventoryNewQuantity.Text);

                i = this.checkedListBox_CurrentInventory.SelectedIndex;
                this.checkedListBox_CurrentInventory.Items[i] = selectedInventory;
                this.checkedListBox_TruckInventoryInStock.Items[i] = selectedInventory;

                if (selectedInventory != null)
                {
                    textBox_InventoryCurrentNameOfSelectedItem.Text = selectedInventory.FirstProperty;
                    textBox_InventoryCurrentIdOfSelectedItem.Text = selectedInventory.SecondProperty;
                    textBox_InventoryCurrentQuantityOfSelectedItem.Text = selectedInventory.ThirdProperty.ToString();
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

        private void button_TruckSaveInfo_Click(object sender, EventArgs e)
        {
            Truck<string, string, string> truckInfo = new Truck<string, string, string>("", "", "");

            try
            {
                if (textBox_TruckLicensePlate.Text == "" || textBox_TruckVinNumber.Text == "" || textBox_TruckMakeAndModel.Text == "")
                {
                    throw new System.Exception();
                }

                truckInfo.FirstProperty = textBox_TruckLicensePlate.Text;
                truckInfo.SecondProperty = textBox_TruckVinNumber.Text;
                truckInfo.ThirdProperty = textBox_TruckMakeAndModel.Text;

                checkedListBox_TruckList.Items.Add(truckInfo);
                checkedListBox_TruckList.DisplayMember = "FirstProperty";
            }
            catch (Exception)
            {
                MessageBox.Show("Must provide a License Plate, VIN Number, and the Make/Model to register a new Truck.", "Missing Truck Info");
            }

        }

        private void button_TrucksMoveInventoryToTruck_Click(object sender, EventArgs e)
        {
            List<Inventory<string, string, int>> selectedInventory = new List<Inventory<string, string, int>>();
            List<Inventory<string, string, int>> selectedTruckInventoryList = new List<Inventory<string, string, int>>();

            foreach (var item in checkedListBox_TruckInventoryInStock.CheckedItems.OfType<Inventory<string, string, int>>().ToList())
            {
                // Update the current inventory of the truck

                checkedListBox_TruckCurrentInventory.Items.Add(item, false);
                checkedListBox_TruckCurrentInventory.DisplayMember = "FirstProperty";

                checkedListBox_WarehouseTruckManifest.Items.Add(item, false);
                checkedListBox_WarehouseTruckManifest.DisplayMember = "FirstProperty";

                // Update the removal of the Inventory object from current stock on Inventory and Trucks tab

                checkedListBox_CurrentInventory.Items.Remove(item);
                checkedListBox_TruckInventoryInStock.Items.Remove(item);
            }

        }

        private void button_TruckMoveInventortyToStock_Click(object sender, EventArgs e)
        {
            foreach (var item in checkedListBox_TruckCurrentInventory.CheckedItems.OfType<Inventory<string, string, int>>().ToList())
            {
                checkedListBox_CurrentInventory.Items.Add(item, false);
                checkedListBox_CurrentInventory.DisplayMember = "FirstProperty";

                checkedListBox_TruckInventoryInStock.Items.Add(item, false);
                checkedListBox_TruckInventoryInStock.DisplayMember = "FirstProperty";

                // Update the removal of the Inventory object from current stock on Inventory and Trucks tab

                checkedListBox_TruckCurrentInventory.Items.Remove(item);
                checkedListBox_WarehouseTruckManifest.Items.Remove(item);
            }
        }

        private void button_TruckRemoveChecked_Click(object sender, EventArgs e)
        {
            foreach (var item in checkedListBox_TruckList.CheckedItems.OfType<Truck<string, string, string>>().ToList())
            {
                checkedListBox_TruckList.Items.Remove(item);
            }
        }

        private void button_WarehouseMakeDelivery_Click(object sender, EventArgs e)
        {
            foreach (var item in checkedListBox_WarehouseTruckManifest.CheckedItems.OfType<Inventory<string, string, int>>().ToList())
            {
                checkedListBox_TruckCurrentInventory.Items.Remove(item);
                checkedListBox_WarehouseTruckManifest.Items.Remove(item);

                checkedListBox_WarehouseManifest.Items.Add(item);
                checkedListBox_WarehouseManifest.DisplayMember = "FirstProperty";
            }
        }
    }
}
