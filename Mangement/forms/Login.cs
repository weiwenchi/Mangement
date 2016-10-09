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
using System.Configuration;
using Management;

namespace Management.forms
{
    public partial class Login : Form
    {
        public Connection con { get; set; }

        private bool EnterPressed;
        public Login()
        {
            InitializeComponent();
            con = new Connection();
            con.connectionString = ConfigurationManager.ConnectionStrings["SyncDB"].ToString();
            CenterToScreen();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            bool logined=false;
            string name = textBoxUserName.Text;
            string password = textBoxPassword.Text;
            using (var context = new ManagementDbEntities())
            {
                var user=context.Users.Where(c => c.Name == name).FirstOrDefault();
                if (user != null)
                {
                    var hashedPassword = con.HashPassword(password);
                    if (user.Password.SequenceEqual(hashedPassword))
                    {
                        logined = true;
                    }
                }
            }
            if (logined)
            {
                Form frmMain = new Main(this);
                this.Hide();
                frmMain.Closed += (s, args) => this.Close();
                frmMain.Show();
            }
            else
            {
                labelWarning.Visible = true;
            }
        }

        private void textBoxPassword_KeyUp(object sender, KeyEventArgs e)
        {
            if (EnterPressed)
            {
                buttonLogin_Click(sender, e);
            }
        }

        private void textBoxPassword_KeyDown(object sender, KeyEventArgs e)
        {
            EnterPressed = false;
            if (e.KeyCode == Keys.Enter)
            {
                EnterPressed = true;
                e.SuppressKeyPress = true;
            }
        }
    }
}
