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
            this.tabControl_LogisticsManagerMain.SuspendLayout();
            this.tabPage_Inventory.SuspendLayout();
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
            this.tabControl_LogisticsManagerMain.Size = new System.Drawing.Size(802, 454);
            this.tabControl_LogisticsManagerMain.TabIndex = 0;
            // 
            // tabPage_Inventory
            // 
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
            this.tabPage_Inventory.Size = new System.Drawing.Size(794, 428);
            this.tabPage_Inventory.TabIndex = 0;
            this.tabPage_Inventory.Text = "Inventory";
            this.tabPage_Inventory.UseVisualStyleBackColor = true;
            // 
            // tabPage_Vehicles
            // 
            this.tabPage_Vehicles.Location = new System.Drawing.Point(4, 22);
            this.tabPage_Vehicles.Name = "tabPage_Vehicles";
            this.tabPage_Vehicles.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Vehicles.Size = new System.Drawing.Size(794, 428);
            this.tabPage_Vehicles.TabIndex = 1;
            this.tabPage_Vehicles.Text = "Vehicles";
            this.tabPage_Vehicles.UseVisualStyleBackColor = true;
            // 
            // tabPage_Customers
            // 
            this.tabPage_Customers.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage_Customers.Location = new System.Drawing.Point(4, 22);
            this.tabPage_Customers.Name = "tabPage_Customers";
            this.tabPage_Customers.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Customers.Size = new System.Drawing.Size(794, 428);
            this.tabPage_Customers.TabIndex = 2;
            this.tabPage_Customers.Text = "Customers";
            this.tabPage_Customers.UseVisualStyleBackColor = true;
            // 
            // textBox_InventoryName
            // 
            this.textBox_InventoryName.Location = new System.Drawing.Point(120, 65);
            this.textBox_InventoryName.Name = "textBox_InventoryName";
            this.textBox_InventoryName.Size = new System.Drawing.Size(240, 20);
            this.textBox_InventoryName.TabIndex = 0;
            // 
            // button_SubmitInventory
            // 
            this.button_SubmitInventory.Location = new System.Drawing.Point(120, 143);
            this.button_SubmitInventory.Name = "button_SubmitInventory";
            this.button_SubmitInventory.Size = new System.Drawing.Size(114, 23);
            this.button_SubmitInventory.TabIndex = 1;
            this.button_SubmitInventory.Text = "Submit Inventory";
            this.button_SubmitInventory.UseVisualStyleBackColor = true;
            this.button_SubmitInventory.Click += new System.EventHandler(this.button_SubmitInventory_Click);
            // 
            // textBox_InventoryId
            // 
            this.textBox_InventoryId.Location = new System.Drawing.Point(120, 91);
            this.textBox_InventoryId.Name = "textBox_InventoryId";
            this.textBox_InventoryId.Size = new System.Drawing.Size(240, 20);
            this.textBox_InventoryId.TabIndex = 2;
            // 
            // label_InventoryName
            // 
            this.label_InventoryName.AutoSize = true;
            this.label_InventoryName.Location = new System.Drawing.Point(43, 72);
            this.label_InventoryName.Name = "label_InventoryName";
            this.label_InventoryName.Size = new System.Drawing.Size(43, 13);
            this.label_InventoryName.TabIndex = 3;
            this.label_InventoryName.Text = "Name:";
            // 
            // textBox_InventoryQuantity
            // 
            this.textBox_InventoryQuantity.Location = new System.Drawing.Point(120, 117);
            this.textBox_InventoryQuantity.Name = "textBox_InventoryQuantity";
            this.textBox_InventoryQuantity.Size = new System.Drawing.Size(240, 20);
            this.textBox_InventoryQuantity.TabIndex = 4;
            this.textBox_InventoryQuantity.Text = "1";
            this.textBox_InventoryQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_InventoryQuantity_KeyPress);
            // 
            // label_InventoryID
            // 
            this.label_InventoryID.AutoSize = true;
            this.label_InventoryID.Location = new System.Drawing.Point(43, 98);
            this.label_InventoryID.Name = "label_InventoryID";
            this.label_InventoryID.Size = new System.Drawing.Size(24, 13);
            this.label_InventoryID.TabIndex = 5;
            this.label_InventoryID.Text = "ID:";
            // 
            // label_InventoryQuantity
            // 
            this.label_InventoryQuantity.AutoSize = true;
            this.label_InventoryQuantity.Location = new System.Drawing.Point(43, 120);
            this.label_InventoryQuantity.Name = "label_InventoryQuantity";
            this.label_InventoryQuantity.Size = new System.Drawing.Size(58, 13);
            this.label_InventoryQuantity.TabIndex = 6;
            this.label_InventoryQuantity.Text = "Quantity:";
            // 
            // label_InventoryTitle
            // 
            this.label_InventoryTitle.AutoSize = true;
            this.label_InventoryTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_InventoryTitle.Location = new System.Drawing.Point(42, 21);
            this.label_InventoryTitle.Name = "label_InventoryTitle";
            this.label_InventoryTitle.Size = new System.Drawing.Size(318, 24);
            this.label_InventoryTitle.TabIndex = 7;
            this.label_InventoryTitle.Text = "Enter Inventory Information Here:";
            // 
            // button_ClearAll
            // 
            this.button_ClearAll.Location = new System.Drawing.Point(246, 143);
            this.button_ClearAll.Name = "button_ClearAll";
            this.button_ClearAll.Size = new System.Drawing.Size(114, 23);
            this.button_ClearAll.TabIndex = 8;
            this.button_ClearAll.Text = "Clear All";
            this.button_ClearAll.UseVisualStyleBackColor = true;
            this.button_ClearAll.Click += new System.EventHandler(this.button_ClearAll_Click);
            // 
            // form_LogisticsManagerMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl_LogisticsManagerMain);
            this.Name = "form_LogisticsManagerMain";
            this.Text = "Logistics Manager";
            this.tabControl_LogisticsManagerMain.ResumeLayout(false);
            this.tabPage_Inventory.ResumeLayout(false);
            this.tabPage_Inventory.PerformLayout();
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
    }
}

