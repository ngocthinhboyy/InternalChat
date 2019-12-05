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
            this.components = new System.ComponentModel.Container();
            this.activeStatus = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.onlineIcon = new System.Windows.Forms.PictureBox();
            this.offlineIcon = new System.Windows.Forms.PictureBox();
            this.user_Avatar = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Timer_Offline = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.onlineIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.offlineIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.user_Avatar)).BeginInit();
            this.SuspendLayout();
            // 
            // activeStatus
            // 
            this.activeStatus.AutoSize = true;
            this.activeStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.activeStatus.ForeColor = System.Drawing.Color.DeepPink;
            this.activeStatus.Location = new System.Drawing.Point(177, 83);
            this.activeStatus.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.activeStatus.Name = "activeStatus";
            this.activeStatus.Size = new System.Drawing.Size(114, 25);
            this.activeStatus.TabIndex = 0;
            this.activeStatus.Text = "active now";
            // 
            // username
            // 
            this.username.AutoEllipsis = true;
            this.username.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.ForeColor = System.Drawing.Color.DeepPink;
            this.username.Location = new System.Drawing.Point(175, 25);
            this.username.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(152, 31);
            this.username.TabIndex = 2;
            this.username.Text = "Username";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Internal_Society.Properties.Resources.font_awesome_4_7_0_square_90_0_ff0000_none;
            this.pictureBox2.Location = new System.Drawing.Point(117, 5);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(55, 51);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // onlineIcon
            // 
            this.onlineIcon.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.onlineIcon.Image = global::Internal_Society.Properties.Resources.font_awesome_4_7_0_circle_15_0_58de40_none;
            this.onlineIcon.Location = new System.Drawing.Point(428, 28);
            this.onlineIcon.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.onlineIcon.Name = "onlineIcon";
            this.onlineIcon.Size = new System.Drawing.Size(15, 15);
            this.onlineIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.onlineIcon.TabIndex = 4;
            this.onlineIcon.TabStop = false;
            // 
            // offlineIcon
            // 
            this.offlineIcon.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.offlineIcon.Image = global::Internal_Society.Properties.Resources.offline;
            this.offlineIcon.Location = new System.Drawing.Point(428, 28);
            this.offlineIcon.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.offlineIcon.Name = "offlineIcon";
            this.offlineIcon.Size = new System.Drawing.Size(15, 15);
            this.offlineIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.offlineIcon.TabIndex = 3;
            this.offlineIcon.TabStop = false;
            this.offlineIcon.Visible = false;
            // 
            // user_Avatar
            // 
            this.user_Avatar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.user_Avatar.Image = global::Internal_Society.Properties.Resources.user_001;
            this.user_Avatar.Location = new System.Drawing.Point(27, 22);
            this.user_Avatar.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.user_Avatar.Name = "user_Avatar";
            this.user_Avatar.Size = new System.Drawing.Size(117, 108);
            this.user_Avatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.user_Avatar.TabIndex = 1;
            this.user_Avatar.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Red;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(122, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 29);
            this.label1.TabIndex = 6;
            this.label1.Text = "01";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Timer_Offline
            // 
            this.Timer_Offline.Interval = 58000;
            this.Timer_Offline.Tick += new System.EventHandler(this.Timer_Offline_Tick);
            // 
            // activeFriend
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.onlineIcon);
            this.Controls.Add(this.offlineIcon);
            this.Controls.Add(this.username);
            this.Controls.Add(this.user_Avatar);
            this.Controls.Add(this.activeStatus);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "activeFriend";
            this.Size = new System.Drawing.Size(470, 154);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.onlineIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.offlineIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.user_Avatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label activeStatus;
        private System.Windows.Forms.PictureBox user_Avatar;
        private System.Windows.Forms.Label username;
        private System.Windows.Forms.PictureBox offlineIcon;
        private System.Windows.Forms.PictureBox onlineIcon;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer Timer_Offline;
    }
}
