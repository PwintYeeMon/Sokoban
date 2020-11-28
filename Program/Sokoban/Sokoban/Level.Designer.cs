namespace Sokoban
{
    partial class frmLevel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLevel));
            this.btnlevel1 = new System.Windows.Forms.Button();
            this.btnlevel2 = new System.Windows.Forms.Button();
            this.btnlevel3 = new System.Windows.Forms.Button();
            this.btnback = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnlevel1
            // 
            this.btnlevel1.BackColor = System.Drawing.Color.Firebrick;
            this.btnlevel1.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlevel1.ForeColor = System.Drawing.Color.White;
            this.btnlevel1.Location = new System.Drawing.Point(77, 126);
            this.btnlevel1.Name = "btnlevel1";
            this.btnlevel1.Size = new System.Drawing.Size(90, 64);
            this.btnlevel1.TabIndex = 9;
            this.btnlevel1.Text = "1";
            this.btnlevel1.UseVisualStyleBackColor = false;
            this.btnlevel1.Click += new System.EventHandler(this.btnlevel1_Click);
            // 
            // btnlevel2
            // 
            this.btnlevel2.BackColor = System.Drawing.Color.Firebrick;
            this.btnlevel2.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlevel2.ForeColor = System.Drawing.Color.White;
            this.btnlevel2.Location = new System.Drawing.Point(298, 126);
            this.btnlevel2.Name = "btnlevel2";
            this.btnlevel2.Size = new System.Drawing.Size(90, 64);
            this.btnlevel2.TabIndex = 10;
            this.btnlevel2.Text = "2";
            this.btnlevel2.UseVisualStyleBackColor = false;
            this.btnlevel2.Click += new System.EventHandler(this.btnlevel2_Click);
            // 
            // btnlevel3
            // 
            this.btnlevel3.BackColor = System.Drawing.Color.Firebrick;
            this.btnlevel3.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlevel3.ForeColor = System.Drawing.Color.White;
            this.btnlevel3.Location = new System.Drawing.Point(514, 126);
            this.btnlevel3.Name = "btnlevel3";
            this.btnlevel3.Size = new System.Drawing.Size(90, 64);
            this.btnlevel3.TabIndex = 11;
            this.btnlevel3.Text = "3";
            this.btnlevel3.UseVisualStyleBackColor = false;
            this.btnlevel3.Click += new System.EventHandler(this.btnlevel3_Click);
            // 
            // btnback
            // 
            this.btnback.BackColor = System.Drawing.Color.Firebrick;
            this.btnback.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnback.ForeColor = System.Drawing.Color.White;
            this.btnback.Location = new System.Drawing.Point(77, 271);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(79, 37);
            this.btnback.TabIndex = 12;
            this.btnback.Text = "Back";
            this.btnback.UseVisualStyleBackColor = false;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // frmLevel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(692, 360);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.btnlevel3);
            this.Controls.Add(this.btnlevel2);
            this.Controls.Add(this.btnlevel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLevel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Level";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnlevel1;
        private System.Windows.Forms.Button btnlevel2;
        private System.Windows.Forms.Button btnlevel3;
        private System.Windows.Forms.Button btnback;
    }
}