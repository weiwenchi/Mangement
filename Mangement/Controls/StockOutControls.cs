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
    public partial class StockOutControls : UserControl
    {
        public StockOutControls()
        {
            InitializeComponent();
        }

        private void btnStockOut_Click(object sender, EventArgs e)
        {
            Form StockOutProduct = new StockOutProduct();
            StockOutProduct.ShowDialog();
        }

        private void btnStockOutDetails_Click(object sender, EventArgs e)
        {
            Form formStockOutDetail = new StockOutDetail();
            formStockOutDetail.ShowDialog();
        }
    }
}
