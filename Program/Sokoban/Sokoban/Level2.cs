using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Sokoban
{
    public partial class frmLevel2 : Form
    {
        int count = 120;
        int pistolcount = 1;

        public frmLevel2()
        {
            InitializeComponent();
        }

        private void pictureBox35_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox52_Click(object sender, EventArgs e)
        {

        }

        private void btnback_Click(object sender, EventArgs e)
        {
            frmLevel l = new frmLevel();
            l.Show();

            this.Hide();
        }

        private void pboption_Click(object sender, EventArgs e)
        {
            
        }

        private void frmLevel2_KeyDown(object sender, KeyEventArgs e)
        {
            int px = pbchar.Location.X;
            int py = pbchar.Location.Y;

            List<PictureBox> walls = new List<PictureBox> { wall1, wall2, wall3, wall4, wall5, wall6, wall7, wall8, wall9,
                wall10, wall11, wall12, wall13, wall14, wall15, wall16, wall17, wall18, wall19, wall20, wall21, wall22, 
                wall23, wall24, wall25, wall26, wall27, wall28, wall29, wall30, wall31, wall32, wall33, wall34, wall35, 
                wall36, wall37, wall38, wall39, wall40, wall41 };
           
            List<PictureBox> boxes = new List<PictureBox> { pbbox1, pbbox2, pbbox3, pbbox4, pbbox5, pbextrabox };

            List<PictureBox> targets = new List<PictureBox> { pbtarget1, pbtarget2, pbtarget3, pbtarget4 };

            if (e.KeyData == Keys.Right)
            {
                bool isWall = false;
                foreach (var wall in walls)
                {
                    if ((pbchar.Location.X + 30) == wall.Location.X && pbchar.Location.Y == wall.Location.Y)
                    {
                        isWall = true;
                        break;
                    }
                }
                if (isWall == false)
                {
                    px += 30; count -= 1;

                    foreach (var box in boxes)
                    {
                        if (px == box.Location.X && py == box.Location.Y)
                        {
                            box.Left += 30;

                            if (pbbox1.Location.X == pbbox2.Location.X && pbbox1.Location.Y == pbbox2.Location.Y ||
                                pbbox1.Location.X == pbbox3.Location.X && pbbox1.Location.Y == pbbox3.Location.Y ||
                                pbbox1.Location.X == pbbox4.Location.X && pbbox1.Location.Y == pbbox4.Location.Y ||
                                pbbox1.Location.X == pbbox5.Location.X && pbbox1.Location.Y == pbbox5.Location.Y ||
                                pbbox1.Location.X == pbextrabox.Location.X && pbbox1.Location.Y == pbextrabox.Location.Y ||

                                pbbox2.Location.X == pbbox1.Location.X && pbbox2.Location.Y == pbbox1.Location.Y ||
                                pbbox2.Location.X == pbbox3.Location.X && pbbox2.Location.Y == pbbox3.Location.Y ||
                                pbbox2.Location.X == pbbox4.Location.X && pbbox2.Location.Y == pbbox4.Location.Y ||
                                pbbox2.Location.X == pbbox5.Location.X && pbbox2.Location.Y == pbbox5.Location.Y ||
                                pbbox2.Location.X == pbextrabox.Location.X && pbbox2.Location.Y == pbextrabox.Location.Y ||

                                pbbox3.Location.X == pbbox1.Location.X && pbbox3.Location.Y == pbbox1.Location.Y ||
                                pbbox3.Location.X == pbbox2.Location.X && pbbox3.Location.Y == pbbox2.Location.Y ||
                                pbbox3.Location.X == pbbox4.Location.X && pbbox3.Location.Y == pbbox4.Location.Y ||
                                pbbox3.Location.X == pbbox5.Location.X && pbbox3.Location.Y == pbbox5.Location.Y ||
                                pbbox3.Location.X == pbextrabox.Location.X && pbbox3.Location.Y == pbextrabox.Location.Y ||

                                pbbox4.Location.X == pbbox1.Location.X && pbbox4.Location.Y == pbbox1.Location.Y ||
                                pbbox4.Location.X == pbbox2.Location.X && pbbox4.Location.Y == pbbox2.Location.Y ||
                                pbbox4.Location.X == pbbox3.Location.X && pbbox4.Location.Y == pbbox3.Location.Y ||
                                pbbox4.Location.X == pbbox5.Location.X && pbbox4.Location.Y == pbbox5.Location.Y ||
                                pbbox4.Location.X == pbextrabox.Location.X && pbbox4.Location.Y == pbextrabox.Location.Y ||

                                pbbox5.Location.X == pbbox1.Location.X && pbbox5.Location.Y == pbbox1.Location.Y ||
                                pbbox5.Location.X == pbbox2.Location.X && pbbox5.Location.Y == pbbox2.Location.Y ||
                                pbbox5.Location.X == pbbox3.Location.X && pbbox5.Location.Y == pbbox3.Location.Y ||
                                pbbox5.Location.X == pbbox4.Location.X && pbbox5.Location.Y == pbbox4.Location.Y ||
                                pbbox5.Location.X == pbextrabox.Location.X && pbbox5.Location.Y == pbextrabox.Location.Y ||

                                pbextrabox.Location.X == pbbox1.Location.X && pbextrabox.Location.Y == pbbox1.Location.Y ||
                                pbextrabox.Location.X == pbbox2.Location.X && pbextrabox.Location.Y == pbbox2.Location.Y ||
                                pbextrabox.Location.X == pbbox3.Location.X && pbextrabox.Location.Y == pbbox3.Location.Y ||
                                pbextrabox.Location.X == pbbox4.Location.X && pbextrabox.Location.Y == pbbox4.Location.Y ||
                                pbextrabox.Location.X == pbbox5.Location.X && pbextrabox.Location.Y == pbbox5.Location.Y
                                )
                             {
                                 px -= 30;
                                 box.Left -= 30;
                                 count += 1;
                             }

                            foreach (var wall in walls)
                            {
                                if (box.Location.X == wall.Location.X && box.Location.Y == wall.Location.Y)
                                {
                                    px -= 30;
                                    box.Left -= 30;
                                    count += 1;
                                }
                            }
                        }
                    }
                }
            }
            else if (e.KeyData == Keys.Left)
            {
                bool isWall = false;
                foreach (var wall in walls)
                {
                    if ((pbchar.Location.X - 30) == wall.Location.X && pbchar.Location.Y == wall.Location.Y)
                    {
                        isWall = true;
                        break;
                    }
                }
                if (isWall == false)
                {
                    px -= 30; count -= 1;

                    foreach (var box in boxes)
                    {
                        if (px == box.Location.X && py == box.Location.Y)
                        {
                            box.Left -= 30;

                            if (pbbox1.Location.X == pbbox2.Location.X && pbbox1.Location.Y == pbbox2.Location.Y ||
                                pbbox1.Location.X == pbbox3.Location.X && pbbox1.Location.Y == pbbox3.Location.Y ||
                                pbbox1.Location.X == pbbox4.Location.X && pbbox1.Location.Y == pbbox4.Location.Y ||
                                pbbox1.Location.X == pbbox5.Location.X && pbbox1.Location.Y == pbbox5.Location.Y ||
                                pbbox1.Location.X == pbextrabox.Location.X && pbbox1.Location.Y == pbextrabox.Location.Y ||

                                pbbox2.Location.X == pbbox1.Location.X && pbbox2.Location.Y == pbbox1.Location.Y ||
                                pbbox2.Location.X == pbbox3.Location.X && pbbox2.Location.Y == pbbox3.Location.Y ||
                                pbbox2.Location.X == pbbox4.Location.X && pbbox2.Location.Y == pbbox4.Location.Y ||
                                pbbox2.Location.X == pbbox5.Location.X && pbbox2.Location.Y == pbbox5.Location.Y ||
                                pbbox2.Location.X == pbextrabox.Location.X && pbbox2.Location.Y == pbextrabox.Location.Y ||

                                pbbox3.Location.X == pbbox1.Location.X && pbbox3.Location.Y == pbbox1.Location.Y ||
                                pbbox3.Location.X == pbbox2.Location.X && pbbox3.Location.Y == pbbox2.Location.Y ||
                                pbbox3.Location.X == pbbox4.Location.X && pbbox3.Location.Y == pbbox4.Location.Y ||
                                pbbox3.Location.X == pbbox5.Location.X && pbbox3.Location.Y == pbbox5.Location.Y ||
                                pbbox3.Location.X == pbextrabox.Location.X && pbbox3.Location.Y == pbextrabox.Location.Y ||

                                pbbox4.Location.X == pbbox1.Location.X && pbbox4.Location.Y == pbbox1.Location.Y ||
                                pbbox4.Location.X == pbbox2.Location.X && pbbox4.Location.Y == pbbox2.Location.Y ||
                                pbbox4.Location.X == pbbox3.Location.X && pbbox4.Location.Y == pbbox3.Location.Y ||
                                pbbox4.Location.X == pbbox5.Location.X && pbbox4.Location.Y == pbbox5.Location.Y ||
                                pbbox4.Location.X == pbextrabox.Location.X && pbbox4.Location.Y == pbextrabox.Location.Y ||

                                pbbox5.Location.X == pbbox1.Location.X && pbbox5.Location.Y == pbbox1.Location.Y ||
                                pbbox5.Location.X == pbbox2.Location.X && pbbox5.Location.Y == pbbox2.Location.Y ||
                                pbbox5.Location.X == pbbox3.Location.X && pbbox5.Location.Y == pbbox3.Location.Y ||
                                pbbox5.Location.X == pbbox4.Location.X && pbbox5.Location.Y == pbbox4.Location.Y ||
                                pbbox5.Location.X == pbextrabox.Location.X && pbbox5.Location.Y == pbextrabox.Location.Y ||

                                pbextrabox.Location.X == pbbox1.Location.X && pbextrabox.Location.Y == pbbox1.Location.Y ||
                                pbextrabox.Location.X == pbbox2.Location.X && pbextrabox.Location.Y == pbbox2.Location.Y ||
                                pbextrabox.Location.X == pbbox3.Location.X && pbextrabox.Location.Y == pbbox3.Location.Y ||
                                pbextrabox.Location.X == pbbox4.Location.X && pbextrabox.Location.Y == pbbox4.Location.Y ||
                                pbextrabox.Location.X == pbbox5.Location.X && pbextrabox.Location.Y == pbbox5.Location.Y
                                )
                            {
                                px += 30;
                                box.Left += 30;
                                count += 1;
                            }

                            foreach (var wall in walls)
                            {
                                if (box.Location.X == wall.Location.X && box.Location.Y == wall.Location.Y)
                                {
                                    px += 30;
                                    box.Left += 30;
                                    count += 1;
                                }
                            }
                        }
                    }
                }
            }
            else if (e.KeyData == Keys.Up)
            {
                bool isWall = false;
                foreach (var wall in walls)
                {
                    if ((pbchar.Location.Y - 30) == wall.Location.Y && pbchar.Location.X == wall.Location.X)
                    {
                        isWall = true;
                        break;
                    }
                }
                if (isWall == false)
                {
                    py -= 30; count -= 1;

                    foreach (var box in boxes)
                    {
                        if (py == box.Location.Y && px == box.Location.X)
                        {
                            box.Top -= 30;

                            if (pbbox1.Location.X == pbbox2.Location.X && pbbox1.Location.Y == pbbox2.Location.Y ||
                                pbbox1.Location.X == pbbox3.Location.X && pbbox1.Location.Y == pbbox3.Location.Y ||
                                pbbox1.Location.X == pbbox4.Location.X && pbbox1.Location.Y == pbbox4.Location.Y ||
                                pbbox1.Location.X == pbbox5.Location.X && pbbox1.Location.Y == pbbox5.Location.Y ||
                                pbbox1.Location.X == pbextrabox.Location.X && pbbox1.Location.Y == pbextrabox.Location.Y ||

                                pbbox2.Location.X == pbbox1.Location.X && pbbox2.Location.Y == pbbox1.Location.Y ||
                                pbbox2.Location.X == pbbox3.Location.X && pbbox2.Location.Y == pbbox3.Location.Y ||
                                pbbox2.Location.X == pbbox4.Location.X && pbbox2.Location.Y == pbbox4.Location.Y ||
                                pbbox2.Location.X == pbbox5.Location.X && pbbox2.Location.Y == pbbox5.Location.Y ||
                                pbbox2.Location.X == pbextrabox.Location.X && pbbox2.Location.Y == pbextrabox.Location.Y ||

                                pbbox3.Location.X == pbbox1.Location.X && pbbox3.Location.Y == pbbox1.Location.Y ||
                                pbbox3.Location.X == pbbox2.Location.X && pbbox3.Location.Y == pbbox2.Location.Y ||
                                pbbox3.Location.X == pbbox4.Location.X && pbbox3.Location.Y == pbbox4.Location.Y ||
                                pbbox3.Location.X == pbbox5.Location.X && pbbox3.Location.Y == pbbox5.Location.Y ||
                                pbbox3.Location.X == pbextrabox.Location.X && pbbox3.Location.Y == pbextrabox.Location.Y ||

                                pbbox4.Location.X == pbbox1.Location.X && pbbox4.Location.Y == pbbox1.Location.Y ||
                                pbbox4.Location.X == pbbox2.Location.X && pbbox4.Location.Y == pbbox2.Location.Y ||
                                pbbox4.Location.X == pbbox3.Location.X && pbbox4.Location.Y == pbbox3.Location.Y ||
                                pbbox4.Location.X == pbbox5.Location.X && pbbox4.Location.Y == pbbox5.Location.Y ||
                                pbbox4.Location.X == pbextrabox.Location.X && pbbox4.Location.Y == pbextrabox.Location.Y ||

                                pbbox5.Location.X == pbbox1.Location.X && pbbox5.Location.Y == pbbox1.Location.Y ||
                                pbbox5.Location.X == pbbox2.Location.X && pbbox5.Location.Y == pbbox2.Location.Y ||
                                pbbox5.Location.X == pbbox3.Location.X && pbbox5.Location.Y == pbbox3.Location.Y ||
                                pbbox5.Location.X == pbbox4.Location.X && pbbox5.Location.Y == pbbox4.Location.Y ||
                                pbbox5.Location.X == pbextrabox.Location.X && pbbox5.Location.Y == pbextrabox.Location.Y ||

                                pbextrabox.Location.X == pbbox1.Location.X && pbextrabox.Location.Y == pbbox1.Location.Y ||
                                pbextrabox.Location.X == pbbox2.Location.X && pbextrabox.Location.Y == pbbox2.Location.Y ||
                                pbextrabox.Location.X == pbbox3.Location.X && pbextrabox.Location.Y == pbbox3.Location.Y ||
                                pbextrabox.Location.X == pbbox4.Location.X && pbextrabox.Location.Y == pbbox4.Location.Y ||
                                pbextrabox.Location.X == pbbox5.Location.X && pbextrabox.Location.Y == pbbox5.Location.Y
                                )
                            {
                                py += 30;
                                box.Top += 30;
                                count += 1;
                            }

                            foreach (var wall in walls)
                            {
                                if (box.Location.X == wall.Location.X && box.Location.Y == wall.Location.Y)
                                {
                                    py += 30;
                                    box.Top += 30;
                                    count += 1;
                                }
                            }
                        }
                    }
                }
            }
            else if (e.KeyData == Keys.Down)
            {
                bool isWall = false;
                foreach (var wall in walls)
                {
                    if ((pbchar.Location.Y + 30) == wall.Location.Y && pbchar.Location.X == wall.Location.X)
                    {
                        isWall = true;
                        break;
                    }
                }
                if (isWall == false)
                {
                    py += 30; count -= 1;

                    foreach (var box in boxes)
                    {
                        if (py == box.Location.Y && px == box.Location.X)
                        {
                            box.Top += 30;

                            if (pbbox1.Location.X == pbbox2.Location.X && pbbox1.Location.Y == pbbox2.Location.Y ||
                                pbbox1.Location.X == pbbox3.Location.X && pbbox1.Location.Y == pbbox3.Location.Y ||
                                pbbox1.Location.X == pbbox4.Location.X && pbbox1.Location.Y == pbbox4.Location.Y ||
                                pbbox1.Location.X == pbbox5.Location.X && pbbox1.Location.Y == pbbox5.Location.Y ||
                                pbbox1.Location.X == pbextrabox.Location.X && pbbox1.Location.Y == pbextrabox.Location.Y ||

                                pbbox2.Location.X == pbbox1.Location.X && pbbox2.Location.Y == pbbox1.Location.Y ||
                                pbbox2.Location.X == pbbox3.Location.X && pbbox2.Location.Y == pbbox3.Location.Y ||
                                pbbox2.Location.X == pbbox4.Location.X && pbbox2.Location.Y == pbbox4.Location.Y ||
                                pbbox2.Location.X == pbbox5.Location.X && pbbox2.Location.Y == pbbox5.Location.Y ||
                                pbbox2.Location.X == pbextrabox.Location.X && pbbox2.Location.Y == pbextrabox.Location.Y ||

                                pbbox3.Location.X == pbbox1.Location.X && pbbox3.Location.Y == pbbox1.Location.Y ||
                                pbbox3.Location.X == pbbox2.Location.X && pbbox3.Location.Y == pbbox2.Location.Y ||
                                pbbox3.Location.X == pbbox4.Location.X && pbbox3.Location.Y == pbbox4.Location.Y ||
                                pbbox3.Location.X == pbbox5.Location.X && pbbox3.Location.Y == pbbox5.Location.Y ||
                                pbbox3.Location.X == pbextrabox.Location.X && pbbox3.Location.Y == pbextrabox.Location.Y ||

                                pbbox4.Location.X == pbbox1.Location.X && pbbox4.Location.Y == pbbox1.Location.Y ||
                                pbbox4.Location.X == pbbox2.Location.X && pbbox4.Location.Y == pbbox2.Location.Y ||
                                pbbox4.Location.X == pbbox3.Location.X && pbbox4.Location.Y == pbbox3.Location.Y ||
                                pbbox4.Location.X == pbbox5.Location.X && pbbox4.Location.Y == pbbox5.Location.Y ||
                                pbbox4.Location.X == pbextrabox.Location.X && pbbox4.Location.Y == pbextrabox.Location.Y ||

                                pbbox5.Location.X == pbbox1.Location.X && pbbox5.Location.Y == pbbox1.Location.Y ||
                                pbbox5.Location.X == pbbox2.Location.X && pbbox5.Location.Y == pbbox2.Location.Y ||
                                pbbox5.Location.X == pbbox3.Location.X && pbbox5.Location.Y == pbbox3.Location.Y ||
                                pbbox5.Location.X == pbbox4.Location.X && pbbox5.Location.Y == pbbox4.Location.Y ||
                                pbbox5.Location.X == pbextrabox.Location.X && pbbox5.Location.Y == pbextrabox.Location.Y ||

                                pbextrabox.Location.X == pbbox1.Location.X && pbextrabox.Location.Y == pbbox1.Location.Y ||
                                pbextrabox.Location.X == pbbox2.Location.X && pbextrabox.Location.Y == pbbox2.Location.Y ||
                                pbextrabox.Location.X == pbbox3.Location.X && pbextrabox.Location.Y == pbbox3.Location.Y ||
                                pbextrabox.Location.X == pbbox4.Location.X && pbextrabox.Location.Y == pbbox4.Location.Y ||
                                pbextrabox.Location.X == pbbox5.Location.X && pbextrabox.Location.Y == pbbox5.Location.Y
                                )
                            {
                                py -= 30;
                                box.Top -= 30;
                                count += 1;
                            }

                            foreach (var wall in walls)
                            {
                                if (box.Location.X == wall.Location.X && box.Location.Y == wall.Location.Y)
                                {
                                    py -= 30;
                                    box.Top -= 30;
                                    count += 1;
                                }
                            }
                        }
                    }
                }
            }

            int successCount = 0;

            foreach (var target in targets)
            {
                if (target.Location.X == pbbox1.Location.X && target.Location.Y == pbbox1.Location.Y ||
                    target.Location.X == pbbox2.Location.X && target.Location.Y == pbbox2.Location.Y ||
                    target.Location.X == pbbox3.Location.X && target.Location.Y == pbbox3.Location.Y ||
                    target.Location.X == pbbox4.Location.X && target.Location.Y == pbbox4.Location.Y ||
                    target.Location.X == pbbox5.Location.X && target.Location.Y == pbbox5.Location.Y
                   )
                {
                    successCount++;
                }
            }

            if (successCount == 4)
            {
                MessageBox.Show("Level 2 Complete!");
                frmLevel3 l3 = new frmLevel3();
                l3.Show();
                this.Hide();
            }

            pbchar.Location = new Point(px, py);

            lblMovementCount.Text = Convert.ToString(count);

            ReachCountLimit();

        }

        public void ReachCountLimit()
        {
            if (count == 0)
            {
                MessageBox.Show("You have reach your limit. Start again.");

                frmLevel2 l2 = new frmLevel2();
                l2.Show();
                this.Hide();
            }
        }

        private void frmLevel2_Load(object sender, EventArgs e)
        {

        }

        private void lblgun_Click(object sender, EventArgs e)
        {
            if (pistolcount == 1)
            {
                int px = pbchar.Location.X;
                int py = pbchar.Location.Y;

                List<PictureBox> walls = new List<PictureBox> { wall1, wall2, wall3, wall4, wall5, wall6, wall7, wall8, wall9,
                wall10, wall11, wall12, wall13, wall14, wall15, wall16, wall17, wall18, wall19, wall20, wall21, wall22, 
                wall23, wall24, wall25, wall26, wall27, wall28, wall29, wall30, wall31, wall32, wall33, wall34, wall35, 
                wall36, wall37, wall38, wall39, wall40, wall41 };

                List<PictureBox> boxes = new List<PictureBox> { pbbox1, pbbox2, pbbox3, pbbox4, pbbox5, pbextrabox };

                List<PictureBox> targets = new List<PictureBox> { pbtarget1, pbtarget2, pbtarget3, pbtarget4 };

                foreach (var box in boxes)
                {
                    if ((py) == box.Location.Y && (px + 60) == box.Location.X)
                    {
                        pistolcount -= 1;
                        box.Visible = false;
                        lblpistolcount.Text = Convert.ToString(pistolcount);
                        box.Location = new Point(0, 0);
                        lblgunright.Enabled = false;
                        lblgunleft.Enabled = false;
                        lblgunup.Enabled = false;
                        lblgundown.Enabled = false;
                    }
                }
            }
            else
            {
                lblgunright.Enabled = false;
                lblgunleft.Enabled = false;
                lblgunup.Enabled = false;
                lblgundown.Enabled = false;
            }
        }

        private void lblgunleft_Click(object sender, EventArgs e)
        {
            if (pistolcount == 1)
            {
                int px = pbchar.Location.X;
                int py = pbchar.Location.Y;

                List<PictureBox> walls = new List<PictureBox> { wall1, wall2, wall3, wall4, wall5, wall6, wall7, wall8, wall9,
                wall10, wall11, wall12, wall13, wall14, wall15, wall16, wall17, wall18, wall19, wall20, wall21, wall22, 
                wall23, wall24, wall25, wall26, wall27, wall28, wall29, wall30, wall31, wall32, wall33, wall34, wall35, 
                wall36, wall37, wall38, wall39, wall40, wall41 };

                List<PictureBox> boxes = new List<PictureBox> { pbbox1, pbbox2, pbbox3, pbbox4, pbbox5, pbextrabox };

                List<PictureBox> targets = new List<PictureBox> { pbtarget1, pbtarget2, pbtarget3, pbtarget4 };

                foreach (var box in boxes)
                {
                    if ((py) == box.Location.Y && (px - 60) == box.Location.X)
                    {
                        pistolcount -= 1;
                        box.Visible = false;
                        lblpistolcount.Text = Convert.ToString(pistolcount);
                        box.Location = new Point(0, 0);
                        lblgunright.Enabled = false;
                        lblgunleft.Enabled = false;
                        lblgunup.Enabled = false;
                        lblgundown.Enabled = false;
                    }
                }
            }
            else
            {
                lblgunright.Enabled = false;
                lblgunleft.Enabled = false;
                lblgunup.Enabled = false;
                lblgundown.Enabled = false;
            }
        }

        private void lblgunup_Click(object sender, EventArgs e)
        {
            if (pistolcount == 1)
            {
                int px = pbchar.Location.X;
                int py = pbchar.Location.Y;

                List<PictureBox> walls = new List<PictureBox> { wall1, wall2, wall3, wall4, wall5, wall6, wall7, wall8, wall9,
                wall10, wall11, wall12, wall13, wall14, wall15, wall16, wall17, wall18, wall19, wall20, wall21, wall22, 
                wall23, wall24, wall25, wall26, wall27, wall28, wall29, wall30, wall31, wall32, wall33, wall34, wall35, 
                wall36, wall37, wall38, wall39, wall40, wall41 };

                List<PictureBox> boxes = new List<PictureBox> { pbbox1, pbbox2, pbbox3, pbbox4, pbbox5, pbextrabox };

                List<PictureBox> targets = new List<PictureBox> { pbtarget1, pbtarget2, pbtarget3, pbtarget4 };

                foreach (var box in boxes)
                {
                    if ((py - 60) == box.Location.Y && (px) == box.Location.X)
                    {
                        pistolcount -= 1;
                        box.Visible = false;
                        lblpistolcount.Text = Convert.ToString(pistolcount);
                        box.Location = new Point(0, 0);
                        lblgunright.Enabled = false;
                        lblgunleft.Enabled = false;
                        lblgunup.Enabled = false;
                        lblgundown.Enabled = false;
                    }
                }
            }
            else
            {
                lblgunright.Enabled = false;
                lblgunleft.Enabled = false;
                lblgunup.Enabled = false;
                lblgundown.Enabled = false;
            }
        }

        private void lblgundown_Click(object sender, EventArgs e)
        {
            if (pistolcount == 1)
            {
                int px = pbchar.Location.X;
                int py = pbchar.Location.Y;

                List<PictureBox> walls = new List<PictureBox> { wall1, wall2, wall3, wall4, wall5, wall6, wall7, wall8, wall9,
                wall10, wall11, wall12, wall13, wall14, wall15, wall16, wall17, wall18, wall19, wall20, wall21, wall22, 
                wall23, wall24, wall25, wall26, wall27, wall28, wall29, wall30, wall31, wall32, wall33, wall34, wall35, 
                wall36, wall37, wall38, wall39, wall40, wall41 };

                List<PictureBox> boxes = new List<PictureBox> { pbbox1, pbbox2, pbbox3, pbbox4, pbbox5, pbextrabox };

                List<PictureBox> targets = new List<PictureBox> { pbtarget1, pbtarget2, pbtarget3, pbtarget4 };

                foreach (var box in boxes)
                {
                    if ((py + 60) == box.Location.Y && (px) == box.Location.X)
                    {
                        pistolcount -= 1;
                        box.Visible = false;
                        lblpistolcount.Text = Convert.ToString(pistolcount);
                        box.Location = new Point(0, 0);
                        lblgunright.Enabled = false;
                        lblgunleft.Enabled = false;
                        lblgunup.Enabled = false;
                        lblgundown.Enabled = false;
                    }
                }
            }
            else
            {
                lblgunright.Enabled = false;
                lblgunleft.Enabled = false;
                lblgunup.Enabled = false;
                lblgundown.Enabled = false;
            }
        }

        private void pbrefresh_Click(object sender, EventArgs e)
        {
            frmLevel2 l2 = new frmLevel2();
            l2.Show();
            this.Hide();
        }

        private void pbmenu_Click(object sender, EventArgs e)
        {
            frmMenu m = new frmMenu();
            m.Show();
            this.Hide();
        }

        private void pblevel_Click(object sender, EventArgs e)
        {
            frmLevel l = new frmLevel();
            l.Show();
            this.Hide();
        }

        private void pbrefresh_Click_1(object sender, EventArgs e)
        {
            frmLevel2 l2 = new frmLevel2();
            l2.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
