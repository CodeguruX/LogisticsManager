namespace LogisticsManager
{
    partial class form_LogisticsManagerMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl_LogisticsManagerMain = new System.Windows.Forms.TabControl();
            this.tabPage_Inventory = new System.Windows.Forms.TabPage();
            this.tabPage_Vehicles = new System.Windows.Forms.TabPage();
            this.tabPage_Customers = new System.Windows.Forms.TabPage();
            this.textBox_InventoryName = new System.Windows.Forms.TextBox();
            this.button_SubmitInventory = new System.Windows.Forms.Button();
            this.textBox_InventoryId = new System.Windows.Forms.TextBox();
            this.label_InventoryName = new System.Windows.Forms.Label();
            this.textBox_InventoryQuantity = new System.Windows.Forms.TextBox();
            this.label_InventoryID = new System.Windows.Forms.Label();
            this.label_InventoryQuantity = new System.Windows.Forms.Label();
            this.label_InventoryTitle = new System.Windows.Forms.Label();
            this.button_ClearAll = new System.Windows.Forms.Button();
            this.checkedListBox_CurrentInventory = new System.Windows.Forms.CheckedListBox();
            this.label_InventoryCurrent = new System.Windows.Forms.Label();
            this.button_DeleteChecked = new System.Windows.Forms.Button();
            this.textBox_InventoryCurrentQuantityOfSelectedItem = new System.Windows.Forms.TextBox();
            this.label_InventoryChangeCurrentValuesOfSelected = new System.Windows.Forms.Label();
            this.button_InventorySaveChangesToSelectedItem = new System.Windows.Forms.Button();
            this.label_InventoryCurrentQuantity = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label_InventoryCurrentName = new System.Windows.Forms.Label();
            this.textBox_InventoryCurrentNameOfSelectedItem = new System.Windows.Forms.TextBox();
            this.textBox_InventoryCurrentIdOfSelectedItem = new System.Windows.Forms.TextBox();
            this.textBox_InventoryNewName = new System.Windows.Forms.TextBox();
            this.textBox_InventoryNewQuantity = new System.Windows.Forms.TextBox();
            this.textBox_InventoryNewID = new System.Windows.Forms.TextBox();
            this.button_ClearAllNewValues = new System.Windows.Forms.Button();
            this.label_TrucksLicensePlateNumber = new System.Windows.Forms.Label();
            this.label_TrucksVinNumber = new System.Windows.Forms.Label();
            this.label_TruckCustomerName = new System.Windows.Forms.Label();
            this.textBox_TrucksLicensePlate = new System.Windows.Forms.TextBox();
            this.textBox_TrucksVinNumber = new System.Windows.Forms.TextBox();
            this.comboBox_TruckCustomerName = new System.Windows.Forms.ComboBox();
            this.checkedListBox_TrucksCurrentInventory = new System.Windows.Forms.CheckedListBox();
            this.checkedListBox_TrucksInventoryInStock = new System.Windows.Forms.CheckedListBox();
            this.label_TrucksEnterInfo = new System.Windows.Forms.Label();
            this.label_TrucksInStockInventory = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button_TrucksMoveInventoryToTruck = new System.Windows.Forms.Button();
            this.button_TrucksMoveInventortyToStock = new System.Windows.Forms.Button();
            this.label_TrucksList = new System.Windows.Forms.Label();
            this.button_TruckSaveInfo = new System.Windows.Forms.Button();
            this.listBox_TrucksInventoryInStock = new System.Windows.Forms.ListBox();
            this.tabControl_LogisticsManagerMain.SuspendLayout();
            this.tabPage_Inventory.SuspendLayout();
            this.tabPage_Vehicles.SuspendLayout();
            this.tabPage_Customers.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl_LogisticsManagerMain
            // 
            this.tabControl_LogisticsManagerMain.Controls.Add(this.tabPage_Inventory);
            this.tabControl_LogisticsManagerMain.Controls.Add(this.tabPage_Vehicles);
            this.tabControl_LogisticsManagerMain.Controls.Add(this.tabPage_Customers);
            this.tabControl_LogisticsManagerMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl_LogisticsManagerMain.Location = new System.Drawing.Point(-1, 0);
            this.tabControl_LogisticsManagerMain.Name = "tabControl_LogisticsManagerMain";
            this.tabControl_LogisticsManagerMain.SelectedIndex = 0;
            this.tabControl_LogisticsManagerMain.Size = new System.Drawing.Size(819, 454);
            this.tabControl_LogisticsManagerMain.TabIndex = 0;
            // 
            // tabPage_Inventory
            // 
            this.tabPage_Inventory.Controls.Add(this.button_ClearAllNewValues);
            this.tabPage_Inventory.Controls.Add(this.textBox_InventoryNewID);
            this.tabPage_Inventory.Controls.Add(this.textBox_InventoryNewQuantity);
            this.tabPage_Inventory.Controls.Add(this.textBox_InventoryNewName);
            this.tabPage_Inventory.Controls.Add(this.textBox_InventoryCurrentIdOfSelectedItem);
            this.tabPage_Inventory.Controls.Add(this.textBox_InventoryCurrentNameOfSelectedItem);
            this.tabPage_Inventory.Controls.Add(this.label_InventoryCurrentQuantity);
            this.tabPage_Inventory.Controls.Add(this.label2);
            this.tabPage_Inventory.Controls.Add(this.label_InventoryCurrentName);
            this.tabPage_Inventory.Controls.Add(this.button_InventorySaveChangesToSelectedItem);
            this.tabPage_Inventory.Controls.Add(this.label_InventoryChangeCurrentValuesOfSelected);
            this.tabPage_Inventory.Controls.Add(this.textBox_InventoryCurrentQuantityOfSelectedItem);
            this.tabPage_Inventory.Controls.Add(this.button_DeleteChecked);
            this.tabPage_Inventory.Controls.Add(this.label_InventoryCurrent);
            this.tabPage_Inventory.Controls.Add(this.checkedListBox_CurrentInventory);
            this.tabPage_Inventory.Controls.Add(this.button_ClearAll);
            this.tabPage_Inventory.Controls.Add(this.label_InventoryTitle);
            this.tabPage_Inventory.Controls.Add(this.label_InventoryQuantity);
            this.tabPage_Inventory.Controls.Add(this.label_InventoryID);
            this.tabPage_Inventory.Controls.Add(this.textBox_InventoryQuantity);
            this.tabPage_Inventory.Controls.Add(this.label_InventoryName);
            this.tabPage_Inventory.Controls.Add(this.textBox_InventoryId);
            this.tabPage_Inventory.Controls.Add(this.button_SubmitInventory);
            this.tabPage_Inventory.Controls.Add(this.textBox_InventoryName);
            this.tabPage_Inventory.Location = new System.Drawing.Point(4, 22);
            this.tabPage_Inventory.Name = "tabPage_Inventory";
            this.tabPage_Inventory.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Inventory.Size = new System.Drawing.Size(811, 428);
            this.tabPage_Inventory.TabIndex = 0;
            this.tabPage_Inventory.Text = "Inventory";
            this.tabPage_Inventory.UseVisualStyleBackColor = true;
            // 
            // tabPage_Vehicles
            // 
            this.tabPage_Vehicles.Controls.Add(this.button_TruckSaveInfo);
            this.tabPage_Vehicles.Controls.Add(this.label_TrucksList);
            this.tabPage_Vehicles.Controls.Add(this.button_TrucksMoveInventortyToStock);
            this.tabPage_Vehicles.Controls.Add(this.button_TrucksMoveInventoryToTruck);
            this.tabPage_Vehicles.Controls.Add(this.label3);
            this.tabPage_Vehicles.Controls.Add(this.label_TrucksInStockInventory);
            this.tabPage_Vehicles.Controls.Add(this.label_TrucksEnterInfo);
            this.tabPage_Vehicles.Controls.Add(this.checkedListBox_TrucksInventoryInStock);
            this.tabPage_Vehicles.Controls.Add(this.checkedListBox_TrucksCurrentInventory);
            this.tabPage_Vehicles.Controls.Add(this.comboBox_TruckCustomerName);
            this.tabPage_Vehicles.Controls.Add(this.textBox_TrucksVinNumber);
            this.tabPage_Vehicles.Controls.Add(this.textBox_TrucksLicensePlate);
            this.tabPage_Vehicles.Controls.Add(this.label_TruckCustomerName);
            this.tabPage_Vehicles.Controls.Add(this.label_TrucksVinNumber);
            this.tabPage_Vehicles.Controls.Add(this.label_TrucksLicensePlateNumber);
            this.tabPage_Vehicles.Location = new System.Drawing.Point(4, 22);
            this.tabPage_Vehicles.Name = "tabPage_Vehicles";
            this.tabPage_Vehicles.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Vehicles.Size = new System.Drawing.Size(811, 428);
            this.tabPage_Vehicles.TabIndex = 1;
            this.tabPage_Vehicles.Text = "Trucks";
            this.tabPage_Vehicles.UseVisualStyleBackColor = true;
            // 
            // tabPage_Customers
            // 
            this.tabPage_Customers.Controls.Add(this.listBox_TrucksInventoryInStock);
            this.tabPage_Customers.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage_Customers.Location = new System.Drawing.Point(4, 22);
            this.tabPage_Customers.Name = "tabPage_Customers";
            this.tabPage_Customers.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Customers.Size = new System.Drawing.Size(811, 428);
            this.tabPage_Customers.TabIndex = 2;
            this.tabPage_Customers.Text = "Customers";
            this.tabPage_Customers.UseVisualStyleBackColor = true;
            // 
            // textBox_InventoryName
            // 
            this.textBox_InventoryName.Location = new System.Drawing.Point(84, 65);
            this.textBox_InventoryName.Name = "textBox_InventoryName";
            this.textBox_InventoryName.Size = new System.Drawing.Size(367, 20);
            this.textBox_InventoryName.TabIndex = 0;
            // 
            // button_SubmitInventory
            // 
            this.button_SubmitInventory.Location = new System.Drawing.Point(114, 143);
            this.button_SubmitInventory.Name = "button_SubmitInventory";
            this.button_SubmitInventory.Size = new System.Drawing.Size(158, 23);
            this.button_SubmitInventory.TabIndex = 1;
            this.button_SubmitInventory.Text = "Submit Inventory";
            this.button_SubmitInventory.UseVisualStyleBackColor = true;
            this.button_SubmitInventory.Click += new System.EventHandler(this.button_SubmitInventory_Click);
            // 
            // textBox_InventoryId
            // 
            this.textBox_InventoryId.Location = new System.Drawing.Point(84, 91);
            this.textBox_InventoryId.Name = "textBox_InventoryId";
            this.textBox_InventoryId.Size = new System.Drawing.Size(367, 20);
            this.textBox_InventoryId.TabIndex = 2;
            // 
            // label_InventoryName
            // 
            this.label_InventoryName.AutoSize = true;
            this.label_InventoryName.Location = new System.Drawing.Point(7, 72);
            this.label_InventoryName.Name = "label_InventoryName";
            this.label_InventoryName.Size = new System.Drawing.Size(43, 13);
            this.label_InventoryName.TabIndex = 3;
            this.label_InventoryName.Text = "Name:";
            // 
            // textBox_InventoryQuantity
            // 
            this.textBox_InventoryQuantity.Location = new System.Drawing.Point(84, 117);
            this.textBox_InventoryQuantity.Name = "textBox_InventoryQuantity";
            this.textBox_InventoryQuantity.Size = new System.Drawing.Size(367, 20);
            this.textBox_InventoryQuantity.TabIndex = 4;
            this.textBox_InventoryQuantity.Text = "1";
            this.textBox_InventoryQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_InventoryQuantity_KeyPress);
            // 
            // label_InventoryID
            // 
            this.label_InventoryID.AutoSize = true;
            this.label_InventoryID.Location = new System.Drawing.Point(7, 98);
            this.label_InventoryID.Name = "label_InventoryID";
            this.label_InventoryID.Size = new System.Drawing.Size(24, 13);
            this.label_InventoryID.TabIndex = 5;
            this.label_InventoryID.Text = "ID:";
            // 
            // label_InventoryQuantity
            // 
            this.label_InventoryQuantity.AutoSize = true;
            this.label_InventoryQuantity.Location = new System.Drawing.Point(7, 120);
            this.label_InventoryQuantity.Name = "label_InventoryQuantity";
            this.label_InventoryQuantity.Size = new System.Drawing.Size(58, 13);
            this.label_InventoryQuantity.TabIndex = 6;
            this.label_InventoryQuantity.Text = "Quantity:";
            // 
            // label_InventoryTitle
            // 
            this.label_InventoryTitle.AutoSize = true;
            this.label_InventoryTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_InventoryTitle.Location = new System.Drawing.Point(6, 21);
            this.label_InventoryTitle.Name = "label_InventoryTitle";
            this.label_InventoryTitle.Size = new System.Drawing.Size(318, 24);
            this.label_InventoryTitle.TabIndex = 7;
            this.label_InventoryTitle.Text = "Enter Inventory Information Here:";
            // 
            // button_ClearAll
            // 
            this.button_ClearAll.Location = new System.Drawing.Point(272, 143);
            this.button_ClearAll.Name = "button_ClearAll";
            this.button_ClearAll.Size = new System.Drawing.Size(158, 23);
            this.button_ClearAll.TabIndex = 8;
            this.button_ClearAll.Text = "Clear All";
            this.button_ClearAll.UseVisualStyleBackColor = true;
            this.button_ClearAll.Click += new System.EventHandler(this.button_ClearAll_Click);
            // 
            // checkedListBox_CurrentInventory
            // 
            this.checkedListBox_CurrentInventory.FormattingEnabled = true;
            this.checkedListBox_CurrentInventory.Location = new System.Drawing.Point(457, 65);
            this.checkedListBox_CurrentInventory.Name = "checkedListBox_CurrentInventory";
            this.checkedListBox_CurrentInventory.Size = new System.Drawing.Size(328, 319);
            this.checkedListBox_CurrentInventory.TabIndex = 9;
            this.checkedListBox_CurrentInventory.SelectedIndexChanged += new System.EventHandler(this.checkedListBox_CurrentInventory_SelectedIndexChanged);
            // 
            // label_InventoryCurrent
            // 
            this.label_InventoryCurrent.AutoSize = true;
            this.label_InventoryCurrent.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_InventoryCurrent.Location = new System.Drawing.Point(462, 9);
            this.label_InventoryCurrent.Name = "label_InventoryCurrent";
            this.label_InventoryCurrent.Size = new System.Drawing.Size(236, 24);
            this.label_InventoryCurrent.TabIndex = 10;
            this.label_InventoryCurrent.Text = "List of Current Inventory:";
            // 
            // button_DeleteChecked
            // 
            this.button_DeleteChecked.Location = new System.Drawing.Point(466, 36);
            this.button_DeleteChecked.Name = "button_DeleteChecked";
            this.button_DeleteChecked.Size = new System.Drawing.Size(164, 23);
            this.button_DeleteChecked.TabIndex = 11;
            this.button_DeleteChecked.Text = "Delete Checked Inventory";
            this.button_DeleteChecked.UseVisualStyleBackColor = true;
            this.button_DeleteChecked.Click += new System.EventHandler(this.button_DeleteChecked_Click);
            // 
            // textBox_InventoryCurrentQuantityOfSelectedItem
            // 
            this.textBox_InventoryCurrentQuantityOfSelectedItem.Location = new System.Drawing.Point(129, 329);
            this.textBox_InventoryCurrentQuantityOfSelectedItem.Name = "textBox_InventoryCurrentQuantityOfSelectedItem";
            this.textBox_InventoryCurrentQuantityOfSelectedItem.ReadOnly = true;
            this.textBox_InventoryCurrentQuantityOfSelectedItem.Size = new System.Drawing.Size(158, 20);
            this.textBox_InventoryCurrentQuantityOfSelectedItem.TabIndex = 12;
            // 
            // label_InventoryChangeCurrentValuesOfSelected
            // 
            this.label_InventoryChangeCurrentValuesOfSelected.AutoSize = true;
            this.label_InventoryChangeCurrentValuesOfSelected.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_InventoryChangeCurrentValuesOfSelected.Location = new System.Drawing.Point(6, 229);
            this.label_InventoryChangeCurrentValuesOfSelected.Name = "label_InventoryChangeCurrentValuesOfSelected";
            this.label_InventoryChangeCurrentValuesOfSelected.Size = new System.Drawing.Size(400, 24);
            this.label_InventoryChangeCurrentValuesOfSelected.TabIndex = 13;
            this.label_InventoryChangeCurrentValuesOfSelected.Text = "Change Information of Selected Inventory:";
            // 
            // button_InventorySaveChangesToSelectedItem
            // 
            this.button_InventorySaveChangesToSelectedItem.Location = new System.Drawing.Point(114, 355);
            this.button_InventorySaveChangesToSelectedItem.Name = "button_InventorySaveChangesToSelectedItem";
            this.button_InventorySaveChangesToSelectedItem.Size = new System.Drawing.Size(158, 23);
            this.button_InventorySaveChangesToSelectedItem.TabIndex = 15;
            this.button_InventorySaveChangesToSelectedItem.Text = "Save Changes";
            this.button_InventorySaveChangesToSelectedItem.UseVisualStyleBackColor = true;
            this.button_InventorySaveChangesToSelectedItem.Click += new System.EventHandler(this.button_InventorySaveChangesToSelectedItem_Click);
            // 
            // label_InventoryCurrentQuantity
            // 
            this.label_InventoryCurrentQuantity.AutoSize = true;
            this.label_InventoryCurrentQuantity.Location = new System.Drawing.Point(7, 328);
            this.label_InventoryCurrentQuantity.Name = "label_InventoryCurrentQuantity";
            this.label_InventoryCurrentQuantity.Size = new System.Drawing.Size(103, 13);
            this.label_InventoryCurrentQuantity.TabIndex = 18;
            this.label_InventoryCurrentQuantity.Text = "Current Quantity:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 304);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Current ID:";
            // 
            // label_InventoryCurrentName
            // 
            this.label_InventoryCurrentName.AutoSize = true;
            this.label_InventoryCurrentName.Location = new System.Drawing.Point(7, 280);
            this.label_InventoryCurrentName.Name = "label_InventoryCurrentName";
            this.label_InventoryCurrentName.Size = new System.Drawing.Size(88, 13);
            this.label_InventoryCurrentName.TabIndex = 16;
            this.label_InventoryCurrentName.Text = "Current Name:";
            // 
            // textBox_InventoryCurrentNameOfSelectedItem
            // 
            this.textBox_InventoryCurrentNameOfSelectedItem.Location = new System.Drawing.Point(129, 277);
            this.textBox_InventoryCurrentNameOfSelectedItem.Name = "textBox_InventoryCurrentNameOfSelectedItem";
            this.textBox_InventoryCurrentNameOfSelectedItem.ReadOnly = true;
            this.textBox_InventoryCurrentNameOfSelectedItem.Size = new System.Drawing.Size(158, 20);
            this.textBox_InventoryCurrentNameOfSelectedItem.TabIndex = 19;
            // 
            // textBox_InventoryCurrentIdOfSelectedItem
            // 
            this.textBox_InventoryCurrentIdOfSelectedItem.Location = new System.Drawing.Point(129, 303);
            this.textBox_InventoryCurrentIdOfSelectedItem.Name = "textBox_InventoryCurrentIdOfSelectedItem";
            this.textBox_InventoryCurrentIdOfSelectedItem.ReadOnly = true;
            this.textBox_InventoryCurrentIdOfSelectedItem.Size = new System.Drawing.Size(158, 20);
            this.textBox_InventoryCurrentIdOfSelectedItem.TabIndex = 20;
            // 
            // textBox_InventoryNewName
            // 
            this.textBox_InventoryNewName.Location = new System.Drawing.Point(293, 277);
            this.textBox_InventoryNewName.Name = "textBox_InventoryNewName";
            this.textBox_InventoryNewName.Size = new System.Drawing.Size(158, 20);
            this.textBox_InventoryNewName.TabIndex = 21;
            // 
            // textBox_InventoryNewQuantity
            // 
            this.textBox_InventoryNewQuantity.Location = new System.Drawing.Point(293, 329);
            this.textBox_InventoryNewQuantity.Name = "textBox_InventoryNewQuantity";
            this.textBox_InventoryNewQuantity.Size = new System.Drawing.Size(158, 20);
            this.textBox_InventoryNewQuantity.TabIndex = 22;
            this.textBox_InventoryNewQuantity.Text = "1";
            this.textBox_InventoryNewQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_InventoryNewQuantity_KeyPress);
            // 
            // textBox_InventoryNewID
            // 
            this.textBox_InventoryNewID.Location = new System.Drawing.Point(293, 303);
            this.textBox_InventoryNewID.Name = "textBox_InventoryNewID";
            this.textBox_InventoryNewID.Size = new System.Drawing.Size(158, 20);
            this.textBox_InventoryNewID.TabIndex = 23;
            // 
            // button_ClearAllNewValues
            // 
            this.button_ClearAllNewValues.Location = new System.Drawing.Point(272, 355);
            this.button_ClearAllNewValues.Name = "button_ClearAllNewValues";
            this.button_ClearAllNewValues.Size = new System.Drawing.Size(158, 23);
            this.button_ClearAllNewValues.TabIndex = 24;
            this.button_ClearAllNewValues.Text = "Clear All";
            this.button_ClearAllNewValues.UseVisualStyleBackColor = true;
            this.button_ClearAllNewValues.Click += new System.EventHandler(this.button_ClearAllNewValues_Click);
            // 
            // label_TrucksLicensePlateNumber
            // 
            this.label_TrucksLicensePlateNumber.AutoSize = true;
            this.label_TrucksLicensePlateNumber.Location = new System.Drawing.Point(4, 58);
            this.label_TrucksLicensePlateNumber.Name = "label_TrucksLicensePlateNumber";
            this.label_TrucksLicensePlateNumber.Size = new System.Drawing.Size(135, 13);
            this.label_TrucksLicensePlateNumber.TabIndex = 0;
            this.label_TrucksLicensePlateNumber.Text = "License Plate Number:";
            // 
            // label_TrucksVinNumber
            // 
            this.label_TrucksVinNumber.AutoSize = true;
            this.label_TrucksVinNumber.Location = new System.Drawing.Point(4, 87);
            this.label_TrucksVinNumber.Name = "label_TrucksVinNumber";
            this.label_TrucksVinNumber.Size = new System.Drawing.Size(79, 13);
            this.label_TrucksVinNumber.TabIndex = 1;
            this.label_TrucksVinNumber.Text = "VIN Number:";
            this.label_TrucksVinNumber.Click += new System.EventHandler(this.label_TrucksVinNumber_Click);
            // 
            // label_TruckCustomerName
            // 
            this.label_TruckCustomerName.AutoSize = true;
            this.label_TruckCustomerName.Location = new System.Drawing.Point(4, 116);
            this.label_TruckCustomerName.Name = "label_TruckCustomerName";
            this.label_TruckCustomerName.Size = new System.Drawing.Size(99, 13);
            this.label_TruckCustomerName.TabIndex = 2;
            this.label_TruckCustomerName.Text = "Customer Name:";
            // 
            // textBox_TrucksLicensePlate
            // 
            this.textBox_TrucksLicensePlate.Location = new System.Drawing.Point(165, 51);
            this.textBox_TrucksLicensePlate.Name = "textBox_TrucksLicensePlate";
            this.textBox_TrucksLicensePlate.Size = new System.Drawing.Size(124, 20);
            this.textBox_TrucksLicensePlate.TabIndex = 4;
            // 
            // textBox_TrucksVinNumber
            // 
            this.textBox_TrucksVinNumber.Location = new System.Drawing.Point(165, 80);
            this.textBox_TrucksVinNumber.Name = "textBox_TrucksVinNumber";
            this.textBox_TrucksVinNumber.Size = new System.Drawing.Size(124, 20);
            this.textBox_TrucksVinNumber.TabIndex = 5;
            // 
            // comboBox_TruckCustomerName
            // 
            this.comboBox_TruckCustomerName.AutoCompleteCustomSource.AddRange(new string[] {
            "TerraCorp",
            "Gill Bates",
            "Jone Edwards and Son",
            "Toys R Gone",
            "Ham\'s Club"});
            this.comboBox_TruckCustomerName.FormattingEnabled = true;
            this.comboBox_TruckCustomerName.Location = new System.Drawing.Point(165, 108);
            this.comboBox_TruckCustomerName.Name = "comboBox_TruckCustomerName";
            this.comboBox_TruckCustomerName.Size = new System.Drawing.Size(124, 21);
            this.comboBox_TruckCustomerName.TabIndex = 6;
            // 
            // checkedListBox_TrucksCurrentInventory
            // 
            this.checkedListBox_TrucksCurrentInventory.FormattingEnabled = true;
            this.checkedListBox_TrucksCurrentInventory.Location = new System.Drawing.Point(594, 51);
            this.checkedListBox_TrucksCurrentInventory.Name = "checkedListBox_TrucksCurrentInventory";
            this.checkedListBox_TrucksCurrentInventory.Size = new System.Drawing.Size(191, 319);
            this.checkedListBox_TrucksCurrentInventory.TabIndex = 7;
            this.checkedListBox_TrucksCurrentInventory.SelectedIndexChanged += new System.EventHandler(this.checkedListBox_TrucksCurrentInventory_SelectedIndexChanged);
            // 
            // checkedListBox_TrucksInventoryInStock
            // 
            this.checkedListBox_TrucksInventoryInStock.FormattingEnabled = true;
            this.checkedListBox_TrucksInventoryInStock.Location = new System.Drawing.Point(315, 51);
            this.checkedListBox_TrucksInventoryInStock.Name = "checkedListBox_TrucksInventoryInStock";
            this.checkedListBox_TrucksInventoryInStock.Size = new System.Drawing.Size(191, 319);
            this.checkedListBox_TrucksInventoryInStock.TabIndex = 8;
            // 
            // label_TrucksEnterInfo
            // 
            this.label_TrucksEnterInfo.AutoSize = true;
            this.label_TrucksEnterInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_TrucksEnterInfo.Location = new System.Drawing.Point(3, 16);
            this.label_TrucksEnterInfo.Name = "label_TrucksEnterInfo";
            this.label_TrucksEnterInfo.Size = new System.Drawing.Size(286, 24);
            this.label_TrucksEnterInfo.TabIndex = 9;
            this.label_TrucksEnterInfo.Text = "Enter Truck Information Here:";
            // 
            // label_TrucksInStockInventory
            // 
            this.label_TrucksInStockInventory.AutoSize = true;
            this.label_TrucksInStockInventory.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_TrucksInStockInventory.Location = new System.Drawing.Point(311, 16);
            this.label_TrucksInStockInventory.Name = "label_TrucksInStockInventory";
            this.label_TrucksInStockInventory.Size = new System.Drawing.Size(181, 24);
            this.label_TrucksInStockInventory.TabIndex = 10;
            this.label_TrucksInStockInventory.Text = "Inventory In Stock:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(590, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(183, 24);
            this.label3.TabIndex = 11;
            this.label3.Text = "Inventory in Truck:";
            // 
            // button_TrucksMoveInventoryToTruck
            // 
            this.button_TrucksMoveInventoryToTruck.Location = new System.Drawing.Point(515, 116);
            this.button_TrucksMoveInventoryToTruck.Name = "button_TrucksMoveInventoryToTruck";
            this.button_TrucksMoveInventoryToTruck.Size = new System.Drawing.Size(70, 23);
            this.button_TrucksMoveInventoryToTruck.TabIndex = 12;
            this.button_TrucksMoveInventoryToTruck.Text = "Truck >>";
            this.button_TrucksMoveInventoryToTruck.UseVisualStyleBackColor = true;
            // 
            // button_TrucksMoveInventortyToStock
            // 
            this.button_TrucksMoveInventortyToStock.Location = new System.Drawing.Point(515, 271);
            this.button_TrucksMoveInventortyToStock.Name = "button_TrucksMoveInventortyToStock";
            this.button_TrucksMoveInventortyToStock.Size = new System.Drawing.Size(70, 23);
            this.button_TrucksMoveInventortyToStock.TabIndex = 13;
            this.button_TrucksMoveInventortyToStock.Text = "<< Stock";
            this.button_TrucksMoveInventortyToStock.UseVisualStyleBackColor = true;
            // 
            // label_TrucksList
            // 
            this.label_TrucksList.AutoSize = true;
            this.label_TrucksList.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_TrucksList.Location = new System.Drawing.Point(3, 195);
            this.label_TrucksList.Name = "label_TrucksList";
            this.label_TrucksList.Size = new System.Drawing.Size(139, 24);
            this.label_TrucksList.TabIndex = 14;
            this.label_TrucksList.Text = "List of Trucks:";
            // 
            // button_TruckSaveInfo
            // 
            this.button_TruckSaveInfo.Location = new System.Drawing.Point(7, 152);
            this.button_TruckSaveInfo.Name = "button_TruckSaveInfo";
            this.button_TruckSaveInfo.Size = new System.Drawing.Size(124, 23);
            this.button_TruckSaveInfo.TabIndex = 15;
            this.button_TruckSaveInfo.Text = "Save Information";
            this.button_TruckSaveInfo.UseVisualStyleBackColor = true;
            this.button_TruckSaveInfo.Click += new System.EventHandler(this.button_TruckSaveInfo_Click);
            // 
            // listBox_TrucksInventoryInStock
            // 
            this.listBox_TrucksInventoryInStock.FormattingEnabled = true;
            this.listBox_TrucksInventoryInStock.Location = new System.Drawing.Point(274, 58);
            this.listBox_TrucksInventoryInStock.Name = "listBox_TrucksInventoryInStock";
            this.listBox_TrucksInventoryInStock.Size = new System.Drawing.Size(400, 225);
            this.listBox_TrucksInventoryInStock.TabIndex = 0;
            // 
            // form_LogisticsManagerMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 412);
            this.Controls.Add(this.tabControl_LogisticsManagerMain);
            this.Name = "form_LogisticsManagerMain";
            this.Text = "Logistics Manager";
            this.tabControl_LogisticsManagerMain.ResumeLayout(false);
            this.tabPage_Inventory.ResumeLayout(false);
            this.tabPage_Inventory.PerformLayout();
            this.tabPage_Vehicles.ResumeLayout(false);
            this.tabPage_Vehicles.PerformLayout();
            this.tabPage_Customers.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl_LogisticsManagerMain;
        private System.Windows.Forms.TabPage tabPage_Inventory;
        private System.Windows.Forms.TabPage tabPage_Vehicles;
        private System.Windows.Forms.TabPage tabPage_Customers;
        private System.Windows.Forms.Button button_SubmitInventory;
        private System.Windows.Forms.TextBox textBox_InventoryName;
        private System.Windows.Forms.Label label_InventoryName;
        private System.Windows.Forms.TextBox textBox_InventoryId;
        private System.Windows.Forms.TextBox textBox_InventoryQuantity;
        private System.Windows.Forms.Label label_InventoryQuantity;
        private System.Windows.Forms.Label label_InventoryID;
        private System.Windows.Forms.Button button_ClearAll;
        private System.Windows.Forms.Label label_InventoryTitle;
        private System.Windows.Forms.CheckedListBox checkedListBox_CurrentInventory;
        private System.Windows.Forms.Label label_InventoryCurrent;
        private System.Windows.Forms.Button button_DeleteChecked;
        private System.Windows.Forms.Label label_InventoryChangeCurrentValuesOfSelected;
        private System.Windows.Forms.TextBox textBox_InventoryCurrentQuantityOfSelectedItem;
        private System.Windows.Forms.Button button_InventorySaveChangesToSelectedItem;
        private System.Windows.Forms.Label label_InventoryCurrentQuantity;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_InventoryCurrentName;
        private System.Windows.Forms.TextBox textBox_InventoryNewID;
        private System.Windows.Forms.TextBox textBox_InventoryNewQuantity;
        private System.Windows.Forms.TextBox textBox_InventoryNewName;
        private System.Windows.Forms.TextBox textBox_InventoryCurrentIdOfSelectedItem;
        private System.Windows.Forms.TextBox textBox_InventoryCurrentNameOfSelectedItem;
        private System.Windows.Forms.Button button_ClearAllNewValues;
        private System.Windows.Forms.ComboBox comboBox_TruckCustomerName;
        private System.Windows.Forms.TextBox textBox_TrucksVinNumber;
        private System.Windows.Forms.TextBox textBox_TrucksLicensePlate;
        private System.Windows.Forms.Label label_TruckCustomerName;
        private System.Windows.Forms.Label label_TrucksVinNumber;
        private System.Windows.Forms.Label label_TrucksLicensePlateNumber;
        private System.Windows.Forms.Label label_TrucksEnterInfo;
        private System.Windows.Forms.CheckedListBox checkedListBox_TrucksInventoryInStock;
        private System.Windows.Forms.CheckedListBox checkedListBox_TrucksCurrentInventory;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_TrucksInStockInventory;
        private System.Windows.Forms.Button button_TrucksMoveInventortyToStock;
        private System.Windows.Forms.Button button_TrucksMoveInventoryToTruck;
        private System.Windows.Forms.Button button_TruckSaveInfo;
        private System.Windows.Forms.Label label_TrucksList;
        private System.Windows.Forms.ListBox listBox_TrucksInventoryInStock;
    }
}

