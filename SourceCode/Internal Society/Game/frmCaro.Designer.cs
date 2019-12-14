namespace Internal_Society
{
    partial class frmCaro
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCaro));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties26 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties27 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties28 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties29 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties30 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            this.pnl = new System.Windows.Forms.Panel();
            this.timer_Load = new System.Windows.Forms.Timer(this.components);
            this.pnlGameCaro = new System.Windows.Forms.Panel();
            this.btnReset = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnChoiMoi1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnThoat1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnPlayOffline1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnPlayOnline1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.grbLuatChoi = new System.Windows.Forms.GroupBox();
            this.lblLuatChoi = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlGameCaro.SuspendLayout();
            this.grbLuatChoi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl
            // 
            this.pnl.BackColor = System.Drawing.Color.LightGray;
            this.pnl.Location = new System.Drawing.Point(225, 55);
            this.pnl.Name = "pnl";
            this.pnl.Size = new System.Drawing.Size(501, 501);
            this.pnl.TabIndex = 34;
            this.pnl.Paint += new System.Windows.Forms.PaintEventHandler(this.Pnl_Paint);
            this.pnl.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Pnl_MouseClick);
            // 
            // timer_Load
            // 
            this.timer_Load.Interval = 1000;
            this.timer_Load.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // pnlGameCaro
            // 
            this.pnlGameCaro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(153)))));
            this.pnlGameCaro.Controls.Add(this.btnReset);
            this.pnlGameCaro.Controls.Add(this.btnChoiMoi1);
            this.pnlGameCaro.Controls.Add(this.btnThoat1);
            this.pnlGameCaro.Controls.Add(this.btnPlayOffline1);
            this.pnlGameCaro.Controls.Add(this.btnPlayOnline1);
            this.pnlGameCaro.Controls.Add(this.grbLuatChoi);
            this.pnlGameCaro.Controls.Add(this.pictureBox1);
            this.pnlGameCaro.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlGameCaro.Location = new System.Drawing.Point(0, 0);
            this.pnlGameCaro.Name = "pnlGameCaro";
            this.pnlGameCaro.Size = new System.Drawing.Size(207, 606);
            this.pnlGameCaro.TabIndex = 40;
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.Transparent;
            this.btnReset.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnReset.BackgroundImage")));
            this.btnReset.ButtonText = "Reset Game Mode";
            this.btnReset.ButtonTextMarginLeft = 0;
            this.btnReset.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.btnReset.DisabledFillColor = System.Drawing.Color.Gray;
            this.btnReset.DisabledForecolor = System.Drawing.Color.White;
            this.btnReset.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnReset.IconPadding = 10;
            this.btnReset.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnReset.IdleBorderColor = System.Drawing.Color.DeepPink;
            this.btnReset.IdleBorderRadius = 30;
            this.btnReset.IdleBorderThickness = 2;
            this.btnReset.IdleFillColor = System.Drawing.Color.DeepPink;
            this.btnReset.IdleIconLeftImage = null;
            this.btnReset.IdleIconRightImage = null;
            this.btnReset.Location = new System.Drawing.Point(20, 500);
            this.btnReset.Name = "btnReset";
            stateProperties26.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(58)))), ((int)(((byte)(108)))));
            stateProperties26.BorderRadius = 30;
            stateProperties26.BorderThickness = 2;
            stateProperties26.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(58)))), ((int)(((byte)(108)))));
            stateProperties26.IconLeftImage = null;
            stateProperties26.IconRightImage = null;
            this.btnReset.onHoverState = stateProperties26;
            this.btnReset.Size = new System.Drawing.Size(150, 42);
            this.btnReset.TabIndex = 46;
            this.btnReset.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnReset.Click += new System.EventHandler(this.BtnReset_Click_1);
            // 
            // btnChoiMoi1
            // 
            this.btnChoiMoi1.BackColor = System.Drawing.Color.Transparent;
            this.btnChoiMoi1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnChoiMoi1.BackgroundImage")));
            this.btnChoiMoi1.ButtonText = "Chơi mới";
            this.btnChoiMoi1.ButtonTextMarginLeft = 0;
            this.btnChoiMoi1.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.btnChoiMoi1.DisabledFillColor = System.Drawing.Color.Gray;
            this.btnChoiMoi1.DisabledForecolor = System.Drawing.Color.White;
            this.btnChoiMoi1.Enabled = false;
            this.btnChoiMoi1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChoiMoi1.ForeColor = System.Drawing.Color.White;
            this.btnChoiMoi1.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnChoiMoi1.IconPadding = 10;
            this.btnChoiMoi1.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnChoiMoi1.IdleBorderColor = System.Drawing.Color.DeepPink;
            this.btnChoiMoi1.IdleBorderRadius = 30;
            this.btnChoiMoi1.IdleBorderThickness = 2;
            this.btnChoiMoi1.IdleFillColor = System.Drawing.Color.DeepPink;
            this.btnChoiMoi1.IdleIconLeftImage = null;
            this.btnChoiMoi1.IdleIconRightImage = null;
            this.btnChoiMoi1.Location = new System.Drawing.Point(97, 548);
            this.btnChoiMoi1.Name = "btnChoiMoi1";
            stateProperties27.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(58)))), ((int)(((byte)(108)))));
            stateProperties27.BorderRadius = 30;
            stateProperties27.BorderThickness = 2;
            stateProperties27.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(58)))), ((int)(((byte)(108)))));
            stateProperties27.IconLeftImage = null;
            stateProperties27.IconRightImage = null;
            this.btnChoiMoi1.onHoverState = stateProperties27;
            this.btnChoiMoi1.Size = new System.Drawing.Size(104, 45);
            this.btnChoiMoi1.TabIndex = 45;
            this.btnChoiMoi1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnChoiMoi1.Click += new System.EventHandler(this.BtnChoiMoi1_Click_1);
            // 
            // btnThoat1
            // 
            this.btnThoat1.BackColor = System.Drawing.Color.Transparent;
            this.btnThoat1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnThoat1.BackgroundImage")));
            this.btnThoat1.ButtonText = "Thoát";
            this.btnThoat1.ButtonTextMarginLeft = 0;
            this.btnThoat1.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.btnThoat1.DisabledFillColor = System.Drawing.Color.Gray;
            this.btnThoat1.DisabledForecolor = System.Drawing.Color.White;
            this.btnThoat1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat1.ForeColor = System.Drawing.Color.White;
            this.btnThoat1.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnThoat1.IconPadding = 10;
            this.btnThoat1.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnThoat1.IdleBorderColor = System.Drawing.Color.DeepPink;
            this.btnThoat1.IdleBorderRadius = 30;
            this.btnThoat1.IdleBorderThickness = 2;
            this.btnThoat1.IdleFillColor = System.Drawing.Color.DeepPink;
            this.btnThoat1.IdleIconLeftImage = null;
            this.btnThoat1.IdleIconRightImage = null;
            this.btnThoat1.Location = new System.Drawing.Point(6, 548);
            this.btnThoat1.Name = "btnThoat1";
            stateProperties28.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(58)))), ((int)(((byte)(108)))));
            stateProperties28.BorderRadius = 30;
            stateProperties28.BorderThickness = 2;
            stateProperties28.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(58)))), ((int)(((byte)(108)))));
            stateProperties28.IconLeftImage = null;
            stateProperties28.IconRightImage = null;
            this.btnThoat1.onHoverState = stateProperties28;
            this.btnThoat1.Size = new System.Drawing.Size(85, 45);
            this.btnThoat1.TabIndex = 44;
            this.btnThoat1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnThoat1.Click += new System.EventHandler(this.BtnThoat1_Click_1);
            // 
            // btnPlayOffline1
            // 
            this.btnPlayOffline1.BackColor = System.Drawing.Color.Transparent;
            this.btnPlayOffline1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPlayOffline1.BackgroundImage")));
            this.btnPlayOffline1.ButtonText = "Chơi offline";
            this.btnPlayOffline1.ButtonTextMarginLeft = 0;
            this.btnPlayOffline1.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.btnPlayOffline1.DisabledFillColor = System.Drawing.Color.Gray;
            this.btnPlayOffline1.DisabledForecolor = System.Drawing.Color.White;
            this.btnPlayOffline1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlayOffline1.ForeColor = System.Drawing.Color.White;
            this.btnPlayOffline1.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnPlayOffline1.IconPadding = 10;
            this.btnPlayOffline1.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnPlayOffline1.IdleBorderColor = System.Drawing.Color.DeepPink;
            this.btnPlayOffline1.IdleBorderRadius = 30;
            this.btnPlayOffline1.IdleBorderThickness = 2;
            this.btnPlayOffline1.IdleFillColor = System.Drawing.Color.DeepPink;
            this.btnPlayOffline1.IdleIconLeftImage = null;
            this.btnPlayOffline1.IdleIconRightImage = null;
            this.btnPlayOffline1.Location = new System.Drawing.Point(37, 452);
            this.btnPlayOffline1.Name = "btnPlayOffline1";
            stateProperties29.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(58)))), ((int)(((byte)(108)))));
            stateProperties29.BorderRadius = 30;
            stateProperties29.BorderThickness = 2;
            stateProperties29.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(58)))), ((int)(((byte)(108)))));
            stateProperties29.IconLeftImage = null;
            stateProperties29.IconRightImage = null;
            this.btnPlayOffline1.onHoverState = stateProperties29;
            this.btnPlayOffline1.Size = new System.Drawing.Size(120, 42);
            this.btnPlayOffline1.TabIndex = 43;
            this.btnPlayOffline1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnPlayOffline1.Click += new System.EventHandler(this.BtnPlayOffline1_Click_1);
            // 
            // btnPlayOnline1
            // 
            this.btnPlayOnline1.BackColor = System.Drawing.Color.Transparent;
            this.btnPlayOnline1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPlayOnline1.BackgroundImage")));
            this.btnPlayOnline1.ButtonText = "Chơi với bạn bè";
            this.btnPlayOnline1.ButtonTextMarginLeft = 0;
            this.btnPlayOnline1.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.btnPlayOnline1.DisabledFillColor = System.Drawing.Color.Gray;
            this.btnPlayOnline1.DisabledForecolor = System.Drawing.Color.White;
            this.btnPlayOnline1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlayOnline1.ForeColor = System.Drawing.Color.White;
            this.btnPlayOnline1.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnPlayOnline1.IconPadding = 10;
            this.btnPlayOnline1.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnPlayOnline1.IdleBorderColor = System.Drawing.Color.DeepPink;
            this.btnPlayOnline1.IdleBorderRadius = 30;
            this.btnPlayOnline1.IdleBorderThickness = 2;
            this.btnPlayOnline1.IdleFillColor = System.Drawing.Color.DeepPink;
            this.btnPlayOnline1.IdleIconLeftImage = null;
            this.btnPlayOnline1.IdleIconRightImage = null;
            this.btnPlayOnline1.Location = new System.Drawing.Point(37, 407);
            this.btnPlayOnline1.Name = "btnPlayOnline1";
            stateProperties30.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(58)))), ((int)(((byte)(108)))));
            stateProperties30.BorderRadius = 30;
            stateProperties30.BorderThickness = 2;
            stateProperties30.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(58)))), ((int)(((byte)(108)))));
            stateProperties30.IconLeftImage = null;
            stateProperties30.IconRightImage = null;
            this.btnPlayOnline1.onHoverState = stateProperties30;
            this.btnPlayOnline1.Size = new System.Drawing.Size(120, 39);
            this.btnPlayOnline1.TabIndex = 42;
            this.btnPlayOnline1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnPlayOnline1.Click += new System.EventHandler(this.BtnPlayOnline1_Click_1);
            // 
            // grbLuatChoi
            // 
            this.grbLuatChoi.Controls.Add(this.lblLuatChoi);
            this.grbLuatChoi.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbLuatChoi.ForeColor = System.Drawing.Color.Black;
            this.grbLuatChoi.Location = new System.Drawing.Point(10, 213);
            this.grbLuatChoi.Name = "grbLuatChoi";
            this.grbLuatChoi.Size = new System.Drawing.Size(177, 178);
            this.grbLuatChoi.TabIndex = 41;
            this.grbLuatChoi.TabStop = false;
            this.grbLuatChoi.Text = "Luật chơi";
            // 
            // lblLuatChoi
            // 
            this.lblLuatChoi.AutoSize = true;
            this.lblLuatChoi.Location = new System.Drawing.Point(7, 21);
            this.lblLuatChoi.Name = "lblLuatChoi";
            this.lblLuatChoi.Size = new System.Drawing.Size(0, 13);
            this.lblLuatChoi.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Internal_Society.Properties.Resources.unnamed1;
            this.pictureBox1.Location = new System.Drawing.Point(10, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(177, 178);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 40;
            this.pictureBox1.TabStop = false;
            // 
            // frmCaro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Salmon;
            this.ClientSize = new System.Drawing.Size(747, 606);
            this.Controls.Add(this.pnlGameCaro);
            this.Controls.Add(this.pnl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCaro";
            this.Text = "frmCaro";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FrmCaro_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FrmCaro_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FrmCaro_MouseUp);
            this.pnlGameCaro.ResumeLayout(false);
            this.grbLuatChoi.ResumeLayout(false);
            this.grbLuatChoi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnl;
        private System.Windows.Forms.Timer timer_Load;
        private System.Windows.Forms.Panel pnlGameCaro;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnReset;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnChoiMoi1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnThoat1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnPlayOffline1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnPlayOnline1;
        private System.Windows.Forms.GroupBox grbLuatChoi;
        private System.Windows.Forms.Label lblLuatChoi;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}