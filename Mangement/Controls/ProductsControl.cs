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
    public partial class ProductsControl : UserControl
    {
        private int currentSelectID = -1;
        public ProductsControl()
        {
            InitializeComponent();
            refreshProducts();
        }
        public void refreshProducts()
        {
            GridProducts.Rows.Clear();
            using (var context = new ManagementDbEntities())
            {

                var products = context.Products.ToList();
                if (products.Count > 0)
                {
                    btnEdit.Enabled = true;
                    btnDelete.Enabled = true;
                    foreach (Products product in products)
                    {
                        var index = GridProducts.Rows.Add();
                        GridProducts.Rows[index].Cells["colName"].Value = product.Name;
                        GridProducts.Rows[index].Cells["colID"].Value = product.Id;
                        GridProducts.Rows[index].Cells["colSpec"].Value = product.Spec;
                        GridProducts.Rows[index].Cells["colUnit"].Value = product.Unit;
                        GridProducts.Rows[index].Cells["colNotes"].Value = product.Notes;
                        GridProducts.Rows[index].Cells["colPrice"].Value = string.Format("{0:0.00}", product.Price);
                        GridProducts.Rows[index].Cells["colQuantity"].Value = string.Format("{0:0}", product.Quantity);
                    }
                    GridProducts_CellClick(GridProducts, new DataGridViewCellEventArgs(0, 0));
                }
                else
                {
                    btnEdit.Enabled = false;
                    btnDelete.Enabled = false;
                }
            }
        }
        private void GridProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                currentSelectID = (int)GridProducts.Rows[e.RowIndex].Cells["colID"].Value;
                GridProducts.Rows[e.RowIndex].Selected = true;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Form frmaddProduct = new AddProduct();
            frmaddProduct.ShowDialog();
            refreshProducts();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Form frmaddProduct = new AddProduct(currentSelectID);
            frmaddProduct.ShowDialog();
            refreshProducts();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            using (var context = new ManagementDbEntities())
            {
                var itemToRemove = context.Products.Where(c => c.Id == currentSelectID).FirstOrDefault();
                if (itemToRemove != null)
                {
                    context.Products.Remove(itemToRemove);
                    context.SaveChanges();
                }
                refreshProducts();
            }
        }
    }
}
