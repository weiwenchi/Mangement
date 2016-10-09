using Management;

namespace Management.forms
{
    partial class StockOutProduct
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.txtContactPerson = new System.Windows.Forms.TextBox();
            this.labAddress = new System.Windows.Forms.Label();
            this.labContact = new System.Windows.Forms.Label();
            this.labContactPerson = new System.Windows.Forms.Label();
            this.labName = new System.Windows.Forms.Label();
            this.comboCustomerName = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnCreateNewProduct = new System.Windows.Forms.Button();
            this.GridProducts = new System.Windows.Forms.DataGridView();
            this.colName = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colSpec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNotes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColProductTotalAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnInvoice = new System.Windows.Forms.Button();
            this.labWarning = new System.Windows.Forms.Label();
            this.txtTotalAmount = new System.Windows.Forms.TextBox();
            this.labTotalAmount = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(67, 84);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(614, 20);
            this.txtAddress.TabIndex = 3;
            // 
            // txtContact
            // 
            this.txtContact.Location = new System.Drawing.Point(67, 58);
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(144, 20);
            this.txtContact.TabIndex = 2;
            // 
            // txtContactPerson
            // 
            this.txtContactPerson.Location = new System.Drawing.Point(67, 32);
            this.txtContactPerson.Name = "txtContactPerson";
            this.txtContactPerson.Size = new System.Drawing.Size(93, 20);
            this.txtContactPerson.TabIndex = 1;
            // 
            // labAddress
            // 
            this.labAddress.AutoSize = true;
            this.labAddress.Location = new System.Drawing.Point(30, 87);
            this.labAddress.Name = "labAddress";
            this.labAddress.Size = new System.Drawing.Size(31, 13);
            this.labAddress.TabIndex = 16;
            this.labAddress.Text = "地址";
            // 
            // labContact
            // 
            this.labContact.AutoSize = true;
            this.labContact.Location = new System.Drawing.Point(30, 61);
            this.labContact.Name = "labContact";
            this.labContact.Size = new System.Drawing.Size(31, 13);
            this.labContact.TabIndex = 15;
            this.labContact.Text = "电话";
            // 
            // labContactPerson
            // 
            this.labContactPerson.AutoSize = true;
            this.labContactPerson.Location = new System.Drawing.Point(18, 35);
            this.labContactPerson.Name = "labContactPerson";
            this.labContactPerson.Size = new System.Drawing.Size(43, 13);
            this.labContactPerson.TabIndex = 14;
            this.labContactPerson.Text = "联系人";
            // 
            // labName
            // 
            this.labName.AutoSize = true;
            this.labName.Location = new System.Drawing.Point(6, 9);
            this.labName.Name = "labName";
            this.labName.Size = new System.Drawing.Size(55, 13);
            this.labName.TabIndex = 13;
            this.labName.Text = "客户名称";
            // 
            // comboCustomerName
            // 
            this.comboCustomerName.FormattingEnabled = true;
            this.comboCustomerName.Location = new System.Drawing.Point(67, 5);
            this.comboCustomerName.Name = "comboCustomerName";
            this.comboCustomerName.Size = new System.Drawing.Size(314, 21);
            this.comboCustomerName.TabIndex = 0;
            this.comboCustomerName.SelectedIndexChanged += new System.EventHandler(this.comboCustomers_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnCreateNewProduct);
            this.panel1.Controls.Add(this.GridProducts);
            this.panel1.Location = new System.Drawing.Point(9, 119);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(710, 303);
            this.panel1.TabIndex = 22;
            // 
            // btnDelete
            // 
            this.btnDelete.Enabled = false;
            this.btnDelete.Location = new System.Drawing.Point(84, 3);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "删除产品";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnCreateNewProduct
            // 
            this.btnCreateNewProduct.Location = new System.Drawing.Point(3, 3);
            this.btnCreateNewProduct.Name = "btnCreateNewProduct";
            this.btnCreateNewProduct.Size = new System.Drawing.Size(75, 23);
            this.btnCreateNewProduct.TabIndex = 4;
            this.btnCreateNewProduct.Text = "新增产品";
            this.btnCreateNewProduct.UseVisualStyleBackColor = true;
            this.btnCreateNewProduct.Click += new System.EventHandler(this.btnCreateNewProduct_Click);
            // 
            // GridProducts
            // 
            this.GridProducts.AllowUserToAddRows = false;
            this.GridProducts.AllowUserToResizeColumns = false;
            this.GridProducts.AllowUserToResizeRows = false;
            this.GridProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colName,
            this.colSpec,
            this.colUnit,
            this.colPrice,
            this.colQuantity,
            this.colNotes,
            this.ColProductTotalAmount});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GridProducts.DefaultCellStyle = dataGridViewCellStyle1;
            this.GridProducts.Location = new System.Drawing.Point(3, 32);
            this.GridProducts.Name = "GridProducts";
            this.GridProducts.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.GridProducts.Size = new System.Drawing.Size(704, 268);
            this.GridProducts.TabIndex = 5;
            this.GridProducts.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridProducts_CellValueChanged);
            this.GridProducts.CurrentCellDirtyStateChanged += new System.EventHandler(this.GridProducts_CurrentCellDirtyStateChanged);
            // 
            // colName
            // 
            this.colName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colName.HeaderText = "产品名称";
            this.colName.Name = "colName";
            this.colName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // colSpec
            // 
            this.colSpec.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colSpec.HeaderText = "规格型号";
            this.colSpec.Name = "colSpec";
            this.colSpec.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colSpec.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colUnit
            // 
            this.colUnit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colUnit.HeaderText = "单位";
            this.colUnit.Name = "colUnit";
            this.colUnit.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colUnit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colUnit.Width = 37;
            // 
            // colPrice
            // 
            this.colPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colPrice.HeaderText = "单价";
            this.colPrice.Name = "colPrice";
            this.colPrice.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colPrice.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colPrice.Width = 37;
            // 
            // colQuantity
            // 
            this.colQuantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colQuantity.HeaderText = "数量";
            this.colQuantity.Name = "colQuantity";
            this.colQuantity.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colQuantity.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colQuantity.Width = 37;
            // 
            // colNotes
            // 
            this.colNotes.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colNotes.HeaderText = "备注";
            this.colNotes.Name = "colNotes";
            this.colNotes.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colNotes.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ColProductTotalAmount
            // 
            this.ColProductTotalAmount.HeaderText = "金额";
            this.ColProductTotalAmount.Name = "ColProductTotalAmount";
            this.ColProductTotalAmount.ReadOnly = true;
            this.ColProductTotalAmount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // btnInvoice
            // 
            this.btnInvoice.Location = new System.Drawing.Point(644, 428);
            this.btnInvoice.Name = "btnInvoice";
            this.btnInvoice.Size = new System.Drawing.Size(75, 23);
            this.btnInvoice.TabIndex = 7;
            this.btnInvoice.Text = "生成发票";
            this.btnInvoice.UseVisualStyleBackColor = true;
            this.btnInvoice.Click += new System.EventHandler(this.btnInvoice_Click);
            // labWarning
            // 
            this.labWarning.AutoSize = true;
            this.labWarning.ForeColor = System.Drawing.Color.Red;
            this.labWarning.Location = new System.Drawing.Point(9, 433);
            this.labWarning.Name = "labWarning";
            this.labWarning.Size = new System.Drawing.Size(187, 13);
            this.labWarning.TabIndex = 23;
            this.labWarning.Text = "请确认输入的单价或数量是否正确";
            this.labWarning.Visible = false;
            // 
            // txtTotalAmount
            // 
            this.txtTotalAmount.Location = new System.Drawing.Point(479, 430);
            this.txtTotalAmount.Name = "txtTotalAmount";
            this.txtTotalAmount.ReadOnly = true;
            this.txtTotalAmount.Size = new System.Drawing.Size(100, 20);
            this.txtTotalAmount.TabIndex = 24;
            // 
            // labTotalAmount
            // 
            this.labTotalAmount.AutoSize = true;
            this.labTotalAmount.Location = new System.Drawing.Point(430, 433);
            this.labTotalAmount.Name = "labTotalAmount";
            this.labTotalAmount.Size = new System.Drawing.Size(43, 13);
            this.labTotalAmount.TabIndex = 25;
            this.labTotalAmount.Text = "总金额";
            // 
            // StockOutProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 461);
            this.Controls.Add(this.labTotalAmount);
            this.Controls.Add(this.txtTotalAmount);
            this.Controls.Add(this.labWarning);
            this.Controls.Add(this.btnInvoice);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.comboCustomerName);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtContact);
            this.Controls.Add(this.txtContactPerson);
            this.Controls.Add(this.labAddress);
            this.Controls.Add(this.labContact);
            this.Controls.Add(this.labContactPerson);
            this.Controls.Add(this.labName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "StockOutProduct";
            this.Text = "产品出库";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtContact;
        private System.Windows.Forms.TextBox txtContactPerson;
        private System.Windows.Forms.Label labAddress;
        private System.Windows.Forms.Label labContact;
        private System.Windows.Forms.Label labContactPerson;
        private System.Windows.Forms.Label labName;
        private System.Windows.Forms.ComboBox comboCustomerName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCreateNewProduct;
        private System.Windows.Forms.DataGridView GridProducts;
        private System.Windows.Forms.Button btnInvoice;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label labWarning;
        private System.Windows.Forms.TextBox txtTotalAmount;
        private System.Windows.Forms.Label labTotalAmount;
        private System.Windows.Forms.DataGridViewComboBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSpec;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNotes;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColProductTotalAmount;
    }
}