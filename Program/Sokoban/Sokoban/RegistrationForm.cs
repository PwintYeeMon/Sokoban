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
    public partial class frmRegistration : Form
    {
        dsSokobanTableAdapters.UserRegisteration1TableAdapter URF = new dsSokobanTableAdapters.UserRegisteration1TableAdapter();
       
        public frmRegistration()
        {
            InitializeComponent();
        }

        public void autoID()
        {
            DataTable dt = new DataTable();
            dt = URF.GetData();

            if (dt.Rows.Count == 0)
            {
                txtuserid.Text = "U_001";
            }
            else
            {
                int size = dt.Rows.Count - 1;

                string oldid = dt.Rows[size][1].ToString();

                int newid = Convert.ToInt32(oldid.Substring(2, 3));
                
                if (newid >= 1 && newid < 9)
                {
                    txtuserid.Text = "U_00" + (newid + 1);
                }
                else if (newid >= 9 && newid < 99)
                {
                    txtuserid.Text = "U_0" + (newid + 1);
                }
                else if (newid >= 99 && newid < 999)
                {
                    txtuserid.Text = "U_" + (newid + 1);
                }
            }
        }



        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void RegisterationForm_Load(object sender, EventArgs e)
        {
            autoID();
        }

        private void btnplay_Click(object sender, EventArgs e)
        {
            try
            {
                UserRegisteration ur = new UserRegisteration();
                ur.P_id = txtuserid.Text;
                ur.P_name = txtusername.Text;
                ur.P_email = txtemail.Text;
                ur.P_password = txtpassword.Text;
                ur.P_repassword = txtrepassword.Text;

                if (txtusername.Text == "")
                {
                    MessageBox.Show("Enter your name");
                    txtusername.Focus();
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
                    URF.InsertQuery(ur.P_name, ur.P_id, ur.P_email, ur.P_password, ur.P_repassword);
                    MessageBox.Show("Registration has been done successfully");
                    autoID();
                    txtusername.Text = "";
                    txtemail.Text = "";
                    txtpassword.Text = "";
                    txtrepassword.Text = "";

                    frmLogIn lf = new frmLogIn();
                    lf.Show();

                    this.Hide();
                }
            }
            catch (NullReferenceException nre)
            {
                MessageBox.Show(nre.Message);
            }
            catch (IndexOutOfRangeException iore)
            {
                MessageBox.Show(iore.Message);
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void lbllogin_Click(object sender, EventArgs e)
        {
            frmLogIn lf = new frmLogIn();
            lf.Show();

            this.Hide();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
