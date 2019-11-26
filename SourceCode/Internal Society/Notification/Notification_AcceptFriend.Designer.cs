namespace Internal_Society
{
    partial class Notification_AcceptFriend
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
            this.lb_Fullname = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lb_More = new Bunifu.Framework.UI.BunifuCustomLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Avatar)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_Avatar
            // 
            this.pb_Avatar.Image = global::Internal_Society.Properties.Resources.user_001;
            this.pb_Avatar.Location = new System.Drawing.Point(49, 27);
            this.pb_Avatar.Margin = new System.Windows.Forms.Padding(5);
            this.pb_Avatar.Name = "pb_Avatar";
            this.pb_Avatar.Size = new System.Drawing.Size(117, 108);
            this.pb_Avatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Avatar.TabIndex = 15;
            this.pb_Avatar.TabStop = false;
            // 
            // lb_Fullname
            // 
            this.lb_Fullname.AutoSize = true;
            this.lb_Fullname.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Fullname.Location = new System.Drawing.Point(194, 27);
            this.lb_Fullname.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lb_Fullname.Name = "lb_Fullname";
            this.lb_Fullname.Size = new System.Drawing.Size(173, 35);
            this.lb_Fullname.TabIndex = 11;
            this.lb_Fullname.Text = "Tân Hữu Toàn";
            // 
            // lb_More
            // 
            this.lb_More.AutoSize = true;
            this.lb_More.Font = new System.Drawing.Font("Segoe UI Semibold", 9.818182F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_More.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lb_More.Location = new System.Drawing.Point(195, 71);
            this.lb_More.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lb_More.Name = "lb_More";
            this.lb_More.Size = new System.Drawing.Size(436, 30);
            this.lb_More.TabIndex = 11;
            this.lb_More.Text = "Hãy gửi cho bạn ấy những lời chúc tốt đẹp ";
            // 
            // Notification_AcceptFriend
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.pb_Avatar);
            this.Controls.Add(this.lb_More);
            this.Controls.Add(this.lb_Fullname);
            this.Name = "Notification_AcceptFriend";
            this.Size = new System.Drawing.Size(1000, 170);
            ((System.ComponentModel.ISupportInitialize)(this.pb_Avatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_Avatar;
        private Bunifu.Framework.UI.BunifuCustomLabel lb_Fullname;
        private Bunifu.Framework.UI.BunifuCustomLabel lb_More;
    }
}
