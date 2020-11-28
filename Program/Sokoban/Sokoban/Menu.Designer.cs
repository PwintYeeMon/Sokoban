namespace Sokoban
{
    partial class frmMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.btnplay = new System.Windows.Forms.Button();
            this.btnoption = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.btnlevel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnplay
            // 
            this.btnplay.BackColor = System.Drawing.Color.Firebrick;
            this.btnplay.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnplay.ForeColor = System.Drawing.Color.White;
            this.btnplay.Location = new System.Drawing.Point(254, 53);
            this.btnplay.Name = "btnplay";
            this.btnplay.Size = new System.Drawing.Size(188, 47);
            this.btnplay.TabIndex = 7;
            this.btnplay.Text = "Play";
            this.btnplay.UseVisualStyleBackColor = false;
            this.btnplay.Click += new System.EventHandler(this.btnplay_Click);
            // 
            // btnoption
            // 
            this.btnoption.BackColor = System.Drawing.Color.Firebrick;
            this.btnoption.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnoption.ForeColor = System.Drawing.Color.White;
            this.btnoption.Location = new System.Drawing.Point(254, 181);
            this.btnoption.Name = "btnoption";
            this.btnoption.Size = new System.Drawing.Size(188, 47);
            this.btnoption.TabIndex = 9;
            this.btnoption.Text = "Option";
            this.btnoption.UseVisualStyleBackColor = false;
            this.btnoption.Click += new System.EventHandler(this.btnoption_Click);
            // 
            // btnexit
            // 
            this.btnexit.BackColor = System.Drawing.Color.Firebrick;
            this.btnexit.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexit.ForeColor = System.Drawing.Color.White;
            this.btnexit.Location = new System.Drawing.Point(254, 245);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(188, 47);
            this.btnexit.TabIndex = 10;
            this.btnexit.Text = "Exit";
            this.btnexit.UseVisualStyleBackColor = false;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // btnlevel
            // 
            this.btnlevel.BackColor = System.Drawing.Color.Firebrick;
            this.btnlevel.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlevel.ForeColor = System.Drawing.Color.White;
            this.btnlevel.Location = new System.Drawing.Point(254, 116);
            this.btnlevel.Name = "btnlevel";
            this.btnlevel.Size = new System.Drawing.Size(188, 47);
            this.btnlevel.TabIndex = 8;
            this.btnlevel.Text = "Level";
            this.btnlevel.UseVisualStyleBackColor = false;
            this.btnlevel.Click += new System.EventHandler(this.btnlevel_Click_1);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(692, 360);
            this.Controls.Add(this.btnlevel);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnoption);
            this.Controls.Add(this.btnplay);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnplay;
        private System.Windows.Forms.Button btnoption;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Button btnlevel;
    }
}