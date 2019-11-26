namespace Internal_Society
{
    partial class friendInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(friendInfo));
            this.user_fullname = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.Label();
            this.btn_addFriend = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // user_fullname
            // 
            this.user_fullname.AutoSize = true;
            this.user_fullname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user_fullname.Location = new System.Drawing.Point(155, 64);
            this.user_fullname.Name = "user_fullname";
            this.user_fullname.Size = new System.Drawing.Size(104, 20);
            this.user_fullname.TabIndex = 6;
            this.user_fullname.Text = "user fullname";
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.Location = new System.Drawing.Point(155, 16);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(103, 24);
            this.username.TabIndex = 5;
            this.username.Text = "username";
            // 
            // btn_addFriend
            // 
            this.btn_addFriend.Activecolor = System.Drawing.Color.SeaGreen;
            this.btn_addFriend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_addFriend.BackColor = System.Drawing.Color.SeaGreen;
            this.btn_addFriend.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_addFriend.BorderRadius = 0;
            this.btn_addFriend.ButtonText = "Add friend";
            this.btn_addFriend.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_addFriend.DisabledColor = System.Drawing.Color.Gray;
            this.btn_addFriend.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_addFriend.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_addFriend.Iconimage")));
            this.btn_addFriend.Iconimage_right = null;
            this.btn_addFriend.Iconimage_right_Selected = null;
            this.btn_addFriend.Iconimage_Selected = null;
            this.btn_addFriend.IconMarginLeft = 0;
            this.btn_addFriend.IconMarginRight = 0;
            this.btn_addFriend.IconRightVisible = true;
            this.btn_addFriend.IconRightZoom = 0D;
            this.btn_addFriend.IconVisible = true;
            this.btn_addFriend.IconZoom = 90D;
            this.btn_addFriend.IsTab = false;
            this.btn_addFriend.Location = new System.Drawing.Point(453, 25);
            this.btn_addFriend.Name = "btn_addFriend";
            this.btn_addFriend.Normalcolor = System.Drawing.Color.SeaGreen;
            this.btn_addFriend.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btn_addFriend.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_addFriend.selected = false;
            this.btn_addFriend.Size = new System.Drawing.Size(129, 48);
            this.btn_addFriend.TabIndex = 7;
            this.btn_addFriend.Text = "Add friend";
            this.btn_addFriend.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_addFriend.Textcolor = System.Drawing.Color.White;
            this.btn_addFriend.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addFriend.Click += new System.EventHandler(this.btn_addFriend_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Internal_Society.Properties.Resources.user_001;
            this.pictureBox1.Location = new System.Drawing.Point(36, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(70, 70);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // friendInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btn_addFriend);
            this.Controls.Add(this.user_fullname);
            this.Controls.Add(this.username);
            this.Controls.Add(this.pictureBox1);
            this.Name = "friendInfo";
            this.Size = new System.Drawing.Size(600, 100);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label user_fullname;
        private System.Windows.Forms.Label username;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuFlatButton btn_addFriend;
    }
}
