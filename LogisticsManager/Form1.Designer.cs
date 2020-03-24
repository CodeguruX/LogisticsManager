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
            this.tabControl_LogisticsManagerMain.SuspendLayout();
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
            // form_LogisticsManagerMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl_LogisticsManagerMain);
            this.Name = "form_LogisticsManagerMain";
            this.Text = "Logistics Manager";
            this.tabControl_LogisticsManagerMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl_LogisticsManagerMain;
        private System.Windows.Forms.TabPage tabPage_Inventory;
        private System.Windows.Forms.TabPage tabPage_Vehicles;
        private System.Windows.Forms.TabPage tabPage_Customers;
    }
}

