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
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            this.user_fullname = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_addFriend = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
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
            // btn_addFriend
            // 
            this.btn_addFriend.BackColor = System.Drawing.Color.Transparent;
            this.btn_addFriend.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_addFriend.BackgroundImage")));
            this.btn_addFriend.ButtonText = "Add Friend";
            this.btn_addFriend.ButtonTextMarginLeft = 0;
            this.btn_addFriend.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.btn_addFriend.DisabledFillColor = System.Drawing.Color.Gray;
            this.btn_addFriend.DisabledForecolor = System.Drawing.Color.White;
            this.btn_addFriend.ForeColor = System.Drawing.Color.White;
            this.btn_addFriend.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btn_addFriend.IconPadding = 10;
            this.btn_addFriend.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btn_addFriend.IdleBorderColor = System.Drawing.Color.DeepPink;
            this.btn_addFriend.IdleBorderRadius = 35;
            this.btn_addFriend.IdleBorderThickness = 2;
            this.btn_addFriend.IdleFillColor = System.Drawing.Color.DeepPink;
            this.btn_addFriend.IdleIconLeftImage = null;
            this.btn_addFriend.IdleIconRightImage = null;
            this.btn_addFriend.Location = new System.Drawing.Point(402, 26);
            this.btn_addFriend.Name = "btn_addFriend";
            stateProperties1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties1.BorderRadius = 1;
            stateProperties1.BorderThickness = 1;
            stateProperties1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties1.IconLeftImage = null;
            stateProperties1.IconRightImage = null;
            this.btn_addFriend.onHoverState = stateProperties1;
            this.btn_addFriend.Size = new System.Drawing.Size(154, 45);
            this.btn_addFriend.TabIndex = 8;
            this.btn_addFriend.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_addFriend.Click += new System.EventHandler(this.BunifuButton1_Click);
            // 
            // friendInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.btn_addFriend);
            this.Controls.Add(this.user_fullname);
            this.Controls.Add(this.username);
            this.Controls.Add(this.pictureBox1);
            this.Name = "friendInfo";
            this.Size = new System.Drawing.Size(598, 98);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label user_fullname;
        private System.Windows.Forms.Label username;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btn_addFriend;
    }
}
