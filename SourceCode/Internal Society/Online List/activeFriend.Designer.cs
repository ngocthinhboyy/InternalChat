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
            this.lbl_NewMess = new System.Windows.Forms.Label();
            this.Timer_Offline = new System.Windows.Forms.Timer(this.components);
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.onlineIcon = new System.Windows.Forms.PictureBox();
            this.offlineIcon = new System.Windows.Forms.PictureBox();
            this.user_Avatar = new System.Windows.Forms.PictureBox();
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
            this.activeStatus.Location = new System.Drawing.Point(106, 54);
            this.activeStatus.Name = "activeStatus";
            this.activeStatus.Size = new System.Drawing.Size(71, 16);
            this.activeStatus.TabIndex = 0;
            this.activeStatus.Text = "active now";
            // 
            // username
            // 
            this.username.AutoEllipsis = true;
            this.username.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.ForeColor = System.Drawing.Color.DeepPink;
            this.username.Location = new System.Drawing.Point(105, 16);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(91, 20);
            this.username.TabIndex = 2;
            this.username.Text = "Username";
            // 
            // lbl_NewMess
            // 
            this.lbl_NewMess.AutoSize = true;
            this.lbl_NewMess.BackColor = System.Drawing.Color.Red;
            this.lbl_NewMess.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NewMess.ForeColor = System.Drawing.Color.White;
            this.lbl_NewMess.Location = new System.Drawing.Point(246, 52);
            this.lbl_NewMess.Name = "lbl_NewMess";
            this.lbl_NewMess.Size = new System.Drawing.Size(26, 18);
            this.lbl_NewMess.TabIndex = 6;
            this.lbl_NewMess.Text = "01";
            this.lbl_NewMess.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_NewMess.Visible = false;
            // 
            // Timer_Offline
            // 
            this.Timer_Offline.Interval = 58000;
            this.Timer_Offline.Tick += new System.EventHandler(this.Timer_Offline_Tick);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Internal_Society.Properties.Resources.font_awesome_4_7_0_square_90_0_ff0000_none1;
            this.pictureBox2.Location = new System.Drawing.Point(241, 44);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(40, 36);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Visible = false;
            // 
            // onlineIcon
            // 
            this.onlineIcon.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.onlineIcon.Image = global::Internal_Society.Properties.Resources.font_awesome_4_7_0_circle_15_0_58de40_none;
            this.onlineIcon.Location = new System.Drawing.Point(257, 18);
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
            this.offlineIcon.Location = new System.Drawing.Point(257, 18);
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
            this.user_Avatar.Location = new System.Drawing.Point(16, 14);
            this.user_Avatar.Name = "user_Avatar";
            this.user_Avatar.Size = new System.Drawing.Size(70, 70);
            this.user_Avatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.user_Avatar.TabIndex = 1;
            this.user_Avatar.TabStop = false;
            // 
            // activeFriend
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.lbl_NewMess);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.onlineIcon);
            this.Controls.Add(this.offlineIcon);
            this.Controls.Add(this.username);
            this.Controls.Add(this.user_Avatar);
            this.Controls.Add(this.activeStatus);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "activeFriend";
            this.Size = new System.Drawing.Size(282, 100);
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
        private System.Windows.Forms.Label lbl_NewMess;
        private System.Windows.Forms.Timer Timer_Offline;
    }
}
