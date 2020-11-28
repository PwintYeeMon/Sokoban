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
    public partial class frmLevel : Form
    {
        public frmLevel()
        {
            InitializeComponent();
        }

        private void btnlevel1_Click(object sender, EventArgs e)
        {
            frmLevel1 L = new frmLevel1();
            L.Show();

            this.Hide();
        }

        private void btnlevel2_Click(object sender, EventArgs e)
        {
            frmLevel2 L = new frmLevel2();
            L.Show();

            this.Hide();
        }

        private void btnlevel3_Click(object sender, EventArgs e)
        {
            frmLevel3 L = new frmLevel3();
            L.Show();

            this.Hide();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            frmMenu M = new frmMenu();
            M.Show();

            this.Hide();
        }
    }
}
