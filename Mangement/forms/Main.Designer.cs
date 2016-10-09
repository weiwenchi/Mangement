namespace Management
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.buttonProduct = new System.Windows.Forms.Button();
            this.buttonCustomer = new System.Windows.Forms.Button();
            this.panelMain = new System.Windows.Forms.Panel();
            this.buttonStockIn = new System.Windows.Forms.Button();
            this.buttonStockOut = new System.Windows.Forms.Button();
            this.buttonSetting = new System.Windows.Forms.Button();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMenu.Controls.Add(this.buttonSetting);
            this.panelMenu.Controls.Add(this.buttonStockOut);
            this.panelMenu.Controls.Add(this.buttonStockIn);
            this.panelMenu.Controls.Add(this.buttonProduct);
            this.panelMenu.Controls.Add(this.buttonCustomer);
            this.panelMenu.Location = new System.Drawing.Point(12, 5);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(145, 588);
            this.panelMenu.TabIndex = 0;
            // 
            // buttonProduct
            // 
            this.buttonProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonProduct.Location = new System.Drawing.Point(2, 124);
            this.buttonProduct.Name = "buttonProduct";
            this.buttonProduct.Size = new System.Drawing.Size(138, 80);
            this.buttonProduct.TabIndex = 1;
            this.buttonProduct.Text = "产品";
            this.buttonProduct.UseVisualStyleBackColor = true;
            this.buttonProduct.Click += new System.EventHandler(this.buttonProduct_Click);
            // 
            // buttonCustomer
            // 
            this.buttonCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCustomer.Location = new System.Drawing.Point(2, 6);
            this.buttonCustomer.Name = "buttonCustomer";
            this.buttonCustomer.Size = new System.Drawing.Size(138, 80);
            this.buttonCustomer.TabIndex = 0;
            this.buttonCustomer.Text = "客户";
            this.buttonCustomer.UseVisualStyleBackColor = true;
            this.buttonCustomer.Click += new System.EventHandler(this.buttonCustomer_Click);
            // 
            // panelMain
            // 
            this.panelMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMain.Location = new System.Drawing.Point(163, 5);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(946, 587);
            this.panelMain.TabIndex = 1;
            // 
            // buttonStockIn
            // 
            this.buttonStockIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStockIn.Location = new System.Drawing.Point(2, 240);
            this.buttonStockIn.Name = "buttonStockIn";
            this.buttonStockIn.Size = new System.Drawing.Size(138, 80);
            this.buttonStockIn.TabIndex = 2;
            this.buttonStockIn.Text = "入库管理";
            this.buttonStockIn.UseVisualStyleBackColor = true;
            this.buttonStockIn.Click += new System.EventHandler(this.buttonStockIn_Click);
            // 
            // buttonStockOut
            // 
            this.buttonStockOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStockOut.Location = new System.Drawing.Point(2, 356);
            this.buttonStockOut.Name = "buttonStockOut";
            this.buttonStockOut.Size = new System.Drawing.Size(138, 80);
            this.buttonStockOut.TabIndex = 3;
            this.buttonStockOut.Text = "出库管理";
            this.buttonStockOut.UseVisualStyleBackColor = true;
            this.buttonStockOut.Click += new System.EventHandler(this.buttonStockOut_Click);
            // 
            // buttonSetting
            // 
            this.buttonSetting.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSetting.Location = new System.Drawing.Point(2, 478);
            this.buttonSetting.Name = "buttonSetting";
            this.buttonSetting.Size = new System.Drawing.Size(138, 80);
            this.buttonSetting.TabIndex = 4;
            this.buttonSetting.Text = "设置";
            this.buttonSetting.UseVisualStyleBackColor = true;
            this.buttonSetting.Click += new System.EventHandler(this.buttonSetting_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1120, 602);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.panelMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button buttonCustomer;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Button buttonProduct;
        private System.Windows.Forms.Button buttonStockOut;
        private System.Windows.Forms.Button buttonStockIn;
        private System.Windows.Forms.Button buttonSetting;
    }
}

