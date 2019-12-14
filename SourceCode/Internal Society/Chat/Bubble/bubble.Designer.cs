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
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.gradientPanel = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.lb_time = new System.Windows.Forms.Label();
            this.lb_message = new System.Windows.Forms.Label();
            this.picture_sticker = new System.Windows.Forms.PictureBox();
            this.gradientPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_sticker)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // gradientPanel
            // 
            this.gradientPanel.BackColor = System.Drawing.Color.White;
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
            this.gradientPanel.Margin = new System.Windows.Forms.Padding(5);
            this.gradientPanel.Name = "gradientPanel";
            this.gradientPanel.Quality = 10;
            this.gradientPanel.Size = new System.Drawing.Size(667, 205);
            this.gradientPanel.TabIndex = 3;
            // 
            // lb_time
            // 
            this.lb_time.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_time.ForeColor = System.Drawing.Color.White;
            this.lb_time.Location = new System.Drawing.Point(415, 113);
            this.lb_time.Name = "lb_time";
            this.lb_time.Size = new System.Drawing.Size(192, 34);
            this.lb_time.TabIndex = 3;
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
            this.lb_message.Location = new System.Drawing.Point(107, 3);
            this.lb_message.MaximumSize = new System.Drawing.Size(500, 0);
            this.lb_message.Name = "lb_message";
            this.lb_message.Size = new System.Drawing.Size(495, 70);
            this.lb_message.TabIndex = 2;
            this.lb_message.Text = "cnkknknkn238213913890338908383182038912389183180380238912831";
            this.lb_message.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // picture_sticker
            // 
            this.picture_sticker.BackColor = System.Drawing.Color.Transparent;
            this.picture_sticker.InitialImage = global::Internal_Society.Properties.Resources.loading;
            this.picture_sticker.Location = new System.Drawing.Point(2, 2);
            this.picture_sticker.Name = "picture_sticker";
            this.picture_sticker.Size = new System.Drawing.Size(222, 200);
            this.picture_sticker.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picture_sticker.TabIndex = 2;
            this.picture_sticker.TabStop = false;
            this.picture_sticker.Visible = false;
            // 
            // bubble
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.gradientPanel);
            this.Controls.Add(this.picture_sticker);
            this.MaximumSize = new System.Drawing.Size(667, 0);
            this.Name = "bubble";
            this.Size = new System.Drawing.Size(667, 205);
            this.Resize += new System.EventHandler(this.Bubble_Resize);
            this.gradientPanel.ResumeLayout(false);
            this.gradientPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_sticker)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox picture_sticker;
        private Bunifu.Framework.UI.BunifuGradientPanel gradientPanel;
        private System.Windows.Forms.Label lb_time;
        private System.Windows.Forms.Label lb_message;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
    }
}
