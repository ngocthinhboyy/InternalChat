namespace Internal_Society
{
    partial class onlineList
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
            this.label_NoActiveFriend = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TimeRequest
            // 
            this.TimeRequest.Enabled = true;
            this.TimeRequest.Interval = 1000;
            this.TimeRequest.Tick += new System.EventHandler(this.TimeRequest_Tick);
            // 
            // label_NoActiveFriend
            // 
            this.label_NoActiveFriend.AutoSize = true;
            this.label_NoActiveFriend.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_NoActiveFriend.ForeColor = System.Drawing.Color.White;
            this.label_NoActiveFriend.Location = new System.Drawing.Point(36, 61);
            this.label_NoActiveFriend.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_NoActiveFriend.Name = "label_NoActiveFriend";
            this.label_NoActiveFriend.Size = new System.Drawing.Size(232, 33);
            this.label_NoActiveFriend.TabIndex = 0;
            this.label_NoActiveFriend.Text = "No active people";
            // 
            // onlineList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.label_NoActiveFriend);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "onlineList";
            this.Size = new System.Drawing.Size(314, 417);
            this.MouseEnter += new System.EventHandler(this.OnlineList_MouseEnter);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer TimeRequest;
        private System.Windows.Forms.Label label_NoActiveFriend;
    }
}
