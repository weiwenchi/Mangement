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
    public partial class SettingControls : UserControl
    {
        public SettingControls()
        {
            InitializeComponent();
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            Form formChangePassword = new PassWordChange();
            formChangePassword.ShowDialog();
        }

        private void btnEditUserInfo_Click(object sender, EventArgs e)
        {
            Form formUserInfo = new UserInfo();
            formUserInfo.ShowDialog();
        }
    }
}
