namespace Internal_Society
{
    partial class sticker
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
            this.stickerBox = new Bunifu.Framework.UI.BunifuImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.stickerBox)).BeginInit();
            this.SuspendLayout();
            // 
            // stickerBox
            // 
            this.stickerBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.stickerBox.BackColor = System.Drawing.Color.Transparent;
            this.stickerBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.stickerBox.Image = global::Internal_Society.Properties.Resources.tonton_friends_011;
            this.stickerBox.ImageActive = null;
            this.stickerBox.Location = new System.Drawing.Point(3, 15);
            this.stickerBox.Margin = new System.Windows.Forms.Padding(0);
            this.stickerBox.Name = "stickerBox";
            this.stickerBox.Size = new System.Drawing.Size(202, 186);
            this.stickerBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.stickerBox.TabIndex = 3;
            this.stickerBox.TabStop = false;
            this.stickerBox.Zoom = 10;
            this.stickerBox.Click += new System.EventHandler(this.StickerBox_Click);
            // 
            // sticker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.stickerBox);
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "sticker";
            this.Size = new System.Drawing.Size(217, 226);
            ((System.ComponentModel.ISupportInitialize)(this.stickerBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuImageButton stickerBox;
    }
}
