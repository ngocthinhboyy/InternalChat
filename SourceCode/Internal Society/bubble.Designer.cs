namespace Internal_Society
{
    partial class bubble
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
            this.lb_message = new System.Windows.Forms.Label();
            this.lb_time = new System.Windows.Forms.Label();
            this.picture_sticker = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picture_sticker)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_message
            // 
            this.lb_message.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_message.AutoSize = true;
            this.lb_message.BackColor = System.Drawing.Color.Transparent;
            this.lb_message.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_message.ForeColor = System.Drawing.Color.White;
            this.lb_message.Location = new System.Drawing.Point(89, 29);
            this.lb_message.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_message.MaximumSize = new System.Drawing.Size(300, 0);
            this.lb_message.Name = "lb_message";
            this.lb_message.Size = new System.Drawing.Size(300, 40);
            this.lb_message.TabIndex = 0;
            this.lb_message.Text = "cnkknknkn238213913890338908383182038912389183180380238912831";
            this.lb_message.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lb_time
            // 
            this.lb_time.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_time.ForeColor = System.Drawing.Color.White;
            this.lb_time.Location = new System.Drawing.Point(274, 157);
            this.lb_time.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_time.Name = "lb_time";
            this.lb_time.Size = new System.Drawing.Size(115, 22);
            this.lb_time.TabIndex = 1;
            this.lb_time.Text = "2019-10-17 05:26:35";
            this.lb_time.Visible = false;
            // 
            // picture_sticker
            // 
            this.picture_sticker.BackColor = System.Drawing.Color.Transparent;
            this.picture_sticker.Location = new System.Drawing.Point(13, 14);
            this.picture_sticker.Margin = new System.Windows.Forms.Padding(2);
            this.picture_sticker.Name = "picture_sticker";
            this.picture_sticker.Size = new System.Drawing.Size(133, 130);
            this.picture_sticker.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picture_sticker.TabIndex = 2;
            this.picture_sticker.TabStop = false;
            this.picture_sticker.Visible = false;
            // 
            // bubble
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(164)))), ((int)(((byte)(147)))));
            this.Controls.Add(this.picture_sticker);
            this.Controls.Add(this.lb_time);
            this.Controls.Add(this.lb_message);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(400, 0);
            this.Name = "bubble";
            this.Size = new System.Drawing.Size(400, 339);
            this.Resize += new System.EventHandler(this.Bubble_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.picture_sticker)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_message;
        private System.Windows.Forms.Label lb_time;
        private System.Windows.Forms.PictureBox picture_sticker;
    }
}
