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
    public partial class StockOutDetail : Form
    {
        public StockOutDetail()
        {
            InitializeComponent();
            CenterToScreen();
            refreshProducts();
        }
        public void refreshProducts()
        {
            GridStockInDetails.Rows.Clear();
            using (var context = new ManagementDbEntities())
            {

                var stockOutRecords = context.StockOutRecords.GroupBy(r=>r.InvoiceNumber).Select(group => group.FirstOrDefault()).ToList();
                if (dtStart.Checked) stockOutRecords = stockOutRecords.Where(r => r.Date >= dtStart.Value).ToList();
                if (dtEnd.Checked) stockOutRecords = stockOutRecords.Where(r => r.Date <= dtEnd.Value).ToList();
                foreach (StockOutRecords stockOutRecord in stockOutRecords)
                {
                    var index = GridStockInDetails.Rows.Add();
                    GridStockInDetails.Rows[index].Cells["colName"].Value = stockOutRecord.ProductName;
                    GridStockInDetails.Rows[index].Cells["colID"].Value = stockOutRecord.Id;
                    GridStockInDetails.Rows[index].Cells["colDate"].Value = stockOutRecord.Date.GetValueOrDefault().ToString("yyyy/MM/dd");
                    GridStockInDetails.Rows[index].Cells["ColInvoiceNumber"].Value = stockOutRecord.InvoiceNumber;
                }
            }
        }

        private void dtStart_ValueChanged(object sender, EventArgs e)
        {
            refreshProducts();
        }

        private void dtEnd_ValueChanged(object sender, EventArgs e)
        {
            refreshProducts();
        }

        private void dtEnd_EnabledChanged(object sender, EventArgs e)
        {
            refreshProducts();
        }

        private void dtStart_EnabledChanged(object sender, EventArgs e)
        {
            refreshProducts();
        }

        private void btnInvoice_Click(object sender, EventArgs e)
        {
            Form formInvoice = new Invoice(GridStockInDetails.Rows[GridStockInDetails.CurrentCell.RowIndex].Cells["ColInvoiceNumber"].Value.ToString());
            formInvoice.ShowDialog();
        }
    }
}
