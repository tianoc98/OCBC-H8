using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hello
{
    public partial class RegisterForm : Form
    {
        Config db = new Config();

        public RegisterForm()
        {
            InitializeComponent();
            db.Connect("db_infouser");
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            db.ExecuteSql("INSERT INTO `tbl_user` (`id`, `name`, `username`, `password`) VALUES (NULL, '" + nama.Text + "', '" + username.Text + "', '" + pass.Text + "')");
            MessageBox.Show("SUCCESS REGISTER");
            this.Close();

        }
    }
}
