using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP1PBO2020
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bt_login_Click(object sender, EventArgs e)
        {
            Login login = new Login();

            login.username = Convert.ToString(tb_user.Text);
            login.password = Convert.ToString(tb_pass.Text);
            if (String.Compare(login.password, "pbo123") == 0)
            {
                MessageBox.Show("Login Successful");
                Form2 form2 = new Form2();
                this.Hide();
                form2.Show();
            }
            else
            {
                MessageBox.Show("Wrong Login, please try again");
            }
        }

        
    }
}
