namespace Internal_Society
{
    partial class Panel_Sticker
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Panel_Sticker));
            this.panel2 = new System.Windows.Forms.Panel();
            this.pakage_model = new Bunifu.Framework.UI.BunifuImageButton();
            this.sticker_model = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lb_Description = new System.Windows.Forms.Label();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pakage_model)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sticker_model)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.BackColor = System.Drawing.Color.MistyRose;
            this.panel2.Controls.Add(this.pakage_model);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 849);
            this.panel2.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(833, 120);
            this.panel2.TabIndex = 3;
            // 
            // pakage_model
            // 
            this.pakage_model.BackColor = System.Drawing.Color.SeaGreen;
            this.pakage_model.Image = ((System.Drawing.Image)(resources.GetObject("pakage_model.Image")));
            this.pakage_model.ImageActive = null;
            this.pakage_model.Location = new System.Drawing.Point(5, 20);
            this.pakage_model.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.pakage_model.Name = "pakage_model";
            this.pakage_model.Size = new System.Drawing.Size(75, 69);
            this.pakage_model.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pakage_model.TabIndex = 0;
            this.pakage_model.TabStop = false;
            this.pakage_model.Zoom = 10;
            // 
            // sticker_model
            // 
            this.sticker_model.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sticker_model.BackColor = System.Drawing.Color.Transparent;
            this.sticker_model.Image = global::Internal_Society.Properties.Resources.heohong_001;
            this.sticker_model.ImageActive = null;
            this.sticker_model.Location = new System.Drawing.Point(25, 40);
            this.sticker_model.Name = "sticker_model";
            this.sticker_model.Size = new System.Drawing.Size(200, 185);
            this.sticker_model.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.sticker_model.TabIndex = 2;
            this.sticker_model.TabStop = false;
            this.sticker_model.Visible = false;
            this.sticker_model.Zoom = 10;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.MistyRose;
            this.panel1.Controls.Add(this.sticker_model);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel1.Location = new System.Drawing.Point(0, 49);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(833, 800);
            this.panel1.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.PeachPuff;
            this.panel3.Controls.Add(this.lb_Description);
            this.panel3.Controls.Add(this.bunifuImageButton1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(833, 49);
            this.panel3.TabIndex = 4;
            // 
            // lb_Description
            // 
            this.lb_Description.AutoSize = true;
            this.lb_Description.Font = new System.Drawing.Font("Segoe UI", 12.15584F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Description.Location = new System.Drawing.Point(3, 6);
            this.lb_Description.Name = "lb_Description";
            this.lb_Description.Size = new System.Drawing.Size(136, 36);
            this.lb_Description.TabIndex = 1;
            this.lb_Description.Text = "Heo hồng";
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton1.Image = global::Internal_Society.Properties.Resources.delete_001;
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(780, 0);
            this.bunifuImageButton1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(48, 48);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 0;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.BunifuImageButton1_Click);
            // 
            // Panel_Sticker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 969);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Panel_Sticker";
            this.Opacity = 0.9D;
            this.Text = "Panel_Sticker1";
            this.Load += new System.EventHandler(this.Panel_Sticker_Load);
            this.Shown += new System.EventHandler(this.Panel_Sticker_Shown);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pakage_model)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sticker_model)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuImageButton pakage_model;
        private Bunifu.Framework.UI.BunifuImageButton sticker_model;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private System.Windows.Forms.Label lb_Description;
    }
}