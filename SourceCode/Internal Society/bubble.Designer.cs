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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(bubble));
            this.lb_message = new System.Windows.Forms.Label();
            this.lb_time = new System.Windows.Forms.Label();
            this.picture_sticker = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picture_sticker)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_message
            // 
            this.lb_message.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_message.ForeColor = System.Drawing.Color.White;
            this.lb_message.Location = new System.Drawing.Point(24, 22);
            this.lb_message.Name = "lb_message";
            this.lb_message.Size = new System.Drawing.Size(301, 126);
            this.lb_message.TabIndex = 0;
            this.lb_message.Text = "label1dnananslsnaknSKLN2183938018383182938038930138091830NSAKLnsans\r\n";
            // 
            // lb_time
            // 
            this.lb_time.AutoSize = true;
            this.lb_time.ForeColor = System.Drawing.Color.White;
            this.lb_time.Location = new System.Drawing.Point(24, 148);
            this.lb_time.Name = "lb_time";
            this.lb_time.Size = new System.Drawing.Size(42, 20);
            this.lb_time.TabIndex = 1;
            this.lb_time.Text = "Wed";
            // 
            // picture_sticker
            // 
            this.picture_sticker.BackColor = System.Drawing.Color.Transparent;
            this.picture_sticker.Image = ((System.Drawing.Image)(resources.GetObject("picture_sticker.Image")));
            this.picture_sticker.Location = new System.Drawing.Point(28, 22);
            this.picture_sticker.Name = "picture_sticker";
            this.picture_sticker.Size = new System.Drawing.Size(200, 200);
            this.picture_sticker.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picture_sticker.TabIndex = 2;
            this.picture_sticker.TabStop = false;
            this.picture_sticker.Visible = false;
            // 
            // bubble
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(164)))), ((int)(((byte)(147)))));
            this.Controls.Add(this.picture_sticker);
            this.Controls.Add(this.lb_time);
            this.Controls.Add(this.lb_message);
            this.Name = "bubble";
            this.Size = new System.Drawing.Size(551, 193);
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
