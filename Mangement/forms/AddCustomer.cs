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
    public partial class AddCustomer : Form
    {
        private int selectedID;
        public AddCustomer(int id=-1)
        {
            InitializeComponent();
            CenterToScreen();
            selectedID = id;
            if (id > 0)
            {
                this.Text = "编辑客户";
                using (var context = new ManagementDbEntities())
                {
                    var selectCustomer = context.Customers.Where(c => c.Id == selectedID).FirstOrDefault();
                    txtName.Text = selectCustomer.Name;
                    txtContactPerson.Text = selectCustomer.ContactPerson;
                    txtContact.Text = selectCustomer.Contact;
                    txtAddress.Text = selectCustomer.Address;
                }
            }
            else
            {
                this.Text = "新客户";
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (var context = new ManagementDbEntities())
            {
                if (selectedID > 0)
                { 
                    var selectCustomer = context.Customers.Where(c => c.Id == selectedID).FirstOrDefault();
                    selectCustomer.Name = txtName.Text;
                    selectCustomer.ContactPerson = txtContactPerson.Text;
                    selectCustomer.Contact = txtContact.Text;
                    selectCustomer.Address = txtAddress.Text;
                    context.SaveChanges();
                    this.Close();
                }
                else
                {
                    var newCustomer = new Customers
                    {
                        Name = txtName.Text,
                        ContactPerson = txtContactPerson.Text,
                        Contact = txtContact.Text,
                        Address = txtAddress.Text,
                    };
                    context.Customers.Add(newCustomer);
                    context.SaveChanges();
                    this.Close();
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
