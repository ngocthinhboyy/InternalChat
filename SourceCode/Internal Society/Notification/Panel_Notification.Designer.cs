﻿namespace Internal_Society
{
    partial class Panel_Notification
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
            this.TimeRequest = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // TimeRequest
            // 
            this.TimeRequest.Enabled = true;
            this.TimeRequest.Interval = 1000;
            this.TimeRequest.Tick += new System.EventHandler(this.TimeRequest_Tick);
            // 
            // Panel_Notification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Name = "Panel_Notification";
            this.Size = new System.Drawing.Size(754, 601);
            this.Resize += new System.EventHandler(this.Panel_Notification_Resize);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer TimeRequest;
    }
}
