using Management.Objects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Management.forms
{
    public partial class PassWordChange : Form
    {
        public Connection con { get; set; }
        public PassWordChange()
        {
            InitializeComponent();
            CenterToScreen();
            con = new Connection();
            con.connectionString = ConfigurationManager.ConnectionStrings["SyncDB"].ToString();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            using (var context = new ManagementDbEntities())
            {
                string password = textBoxPassword.Text;
                string newPassword = txtNewPassword.Text;
                var user = context.Users.FirstOrDefault();
                if (user != null)
                {
                    labelWarning.Visible = false;
                    var hashedPassword = con.HashPassword(password);
                    if (user.Password.SequenceEqual(hashedPassword))
                    {
                        var hashedNewPassWord = con.HashPassword(newPassword);
                        user.Password = hashedNewPassWord;
                        context.SaveChanges();
                        this.Close();
                    }
                    else
                    {
                        labelWarning.Visible = true;
                    }
                }
            }
        }
    }
}
