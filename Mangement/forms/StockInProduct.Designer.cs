namespace Management.forms
{
    partial class StockInProduct
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
            this.dtPicker = new System.Windows.Forms.DateTimePicker();
            this.comboProducts = new System.Windows.Forms.ComboBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.labNotes = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtSpec = new System.Windows.Forms.TextBox();
            this.labPrice = new System.Windows.Forms.Label();
            this.labUnit = new System.Windows.Forms.Label();
            this.labSpec = new System.Windows.Forms.Label();
            this.txtUnit = new System.Windows.Forms.TextBox();
            this.labProductName = new System.Windows.Forms.Label();
            this.labDate = new System.Windows.Forms.Label();
            this.labStockInQuantity = new System.Windows.Forms.Label();
            this.labTotalQuantity = new System.Windows.Forms.Label();
            this.txtStockInQuantity = new System.Windows.Forms.TextBox();
            this.txtTotalQuantity = new System.Windows.Forms.TextBox();
            this.labWarning = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dtPicker
            // 
            this.dtPicker.CustomFormat = "yyyy/MM/dd";
            this.dtPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtPicker.Location = new System.Drawing.Point(73, 156);
            this.dtPicker.Name = "dtPicker";
            this.dtPicker.Size = new System.Drawing.Size(101, 20);
            this.dtPicker.TabIndex = 6;
            // 
            // comboProducts
            // 
            this.comboProducts.FormattingEnabled = true;
            this.comboProducts.Location = new System.Drawing.Point(73, 24);
            this.comboProducts.Name = "comboProducts";
            this.comboProducts.Size = new System.Drawing.Size(121, 21);
            this.comboProducts.Sorted = true;
            this.comboProducts.TabIndex = 1;
            this.comboProducts.SelectedIndexChanged += new System.EventHandler(this.comboProducts_SelectedIndexChanged);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(189, 250);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(73, 250);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "确认";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtNotes
            // 
            this.txtNotes.Location = new System.Drawing.Point(73, 130);
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.ReadOnly = true;
            this.txtNotes.Size = new System.Drawing.Size(222, 20);
            this.txtNotes.TabIndex = 5;
            // 
            // labNotes
            // 
            this.labNotes.AutoSize = true;
            this.labNotes.Location = new System.Drawing.Point(36, 133);
            this.labNotes.Name = "labNotes";
            this.labNotes.Size = new System.Drawing.Size(31, 13);
            this.labNotes.TabIndex = 33;
            this.labNotes.Text = "备注";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(73, 103);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.ReadOnly = true;
            this.txtPrice.Size = new System.Drawing.Size(93, 20);
            this.txtPrice.TabIndex = 4;
            // 
            // txtSpec
            // 
            this.txtSpec.Location = new System.Drawing.Point(73, 51);
            this.txtSpec.Name = "txtSpec";
            this.txtSpec.ReadOnly = true;
            this.txtSpec.Size = new System.Drawing.Size(144, 20);
            this.txtSpec.TabIndex = 2;
            // 
            // labPrice
            // 
            this.labPrice.AutoSize = true;
            this.labPrice.Location = new System.Drawing.Point(36, 106);
            this.labPrice.Name = "labPrice";
            this.labPrice.Size = new System.Drawing.Size(31, 13);
            this.labPrice.TabIndex = 32;
            this.labPrice.Text = "单价";
            // 
            // labUnit
            // 
            this.labUnit.AutoSize = true;
            this.labUnit.Location = new System.Drawing.Point(36, 80);
            this.labUnit.Name = "labUnit";
            this.labUnit.Size = new System.Drawing.Size(31, 13);
            this.labUnit.TabIndex = 31;
            this.labUnit.Text = "单位";
            // 
            // labSpec
            // 
            this.labSpec.AutoSize = true;
            this.labSpec.Location = new System.Drawing.Point(12, 54);
            this.labSpec.Name = "labSpec";
            this.labSpec.Size = new System.Drawing.Size(55, 13);
            this.labSpec.TabIndex = 30;
            this.labSpec.Text = "规格型号";
            // 
            // txtUnit
            // 
            this.txtUnit.Location = new System.Drawing.Point(74, 78);
            this.txtUnit.Name = "txtUnit";
            this.txtUnit.ReadOnly = true;
            this.txtUnit.Size = new System.Drawing.Size(39, 20);
            this.txtUnit.TabIndex = 3;
            // 
            // labProductName
            // 
            this.labProductName.AutoSize = true;
            this.labProductName.Location = new System.Drawing.Point(12, 27);
            this.labProductName.Name = "labProductName";
            this.labProductName.Size = new System.Drawing.Size(55, 13);
            this.labProductName.TabIndex = 35;
            this.labProductName.Text = "产品名称";
            // 
            // labDate
            // 
            this.labDate.AutoSize = true;
            this.labDate.Location = new System.Drawing.Point(13, 162);
            this.labDate.Name = "labDate";
            this.labDate.Size = new System.Drawing.Size(55, 13);
            this.labDate.TabIndex = 36;
            this.labDate.Text = "入库日期";
            // 
            // labStockInQuantity
            // 
            this.labStockInQuantity.AutoSize = true;
            this.labStockInQuantity.Location = new System.Drawing.Point(13, 188);
            this.labStockInQuantity.Name = "labStockInQuantity";
            this.labStockInQuantity.Size = new System.Drawing.Size(55, 13);
            this.labStockInQuantity.TabIndex = 37;
            this.labStockInQuantity.Text = "入库数量";
            // 
            // labTotalQuantity
            // 
            this.labTotalQuantity.AutoSize = true;
            this.labTotalQuantity.Location = new System.Drawing.Point(24, 210);
            this.labTotalQuantity.Name = "labTotalQuantity";
            this.labTotalQuantity.Size = new System.Drawing.Size(43, 13);
            this.labTotalQuantity.TabIndex = 38;
            this.labTotalQuantity.Text = "总数量";
            // 
            // txtStockInQuantity
            // 
            this.txtStockInQuantity.Location = new System.Drawing.Point(73, 183);
            this.txtStockInQuantity.Name = "txtStockInQuantity";
            this.txtStockInQuantity.Size = new System.Drawing.Size(100, 20);
            this.txtStockInQuantity.TabIndex = 7;
            this.txtStockInQuantity.TextChanged += new System.EventHandler(this.txtStockInQuantity_TextChanged);
            this.txtStockInQuantity.Leave += new System.EventHandler(this.txtStockInQuantity_Leave);
            // 
            // txtTotalQuantity
            // 
            this.txtTotalQuantity.Location = new System.Drawing.Point(73, 209);
            this.txtTotalQuantity.Name = "txtTotalQuantity";
            this.txtTotalQuantity.ReadOnly = true;
            this.txtTotalQuantity.Size = new System.Drawing.Size(100, 20);
            this.txtTotalQuantity.TabIndex = 8;
            // 
            // labWarning
            // 
            this.labWarning.AutoSize = true;
            this.labWarning.ForeColor = System.Drawing.Color.Red;
            this.labWarning.Location = new System.Drawing.Point(179, 186);
            this.labWarning.Name = "labWarning";
            this.labWarning.Size = new System.Drawing.Size(67, 13);
            this.labWarning.TabIndex = 39;
            this.labWarning.Text = "请输入数字";
            this.labWarning.Visible = false;
            // 
            // StockInProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 293);
            this.Controls.Add(this.labWarning);
            this.Controls.Add(this.txtTotalQuantity);
            this.Controls.Add(this.txtStockInQuantity);
            this.Controls.Add(this.labTotalQuantity);
            this.Controls.Add(this.labStockInQuantity);
            this.Controls.Add(this.labDate);
            this.Controls.Add(this.labProductName);
            this.Controls.Add(this.txtUnit);
            this.Controls.Add(this.txtNotes);
            this.Controls.Add(this.labNotes);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtSpec);
            this.Controls.Add(this.labPrice);
            this.Controls.Add(this.labUnit);
            this.Controls.Add(this.labSpec);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.comboProducts);
            this.Controls.Add(this.dtPicker);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "StockInProduct";
            this.Text = "产品入库";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtPicker;
        private System.Windows.Forms.ComboBox comboProducts;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.Label labNotes;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtSpec;
        private System.Windows.Forms.Label labPrice;
        private System.Windows.Forms.Label labUnit;
        private System.Windows.Forms.Label labSpec;
        private System.Windows.Forms.TextBox txtUnit;
        private System.Windows.Forms.Label labProductName;
        private System.Windows.Forms.Label labDate;
        private System.Windows.Forms.Label labStockInQuantity;
        private System.Windows.Forms.Label labTotalQuantity;
        private System.Windows.Forms.TextBox txtStockInQuantity;
        private System.Windows.Forms.TextBox txtTotalQuantity;
        private System.Windows.Forms.Label labWarning;
    }
}