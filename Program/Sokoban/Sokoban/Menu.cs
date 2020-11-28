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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnlevel_Click(object sender, EventArgs e)
        {
            frmLevel L = new frmLevel();
            L.Show();

            this.Hide();
        }

        private void btnplay_Click(object sender, EventArgs e)
        {
            frmLevel1 L1 = new frmLevel1();
            L1.Show();

            this.Hide();
        }

        private void btnoption_Click(object sender, EventArgs e)
        {
            frmOption o = new frmOption();
            o.Show();

            this.Hide();
        }

        private void btnlevel_Click_1(object sender, EventArgs e)
        {
            frmLevel l = new frmLevel();
            l.Show();

            this.Hide();
        }
    }
}
