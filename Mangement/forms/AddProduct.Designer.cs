namespace Management.forms
{
    partial class AddProduct
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtSpec = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.labPrice = new System.Windows.Forms.Label();
            this.labUnit = new System.Windows.Forms.Label();
            this.labSpec = new System.Windows.Forms.Label();
            this.labName = new System.Windows.Forms.Label();
            this.labNotes = new System.Windows.Forms.Label();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.comUnit = new System.Windows.Forms.ComboBox();
            this.labWarning = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(174, 165);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(72, 165);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "确认";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(72, 100);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(93, 20);
            this.txtPrice.TabIndex = 3;
            this.txtPrice.TextChanged += new System.EventHandler(this.txtPrice_TextChanged);
            this.txtPrice.Leave += new System.EventHandler(this.txtPrice_Leave);
            // 
            // txtSpec
            // 
            this.txtSpec.Location = new System.Drawing.Point(72, 48);
            this.txtSpec.Name = "txtSpec";
            this.txtSpec.Size = new System.Drawing.Size(144, 20);
            this.txtSpec.TabIndex = 1;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(72, 22);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(144, 20);
            this.txtName.TabIndex = 0;
            // 
            // labPrice
            // 
            this.labPrice.AutoSize = true;
            this.labPrice.Location = new System.Drawing.Point(35, 103);
            this.labPrice.Name = "labPrice";
            this.labPrice.Size = new System.Drawing.Size(31, 13);
            this.labPrice.TabIndex = 18;
            this.labPrice.Text = "单价";
            // 
            // labUnit
            // 
            this.labUnit.AutoSize = true;
            this.labUnit.Location = new System.Drawing.Point(35, 77);
            this.labUnit.Name = "labUnit";
            this.labUnit.Size = new System.Drawing.Size(31, 13);
            this.labUnit.TabIndex = 17;
            this.labUnit.Text = "单位";
            // 
            // labSpec
            // 
            this.labSpec.AutoSize = true;
            this.labSpec.Location = new System.Drawing.Point(11, 51);
            this.labSpec.Name = "labSpec";
            this.labSpec.Size = new System.Drawing.Size(55, 13);
            this.labSpec.TabIndex = 16;
            this.labSpec.Text = "规格型号";
            // 
            // labName
            // 
            this.labName.AutoSize = true;
            this.labName.Location = new System.Drawing.Point(35, 25);
            this.labName.Name = "labName";
            this.labName.Size = new System.Drawing.Size(31, 13);
            this.labName.TabIndex = 15;
            this.labName.Text = "名称";
            // 
            // labNotes
            // 
            this.labNotes.AutoSize = true;
            this.labNotes.Location = new System.Drawing.Point(35, 130);
            this.labNotes.Name = "labNotes";
            this.labNotes.Size = new System.Drawing.Size(31, 13);
            this.labNotes.TabIndex = 25;
            this.labNotes.Text = "备注";
            // 
            // txtNotes
            // 
            this.txtNotes.Location = new System.Drawing.Point(72, 127);
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(222, 20);
            this.txtNotes.TabIndex = 4;
            // 
            // comUnit
            // 
            this.comUnit.FormattingEnabled = true;
            this.comUnit.Items.AddRange(new object[] {
            "瓶",
            "只",
            "箱",
            "桶"});
            this.comUnit.Location = new System.Drawing.Point(73, 73);
            this.comUnit.Name = "comUnit";
            this.comUnit.Size = new System.Drawing.Size(55, 21);
            this.comUnit.TabIndex = 2;
            // 
            // labWarning
            // 
            this.labWarning.AutoSize = true;
            this.labWarning.ForeColor = System.Drawing.Color.Red;
            this.labWarning.Location = new System.Drawing.Point(182, 103);
            this.labWarning.Name = "labWarning";
            this.labWarning.Size = new System.Drawing.Size(67, 13);
            this.labWarning.TabIndex = 28;
            this.labWarning.Text = "请输入数字";
            this.labWarning.Visible = false;
            // 
            // AddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 206);
            this.Controls.Add(this.labWarning);
            this.Controls.Add(this.comUnit);
            this.Controls.Add(this.txtNotes);
            this.Controls.Add(this.labNotes);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtSpec);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.labPrice);
            this.Controls.Add(this.labUnit);
            this.Controls.Add(this.labSpec);
            this.Controls.Add(this.labName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AddProduct";
            this.Text = "新产品";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtSpec;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label labPrice;
        private System.Windows.Forms.Label labUnit;
        private System.Windows.Forms.Label labSpec;
        private System.Windows.Forms.Label labName;
        private System.Windows.Forms.Label labNotes;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.ComboBox comUnit;
        private System.Windows.Forms.Label labWarning;
    }
}