namespace Internal_Society
{
    partial class NotiCaro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NotiCaro));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            this.btn_Remove = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btn_Accept = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.lb_Message = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.pb_Avatar = new System.Windows.Forms.PictureBox();
            this.lb_Fullname = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lb_Noti_Detail = new Bunifu.Framework.UI.BunifuCustomLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Avatar)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Remove
            // 
            this.btn_Remove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Remove.BackColor = System.Drawing.Color.Transparent;
            this.btn_Remove.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Remove.BackgroundImage")));
            this.btn_Remove.ButtonText = "Remove";
            this.btn_Remove.ButtonTextMarginLeft = 0;
            this.btn_Remove.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.btn_Remove.DisabledFillColor = System.Drawing.Color.Gray;
            this.btn_Remove.DisabledForecolor = System.Drawing.Color.White;
            this.btn_Remove.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Remove.ForeColor = System.Drawing.Color.White;
            this.btn_Remove.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btn_Remove.IconPadding = 10;
            this.btn_Remove.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btn_Remove.IdleBorderColor = System.Drawing.Color.DeepPink;
            this.btn_Remove.IdleBorderRadius = 30;
            this.btn_Remove.IdleBorderThickness = 1;
            this.btn_Remove.IdleFillColor = System.Drawing.Color.DeepPink;
            this.btn_Remove.IdleIconLeftImage = null;
            this.btn_Remove.IdleIconRightImage = null;
            this.btn_Remove.Location = new System.Drawing.Point(453, 80);
            this.btn_Remove.Name = "btn_Remove";
            stateProperties1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(58)))), ((int)(((byte)(108)))));
            stateProperties1.BorderRadius = 30;
            stateProperties1.BorderThickness = 1;
            stateProperties1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(58)))), ((int)(((byte)(108)))));
            stateProperties1.IconLeftImage = null;
            stateProperties1.IconRightImage = null;
            this.btn_Remove.onHoverState = stateProperties1;
            this.btn_Remove.Size = new System.Drawing.Size(121, 45);
            this.btn_Remove.TabIndex = 20;
            this.btn_Remove.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Remove.Click += new System.EventHandler(this.Btn_Remove_Click);
            // 
            // btn_Accept
            // 
            this.btn_Accept.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Accept.BackColor = System.Drawing.Color.Transparent;
            this.btn_Accept.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Accept.BackgroundImage")));
            this.btn_Accept.ButtonText = "Accept";
            this.btn_Accept.ButtonTextMarginLeft = 0;
            this.btn_Accept.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.btn_Accept.DisabledFillColor = System.Drawing.Color.Gray;
            this.btn_Accept.DisabledForecolor = System.Drawing.Color.White;
            this.btn_Accept.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Accept.ForeColor = System.Drawing.Color.White;
            this.btn_Accept.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btn_Accept.IconPadding = 10;
            this.btn_Accept.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btn_Accept.IdleBorderColor = System.Drawing.Color.DeepPink;
            this.btn_Accept.IdleBorderRadius = 30;
            this.btn_Accept.IdleBorderThickness = 0;
            this.btn_Accept.IdleFillColor = System.Drawing.Color.DeepPink;
            this.btn_Accept.IdleIconLeftImage = null;
            this.btn_Accept.IdleIconRightImage = null;
            this.btn_Accept.Location = new System.Drawing.Point(311, 80);
            this.btn_Accept.Name = "btn_Accept";
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(58)))), ((int)(((byte)(108)))));
            stateProperties2.BorderRadius = 30;
            stateProperties2.BorderThickness = 0;
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(58)))), ((int)(((byte)(108)))));
            stateProperties2.IconLeftImage = null;
            stateProperties2.IconRightImage = null;
            this.btn_Accept.onHoverState = stateProperties2;
            this.btn_Accept.Size = new System.Drawing.Size(121, 45);
            this.btn_Accept.TabIndex = 19;
            this.btn_Accept.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Accept.Click += new System.EventHandler(this.Btn_Accept_Click);
            // 
            // lb_Message
            // 
            this.lb_Message.AutoSize = true;
            this.lb_Message.Font = new System.Drawing.Font("Segoe UI Semibold", 9.818182F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Message.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lb_Message.Location = new System.Drawing.Point(116, 85);
            this.lb_Message.Name = "lb_Message";
            this.lb_Message.Size = new System.Drawing.Size(144, 19);
            this.lb_Message.TabIndex = 18;
            this.lb_Message.Text = "Invited you play caro.";
            this.lb_Message.Visible = false;
            // 
            // pb_Avatar
            // 
            this.pb_Avatar.Image = global::Internal_Society.Properties.Resources.user_001;
            this.pb_Avatar.Location = new System.Drawing.Point(28, 55);
            this.pb_Avatar.Name = "pb_Avatar";
            this.pb_Avatar.Size = new System.Drawing.Size(70, 70);
            this.pb_Avatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Avatar.TabIndex = 17;
            this.pb_Avatar.TabStop = false;
            // 
            // lb_Fullname
            // 
            this.lb_Fullname.AutoSize = true;
            this.lb_Fullname.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Fullname.Location = new System.Drawing.Point(115, 55);
            this.lb_Fullname.Name = "lb_Fullname";
            this.lb_Fullname.Size = new System.Drawing.Size(103, 20);
            this.lb_Fullname.TabIndex = 15;
            this.lb_Fullname.Text = "Tân Hữu Toàn";
            // 
            // lb_Noti_Detail
            // 
            this.lb_Noti_Detail.AutoSize = true;
            this.lb_Noti_Detail.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Noti_Detail.Location = new System.Drawing.Point(24, 16);
            this.lb_Noti_Detail.Name = "lb_Noti_Detail";
            this.lb_Noti_Detail.Size = new System.Drawing.Size(142, 20);
            this.lb_Noti_Detail.TabIndex = 16;
            this.lb_Noti_Detail.Text = "Game Caro Request";
            // 
            // NotiCaro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_Remove);
            this.Controls.Add(this.btn_Accept);
            this.Controls.Add(this.lb_Message);
            this.Controls.Add(this.pb_Avatar);
            this.Controls.Add(this.lb_Fullname);
            this.Controls.Add(this.lb_Noti_Detail);
            this.Name = "NotiCaro";
            this.Size = new System.Drawing.Size(598, 141);
            ((System.ComponentModel.ISupportInitialize)(this.pb_Avatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btn_Remove;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btn_Accept;
        private Bunifu.Framework.UI.BunifuCustomLabel lb_Message;
        private System.Windows.Forms.PictureBox pb_Avatar;
        private Bunifu.Framework.UI.BunifuCustomLabel lb_Fullname;
        private Bunifu.Framework.UI.BunifuCustomLabel lb_Noti_Detail;
    }
}
