using Management.Objects;
using Management;
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
    public partial class StockInProduct : Form
    {
        private List<Products> products;
        private Products selectedProduct;
        public StockInProduct()
        {
            InitializeComponent();
            CenterToScreen();
            dtPicker.Value = DateTime.Today;
            using (var context = new ManagementDbEntities())
            {
                comboProducts.Items.Clear();
                products = context.Products.ToList();
                comboProducts.DisplayMember = "Text";
                comboProducts.ValueMember = "Value";
                foreach (var product in products)
                {
                    ComboboxItem item = new ComboboxItem { Text = product.Name, Value = product.Id };
                    comboProducts.Items.Add(item);
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedProduct = products.Where(p => p.Id.ToString() == (comboProducts.SelectedItem as ComboboxItem).Value.ToString()).FirstOrDefault();
            if (selectedProduct != null)
            {
                txtSpec.Text = selectedProduct.Spec;
                txtUnit.Text = selectedProduct.Unit;
                txtPrice.Text = string.Format("{0:0.00}", selectedProduct.Price);
                txtNotes.Text = selectedProduct.Notes;
                txtTotalQuantity.Text = selectedProduct.Quantity.ToString();
            }
        }

        private void txtStockInQuantity_TextChanged(object sender, EventArgs e)
        {
            double number;
            if (double.TryParse(txtStockInQuantity.Text, out number))
            {
                labWarning.Visible = false;
            }
            else
            {
                labWarning.Visible = true;
            }
        }

        private void txtStockInQuantity_Leave(object sender, EventArgs e)
        {
            double number;
            if (double.TryParse(txtStockInQuantity.Text, out number))
            {
                number = selectedProduct.Quantity.GetValueOrDefault() + number;
                txtTotalQuantity.Text = number.ToString();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtStockInQuantity.Text == string.Empty)
            {
                labWarning.Visible = true;
            }
            if (!labWarning.Visible)
            {
                using (var context = new ManagementDbEntities())
                {
                    context.Products.Where(c=>c.Id==selectedProduct.Id).FirstOrDefault().Quantity= double.Parse(txtTotalQuantity.Text);
                    var newRecord = new StockInRecords
                    {
                        ProductName = comboProducts.Text,
                        ProductNotes = txtNotes.Text,
                        ProductSpec = txtSpec.Text,
                        ProductUnit = txtUnit.Text,
                        Quantity = double.Parse(txtStockInQuantity.Text),
                        Date = dtPicker.Value,
                    };
                    context.StockInRecords.Add(newRecord);
                    context.SaveChanges();
                    this.Close();
                }
            }
        }
    }
}
