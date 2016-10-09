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
    public partial class AddProduct : Form
    {
        private int selectedID;
        public AddProduct(int id = -1)
        {
            InitializeComponent();
            CenterToScreen();
            selectedID = id;
            if (id > 0)
            {
                this.Text = "编辑产品";
                using (var context = new ManagementDbEntities())
                {
                    var selectProduct = context.Products.Where(c => c.Id == selectedID).FirstOrDefault();
                    txtName.Text = selectProduct.Name;
                    txtSpec.Text = selectProduct.Spec;
                    comUnit.Text = selectProduct.Unit;
                    txtPrice.Text = string.Format("{0:0.00}",selectProduct.Price);
                    txtNotes.Text = selectProduct.Notes;
                }
            }
            else
            {
                this.Text = "新产品";
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtPrice.Text == string.Empty)
            {
                labWarning.Visible = true;
            }
            if (!labWarning.Visible)
            {
                using (var context = new ManagementDbEntities())
                {

                    if (selectedID > 0)
                    {
                        var selectProduct = context.Products.Where(c => c.Id == selectedID).FirstOrDefault();
                        selectProduct.Name = txtName.Text;
                        selectProduct.Spec = txtSpec.Text;
                        selectProduct.Unit = comUnit.Text;
                        selectProduct.Price = double.Parse(txtPrice.Text);
                        selectProduct.Notes = txtNotes.Text;
                        context.SaveChanges();
                        this.Close();
                    }
                    else
                    {
                        var newProduct = new Products
                        {
                            Name = txtName.Text,
                            Spec = txtSpec.Text,
                            Unit = comUnit.Text,
                            Price = double.Parse(txtPrice.Text),
                            Notes = txtNotes.Text,
                            Quantity = 0,
                        };
                        context.Products.Add(newProduct);
                        context.SaveChanges();
                        this.Close();
                    }
                }
            }
        }
        private void txtPrice_TextChanged(object sender, EventArgs e)
        {
            double number;
            if (double.TryParse(txtPrice.Text, out number))
            {
                labWarning.Visible = false;
            }
            else
            {
                labWarning.Visible = true;
            }
        }

        private void txtPrice_Leave(object sender, EventArgs e)
        {
            double number;
            if (double.TryParse(txtPrice.Text, out number))
            {
                txtPrice.Text = string.Format("{0:0.00}", double.Parse(txtPrice.Text));
            }
        }
    }
}
