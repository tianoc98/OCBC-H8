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

    public partial class LoginForm : Form
    {
        Config db = new Config();
        public LoginForm()
        {
            InitializeComponent();
            db.Connect("db_infouser");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RegisterForm register = new RegisterForm();
            register.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            db.ExecuteSelect("SELECT * FROM `tbl_user` where username ='" + username.Text + "' and password ='" + password + "'");
            if(db.Count() == 1)
            {
                MessageBox.Show("Success You Will Login as " + db.Results(0, "names"));
                this.Close();
            }
            else
            {
                MessageBox.Show("Wrong username and password");
            }
        }
    }
}
