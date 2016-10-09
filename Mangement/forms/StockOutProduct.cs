using Management.Objects;
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
    public partial class StockOutProduct : Form
    {
        private List<Customers> customers;
        private Customers selectedCustomer;
        private List<Products> products;
        public StockOutProduct()
        {
            InitializeComponent();
            CenterToScreen();
            using (var context = new ManagementDbEntities())
            {
                comboCustomerName.Items.Clear();
                customers = context.Customers.ToList();
                products = context.Products.ToList();
                comboCustomerName.DisplayMember = "Text";
                comboCustomerName.ValueMember = "Value";
                foreach (var customer in customers)
                {
                    ComboboxItem item = new ComboboxItem { Text = customer.Name, Value = customer.Id };
                    comboCustomerName.Items.Add(item);
                }

                DataGridViewComboBoxColumn theColumn = (DataGridViewComboBoxColumn)this.GridProducts.Columns["ColName"];
                theColumn.DataSource = products;
                theColumn.ValueMember = "Id";
                theColumn.DisplayMember = "Name";
            }
        }

        private void comboCustomers_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedCustomer = customers.Where(p => p.Id.ToString() == (comboCustomerName.SelectedItem as ComboboxItem).Value.ToString()).FirstOrDefault();
            if (selectedCustomer != null)
            {
                txtContact.Text = selectedCustomer.Contact;
                txtAddress.Text = selectedCustomer.Address;
                txtContactPerson.Text = selectedCustomer.ContactPerson;
            }
        }

        private void btnCreateNewProduct_Click(object sender, EventArgs e)
        {
            GridProducts.Rows.Add();
            if (GridProducts.RowCount == 8)
            {
                btnCreateNewProduct.Enabled = false;
            }
            if (GridProducts.RowCount > 0) btnDelete.Enabled = true;
        }

        private void GridProducts_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                double number;
                if (e.ColumnIndex == 3)
                {
                    if (double.TryParse(GridProducts.Rows[e.RowIndex].Cells["ColPrice"].Value.ToString(), out number))
                    { GridProducts.Rows[e.RowIndex].Cells["ColPrice"].Value = string.Format("{0:0.00}", number); }
                    else GridProducts.Rows[e.RowIndex].Cells["ColPrice"].Value = string.Empty;
                }
                else if (e.ColumnIndex == 4)
                {
                    if (double.TryParse(GridProducts.Rows[e.RowIndex].Cells["ColQuantity"].Value.ToString(), out number))
                    { GridProducts.Rows[e.RowIndex].Cells["ColQuantity"].Value = string.Format("{0:0}", number); }
                    else GridProducts.Rows[e.RowIndex].Cells["ColQuantity"].Value = string.Empty;
                }
                else if (e.ColumnIndex == 0)
                {
                    Products selectedProduct;
                    DataGridViewComboBoxCell cb = (DataGridViewComboBoxCell)GridProducts.CurrentCell;
                    selectedProduct = products.Where(p => p.Id.ToString() == Convert.ToString(cb.Value)).FirstOrDefault();
                    if (selectedProduct != null)
                    {
                        GridProducts.Rows[e.RowIndex].Cells["ColSpec"].Value = selectedProduct.Spec;
                        GridProducts.Rows[e.RowIndex].Cells["ColUnit"].Value = selectedProduct.Unit;
                        GridProducts.Rows[e.RowIndex].Cells["ColPrice"].Value = string.Format("{0:0.00}", selectedProduct.Price);
                        GridProducts.Rows[e.RowIndex].Cells["ColNotes"].Value = selectedProduct.Notes;
                    }
                }
                if ((e.ColumnIndex == 3 || e.ColumnIndex == 4) && GridProducts.Rows[e.RowIndex].Cells["ColPrice"].Value !=null && GridProducts.Rows[e.RowIndex].Cells["ColQuantity"].Value !=null)
                {
                    if (GridProducts.Rows[e.RowIndex].Cells["ColPrice"].Value.ToString() != string.Empty && GridProducts.Rows[e.RowIndex].Cells["ColQuantity"].Value.ToString() != string.Empty)
                    {
                        double price = double.Parse(GridProducts.Rows[e.RowIndex].Cells["ColPrice"].Value.ToString());
                        double quantity = double.Parse(GridProducts.Rows[e.RowIndex].Cells["ColQuantity"].Value.ToString());
                        double productTotalAmount = price * quantity;
                        GridProducts.Rows[e.RowIndex].Cells["ColProductTotalAmount"].Value= string.Format("{0:0.00}", productTotalAmount);
                    }
                    else
                    {
                        GridProducts.Rows[e.RowIndex].Cells["ColProductTotalAmount"].Value = "0.00";
                    }
                    CalculateTotalAmount();
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (GridProducts.CurrentCell.RowIndex>=0)
            { GridProducts.Rows.RemoveAt(GridProducts.CurrentCell.RowIndex); }
            if (GridProducts.RowCount == 0) btnDelete.Enabled = false;
            if (GridProducts.RowCount < 8) btnCreateNewProduct.Enabled = true;

        }

        private void GridProducts_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (GridProducts.IsCurrentCellDirty && GridProducts.CurrentCell.ColumnIndex == 0)
            {
                GridProducts.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        private void btnInvoice_Click(object sender, EventArgs e)
        {
            bool thisCanBeProceed = true;
            int quantity;
            double price;
            labWarning.Visible = false;
            foreach (DataGridViewRow row in GridProducts.Rows)
            {
                if (row.Cells["ColQuantity"].Value.ToString() == string.Empty || !int.TryParse(row.Cells["ColQuantity"].Value.ToString(), out quantity))
                {
                    thisCanBeProceed = false;
                    labWarning.Visible = true;
                    break;
                }
                if (row.Cells["ColPrice"].Value.ToString() == string.Empty || !double.TryParse(row.Cells["ColPrice"].Value.ToString(), out price))
                {
                    thisCanBeProceed = false;
                    labWarning.Visible = true;
                    break;
                }
                Products selectedProduct;
                DataGridViewComboBoxCell cb = (DataGridViewComboBoxCell)row.Cells["ColName"];
                selectedProduct = products.Where(p => p.Id.ToString() == Convert.ToString(cb.Value)).FirstOrDefault();
                if(selectedProduct.Quantity<quantity)
                {
                    thisCanBeProceed = false;
                    MessageBox.Show(selectedProduct.Name+ "库存不足", "错误", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
                    break;
                }
            }
            if (thisCanBeProceed)
            {
                string invoiceNumber;
                invoiceNumber = GetInvoiceNumber();
                using (var context = new ManagementDbEntities())
                {
                    foreach (DataGridViewRow row in GridProducts.Rows)
                    {
                        price = double.Parse(row.Cells["ColPrice"].Value.ToString());
                        quantity = int.Parse(row.Cells["ColQuantity"].Value.ToString());
                        var total = price * quantity;
                        var newRecord = new StockOutRecords
                        {
                            CustomerName = selectedCustomer.Name,
                            CustomerContactPerson = txtContactPerson.Text,
                            CustomerContact = txtContact.Text,
                            CustomerAddress = txtAddress.Text,
                            Date = DateTime.Today.Date,
                            InvoiceNumber = invoiceNumber,
                            ProductSpec = row.Cells["ColSpec"].Value.ToString(),
                            ProductUnit = row.Cells["ColUnit"].Value.ToString(),
                            ProductPrice = price,
                            ProductNotes = row.Cells["ColNotes"].Value.ToString(),
                            ProductQuantity = quantity,
                            ProductTotalAmount = total,
                            ProductName = row.Cells["ColName"].EditedFormattedValue.ToString(),
                            Order = row.Index+1,
                        };
                        context.StockOutRecords.Add(newRecord);
                        Products selectedProduct;
                        DataGridViewComboBoxCell cb = (DataGridViewComboBoxCell)row.Cells["ColName"];
                        selectedProduct = products.Where(p => p.Id.ToString() == Convert.ToString(cb.Value)).FirstOrDefault();
                        var stockoutProduct = context.Products.Where(p => p.Id == selectedProduct.Id).FirstOrDefault();
                        stockoutProduct.Quantity = stockoutProduct.Quantity - quantity;
                        context.SaveChanges();
                    }
                }
                Form formInvoice = new Invoice(invoiceNumber);
                formInvoice.ShowDialog();
                this.Close();
            }

        }

        private string GetInvoiceNumber()
        {
            string invoiceNumber;

            using (var context = new ManagementDbEntities())
            {
                var counter = context.Counters.Where(c => c.Name == "invoice").FirstOrDefault();
                if (counter == null)
                {
                    var newCounter = new Counters
                    {
                        Name = "invoice",
                        Format="<YYYYMM>0000",
                        Value= "<YYYYMM>0000",
                    };
                    context.Counters.Add(newCounter);
                    context.SaveChanges();
                }
                counter = context.Counters.Where(c => c.Name == "invoice").FirstOrDefault();
                if (counter.Value == "<YYYYMM>0000")
                {
                    counter.Value = DateTime.Today.Year.ToString() + string.Format("{0:00}",DateTime.Today.Month) + "0000";
                }
                else
                {
                    string counterValue;
                    int number;
                    if (counter.Value.Substring(0, 4) == DateTime.Today.Year.ToString() && counter.Value.Substring(4, 2) == string.Format("{0:00}", DateTime.Today.Month))
                    {
                        counterValue = counter.Value.Substring(6, 4);
                        int.TryParse(counterValue, out number);
                        number += 1;
                        counterValue = string.Format("{0:0000}", number);
                    }
                    else
                    {
                        counterValue = "0000";
                    }
                    counter.Value = DateTime.Today.Year.ToString() + string.Format("{0:00}", DateTime.Today.Month) + counterValue;
                }

                invoiceNumber = counter.Value;
                context.SaveChanges();
            }
            return invoiceNumber;
        }

        private void CalculateTotalAmount()
        {
            double totalAmount;
            double productAmount;
            totalAmount = 0;
            foreach (DataGridViewRow row in GridProducts.Rows)
            {
                if (row.Cells["ColProductTotalAmount"].Value != null)
                {
                    if (double.TryParse(row.Cells["ColProductTotalAmount"].Value.ToString(), out productAmount))
                    {
                        totalAmount += productAmount;
                    }
                }
            }
            if (totalAmount > 0)
            {
                txtTotalAmount.Text = string.Format("{0:0.00}", totalAmount);
            }
            else
            {
                txtTotalAmount.Text = string.Empty;
            }
        }
    }
}
