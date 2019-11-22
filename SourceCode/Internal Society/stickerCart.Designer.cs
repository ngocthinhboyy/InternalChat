namespace Internal_Society
{
    partial class stickerCart
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(stickerCart));
            this.lbl_description = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_preview = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btn_add = new Bunifu.Framework.UI.BunifuThinButton2();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_description
            // 
            this.lbl_description.AutoSize = true;
            this.lbl_description.Location = new System.Drawing.Point(115, 50);
            this.lbl_description.Name = "lbl_description";
            this.lbl_description.Size = new System.Drawing.Size(35, 13);
            this.lbl_description.TabIndex = 2;
            this.lbl_description.Text = "label1";
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.Location = new System.Drawing.Point(115, 24);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(52, 18);
            this.lbl_name.TabIndex = 3;
            this.lbl_name.Text = "label2";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(14, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(85, 71);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // btn_preview
            // 
            this.btn_preview.ActiveBorderThickness = 1;
            this.btn_preview.ActiveCornerRadius = 20;
            this.btn_preview.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btn_preview.ActiveForecolor = System.Drawing.Color.White;
            this.btn_preview.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btn_preview.BackColor = System.Drawing.Color.White;
            this.btn_preview.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_preview.BackgroundImage")));
            this.btn_preview.ButtonText = "Preview";
            this.btn_preview.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_preview.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_preview.ForeColor = System.Drawing.Color.SeaGreen;
            this.btn_preview.IdleBorderThickness = 1;
            this.btn_preview.IdleCornerRadius = 20;
            this.btn_preview.IdleFillColor = System.Drawing.Color.White;
            this.btn_preview.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btn_preview.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btn_preview.Location = new System.Drawing.Point(267, 5);
            this.btn_preview.Margin = new System.Windows.Forms.Padding(5);
            this.btn_preview.Name = "btn_preview";
            this.btn_preview.Size = new System.Drawing.Size(75, 42);
            this.btn_preview.TabIndex = 6;
            this.btn_preview.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_preview.Click += new System.EventHandler(this.Btn_preview_Click);
            // 
            // btn_add
            // 
            this.btn_add.ActiveBorderThickness = 1;
            this.btn_add.ActiveCornerRadius = 20;
            this.btn_add.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btn_add.ActiveForecolor = System.Drawing.Color.White;
            this.btn_add.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btn_add.BackColor = System.Drawing.Color.White;
            this.btn_add.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_add.BackgroundImage")));
            this.btn_add.ButtonText = "Add";
            this.btn_add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_add.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.ForeColor = System.Drawing.Color.SeaGreen;
            this.btn_add.IdleBorderThickness = 1;
            this.btn_add.IdleCornerRadius = 20;
            this.btn_add.IdleFillColor = System.Drawing.Color.White;
            this.btn_add.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btn_add.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btn_add.Location = new System.Drawing.Point(267, 50);
            this.btn_add.Margin = new System.Windows.Forms.Padding(5);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 42);
            this.btn_add.TabIndex = 7;
            this.btn_add.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // stickerCart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.btn_preview);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.lbl_description);
            this.Name = "stickerCart";
            this.Size = new System.Drawing.Size(348, 98);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_description;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_preview;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_add;
    }
}
