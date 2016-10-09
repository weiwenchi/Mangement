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
    public partial class StockInControls : UserControl
    {
        public StockInControls()
        {
            InitializeComponent();
        }

        private void btnStockIn_Click(object sender, EventArgs e)
        {
            Form stockInForm = new StockInProduct();
            stockInForm.ShowDialog();
        }

        private void btnDetails_Click(object sender, EventArgs e)
        {
            Form stockInDetail = new StockInDetails();
            stockInDetail.ShowDialog();
        }
    }
}
