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
    public partial class StockInDetails : Form
    {
        public StockInDetails()
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

                var stockInRecords = context.StockInRecords.ToList();
                if (dtStart.Checked) stockInRecords = stockInRecords.Where(r => r.Date >= dtStart.Value).ToList();
                if (dtEnd.Checked) stockInRecords = stockInRecords.Where(r => r.Date <= dtEnd.Value).ToList();
                foreach (StockInRecords stockInRecord in stockInRecords)
                {
                    var index = GridStockInDetails.Rows.Add();
                    GridStockInDetails.Rows[index].Cells["colName"].Value = stockInRecord.ProductName;
                    GridStockInDetails.Rows[index].Cells["colID"].Value = stockInRecord.Id;
                    GridStockInDetails.Rows[index].Cells["colSpec"].Value = stockInRecord.ProductSpec;
                    GridStockInDetails.Rows[index].Cells["colUnit"].Value = stockInRecord.ProductUnit;
                    GridStockInDetails.Rows[index].Cells["colNotes"].Value = stockInRecord.ProductNotes;
                    GridStockInDetails.Rows[index].Cells["colDate"].Value = stockInRecord.Date.GetValueOrDefault().ToString("yyyy/MM/dd");
                    GridStockInDetails.Rows[index].Cells["colQuantity"].Value = string.Format("{0:0}", stockInRecord.Quantity);
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
    }
}
