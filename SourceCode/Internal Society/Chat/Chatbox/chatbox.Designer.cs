﻿namespace Internal_Society
{
    partial class chatbox
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txt_input = new System.Windows.Forms.TextBox();
            this.button_More = new Bunifu.Framework.UI.BunifuImageButton();
            this.button_Sticker = new Bunifu.Framework.UI.BunifuImageButton();
            this.button_Picture = new Bunifu.Framework.UI.BunifuImageButton();
            this.button_Attach = new Bunifu.Framework.UI.BunifuImageButton();
            this.button_Send = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bubble2 = new Internal_Society.bubble();
            this.bubble1 = new Internal_Society.bubble();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.TimeRequest = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.button_More)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.button_Sticker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.button_Picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.button_Attach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.button_Send)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.button_More);
            this.panel1.Controls.Add(this.button_Sticker);
            this.panel1.Controls.Add(this.button_Picture);
            this.panel1.Controls.Add(this.button_Attach);
            this.panel1.Controls.Add(this.button_Send);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 767);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1192, 102);
            this.panel1.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel3.Controls.Add(this.txt_input);
            this.panel3.Location = new System.Drawing.Point(408, 22);
            this.panel3.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(678, 55);
            this.panel3.TabIndex = 4;
            // 
            // txt_input
            // 
            this.txt_input.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_input.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_input.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_input.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_input.Location = new System.Drawing.Point(30, 0);
            this.txt_input.Name = "txt_input";
            this.txt_input.Size = new System.Drawing.Size(665, 57);
            this.txt_input.TabIndex = 0;
            this.txt_input.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBox1_KeyDown);
            // 
            // button_More
            // 
            this.button_More.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_More.BackColor = System.Drawing.Color.Transparent;
            this.button_More.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_More.Image = global::Internal_Society.Properties.Resources.color_wheel_96px;
            this.button_More.ImageActive = null;
            this.button_More.Location = new System.Drawing.Point(308, 6);
            this.button_More.Name = "button_More";
            this.button_More.Size = new System.Drawing.Size(95, 85);
            this.button_More.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.button_More.TabIndex = 1;
            this.button_More.TabStop = false;
            this.button_More.Zoom = 10;
            this.button_More.Click += new System.EventHandler(this.Button_More_Click);
            // 
            // button_Sticker
            // 
            this.button_Sticker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_Sticker.BackColor = System.Drawing.Color.Transparent;
            this.button_Sticker.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Sticker.Image = global::Internal_Society.Properties.Resources.bored_96px;
            this.button_Sticker.ImageActive = null;
            this.button_Sticker.Location = new System.Drawing.Point(207, 6);
            this.button_Sticker.Name = "button_Sticker";
            this.button_Sticker.Size = new System.Drawing.Size(95, 85);
            this.button_Sticker.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.button_Sticker.TabIndex = 1;
            this.button_Sticker.TabStop = false;
            this.button_Sticker.Zoom = 10;
            this.button_Sticker.Click += new System.EventHandler(this.Button_Sticker_Click);
            // 
            // button_Picture
            // 
            this.button_Picture.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_Picture.BackColor = System.Drawing.Color.Transparent;
            this.button_Picture.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Picture.Image = global::Internal_Society.Properties.Resources.picture_200px;
            this.button_Picture.ImageActive = null;
            this.button_Picture.Location = new System.Drawing.Point(105, 6);
            this.button_Picture.Name = "button_Picture";
            this.button_Picture.Size = new System.Drawing.Size(95, 85);
            this.button_Picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.button_Picture.TabIndex = 1;
            this.button_Picture.TabStop = false;
            this.button_Picture.Zoom = 10;
            this.button_Picture.Click += new System.EventHandler(this.Button_Picture_Click);
            // 
            // button_Attach
            // 
            this.button_Attach.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_Attach.BackColor = System.Drawing.Color.Transparent;
            this.button_Attach.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Attach.Image = global::Internal_Society.Properties.Resources.attach_96px;
            this.button_Attach.ImageActive = null;
            this.button_Attach.Location = new System.Drawing.Point(3, 6);
            this.button_Attach.Name = "button_Attach";
            this.button_Attach.Size = new System.Drawing.Size(95, 85);
            this.button_Attach.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.button_Attach.TabIndex = 1;
            this.button_Attach.TabStop = false;
            this.button_Attach.Zoom = 10;
            this.button_Attach.Click += new System.EventHandler(this.Button_Attach_Click);
            // 
            // button_Send
            // 
            this.button_Send.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Send.BackColor = System.Drawing.Color.Transparent;
            this.button_Send.Image = global::Internal_Society.Properties.Resources.send_001;
            this.button_Send.ImageActive = null;
            this.button_Send.Location = new System.Drawing.Point(1093, 6);
            this.button_Send.Name = "button_Send";
            this.button_Send.Size = new System.Drawing.Size(95, 85);
            this.button_Send.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.button_Send.TabIndex = 1;
            this.button_Send.TabStop = false;
            this.button_Send.Zoom = 10;
            this.button_Send.Click += new System.EventHandler(this.button_Send_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.AutoScroll = true;
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.bubble2);
            this.panel2.Controls.Add(this.bubble1);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1192, 768);
            this.panel2.TabIndex = 4;
            this.panel2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Panel2_MouseClick);
            // 
            // bubble2
            // 
            this.bubble2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bubble2.AutoSize = true;
            this.bubble2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(164)))), ((int)(((byte)(147)))));
            this.bubble2.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold);
            this.bubble2.Location = new System.Drawing.Point(15, 17);
            this.bubble2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bubble2.MaximumSize = new System.Drawing.Size(667, 0);
            this.bubble2.Name = "bubble2";
            this.bubble2.Size = new System.Drawing.Size(577, 90);
            this.bubble2.TabIndex = 3;
            this.bubble2.Visible = false;
            // 
            // bubble1
            // 
            this.bubble1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bubble1.AutoSize = true;
            this.bubble1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(164)))), ((int)(((byte)(147)))));
            this.bubble1.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold);
            this.bubble1.Location = new System.Drawing.Point(612, 17);
            this.bubble1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bubble1.MaximumSize = new System.Drawing.Size(667, 0);
            this.bubble1.Name = "bubble1";
            this.bubble1.Size = new System.Drawing.Size(552, 90);
            this.bubble1.TabIndex = 2;
            this.bubble1.Visible = false;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 20;
            this.bunifuElipse1.TargetControl = this.panel3;
            // 
            // TimeRequest
            // 
            this.TimeRequest.Enabled = true;
            this.TimeRequest.Interval = 1500;
            this.TimeRequest.Tick += new System.EventHandler(this.TimeRequest_Tick);
            // 
            // chatbox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "chatbox";
            this.Size = new System.Drawing.Size(1192, 869);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.button_More)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.button_Sticker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.button_Picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.button_Attach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.button_Send)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuImageButton button_Send;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_input;
        private bubble bubble2;
        private bubble bubble1;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuImageButton button_More;
        private Bunifu.Framework.UI.BunifuImageButton button_Sticker;
        private Bunifu.Framework.UI.BunifuImageButton button_Picture;
        private Bunifu.Framework.UI.BunifuImageButton button_Attach;
        private System.Windows.Forms.Panel panel3;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Timer TimeRequest;
    }
}
