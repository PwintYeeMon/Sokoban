using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sokoban
{
    public partial class frmOption : Form
    {
        dsSokobanTableAdapters.UserRegisteration1TableAdapter URF = new dsSokobanTableAdapters.UserRegisteration1TableAdapter();

        public frmOption()
        {
            InitializeComponent();
        }



        private void btnback_Click(object sender, EventArgs e)
        {
            frmMenu m = new frmMenu();
            m.Show();

            this.Hide();
        }

        private void Option_Load(object sender, EventArgs e)
        {
            txtusername.Text = frmLogIn.UserID;
            txtuserid.Text = frmLogIn.UserName;
            txtemail.Text = frmLogIn.Email;

        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            string P_name = txtusername.Text;
            string P_id = txtuserid.Text;
            string P_email = txtemail.Text;
            string P_password = txtpassword.Text;
            string P_repassword = txtrepassword.Text;

            if (txtusername.Text == "")
            {
                MessageBox.Show("Enter your name");
                txtuserid.Focus();
            }

            else if (txtemail.Text == "")
            {
                MessageBox.Show("Enter your email");
                txtemail.Focus();
            }

            else if (txtpassword.Text == "")
            {
                MessageBox.Show("Enter your password");
                txtpassword.Focus();
            }

            else if (txtrepassword.Text == "")
            {
                MessageBox.Show("Re-enter your password");
                txtrepassword.Focus();
            }

            else if (txtpassword.Text != txtrepassword.Text)
            {
                MessageBox.Show("The passwords you entered do not match. Please re-enter your password");
                txtrepassword.Focus();
            }

            else
            {
                URF.UpdateQuery(P_name, P_email, P_password, P_repassword, P_id);
                MessageBox.Show("Update has been done successfully");

                frmMenu m = new frmMenu();
                m.Show();

                this.Hide();
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
