using Management.forms;
using Management.Objects;
using Management.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Management
{
    public partial class Main : Form
    {
        private Connection con;
        public Main(Login frmLogin)
        {
            InitializeComponent();
            CenterToScreen();
            con=frmLogin.con;
            
        }

        private void buttonCustomer_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            var myControl = new CustomersControl();
            panelMain.Controls.Add(myControl);
        }

        private void buttonProduct_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            var myControl = new ProductsControl();
            panelMain.Controls.Add(myControl);
        }

        private void buttonStockIn_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            var myControl = new StockInControls();
            panelMain.Controls.Add(myControl);
        }

        private void buttonStockOut_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            var myControl = new StockOutControls();
            panelMain.Controls.Add(myControl);
        }

        private void buttonSetting_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            var myControl = new SettingControls();
            panelMain.Controls.Add(myControl);
        }
    }
}
