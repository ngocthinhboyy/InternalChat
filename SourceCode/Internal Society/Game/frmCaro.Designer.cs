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
            Bunifu.UI.WinForms.BunifuAnimatorNS.Animation animation10 = new Bunifu.UI.WinForms.BunifuAnimatorNS.Animation();
            Bunifu.UI.WinForms.BunifuAnimatorNS.Animation animation9 = new Bunifu.UI.WinForms.BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCaro));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties21 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties22 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties23 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties24 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties25 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            this.pnl = new System.Windows.Forms.Panel();
            this.timer_Load = new System.Windows.Forms.Timer(this.components);
            this.pnlGameCaro = new System.Windows.Forms.Panel();
            this.pnl_Friend = new System.Windows.Forms.Panel();
            this.grbLuatChoi = new System.Windows.Forms.GroupBox();
            this.lblLuatChoi = new System.Windows.Forms.Label();
            this.bunifuTransition1 = new Bunifu.UI.WinForms.BunifuTransition(this.components);
            this.bunifuTransition2 = new Bunifu.UI.WinForms.BunifuTransition(this.components);
            this.label_NoActiveFriend = new System.Windows.Forms.Label();
            this.btnReset = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnChoiMoi1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnThoat1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnPlayOffline1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnPlayOnline1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.pnlGameCaro.SuspendLayout();
            this.pnl_Friend.SuspendLayout();
            this.grbLuatChoi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl
            // 
            this.pnl.BackColor = System.Drawing.Color.LightGray;
            this.bunifuTransition2.SetDecoration(this.pnl, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.pnl, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.pnl.Location = new System.Drawing.Point(233, 62);
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
            this.bunifuTransition2.SetDecoration(this.pnlGameCaro, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.pnlGameCaro, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.pnlGameCaro.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlGameCaro.Location = new System.Drawing.Point(0, 0);
            this.pnlGameCaro.Name = "pnlGameCaro";
            this.pnlGameCaro.Size = new System.Drawing.Size(219, 606);
            this.pnlGameCaro.TabIndex = 40;
            // 
            // pnl_Friend
            // 
            this.pnl_Friend.BackColor = System.Drawing.Color.White;
            this.pnl_Friend.Controls.Add(this.label_NoActiveFriend);
            this.bunifuTransition2.SetDecoration(this.pnl_Friend, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.pnl_Friend, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.pnl_Friend.Location = new System.Drawing.Point(228, 0);
            this.pnl_Friend.Name = "pnl_Friend";
            this.pnl_Friend.Size = new System.Drawing.Size(219, 606);
            this.pnl_Friend.TabIndex = 47;
            this.pnl_Friend.Visible = false;
            this.pnl_Friend.Paint += new System.Windows.Forms.PaintEventHandler(this.Pnl_Friend_Paint);
            this.pnl_Friend.MouseEnter += new System.EventHandler(this.Pnl_Friend_MouseEnter);
            // 
            // grbLuatChoi
            // 
            this.grbLuatChoi.Controls.Add(this.lblLuatChoi);
            this.bunifuTransition2.SetDecoration(this.grbLuatChoi, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.grbLuatChoi, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
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
            this.bunifuTransition1.SetDecoration(this.lblLuatChoi, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.lblLuatChoi, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.lblLuatChoi.Location = new System.Drawing.Point(7, 21);
            this.lblLuatChoi.Name = "lblLuatChoi";
            this.lblLuatChoi.Size = new System.Drawing.Size(0, 13);
            this.lblLuatChoi.TabIndex = 0;
            // 
            // bunifuTransition1
            // 
            this.bunifuTransition1.AnimationType = Bunifu.UI.WinForms.BunifuAnimatorNS.AnimationType.VertSlide;
            this.bunifuTransition1.Cursor = null;
            animation10.AnimateOnlyDifferences = true;
            animation10.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation10.BlindCoeff")));
            animation10.LeafCoeff = 0F;
            animation10.MaxTime = 1F;
            animation10.MinTime = 0F;
            animation10.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation10.MosaicCoeff")));
            animation10.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation10.MosaicShift")));
            animation10.MosaicSize = 0;
            animation10.Padding = new System.Windows.Forms.Padding(0);
            animation10.RotateCoeff = 0F;
            animation10.RotateLimit = 0F;
            animation10.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation10.ScaleCoeff")));
            animation10.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation10.SlideCoeff")));
            animation10.TimeCoeff = 0F;
            animation10.TransparencyCoeff = 0F;
            this.bunifuTransition1.DefaultAnimation = animation10;
            // 
            // bunifuTransition2
            // 
            this.bunifuTransition2.AnimationType = Bunifu.UI.WinForms.BunifuAnimatorNS.AnimationType.ScaleAndRotate;
            this.bunifuTransition2.Cursor = null;
            animation9.AnimateOnlyDifferences = true;
            animation9.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation9.BlindCoeff")));
            animation9.LeafCoeff = 0F;
            animation9.MaxTime = 1F;
            animation9.MinTime = 0F;
            animation9.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation9.MosaicCoeff")));
            animation9.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation9.MosaicShift")));
            animation9.MosaicSize = 0;
            animation9.Padding = new System.Windows.Forms.Padding(30);
            animation9.RotateCoeff = 0.5F;
            animation9.RotateLimit = 0.2F;
            animation9.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation9.ScaleCoeff")));
            animation9.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation9.SlideCoeff")));
            animation9.TimeCoeff = 0F;
            animation9.TransparencyCoeff = 0F;
            this.bunifuTransition2.DefaultAnimation = animation9;
            // 
            // label_NoActiveFriend
            // 
            this.label_NoActiveFriend.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.label_NoActiveFriend, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.label_NoActiveFriend, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.label_NoActiveFriend.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_NoActiveFriend.ForeColor = System.Drawing.Color.Black;
            this.label_NoActiveFriend.Location = new System.Drawing.Point(30, 55);
            this.label_NoActiveFriend.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_NoActiveFriend.Name = "label_NoActiveFriend";
            this.label_NoActiveFriend.Size = new System.Drawing.Size(143, 33);
            this.label_NoActiveFriend.TabIndex = 1;
            this.label_NoActiveFriend.Text = "No Friend";
            this.label_NoActiveFriend.Visible = false;
            this.label_NoActiveFriend.Click += new System.EventHandler(this.Label_NoActiveFriend_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.Transparent;
            this.btnReset.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnReset.BackgroundImage")));
            this.btnReset.ButtonText = "Reset Game Mode";
            this.btnReset.ButtonTextMarginLeft = 0;
            this.bunifuTransition2.SetDecoration(this.btnReset, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.btnReset, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
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
            stateProperties21.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(58)))), ((int)(((byte)(108)))));
            stateProperties21.BorderRadius = 30;
            stateProperties21.BorderThickness = 2;
            stateProperties21.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(58)))), ((int)(((byte)(108)))));
            stateProperties21.IconLeftImage = null;
            stateProperties21.IconRightImage = null;
            this.btnReset.onHoverState = stateProperties21;
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
            this.bunifuTransition2.SetDecoration(this.btnChoiMoi1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.btnChoiMoi1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
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
            stateProperties22.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(58)))), ((int)(((byte)(108)))));
            stateProperties22.BorderRadius = 30;
            stateProperties22.BorderThickness = 2;
            stateProperties22.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(58)))), ((int)(((byte)(108)))));
            stateProperties22.IconLeftImage = null;
            stateProperties22.IconRightImage = null;
            this.btnChoiMoi1.onHoverState = stateProperties22;
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
            this.bunifuTransition2.SetDecoration(this.btnThoat1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.btnThoat1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
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
            stateProperties23.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(58)))), ((int)(((byte)(108)))));
            stateProperties23.BorderRadius = 30;
            stateProperties23.BorderThickness = 2;
            stateProperties23.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(58)))), ((int)(((byte)(108)))));
            stateProperties23.IconLeftImage = null;
            stateProperties23.IconRightImage = null;
            this.btnThoat1.onHoverState = stateProperties23;
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
            this.bunifuTransition2.SetDecoration(this.btnPlayOffline1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.btnPlayOffline1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
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
            stateProperties24.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(58)))), ((int)(((byte)(108)))));
            stateProperties24.BorderRadius = 30;
            stateProperties24.BorderThickness = 2;
            stateProperties24.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(58)))), ((int)(((byte)(108)))));
            stateProperties24.IconLeftImage = null;
            stateProperties24.IconRightImage = null;
            this.btnPlayOffline1.onHoverState = stateProperties24;
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
            this.bunifuTransition2.SetDecoration(this.btnPlayOnline1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.btnPlayOnline1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
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
            stateProperties25.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(58)))), ((int)(((byte)(108)))));
            stateProperties25.BorderRadius = 30;
            stateProperties25.BorderThickness = 2;
            stateProperties25.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(58)))), ((int)(((byte)(108)))));
            stateProperties25.IconLeftImage = null;
            stateProperties25.IconRightImage = null;
            this.btnPlayOnline1.onHoverState = stateProperties25;
            this.btnPlayOnline1.Size = new System.Drawing.Size(120, 39);
            this.btnPlayOnline1.TabIndex = 42;
            this.btnPlayOnline1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnPlayOnline1.Click += new System.EventHandler(this.BtnPlayOnline1_Click_1);
            // 
            // pictureBox1
            // 
            this.bunifuTransition1.SetDecoration(this.pictureBox1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.pictureBox1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.pictureBox1.Image = global::Internal_Society.Properties.Resources.unnamed1;
            this.pictureBox1.Location = new System.Drawing.Point(10, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(177, 178);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 40;
            this.pictureBox1.TabStop = false;
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition2.SetDecoration(this.bunifuImageButton1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.bunifuImageButton1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuImageButton1.Image = global::Internal_Society.Properties.Resources.delete_0021;
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(703, 0);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(43, 42);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 48;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.BunifuImageButton1_Click_1);
            // 
            // frmCaro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Salmon;
            this.ClientSize = new System.Drawing.Size(747, 606);
            this.Controls.Add(this.bunifuImageButton1);
            this.Controls.Add(this.pnl_Friend);
            this.Controls.Add(this.pnlGameCaro);
            this.Controls.Add(this.pnl);
            this.bunifuTransition2.SetDecoration(this, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCaro";
            this.Text = "frmCaro";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FrmCaro_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FrmCaro_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FrmCaro_MouseUp);
            this.pnlGameCaro.ResumeLayout(false);
            this.pnl_Friend.ResumeLayout(false);
            this.pnl_Friend.PerformLayout();
            this.grbLuatChoi.ResumeLayout(false);
            this.grbLuatChoi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
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
        private System.Windows.Forms.Panel pnl_Friend;
        private Bunifu.UI.WinForms.BunifuTransition bunifuTransition1;
        private Bunifu.UI.WinForms.BunifuTransition bunifuTransition2;
        private System.Windows.Forms.Label label_NoActiveFriend;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
    }
}