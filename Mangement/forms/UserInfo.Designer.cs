namespace Management.forms
{
    partial class UserInfo
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtCompanyName = new System.Windows.Forms.TextBox();
            this.txtCompanyAddress = new System.Windows.Forms.TextBox();
            this.txtCompanyContact = new System.Windows.Forms.TextBox();
            this.txtComapnyFax = new System.Windows.Forms.TextBox();
            this.txtInvoiceMaker = new System.Windows.Forms.TextBox();
            this.labName = new System.Windows.Forms.Label();
            this.labCompanyName = new System.Windows.Forms.Label();
            this.labCompanyAddress = new System.Windows.Forms.Label();
            this.labCompanyContact = new System.Windows.Forms.Label();
            this.labCompanyFax = new System.Windows.Forms.Label();
            this.labInvoiceMaker = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(66, 12);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(115, 20);
            this.txtName.TabIndex = 0;
            // 
            // txtCompanyName
            // 
            this.txtCompanyName.Location = new System.Drawing.Point(66, 38);
            this.txtCompanyName.Name = "txtCompanyName";
            this.txtCompanyName.Size = new System.Drawing.Size(231, 20);
            this.txtCompanyName.TabIndex = 1;
            // 
            // txtCompanyAddress
            // 
            this.txtCompanyAddress.Location = new System.Drawing.Point(66, 64);
            this.txtCompanyAddress.Name = "txtCompanyAddress";
            this.txtCompanyAddress.Size = new System.Drawing.Size(309, 20);
            this.txtCompanyAddress.TabIndex = 2;
            // 
            // txtCompanyContact
            // 
            this.txtCompanyContact.Location = new System.Drawing.Point(66, 90);
            this.txtCompanyContact.Name = "txtCompanyContact";
            this.txtCompanyContact.Size = new System.Drawing.Size(100, 20);
            this.txtCompanyContact.TabIndex = 3;
            // 
            // txtComapnyFax
            // 
            this.txtComapnyFax.Location = new System.Drawing.Point(66, 116);
            this.txtComapnyFax.Name = "txtComapnyFax";
            this.txtComapnyFax.Size = new System.Drawing.Size(100, 20);
            this.txtComapnyFax.TabIndex = 4;
            // 
            // txtInvoiceMaker
            // 
            this.txtInvoiceMaker.Location = new System.Drawing.Point(66, 142);
            this.txtInvoiceMaker.Name = "txtInvoiceMaker";
            this.txtInvoiceMaker.Size = new System.Drawing.Size(100, 20);
            this.txtInvoiceMaker.TabIndex = 5;
            // 
            // labName
            // 
            this.labName.AutoSize = true;
            this.labName.Location = new System.Drawing.Point(17, 15);
            this.labName.Name = "labName";
            this.labName.Size = new System.Drawing.Size(43, 13);
            this.labName.TabIndex = 6;
            this.labName.Text = "用户名";
            // 
            // labCompanyName
            // 
            this.labCompanyName.AutoSize = true;
            this.labCompanyName.Location = new System.Drawing.Point(5, 41);
            this.labCompanyName.Name = "labCompanyName";
            this.labCompanyName.Size = new System.Drawing.Size(55, 13);
            this.labCompanyName.TabIndex = 7;
            this.labCompanyName.Text = "公司名称";
            // 
            // labCompanyAddress
            // 
            this.labCompanyAddress.AutoSize = true;
            this.labCompanyAddress.Location = new System.Drawing.Point(5, 67);
            this.labCompanyAddress.Name = "labCompanyAddress";
            this.labCompanyAddress.Size = new System.Drawing.Size(55, 13);
            this.labCompanyAddress.TabIndex = 8;
            this.labCompanyAddress.Text = "公司地址";
            // 
            // labCompanyContact
            // 
            this.labCompanyContact.AutoSize = true;
            this.labCompanyContact.Location = new System.Drawing.Point(5, 93);
            this.labCompanyContact.Name = "labCompanyContact";
            this.labCompanyContact.Size = new System.Drawing.Size(55, 13);
            this.labCompanyContact.TabIndex = 9;
            this.labCompanyContact.Text = "公司电话";
            // 
            // labCompanyFax
            // 
            this.labCompanyFax.AutoSize = true;
            this.labCompanyFax.Location = new System.Drawing.Point(5, 119);
            this.labCompanyFax.Name = "labCompanyFax";
            this.labCompanyFax.Size = new System.Drawing.Size(55, 13);
            this.labCompanyFax.TabIndex = 10;
            this.labCompanyFax.Text = "公司传真";
            // 
            // labInvoiceMaker
            // 
            this.labInvoiceMaker.AutoSize = true;
            this.labInvoiceMaker.Location = new System.Drawing.Point(17, 145);
            this.labInvoiceMaker.Name = "labInvoiceMaker";
            this.labInvoiceMaker.Size = new System.Drawing.Size(43, 13);
            this.labInvoiceMaker.TabIndex = 11;
            this.labInvoiceMaker.Text = "制单人";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(153, 181);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 12;
            this.btnSubmit.Text = "确认";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // UserInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 216);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.labInvoiceMaker);
            this.Controls.Add(this.labCompanyFax);
            this.Controls.Add(this.labCompanyContact);
            this.Controls.Add(this.labCompanyAddress);
            this.Controls.Add(this.labCompanyName);
            this.Controls.Add(this.labName);
            this.Controls.Add(this.txtInvoiceMaker);
            this.Controls.Add(this.txtComapnyFax);
            this.Controls.Add(this.txtCompanyContact);
            this.Controls.Add(this.txtCompanyAddress);
            this.Controls.Add(this.txtCompanyName);
            this.Controls.Add(this.txtName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "UserInfo";
            this.Text = "用户信息";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtCompanyName;
        private System.Windows.Forms.TextBox txtCompanyAddress;
        private System.Windows.Forms.TextBox txtCompanyContact;
        private System.Windows.Forms.TextBox txtComapnyFax;
        private System.Windows.Forms.TextBox txtInvoiceMaker;
        private System.Windows.Forms.Label labName;
        private System.Windows.Forms.Label labCompanyName;
        private System.Windows.Forms.Label labCompanyAddress;
        private System.Windows.Forms.Label labCompanyContact;
        private System.Windows.Forms.Label labCompanyFax;
        private System.Windows.Forms.Label labInvoiceMaker;
        private System.Windows.Forms.Button btnSubmit;
    }
}