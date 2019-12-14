namespace Internal_Society
{
    partial class friend
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
            this.onlineIcon = new System.Windows.Forms.PictureBox();
            this.user_Avatar = new System.Windows.Forms.PictureBox();
            this.offlineIcon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.onlineIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.user_Avatar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.offlineIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // username
            // 
            this.username.AutoEllipsis = true;
            this.username.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.ForeColor = System.Drawing.Color.DeepPink;
            this.username.Location = new System.Drawing.Point(76, 12);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(91, 20);
            this.username.TabIndex = 7;
            this.username.Text = "Username";
            // 
            // activeStatus
            // 
            this.activeStatus.AutoEllipsis = true;
            this.activeStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.activeStatus.ForeColor = System.Drawing.Color.DeepPink;
            this.activeStatus.Location = new System.Drawing.Point(76, 32);
            this.activeStatus.Name = "activeStatus";
            this.activeStatus.Size = new System.Drawing.Size(121, 15);
            this.activeStatus.TabIndex = 5;
            this.activeStatus.Text = "active now";
            // 
            // onlineIcon
            // 
            this.onlineIcon.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.onlineIcon.Image = global::Internal_Society.Properties.Resources.font_awesome_4_7_0_circle_15_0_58de40_none;
            this.onlineIcon.Location = new System.Drawing.Point(182, 12);
            this.onlineIcon.Name = "onlineIcon";
            this.onlineIcon.Size = new System.Drawing.Size(15, 15);
            this.onlineIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.onlineIcon.TabIndex = 8;
            this.onlineIcon.TabStop = false;
            // 
            // user_Avatar
            // 
            this.user_Avatar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.user_Avatar.Image = global::Internal_Society.Properties.Resources.user_001;
            this.user_Avatar.Location = new System.Drawing.Point(13, 12);
            this.user_Avatar.Name = "user_Avatar";
            this.user_Avatar.Size = new System.Drawing.Size(57, 55);
            this.user_Avatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.user_Avatar.TabIndex = 6;
            this.user_Avatar.TabStop = false;
            // 
            // offlineIcon
            // 
            this.offlineIcon.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.offlineIcon.Image = global::Internal_Society.Properties.Resources.offline;
            this.offlineIcon.Location = new System.Drawing.Point(182, 12);
            this.offlineIcon.Name = "offlineIcon";
            this.offlineIcon.Size = new System.Drawing.Size(15, 15);
            this.offlineIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.offlineIcon.TabIndex = 9;
            this.offlineIcon.TabStop = false;
            this.offlineIcon.Visible = false;
            // 
            // friend
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.offlineIcon);
            this.Controls.Add(this.onlineIcon);
            this.Controls.Add(this.username);
            this.Controls.Add(this.user_Avatar);
            this.Controls.Add(this.activeStatus);
            this.Name = "friend";
            this.Size = new System.Drawing.Size(200, 80);
            ((System.ComponentModel.ISupportInitialize)(this.onlineIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.user_Avatar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.offlineIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox onlineIcon;
        private System.Windows.Forms.Label username;
        private System.Windows.Forms.PictureBox user_Avatar;
        private System.Windows.Forms.Label activeStatus;
        private System.Windows.Forms.PictureBox offlineIcon;
    }
}
