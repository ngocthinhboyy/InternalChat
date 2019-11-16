namespace Internal_Society
{
    partial class activeFriend
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.username = new System.Windows.Forms.Label();
            this.activeStatus = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.onlineIcon = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.onlineIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.Location = new System.Drawing.Point(105, 16);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(91, 20);
            this.username.TabIndex = 1;
            this.username.Text = "Username";
            // 
            // activeStatus
            // 
            this.activeStatus.AutoSize = true;
            this.activeStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.activeStatus.Location = new System.Drawing.Point(106, 54);
            this.activeStatus.Name = "activeStatus";
            this.activeStatus.Size = new System.Drawing.Size(71, 16);
            this.activeStatus.TabIndex = 2;
            this.activeStatus.Text = "active now";
            this.activeStatus.Click += new System.EventHandler(this.ActiveStatus_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Internal_Society.Properties.Resources.offline;
            this.pictureBox2.Location = new System.Drawing.Point(234, 18);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(15, 15);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // onlineIcon
            // 
            this.onlineIcon.Image = global::Internal_Society.Properties.Resources.font_awesome_4_7_0_circle_15_0_58de40_none;
            this.onlineIcon.Location = new System.Drawing.Point(234, 18);
            this.onlineIcon.Name = "onlineIcon";
            this.onlineIcon.Size = new System.Drawing.Size(15, 15);
            this.onlineIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.onlineIcon.TabIndex = 3;
            this.onlineIcon.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Internal_Society.Properties.Resources.user_001;
            this.pictureBox1.Location = new System.Drawing.Point(16, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(70, 70);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // activeFriend
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.onlineIcon);
            this.Controls.Add(this.activeStatus);
            this.Controls.Add(this.username);
            this.Controls.Add(this.pictureBox1);
            this.Name = "activeFriend";
            this.Size = new System.Drawing.Size(259, 100);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.onlineIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label username;
        private System.Windows.Forms.Label activeStatus;
        private System.Windows.Forms.PictureBox onlineIcon;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}
