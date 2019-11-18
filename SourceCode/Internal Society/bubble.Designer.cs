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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(bubble));
            this.picture_sticker = new System.Windows.Forms.PictureBox();
            this.gradientPanel = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.lb_time = new System.Windows.Forms.Label();
            this.lb_message = new System.Windows.Forms.Label();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picture_sticker)).BeginInit();
            this.gradientPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // picture_sticker
            // 
            this.picture_sticker.BackColor = System.Drawing.Color.Transparent;
            this.picture_sticker.Location = new System.Drawing.Point(31, 26);
            this.picture_sticker.Margin = new System.Windows.Forms.Padding(2);
            this.picture_sticker.Name = "picture_sticker";
            this.picture_sticker.Size = new System.Drawing.Size(133, 130);
            this.picture_sticker.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picture_sticker.TabIndex = 5;
            this.picture_sticker.TabStop = false;
            this.picture_sticker.Visible = false;
            // 
            // gradientPanel
            // 
            this.gradientPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gradientPanel.BackgroundImage")));
            this.gradientPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gradientPanel.Controls.Add(this.lb_time);
            this.gradientPanel.Controls.Add(this.lb_message);
            this.gradientPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gradientPanel.GradientBottomLeft = System.Drawing.Color.White;
            this.gradientPanel.GradientBottomRight = System.Drawing.Color.White;
            this.gradientPanel.GradientTopLeft = System.Drawing.Color.White;
            this.gradientPanel.GradientTopRight = System.Drawing.Color.White;
            this.gradientPanel.Location = new System.Drawing.Point(0, 0);
            this.gradientPanel.Name = "gradientPanel";
            this.gradientPanel.Quality = 10;
            this.gradientPanel.Size = new System.Drawing.Size(400, 158);
            this.gradientPanel.TabIndex = 3;
            // 
            // lb_time
            // 
            this.lb_time.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_time.ForeColor = System.Drawing.Color.White;
            this.lb_time.Location = new System.Drawing.Point(273, 49);
            this.lb_time.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_time.Name = "lb_time";
            this.lb_time.Size = new System.Drawing.Size(115, 22);
            this.lb_time.TabIndex = 4;
            this.lb_time.Text = "2019-10-17 05:26:35";
            this.lb_time.Visible = false;
            // 
            // lb_message
            // 
            this.lb_message.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_message.AutoSize = true;
            this.lb_message.BackColor = System.Drawing.Color.Transparent;
            this.lb_message.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_message.ForeColor = System.Drawing.Color.White;
            this.lb_message.Location = new System.Drawing.Point(57, -77);
            this.lb_message.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_message.MaximumSize = new System.Drawing.Size(300, 0);
            this.lb_message.Name = "lb_message";
            this.lb_message.Size = new System.Drawing.Size(300, 40);
            this.lb_message.TabIndex = 3;
            this.lb_message.Text = "cnkknknkn238213913890338908383182038912389183180380238912831";
            this.lb_message.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bubble
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.picture_sticker);
            this.Controls.Add(this.gradientPanel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(400, 0);
            this.Name = "bubble";
            this.Size = new System.Drawing.Size(400, 158);
            this.Resize += new System.EventHandler(this.Bubble_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.picture_sticker)).EndInit();
            this.gradientPanel.ResumeLayout(false);
            this.gradientPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picture_sticker;
        private Bunifu.Framework.UI.BunifuGradientPanel gradientPanel;
        private System.Windows.Forms.Label lb_message;
        private System.Windows.Forms.Label lb_time;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
    }
}
