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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(activeFriend));
            this.username = new System.Windows.Forms.Label();
            this.activeStatus = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.offlineIcon = new System.Windows.Forms.PictureBox();
            this.onlineIcon = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.offlineIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.onlineIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // username
            // 
            this.username.AutoEllipsis = true;
            this.username.BackColor = System.Drawing.Color.Transparent;
            this.username.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.ForeColor = System.Drawing.Color.White;
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
            this.activeStatus.ForeColor = System.Drawing.Color.White;
            this.activeStatus.Location = new System.Drawing.Point(106, 54);
            this.activeStatus.Name = "activeStatus";
            this.activeStatus.Size = new System.Drawing.Size(71, 16);
            this.activeStatus.TabIndex = 2;
            this.activeStatus.Text = "active now";
            this.activeStatus.Click += new System.EventHandler(this.ActiveStatus_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(70, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(33, 33);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // offlineIcon
            // 
            this.offlineIcon.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.offlineIcon.Image = global::Internal_Society.Properties.Resources.offline;
            this.offlineIcon.Location = new System.Drawing.Point(234, 18);
            this.offlineIcon.Name = "offlineIcon";
            this.offlineIcon.Size = new System.Drawing.Size(15, 15);
            this.offlineIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.offlineIcon.TabIndex = 4;
            this.offlineIcon.TabStop = false;
            this.offlineIcon.Visible = false;
            // 
            // onlineIcon
            // 
            this.onlineIcon.Anchor = System.Windows.Forms.AnchorStyles.Right;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Red;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(73, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "01";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // activeFriend
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.offlineIcon);
            this.Controls.Add(this.onlineIcon);
            this.Controls.Add(this.activeStatus);
            this.Controls.Add(this.username);
            this.Controls.Add(this.pictureBox1);
            this.Name = "activeFriend";
            this.Size = new System.Drawing.Size(259, 100);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.offlineIcon)).EndInit();
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
        private System.Windows.Forms.PictureBox offlineIcon;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
    }
}
