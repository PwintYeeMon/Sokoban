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
    public partial class frmStart : Form
    {
        Timer formClose = new Timer();
        public frmStart()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void frmStart_Load(object sender, EventArgs e)
        {
        
            formClose.Interval = 3000;
            formClose.Tick += new EventHandler(formClose_Tick);
            formClose.Start();
        }

        void formClose_Tick(object sender, EventArgs e)
        {
            formClose.Stop();
            formClose.Tick -= new EventHandler(formClose_Tick);

            frmRegistration L = new frmRegistration();
            L.Show();

            this.Hide();
        }
    }
}
