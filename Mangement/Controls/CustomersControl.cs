using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Management.forms;

namespace Management.Controls
{
    public partial class CustomersControl : UserControl
    {
        private int currentSelectID=-1;
        public CustomersControl()
        {
            InitializeComponent();
            refreshCustomers();
        }
        public void refreshCustomers()
        {
            GridCustomers.Rows.Clear();
            using (var context = new ManagementDbEntities())
            {

                var customers=context.Customers.ToList();
                if (customers.Count > 0)
                {
                    btnEdit.Enabled = true;
                    btnDelete.Enabled = true;
                    foreach (Customers customer in customers)
                    {
                        var index = GridCustomers.Rows.Add();
                        GridCustomers.Rows[index].Cells["colName"].Value = customer.Name;
                        GridCustomers.Rows[index].Cells["colID"].Value = customer.Id;
                        GridCustomers.Rows[index].Cells["colContactPerson"].Value = customer.ContactPerson;
                        GridCustomers.Rows[index].Cells["colContact"].Value = customer.Contact;
                        GridCustomers.Rows[index].Cells["colAddress"].Value = customer.Address;

                    }
                    GridCustomers_CellClick(GridCustomers, new DataGridViewCellEventArgs(0, 0));
                }
                else
                {
                    btnEdit.Enabled = false;
                    btnDelete.Enabled = false;
                    txtName.Text = "";
                    txtContactPerson.Text = "";
                    txtContact.Text = "";
                    txtAddress.Text = "";
                }
            }

        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Form frmaddCustomer = new AddCustomer();
            frmaddCustomer.ShowDialog();
            refreshCustomers();
        }

        private void GridCustomers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                currentSelectID = (int)GridCustomers.Rows[e.RowIndex].Cells["colID"].Value;
                txtName.Text = GridCustomers.Rows[e.RowIndex].Cells["colName"].Value.ToString();
                txtContactPerson.Text = GridCustomers.Rows[e.RowIndex].Cells["colContactPerson"].Value.ToString();
                txtContact.Text = GridCustomers.Rows[e.RowIndex].Cells["colContact"].Value.ToString();
                txtAddress.Text = GridCustomers.Rows[e.RowIndex].Cells["colAddress"].Value.ToString();
                GridCustomers.Rows[e.RowIndex].Selected = true;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Form frmaddCustomer = new AddCustomer(currentSelectID);
            frmaddCustomer.ShowDialog();
            refreshCustomers();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            using (var context = new ManagementDbEntities())
            {
                var itemToRemove = context.Customers.Where(c => c.Id == currentSelectID).FirstOrDefault();
                if (itemToRemove != null)
                {
                    context.Customers.Remove(itemToRemove);
                    context.SaveChanges();
                }
                refreshCustomers();
            }
        }
    }
}
