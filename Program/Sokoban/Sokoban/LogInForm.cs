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
    public partial class frmLogIn : Form
    {
        dsSokobanTableAdapters.UserRegisteration1TableAdapter URF = new dsSokobanTableAdapters.UserRegisteration1TableAdapter();

        public static string UserID, UserName, Email;

        public frmLogIn()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void cbouserid_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblregisteration_Click(object sender, EventArgs e)
        {
            frmRegistration rf = new frmRegistration();
            rf.Show();

            this.Hide();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            if (txtusername.Text == "")
            {
                MessageBox.Show("Enter Your Name");
                txtusername.Focus();
            }

            else if (txtpassword.Text == "")
            {
                MessageBox.Show("Enter Your Password");
                txtpassword.Focus();
            }

            else
            {
                DataTable dt = new DataTable();
                dt = URF.GetDataForLogin(txtusername.Text.ToString(), txtpassword.Text.ToString());

                string userName = txtusername.Text;
                string password = txtpassword.Text;

                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Login Successful");

                    dt = URF.LogInProfile(userName,password);
                    dgvlprofile.DataSource = dt;
                    UserID = dgvlprofile[0, 0].Value.ToString();
                    UserName = dgvlprofile[1, 0].Value.ToString();
                    Email = dgvlprofile[2, 0].Value.ToString();

                    frmMenu M = new frmMenu();
                    M.Show();

                    this.Hide();
                }

                else
                {
                    MessageBox.Show("Invalid Login");
                    txtusername.Text = "";
                    txtpassword.Text = "";
                }
            }
        }

        private void frmLogIn_Load(object sender, EventArgs e)
        {

        }
    }
}
