namespace Management.Controls
{
    partial class CustomersControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panButtons = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.panDetails = new System.Windows.Forms.Panel();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.txtContactPerson = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.labContactName = new System.Windows.Forms.Label();
            this.labContact = new System.Windows.Forms.Label();
            this.labAddress = new System.Windows.Forms.Label();
            this.labName = new System.Windows.Forms.Label();
            this.panCustomers = new System.Windows.Forms.Panel();
            this.GridCustomers = new System.Windows.Forms.DataGridView();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colContactPerson = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colContact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panButtons.SuspendLayout();
            this.panDetails.SuspendLayout();
            this.panCustomers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridCustomers)).BeginInit();
            this.SuspendLayout();
            // 
            // panButtons
            // 
            this.panButtons.Controls.Add(this.btnDelete);
            this.panButtons.Controls.Add(this.btnEdit);
            this.panButtons.Controls.Add(this.btnAdd);
            this.panButtons.Location = new System.Drawing.Point(3, 3);
            this.panButtons.Name = "panButtons";
            this.panButtons.Size = new System.Drawing.Size(940, 35);
            this.panButtons.TabIndex = 0;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(167, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "删除";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(85, 4);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "编辑";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(4, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "新增";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // panDetails
            // 
            this.panDetails.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panDetails.Controls.Add(this.txtAddress);
            this.panDetails.Controls.Add(this.txtContact);
            this.panDetails.Controls.Add(this.txtContactPerson);
            this.panDetails.Controls.Add(this.txtName);
            this.panDetails.Controls.Add(this.labContactName);
            this.panDetails.Controls.Add(this.labContact);
            this.panDetails.Controls.Add(this.labAddress);
            this.panDetails.Controls.Add(this.labName);
            this.panDetails.Location = new System.Drawing.Point(3, 36);
            this.panDetails.Name = "panDetails";
            this.panDetails.Size = new System.Drawing.Size(940, 60);
            this.panDetails.TabIndex = 1;
            // 
            // txtAddress
            // 
            this.txtAddress.Enabled = false;
            this.txtAddress.Location = new System.Drawing.Point(53, 32);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(882, 20);
            this.txtAddress.TabIndex = 8;
            // 
            // txtContact
            // 
            this.txtContact.Enabled = false;
            this.txtContact.Location = new System.Drawing.Point(791, 7);
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(144, 20);
            this.txtContact.TabIndex = 7;
            // 
            // txtContactPerson
            // 
            this.txtContactPerson.Enabled = false;
            this.txtContactPerson.Location = new System.Drawing.Point(655, 7);
            this.txtContactPerson.Name = "txtContactPerson";
            this.txtContactPerson.Size = new System.Drawing.Size(93, 20);
            this.txtContactPerson.TabIndex = 6;
            // 
            // txtName
            // 
            this.txtName.Enabled = false;
            this.txtName.Location = new System.Drawing.Point(53, 7);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(547, 20);
            this.txtName.TabIndex = 5;
            // 
            // labContactName
            // 
            this.labContactName.AutoSize = true;
            this.labContactName.Location = new System.Drawing.Point(606, 10);
            this.labContactName.Name = "labContactName";
            this.labContactName.Size = new System.Drawing.Size(43, 13);
            this.labContactName.TabIndex = 4;
            this.labContactName.Text = "联系人";
            // 
            // labContact
            // 
            this.labContact.AutoSize = true;
            this.labContact.Location = new System.Drawing.Point(754, 10);
            this.labContact.Name = "labContact";
            this.labContact.Size = new System.Drawing.Size(31, 13);
            this.labContact.TabIndex = 2;
            this.labContact.Text = "电话";
            // 
            // labAddress
            // 
            this.labAddress.AutoSize = true;
            this.labAddress.Location = new System.Drawing.Point(16, 35);
            this.labAddress.Name = "labAddress";
            this.labAddress.Size = new System.Drawing.Size(31, 13);
            this.labAddress.TabIndex = 1;
            this.labAddress.Text = "地址";
            // 
            // labName
            // 
            this.labName.AutoSize = true;
            this.labName.Location = new System.Drawing.Point(16, 10);
            this.labName.Name = "labName";
            this.labName.Size = new System.Drawing.Size(31, 13);
            this.labName.TabIndex = 0;
            this.labName.Text = "名称";
            // 
            // panCustomers
            // 
            this.panCustomers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panCustomers.Controls.Add(this.GridCustomers);
            this.panCustomers.Location = new System.Drawing.Point(3, 102);
            this.panCustomers.Name = "panCustomers";
            this.panCustomers.Size = new System.Drawing.Size(940, 482);
            this.panCustomers.TabIndex = 2;
            // 
            // GridCustomers
            // 
            this.GridCustomers.AllowUserToAddRows = false;
            this.GridCustomers.AllowUserToDeleteRows = false;
            this.GridCustomers.AllowUserToResizeColumns = false;
            this.GridCustomers.AllowUserToResizeRows = false;
            this.GridCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridCustomers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colName,
            this.colContactPerson,
            this.colContact,
            this.colAddress,
            this.colID});
            this.GridCustomers.Location = new System.Drawing.Point(3, 3);
            this.GridCustomers.Name = "GridCustomers";
            this.GridCustomers.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.GridCustomers.Size = new System.Drawing.Size(932, 474);
            this.GridCustomers.TabIndex = 0;
            this.GridCustomers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridCustomers_CellClick);
            // 
            // colName
            // 
            this.colName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colName.HeaderText = "名称";
            this.colName.Name = "colName";
            this.colName.ReadOnly = true;
            this.colName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colName.Width = 37;
            // 
            // colContactPerson
            // 
            this.colContactPerson.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colContactPerson.HeaderText = "联系人";
            this.colContactPerson.Name = "colContactPerson";
            this.colContactPerson.ReadOnly = true;
            this.colContactPerson.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colContactPerson.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colContactPerson.Width = 49;
            // 
            // colContact
            // 
            this.colContact.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colContact.HeaderText = "电话";
            this.colContact.Name = "colContact";
            this.colContact.ReadOnly = true;
            this.colContact.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colContact.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colContact.Width = 37;
            // 
            // colAddress
            // 
            this.colAddress.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colAddress.HeaderText = "地址";
            this.colAddress.Name = "colAddress";
            this.colAddress.ReadOnly = true;
            this.colAddress.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colAddress.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colID
            // 
            this.colID.HeaderText = "ID";
            this.colID.Name = "colID";
            this.colID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colID.Visible = false;
            // 
            // CustomersControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panCustomers);
            this.Controls.Add(this.panDetails);
            this.Controls.Add(this.panButtons);
            this.Name = "CustomersControl";
            this.Size = new System.Drawing.Size(946, 587);
            this.panButtons.ResumeLayout(false);
            this.panDetails.ResumeLayout(false);
            this.panDetails.PerformLayout();
            this.panCustomers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridCustomers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panButtons;
        private System.Windows.Forms.Panel panDetails;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtContact;
        private System.Windows.Forms.TextBox txtContactPerson;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label labContactName;
        private System.Windows.Forms.Label labContact;
        private System.Windows.Forms.Label labAddress;
        private System.Windows.Forms.Label labName;
        private System.Windows.Forms.Panel panCustomers;
        private System.Windows.Forms.DataGridView GridCustomers;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colContactPerson;
        private System.Windows.Forms.DataGridViewTextBoxColumn colContact;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
    }
}
