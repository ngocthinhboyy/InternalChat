namespace Internal_Society
{
    partial class Notification_AddFriend
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
            this.pb_Avatar = new System.Windows.Forms.PictureBox();
            this.btn_Remove = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_Accept = new Bunifu.Framework.UI.BunifuFlatButton();
            this.lb_Fullname = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lb_Noti_Detail = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lb_Message = new Bunifu.Framework.UI.BunifuCustomLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Avatar)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_Avatar
            // 
            this.pb_Avatar.Image = global::Internal_Society.Properties.Resources.user_001;
            this.pb_Avatar.Location = new System.Drawing.Point(48, 81);
            this.pb_Avatar.Margin = new System.Windows.Forms.Padding(5);
            this.pb_Avatar.Name = "pb_Avatar";
            this.pb_Avatar.Size = new System.Drawing.Size(117, 108);
            this.pb_Avatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Avatar.TabIndex = 10;
            this.pb_Avatar.TabStop = false;
            // 
            // btn_Remove
            // 
            this.btn_Remove.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_Remove.BackColor = System.Drawing.Color.MediumPurple;
            this.btn_Remove.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Remove.BorderRadius = 0;
            this.btn_Remove.ButtonText = "Remove";
            this.btn_Remove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Remove.DisabledColor = System.Drawing.Color.Gray;
            this.btn_Remove.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_Remove.Iconimage = global::Internal_Society.Properties.Resources.detete_006;
            this.btn_Remove.Iconimage_right = null;
            this.btn_Remove.Iconimage_right_Selected = null;
            this.btn_Remove.Iconimage_Selected = null;
            this.btn_Remove.IconMarginLeft = 0;
            this.btn_Remove.IconMarginRight = 0;
            this.btn_Remove.IconRightVisible = true;
            this.btn_Remove.IconRightZoom = 0D;
            this.btn_Remove.IconVisible = true;
            this.btn_Remove.IconZoom = 50D;
            this.btn_Remove.IsTab = false;
            this.btn_Remove.Location = new System.Drawing.Point(744, 115);
            this.btn_Remove.Margin = new System.Windows.Forms.Padding(8);
            this.btn_Remove.Name = "btn_Remove";
            this.btn_Remove.Normalcolor = System.Drawing.Color.MediumPurple;
            this.btn_Remove.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btn_Remove.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_Remove.selected = false;
            this.btn_Remove.Size = new System.Drawing.Size(202, 74);
            this.btn_Remove.TabIndex = 8;
            this.btn_Remove.Text = "Remove";
            this.btn_Remove.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Remove.Textcolor = System.Drawing.Color.White;
            this.btn_Remove.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Remove.Click += new System.EventHandler(this.Btn_Remove_Click);
            // 
            // btn_Accept
            // 
            this.btn_Accept.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_Accept.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_Accept.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Accept.BorderRadius = 0;
            this.btn_Accept.ButtonText = "Accept";
            this.btn_Accept.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Accept.DisabledColor = System.Drawing.Color.Gray;
            this.btn_Accept.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_Accept.Iconimage = global::Internal_Society.Properties.Resources.done_001;
            this.btn_Accept.Iconimage_right = null;
            this.btn_Accept.Iconimage_right_Selected = null;
            this.btn_Accept.Iconimage_Selected = null;
            this.btn_Accept.IconMarginLeft = 0;
            this.btn_Accept.IconMarginRight = 0;
            this.btn_Accept.IconRightVisible = true;
            this.btn_Accept.IconRightZoom = 0D;
            this.btn_Accept.IconVisible = true;
            this.btn_Accept.IconZoom = 50D;
            this.btn_Accept.IsTab = false;
            this.btn_Accept.Location = new System.Drawing.Point(507, 115);
            this.btn_Accept.Margin = new System.Windows.Forms.Padding(8);
            this.btn_Accept.Name = "btn_Accept";
            this.btn_Accept.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_Accept.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btn_Accept.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_Accept.selected = false;
            this.btn_Accept.Size = new System.Drawing.Size(202, 74);
            this.btn_Accept.TabIndex = 9;
            this.btn_Accept.Text = "Accept";
            this.btn_Accept.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Accept.Textcolor = System.Drawing.Color.White;
            this.btn_Accept.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Accept.Click += new System.EventHandler(this.Btn_Accept_Click);
            // 
            // lb_Fullname
            // 
            this.lb_Fullname.AutoSize = true;
            this.lb_Fullname.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Fullname.Location = new System.Drawing.Point(193, 81);
            this.lb_Fullname.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lb_Fullname.Name = "lb_Fullname";
            this.lb_Fullname.Size = new System.Drawing.Size(173, 35);
            this.lb_Fullname.TabIndex = 6;
            this.lb_Fullname.Text = "Tân Hữu Toàn";
            // 
            // lb_Noti_Detail
            // 
            this.lb_Noti_Detail.AutoSize = true;
            this.lb_Noti_Detail.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Noti_Detail.Location = new System.Drawing.Point(42, 21);
            this.lb_Noti_Detail.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lb_Noti_Detail.Name = "lb_Noti_Detail";
            this.lb_Noti_Detail.Size = new System.Drawing.Size(192, 35);
            this.lb_Noti_Detail.TabIndex = 7;
            this.lb_Noti_Detail.Text = "Lời mời kết bạn";
            // 
            // lb_Message
            // 
            this.lb_Message.AutoSize = true;
            this.lb_Message.Font = new System.Drawing.Font("Segoe UI Semibold", 9.818182F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Message.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lb_Message.Location = new System.Drawing.Point(195, 127);
            this.lb_Message.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lb_Message.Name = "lb_Message";
            this.lb_Message.Size = new System.Drawing.Size(96, 30);
            this.lb_Message.TabIndex = 12;
            this.lb_Message.Text = "Message";
            this.lb_Message.Visible = false;
            // 
            // Notification_AddFriend
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.lb_Message);
            this.Controls.Add(this.pb_Avatar);
            this.Controls.Add(this.btn_Remove);
            this.Controls.Add(this.btn_Accept);
            this.Controls.Add(this.lb_Fullname);
            this.Controls.Add(this.lb_Noti_Detail);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Notification_AddFriend";
            this.Size = new System.Drawing.Size(1000, 220);
            ((System.ComponentModel.ISupportInitialize)(this.pb_Avatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_Avatar;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Remove;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Accept;
        private Bunifu.Framework.UI.BunifuCustomLabel lb_Fullname;
        private Bunifu.Framework.UI.BunifuCustomLabel lb_Noti_Detail;
        private Bunifu.Framework.UI.BunifuCustomLabel lb_Message;
    }
}
