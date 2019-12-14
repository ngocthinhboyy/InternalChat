namespace Internal_Society
{
    partial class BuyKey
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.subtract = new Bunifu.Framework.UI.BunifuImageButton();
            this.lb_quantityKey = new System.Windows.Forms.Label();
            this.add = new Bunifu.Framework.UI.BunifuImageButton();
            this.lb_KeyWheel = new System.Windows.Forms.Label();
            this.lb_Diamond = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnPurchase = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.subtract)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.add)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.subtract);
            this.panel1.Controls.Add(this.lb_quantityKey);
            this.panel1.Controls.Add(this.add);
            this.panel1.Location = new System.Drawing.Point(98, 341);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(150, 45);
            this.panel1.TabIndex = 0;
            // 
            // subtract
            // 
            this.subtract.BackColor = System.Drawing.Color.Transparent;
            this.subtract.Dock = System.Windows.Forms.DockStyle.Left;
            this.subtract.Image = global::Internal_Society.Properties.Resources.minus_96px;
            this.subtract.ImageActive = null;
            this.subtract.Location = new System.Drawing.Point(0, 0);
            this.subtract.Name = "subtract";
            this.subtract.Size = new System.Drawing.Size(50, 45);
            this.subtract.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.subtract.TabIndex = 3;
            this.subtract.TabStop = false;
            this.subtract.Zoom = 10;
            this.subtract.Click += new System.EventHandler(this.Subtract_Click);
            // 
            // lb_quantityKey
            // 
            this.lb_quantityKey.AutoSize = true;
            this.lb_quantityKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.lb_quantityKey.ForeColor = System.Drawing.Color.Black;
            this.lb_quantityKey.Location = new System.Drawing.Point(65, 14);
            this.lb_quantityKey.Name = "lb_quantityKey";
            this.lb_quantityKey.Size = new System.Drawing.Size(17, 18);
            this.lb_quantityKey.TabIndex = 9;
            this.lb_quantityKey.Text = "0";
            // 
            // add
            // 
            this.add.BackColor = System.Drawing.Color.Transparent;
            this.add.Dock = System.Windows.Forms.DockStyle.Right;
            this.add.Image = global::Internal_Society.Properties.Resources.add_96px;
            this.add.ImageActive = null;
            this.add.Location = new System.Drawing.Point(100, 0);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(50, 45);
            this.add.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.add.TabIndex = 2;
            this.add.TabStop = false;
            this.add.Zoom = 10;
            this.add.Click += new System.EventHandler(this.Add_Click);
            // 
            // lb_KeyWheel
            // 
            this.lb_KeyWheel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_KeyWheel.AutoSize = true;
            this.lb_KeyWheel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.lb_KeyWheel.ForeColor = System.Drawing.Color.Black;
            this.lb_KeyWheel.Location = new System.Drawing.Point(290, 458);
            this.lb_KeyWheel.Name = "lb_KeyWheel";
            this.lb_KeyWheel.Size = new System.Drawing.Size(15, 17);
            this.lb_KeyWheel.TabIndex = 8;
            this.lb_KeyWheel.Text = "6";
            // 
            // lb_Diamond
            // 
            this.lb_Diamond.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_Diamond.AutoSize = true;
            this.lb_Diamond.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.lb_Diamond.ForeColor = System.Drawing.Color.Black;
            this.lb_Diamond.Location = new System.Drawing.Point(429, 458);
            this.lb_Diamond.Name = "lb_Diamond";
            this.lb_Diamond.Size = new System.Drawing.Size(34, 17);
            this.lb_Diamond.TabIndex = 10;
            this.lb_Diamond.Text = "1000";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox3.Image = global::Internal_Society.Properties.Resources.diamond1;
            this.pictureBox3.Location = new System.Drawing.Point(383, 447);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(41, 38);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::Internal_Society.Properties.Resources.key_0011;
            this.pictureBox1.Location = new System.Drawing.Point(243, 447);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(41, 38);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // btnPurchase
            // 
            this.btnPurchase.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnPurchase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnPurchase.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPurchase.BorderRadius = 0;
            this.btnPurchase.ButtonText = "Purchase";
            this.btnPurchase.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPurchase.DisabledColor = System.Drawing.Color.Gray;
            this.btnPurchase.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnPurchase.ForeColor = System.Drawing.Color.Black;
            this.btnPurchase.Iconcolor = System.Drawing.Color.Transparent;
            this.btnPurchase.Iconimage = global::Internal_Society.Properties.Resources.videos_purchased_64px1;
            this.btnPurchase.Iconimage_right = null;
            this.btnPurchase.Iconimage_right_Selected = null;
            this.btnPurchase.Iconimage_Selected = null;
            this.btnPurchase.IconMarginLeft = 0;
            this.btnPurchase.IconMarginRight = 0;
            this.btnPurchase.IconRightVisible = true;
            this.btnPurchase.IconRightZoom = 0D;
            this.btnPurchase.IconVisible = true;
            this.btnPurchase.IconZoom = 90D;
            this.btnPurchase.IsTab = false;
            this.btnPurchase.Location = new System.Drawing.Point(293, 341);
            this.btnPurchase.Name = "btnPurchase";
            this.btnPurchase.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnPurchase.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnPurchase.OnHoverTextColor = System.Drawing.Color.White;
            this.btnPurchase.selected = false;
            this.btnPurchase.Size = new System.Drawing.Size(131, 48);
            this.btnPurchase.TabIndex = 4;
            this.btnPurchase.Text = "Purchase";
            this.btnPurchase.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPurchase.Textcolor = System.Drawing.Color.White;
            this.btnPurchase.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPurchase.Click += new System.EventHandler(this.BtnPurchase_Click);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::Internal_Society.Properties.Resources.keywheel;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.bunifuImageButton1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(537, 289);
            this.panel2.TabIndex = 1;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel2_MouseDown);
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Panel2_MouseMove);
            this.panel2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Panel2_MouseUp);
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton1.Image = global::Internal_Society.Properties.Resources.delete_0031;
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(490, 12);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(35, 34);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 0;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.BunifuImageButton1_Click);
            // 
            // BuyKey
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(537, 497);
            this.Controls.Add(this.lb_Diamond);
            this.Controls.Add(this.lb_KeyWheel);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnPurchase);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BuyKey";
            this.Text = "BuyKey";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BuyKey_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BuyKey_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BuyKey_MouseUp);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.subtract)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.add)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuImageButton add;
        private Bunifu.Framework.UI.BunifuImageButton subtract;
        private Bunifu.Framework.UI.BunifuFlatButton btnPurchase;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label lb_quantityKey;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private System.Windows.Forms.Label lb_KeyWheel;
        private System.Windows.Forms.Label lb_Diamond;
    }
}