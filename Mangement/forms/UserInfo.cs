using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Management.forms
{
    public partial class UserInfo : Form
    {
        public UserInfo()
        {
            InitializeComponent();
            CenterToScreen();
            using (var context = new ManagementDbEntities())
            {
                var user = context.Users.FirstOrDefault();
                txtName.Text=user.Name;
                txtCompanyName.Text=user.CompanyName;
                txtCompanyAddress.Text= user.CompanyAddress;
                txtCompanyContact.Text= user.CompanyContact;
                txtComapnyFax.Text= user.CompanyFax;
                txtInvoiceMaker.Text= user.InvoiceCreator;
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            using (var context = new ManagementDbEntities())
            {
                var user = context.Users.FirstOrDefault();
                user.Name= txtName.Text;
                user.CompanyName=txtCompanyName.Text;
                user.CompanyAddress=txtCompanyAddress.Text;
                user.CompanyContact=txtCompanyContact.Text;
                user.CompanyFax=txtComapnyFax.Text;
                user.InvoiceCreator=txtInvoiceMaker.Text;
                context.SaveChanges();
                this.Close();
            }
        }
    }
}
