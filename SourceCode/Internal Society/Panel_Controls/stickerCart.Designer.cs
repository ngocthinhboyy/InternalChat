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
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            this.lbl_description = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_preview = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btn_add = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_description
            // 
            this.lbl_description.AutoSize = true;
            this.lbl_description.Location = new System.Drawing.Point(192, 112);
            this.lbl_description.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_description.Name = "lbl_description";
            this.lbl_description.Size = new System.Drawing.Size(53, 20);
            this.lbl_description.TabIndex = 2;
            this.lbl_description.Text = "label1";
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.ForeColor = System.Drawing.Color.DeepPink;
            this.lbl_name.Location = new System.Drawing.Point(190, 40);
            this.lbl_name.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_name.MaximumSize = new System.Drawing.Size(200, 154);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(86, 35);
            this.lbl_name.TabIndex = 3;
            this.lbl_name.Text = "label2";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(23, 23);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(142, 109);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // btn_preview
            // 
            this.btn_preview.BackColor = System.Drawing.Color.Transparent;
            this.btn_preview.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_preview.BackgroundImage")));
            this.btn_preview.ButtonText = "Preview";
            this.btn_preview.ButtonTextMarginLeft = 0;
            this.btn_preview.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.btn_preview.DisabledFillColor = System.Drawing.Color.Gray;
            this.btn_preview.DisabledForecolor = System.Drawing.Color.White;
            this.btn_preview.ForeColor = System.Drawing.Color.Black;
            this.btn_preview.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btn_preview.IconPadding = 10;
            this.btn_preview.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btn_preview.IdleBorderColor = System.Drawing.Color.DeepPink;
            this.btn_preview.IdleBorderRadius = 30;
            this.btn_preview.IdleBorderThickness = 2;
            this.btn_preview.IdleFillColor = System.Drawing.Color.DeepPink;
            this.btn_preview.IdleIconLeftImage = null;
            this.btn_preview.IdleIconRightImage = null;
            this.btn_preview.Location = new System.Drawing.Point(415, 15);
            this.btn_preview.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btn_preview.Name = "btn_preview";
            stateProperties1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(58)))), ((int)(((byte)(108)))));
            stateProperties1.BorderRadius = 30;
            stateProperties1.BorderThickness = 2;
            stateProperties1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(58)))), ((int)(((byte)(108)))));
            stateProperties1.IconLeftImage = null;
            stateProperties1.IconRightImage = null;
            this.btn_preview.onHoverState = stateProperties1;
            this.btn_preview.Size = new System.Drawing.Size(127, 55);
            this.btn_preview.TabIndex = 10;
            this.btn_preview.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_preview.Click += new System.EventHandler(this.Btn_preview_Click_1);
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.Transparent;
            this.btn_add.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_add.BackgroundImage")));
            this.btn_add.ButtonText = "Add";
            this.btn_add.ButtonTextMarginLeft = 0;
            this.btn_add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_add.DisabledBorderColor = System.Drawing.Color.SkyBlue;
            this.btn_add.DisabledFillColor = System.Drawing.Color.LightSkyBlue;
            this.btn_add.DisabledForecolor = System.Drawing.Color.White;
            this.btn_add.ForeColor = System.Drawing.Color.Black;
            this.btn_add.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btn_add.IconPadding = 10;
            this.btn_add.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btn_add.IdleBorderColor = System.Drawing.Color.SeaGreen;
            this.btn_add.IdleBorderRadius = 30;
            this.btn_add.IdleBorderThickness = 2;
            this.btn_add.IdleFillColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_add.IdleIconLeftImage = null;
            this.btn_add.IdleIconRightImage = null;
            this.btn_add.Location = new System.Drawing.Point(415, 82);
            this.btn_add.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btn_add.Name = "btn_add";
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(58)))), ((int)(((byte)(108)))));
            stateProperties2.BorderRadius = 30;
            stateProperties2.BorderThickness = 2;
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(58)))), ((int)(((byte)(108)))));
            stateProperties2.IconLeftImage = null;
            stateProperties2.IconRightImage = null;
            this.btn_add.onHoverState = stateProperties2;
            this.btn_add.Size = new System.Drawing.Size(127, 55);
            this.btn_add.TabIndex = 13;
            this.btn_add.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_add.Click += new System.EventHandler(this.Btn_add_Click);
            // 
            // stickerCart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.btn_preview);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.lbl_description);
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "stickerCart";
            this.Size = new System.Drawing.Size(568, 151);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_description;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btn_preview;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btn_add;
    }
}
