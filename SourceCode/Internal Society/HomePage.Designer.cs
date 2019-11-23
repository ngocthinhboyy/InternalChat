using Bunifu.Framework.UI;

namespace Internal_Society
{
    partial class HomePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePage));
            this.panel1 = new System.Windows.Forms.Panel();
            this.indicator = new System.Windows.Forms.PictureBox();
            this.Tab_Settings = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Tab_Games = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Tab_Calendar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Tab_Cart = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Tab_Chat = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Tab_Profile = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Tab_DashBoard = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_create_new = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pn_header = new System.Windows.Forms.Panel();
            this.label_Fullname = new System.Windows.Forms.Label();
            this.picture_user_image = new System.Windows.Forms.PictureBox();
            this.textbox_Search = new Bunifu.Framework.UI.BunifuTextbox();
            this.panel_Search1 = new Internal_Society.Panel_Search();
            this.panel_Settings = new Internal_Society.Panel_Settings();
            this.panel_Games = new Internal_Society.Panel_Games();
            this.panel_Dashboard = new Internal_Society.Panel_Dashboard();
            this.panel_Cart = new Internal_Society.Panel_Cart();
            this.panel_Calendar = new Internal_Society.Panel_Calendar();
            this.panel_Chat = new Internal_Society.Panel_Chat();
            this.panel_Profile = new Internal_Society.Panel_Profile();
            this.onlineList1 = new Internal_Society.onlineList();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.indicator)).BeginInit();
            this.panel2.SuspendLayout();
            this.pn_header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_user_image)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(56)))), ((int)(((byte)(69)))));
            this.panel1.Controls.Add(this.onlineList1);
            this.panel1.Controls.Add(this.indicator);
            this.panel1.Controls.Add(this.Tab_Settings);
            this.panel1.Controls.Add(this.Tab_Games);
            this.panel1.Controls.Add(this.Tab_Calendar);
            this.panel1.Controls.Add(this.Tab_Cart);
            this.panel1.Controls.Add(this.Tab_Chat);
            this.panel1.Controls.Add(this.Tab_Profile);
            this.panel1.Controls.Add(this.Tab_DashBoard);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(314, 661);
            this.panel1.TabIndex = 0;
            // 
            // indicator
            // 
            this.indicator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(121)))), ((int)(((byte)(254)))));
            this.indicator.Location = new System.Drawing.Point(0, 134);
            this.indicator.Margin = new System.Windows.Forms.Padding(2);
            this.indicator.Name = "indicator";
            this.indicator.Size = new System.Drawing.Size(7, 48);
            this.indicator.TabIndex = 11;
            this.indicator.TabStop = false;
            // 
            // Tab_Settings
            // 
            this.Tab_Settings.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(56)))), ((int)(((byte)(69)))));
            this.Tab_Settings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(56)))), ((int)(((byte)(69)))));
            this.Tab_Settings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Tab_Settings.BorderRadius = 0;
            this.Tab_Settings.ButtonText = "  Settings";
            this.Tab_Settings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Tab_Settings.DisabledColor = System.Drawing.Color.Gray;
            this.Tab_Settings.Dock = System.Windows.Forms.DockStyle.Top;
            this.Tab_Settings.Iconcolor = System.Drawing.Color.Transparent;
            this.Tab_Settings.Iconimage = ((System.Drawing.Image)(resources.GetObject("Tab_Settings.Iconimage")));
            this.Tab_Settings.Iconimage_right = null;
            this.Tab_Settings.Iconimage_right_Selected = null;
            this.Tab_Settings.Iconimage_Selected = null;
            this.Tab_Settings.IconMarginLeft = 0;
            this.Tab_Settings.IconMarginRight = 0;
            this.Tab_Settings.IconRightVisible = true;
            this.Tab_Settings.IconRightZoom = 0D;
            this.Tab_Settings.IconVisible = true;
            this.Tab_Settings.IconZoom = 40D;
            this.Tab_Settings.IsTab = false;
            this.Tab_Settings.Location = new System.Drawing.Point(0, 422);
            this.Tab_Settings.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Tab_Settings.Name = "Tab_Settings";
            this.Tab_Settings.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(56)))), ((int)(((byte)(69)))));
            this.Tab_Settings.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(56)))), ((int)(((byte)(69)))));
            this.Tab_Settings.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.Tab_Settings.selected = false;
            this.Tab_Settings.Size = new System.Drawing.Size(314, 48);
            this.Tab_Settings.TabIndex = 12;
            this.Tab_Settings.Text = "  Settings";
            this.Tab_Settings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Tab_Settings.Textcolor = System.Drawing.Color.White;
            this.Tab_Settings.TextFont = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tab_Settings.Click += new System.EventHandler(this.Tab_Settings_Click);
            // 
            // Tab_Games
            // 
            this.Tab_Games.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(56)))), ((int)(((byte)(69)))));
            this.Tab_Games.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(56)))), ((int)(((byte)(69)))));
            this.Tab_Games.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Tab_Games.BorderRadius = 0;
            this.Tab_Games.ButtonText = "  Games";
            this.Tab_Games.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Tab_Games.DisabledColor = System.Drawing.Color.Gray;
            this.Tab_Games.Dock = System.Windows.Forms.DockStyle.Top;
            this.Tab_Games.Iconcolor = System.Drawing.Color.Transparent;
            this.Tab_Games.Iconimage = ((System.Drawing.Image)(resources.GetObject("Tab_Games.Iconimage")));
            this.Tab_Games.Iconimage_right = null;
            this.Tab_Games.Iconimage_right_Selected = null;
            this.Tab_Games.Iconimage_Selected = null;
            this.Tab_Games.IconMarginLeft = 0;
            this.Tab_Games.IconMarginRight = 0;
            this.Tab_Games.IconRightVisible = true;
            this.Tab_Games.IconRightZoom = 0D;
            this.Tab_Games.IconVisible = true;
            this.Tab_Games.IconZoom = 40D;
            this.Tab_Games.IsTab = false;
            this.Tab_Games.Location = new System.Drawing.Point(0, 374);
            this.Tab_Games.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Tab_Games.Name = "Tab_Games";
            this.Tab_Games.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(56)))), ((int)(((byte)(69)))));
            this.Tab_Games.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(56)))), ((int)(((byte)(69)))));
            this.Tab_Games.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.Tab_Games.selected = false;
            this.Tab_Games.Size = new System.Drawing.Size(314, 48);
            this.Tab_Games.TabIndex = 6;
            this.Tab_Games.Text = "  Games";
            this.Tab_Games.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Tab_Games.Textcolor = System.Drawing.Color.White;
            this.Tab_Games.TextFont = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tab_Games.Click += new System.EventHandler(this.Tab_Games_Click);
            // 
            // Tab_Calendar
            // 
            this.Tab_Calendar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(56)))), ((int)(((byte)(69)))));
            this.Tab_Calendar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(56)))), ((int)(((byte)(69)))));
            this.Tab_Calendar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Tab_Calendar.BorderRadius = 0;
            this.Tab_Calendar.ButtonText = "  Calendar";
            this.Tab_Calendar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Tab_Calendar.DisabledColor = System.Drawing.Color.Gray;
            this.Tab_Calendar.Dock = System.Windows.Forms.DockStyle.Top;
            this.Tab_Calendar.Iconcolor = System.Drawing.Color.Transparent;
            this.Tab_Calendar.Iconimage = ((System.Drawing.Image)(resources.GetObject("Tab_Calendar.Iconimage")));
            this.Tab_Calendar.Iconimage_right = null;
            this.Tab_Calendar.Iconimage_right_Selected = null;
            this.Tab_Calendar.Iconimage_Selected = null;
            this.Tab_Calendar.IconMarginLeft = 0;
            this.Tab_Calendar.IconMarginRight = 0;
            this.Tab_Calendar.IconRightVisible = true;
            this.Tab_Calendar.IconRightZoom = 0D;
            this.Tab_Calendar.IconVisible = true;
            this.Tab_Calendar.IconZoom = 40D;
            this.Tab_Calendar.IsTab = false;
            this.Tab_Calendar.Location = new System.Drawing.Point(0, 326);
            this.Tab_Calendar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Tab_Calendar.Name = "Tab_Calendar";
            this.Tab_Calendar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(56)))), ((int)(((byte)(69)))));
            this.Tab_Calendar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(56)))), ((int)(((byte)(69)))));
            this.Tab_Calendar.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.Tab_Calendar.selected = false;
            this.Tab_Calendar.Size = new System.Drawing.Size(314, 48);
            this.Tab_Calendar.TabIndex = 5;
            this.Tab_Calendar.Text = "  Calendar";
            this.Tab_Calendar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Tab_Calendar.Textcolor = System.Drawing.Color.White;
            this.Tab_Calendar.TextFont = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tab_Calendar.Click += new System.EventHandler(this.Tab_Calendar_Click);
            // 
            // Tab_Cart
            // 
            this.Tab_Cart.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(56)))), ((int)(((byte)(69)))));
            this.Tab_Cart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(56)))), ((int)(((byte)(69)))));
            this.Tab_Cart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Tab_Cart.BorderRadius = 0;
            this.Tab_Cart.ButtonText = "  Cart";
            this.Tab_Cart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Tab_Cart.DisabledColor = System.Drawing.Color.Gray;
            this.Tab_Cart.Dock = System.Windows.Forms.DockStyle.Top;
            this.Tab_Cart.Iconcolor = System.Drawing.Color.Transparent;
            this.Tab_Cart.Iconimage = ((System.Drawing.Image)(resources.GetObject("Tab_Cart.Iconimage")));
            this.Tab_Cart.Iconimage_right = null;
            this.Tab_Cart.Iconimage_right_Selected = null;
            this.Tab_Cart.Iconimage_Selected = null;
            this.Tab_Cart.IconMarginLeft = 0;
            this.Tab_Cart.IconMarginRight = 0;
            this.Tab_Cart.IconRightVisible = true;
            this.Tab_Cart.IconRightZoom = 0D;
            this.Tab_Cart.IconVisible = true;
            this.Tab_Cart.IconZoom = 40D;
            this.Tab_Cart.IsTab = false;
            this.Tab_Cart.Location = new System.Drawing.Point(0, 278);
            this.Tab_Cart.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Tab_Cart.Name = "Tab_Cart";
            this.Tab_Cart.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(56)))), ((int)(((byte)(69)))));
            this.Tab_Cart.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(56)))), ((int)(((byte)(69)))));
            this.Tab_Cart.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.Tab_Cart.selected = false;
            this.Tab_Cart.Size = new System.Drawing.Size(314, 48);
            this.Tab_Cart.TabIndex = 4;
            this.Tab_Cart.Text = "  Cart";
            this.Tab_Cart.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Tab_Cart.Textcolor = System.Drawing.Color.White;
            this.Tab_Cart.TextFont = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tab_Cart.Click += new System.EventHandler(this.Tab_Cart_Click);
            // 
            // Tab_Chat
            // 
            this.Tab_Chat.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(56)))), ((int)(((byte)(69)))));
            this.Tab_Chat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(56)))), ((int)(((byte)(69)))));
            this.Tab_Chat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Tab_Chat.BorderRadius = 0;
            this.Tab_Chat.ButtonText = "  Chat";
            this.Tab_Chat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Tab_Chat.DisabledColor = System.Drawing.Color.Gray;
            this.Tab_Chat.Dock = System.Windows.Forms.DockStyle.Top;
            this.Tab_Chat.Iconcolor = System.Drawing.Color.Transparent;
            this.Tab_Chat.Iconimage = ((System.Drawing.Image)(resources.GetObject("Tab_Chat.Iconimage")));
            this.Tab_Chat.Iconimage_right = null;
            this.Tab_Chat.Iconimage_right_Selected = null;
            this.Tab_Chat.Iconimage_Selected = null;
            this.Tab_Chat.IconMarginLeft = 0;
            this.Tab_Chat.IconMarginRight = 0;
            this.Tab_Chat.IconRightVisible = true;
            this.Tab_Chat.IconRightZoom = 0D;
            this.Tab_Chat.IconVisible = true;
            this.Tab_Chat.IconZoom = 40D;
            this.Tab_Chat.IsTab = false;
            this.Tab_Chat.Location = new System.Drawing.Point(0, 230);
            this.Tab_Chat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Tab_Chat.Name = "Tab_Chat";
            this.Tab_Chat.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(56)))), ((int)(((byte)(69)))));
            this.Tab_Chat.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(56)))), ((int)(((byte)(69)))));
            this.Tab_Chat.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.Tab_Chat.selected = false;
            this.Tab_Chat.Size = new System.Drawing.Size(314, 48);
            this.Tab_Chat.TabIndex = 3;
            this.Tab_Chat.Text = "  Chat";
            this.Tab_Chat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Tab_Chat.Textcolor = System.Drawing.Color.White;
            this.Tab_Chat.TextFont = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tab_Chat.Click += new System.EventHandler(this.Tab_Chat_Click);
            // 
            // Tab_Profile
            // 
            this.Tab_Profile.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(56)))), ((int)(((byte)(69)))));
            this.Tab_Profile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(56)))), ((int)(((byte)(69)))));
            this.Tab_Profile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Tab_Profile.BorderRadius = 0;
            this.Tab_Profile.ButtonText = "  Profile";
            this.Tab_Profile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Tab_Profile.DisabledColor = System.Drawing.Color.Gray;
            this.Tab_Profile.Dock = System.Windows.Forms.DockStyle.Top;
            this.Tab_Profile.Iconcolor = System.Drawing.Color.Transparent;
            this.Tab_Profile.Iconimage = ((System.Drawing.Image)(resources.GetObject("Tab_Profile.Iconimage")));
            this.Tab_Profile.Iconimage_right = null;
            this.Tab_Profile.Iconimage_right_Selected = null;
            this.Tab_Profile.Iconimage_Selected = null;
            this.Tab_Profile.IconMarginLeft = 0;
            this.Tab_Profile.IconMarginRight = 0;
            this.Tab_Profile.IconRightVisible = true;
            this.Tab_Profile.IconRightZoom = 0D;
            this.Tab_Profile.IconVisible = true;
            this.Tab_Profile.IconZoom = 40D;
            this.Tab_Profile.IsTab = false;
            this.Tab_Profile.Location = new System.Drawing.Point(0, 182);
            this.Tab_Profile.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Tab_Profile.Name = "Tab_Profile";
            this.Tab_Profile.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(56)))), ((int)(((byte)(69)))));
            this.Tab_Profile.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(56)))), ((int)(((byte)(69)))));
            this.Tab_Profile.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.Tab_Profile.selected = false;
            this.Tab_Profile.Size = new System.Drawing.Size(314, 48);
            this.Tab_Profile.TabIndex = 2;
            this.Tab_Profile.Text = "  Profile";
            this.Tab_Profile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Tab_Profile.Textcolor = System.Drawing.Color.White;
            this.Tab_Profile.TextFont = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tab_Profile.Click += new System.EventHandler(this.Tab_Profile_Click);
            // 
            // Tab_DashBoard
            // 
            this.Tab_DashBoard.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(56)))), ((int)(((byte)(69)))));
            this.Tab_DashBoard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(56)))), ((int)(((byte)(69)))));
            this.Tab_DashBoard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Tab_DashBoard.BorderRadius = 0;
            this.Tab_DashBoard.ButtonText = "  Dashboard";
            this.Tab_DashBoard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Tab_DashBoard.DisabledColor = System.Drawing.Color.Gray;
            this.Tab_DashBoard.Dock = System.Windows.Forms.DockStyle.Top;
            this.Tab_DashBoard.Iconcolor = System.Drawing.Color.Transparent;
            this.Tab_DashBoard.Iconimage = ((System.Drawing.Image)(resources.GetObject("Tab_DashBoard.Iconimage")));
            this.Tab_DashBoard.Iconimage_right = null;
            this.Tab_DashBoard.Iconimage_right_Selected = null;
            this.Tab_DashBoard.Iconimage_Selected = null;
            this.Tab_DashBoard.IconMarginLeft = 0;
            this.Tab_DashBoard.IconMarginRight = 0;
            this.Tab_DashBoard.IconRightVisible = true;
            this.Tab_DashBoard.IconRightZoom = 0D;
            this.Tab_DashBoard.IconVisible = true;
            this.Tab_DashBoard.IconZoom = 40D;
            this.Tab_DashBoard.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Tab_DashBoard.IsTab = false;
            this.Tab_DashBoard.Location = new System.Drawing.Point(0, 134);
            this.Tab_DashBoard.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Tab_DashBoard.Name = "Tab_DashBoard";
            this.Tab_DashBoard.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(56)))), ((int)(((byte)(69)))));
            this.Tab_DashBoard.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(56)))), ((int)(((byte)(69)))));
            this.Tab_DashBoard.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.Tab_DashBoard.selected = true;
            this.Tab_DashBoard.Size = new System.Drawing.Size(314, 48);
            this.Tab_DashBoard.TabIndex = 1;
            this.Tab_DashBoard.Text = "  Dashboard";
            this.Tab_DashBoard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Tab_DashBoard.Textcolor = System.Drawing.Color.White;
            this.Tab_DashBoard.TextFont = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tab_DashBoard.Click += new System.EventHandler(this.Tab_DashBoard_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_create_new);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(314, 134);
            this.panel2.TabIndex = 0;
            // 
            // btn_create_new
            // 
            this.btn_create_new.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_create_new.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_create_new.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_create_new.BorderRadius = 0;
            this.btn_create_new.ButtonText = "Create New";
            this.btn_create_new.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_create_new.DisabledColor = System.Drawing.Color.Gray;
            this.btn_create_new.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_create_new.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_create_new.Iconimage")));
            this.btn_create_new.Iconimage_right = null;
            this.btn_create_new.Iconimage_right_Selected = null;
            this.btn_create_new.Iconimage_Selected = null;
            this.btn_create_new.IconMarginLeft = 0;
            this.btn_create_new.IconMarginRight = 0;
            this.btn_create_new.IconRightVisible = true;
            this.btn_create_new.IconRightZoom = 0D;
            this.btn_create_new.IconVisible = true;
            this.btn_create_new.IconZoom = 90D;
            this.btn_create_new.IsTab = false;
            this.btn_create_new.Location = new System.Drawing.Point(33, 42);
            this.btn_create_new.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_create_new.Name = "btn_create_new";
            this.btn_create_new.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_create_new.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btn_create_new.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_create_new.selected = false;
            this.btn_create_new.Size = new System.Drawing.Size(241, 45);
            this.btn_create_new.TabIndex = 0;
            this.btn_create_new.Text = "Create New";
            this.btn_create_new.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_create_new.Textcolor = System.Drawing.Color.White;
            this.btn_create_new.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_create_new.Click += new System.EventHandler(this.Btn_create_new_Click);
            // 
            // pn_header
            // 
            this.pn_header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(56)))), ((int)(((byte)(69)))));
            this.pn_header.Controls.Add(this.label_Fullname);
            this.pn_header.Controls.Add(this.picture_user_image);
            this.pn_header.Controls.Add(this.textbox_Search);
            this.pn_header.Dock = System.Windows.Forms.DockStyle.Top;
            this.pn_header.Location = new System.Drawing.Point(314, 0);
            this.pn_header.Margin = new System.Windows.Forms.Padding(2);
            this.pn_header.Name = "pn_header";
            this.pn_header.Size = new System.Drawing.Size(836, 65);
            this.pn_header.TabIndex = 1;
            // 
            // label_Fullname
            // 
            this.label_Fullname.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_Fullname.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Fullname.ForeColor = System.Drawing.Color.White;
            this.label_Fullname.Location = new System.Drawing.Point(543, 22);
            this.label_Fullname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Fullname.Name = "label_Fullname";
            this.label_Fullname.Size = new System.Drawing.Size(223, 20);
            this.label_Fullname.TabIndex = 2;
            this.label_Fullname.Text = "Tang Khanh Chuong";
            this.label_Fullname.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // picture_user_image
            // 
            this.picture_user_image.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.picture_user_image.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picture_user_image.Image = ((System.Drawing.Image)(resources.GetObject("picture_user_image.Image")));
            this.picture_user_image.Location = new System.Drawing.Point(770, 0);
            this.picture_user_image.Margin = new System.Windows.Forms.Padding(2);
            this.picture_user_image.Name = "picture_user_image";
            this.picture_user_image.Size = new System.Drawing.Size(67, 65);
            this.picture_user_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picture_user_image.TabIndex = 1;
            this.picture_user_image.TabStop = false;
            this.picture_user_image.Click += new System.EventHandler(this.Picture_user_image_Click);
            // 
            // textbox_Search
            // 
            this.textbox_Search.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textbox_Search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(56)))), ((int)(((byte)(69)))));
            this.textbox_Search.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("textbox_Search.BackgroundImage")));
            this.textbox_Search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.textbox_Search.ForeColor = System.Drawing.Color.Azure;
            this.textbox_Search.Icon = ((System.Drawing.Image)(resources.GetObject("textbox_Search.Icon")));
            this.textbox_Search.Location = new System.Drawing.Point(27, 15);
            this.textbox_Search.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textbox_Search.MaximumSize = new System.Drawing.Size(700, 40);
            this.textbox_Search.Name = "textbox_Search";
            this.textbox_Search.Size = new System.Drawing.Size(397, 36);
            this.textbox_Search.TabIndex = 0;
            this.textbox_Search.text = "Search ...";
            this.textbox_Search.KeyUp += new System.EventHandler(this.Textbox_Search_KeyUp);
            this.textbox_Search.Click += new System.EventHandler(this.Textbox_Search_Click);
            this.textbox_Search.Enter += new System.EventHandler(this.Textbox_Search_Enter);
            this.textbox_Search.Leave += new System.EventHandler(this.Textbox_Search_Leave);
            // 
            // panel_Search1
            // 
            this.panel_Search1.AutoScroll = true;
            this.panel_Search1.BackColor = System.Drawing.Color.PeachPuff;
            this.panel_Search1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Search1.Location = new System.Drawing.Point(314, 65);
            this.panel_Search1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel_Search1.Name = "panel_Search1";
            this.panel_Search1.Size = new System.Drawing.Size(836, 596);
            this.panel_Search1.TabIndex = 11;
            this.panel_Search1.Visible = false;
            // 
            // panel_Settings
            // 
            this.panel_Settings.BackColor = System.Drawing.Color.Plum;
            this.panel_Settings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Settings.Location = new System.Drawing.Point(314, 65);
            this.panel_Settings.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel_Settings.Name = "panel_Settings";
            this.panel_Settings.Size = new System.Drawing.Size(836, 596);
            this.panel_Settings.TabIndex = 10;
            this.panel_Settings.Visible = false;
            // 
            // panel_Games
            // 
            this.panel_Games.BackColor = System.Drawing.SystemColors.Info;
            this.panel_Games.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Games.Location = new System.Drawing.Point(314, 65);
            this.panel_Games.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel_Games.Name = "panel_Games";
            this.panel_Games.Size = new System.Drawing.Size(836, 596);
            this.panel_Games.TabIndex = 9;
            this.panel_Games.Visible = false;
            // 
            // panel_Dashboard
            // 
            this.panel_Dashboard.AutoScroll = true;
            this.panel_Dashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(82)))));
            this.panel_Dashboard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Dashboard.Location = new System.Drawing.Point(314, 65);
            this.panel_Dashboard.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel_Dashboard.Name = "panel_Dashboard";
            this.panel_Dashboard.Size = new System.Drawing.Size(836, 596);
            this.panel_Dashboard.TabIndex = 8;
            // 
            // panel_Cart
            // 
            this.panel_Cart.AutoScroll = true;
            this.panel_Cart.BackColor = System.Drawing.Color.White;
            this.panel_Cart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Cart.Location = new System.Drawing.Point(314, 65);
            this.panel_Cart.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel_Cart.Name = "panel_Cart";
            this.panel_Cart.Size = new System.Drawing.Size(836, 596);
            this.panel_Cart.TabIndex = 7;
            this.panel_Cart.Visible = false;
            // 
            // panel_Calendar
            // 
            this.panel_Calendar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel_Calendar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Calendar.Location = new System.Drawing.Point(314, 65);
            this.panel_Calendar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel_Calendar.Name = "panel_Calendar";
            this.panel_Calendar.Size = new System.Drawing.Size(836, 596);
            this.panel_Calendar.TabIndex = 6;
            this.panel_Calendar.Visible = false;
            // 
            // panel_Chat
            // 
            this.panel_Chat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Chat.Location = new System.Drawing.Point(314, 65);
            this.panel_Chat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel_Chat.Name = "panel_Chat";
            this.panel_Chat.Size = new System.Drawing.Size(836, 596);
            this.panel_Chat.TabIndex = 5;
            this.panel_Chat.Visible = false;
            // 
            // panel_Profile
            // 
            this.panel_Profile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Profile.Location = new System.Drawing.Point(314, 65);
            this.panel_Profile.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel_Profile.Name = "panel_Profile";
            this.panel_Profile.Size = new System.Drawing.Size(836, 596);
            this.panel_Profile.TabIndex = 4;
            this.panel_Profile.Visible = false;
            // 
            // onlineList1
            // 
            this.onlineList1.AutoScroll = true;
            this.onlineList1.Location = new System.Drawing.Point(3, 478);
            this.onlineList1.Name = "onlineList1";
            this.onlineList1.Size = new System.Drawing.Size(314, 94);
            this.onlineList1.TabIndex = 13;
            this.onlineList1.Visible = false;
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(1150, 661);
            this.Controls.Add(this.panel_Search1);
            this.Controls.Add(this.panel_Settings);
            this.Controls.Add(this.panel_Games);
            this.Controls.Add(this.panel_Dashboard);
            this.Controls.Add(this.panel_Cart);
            this.Controls.Add(this.panel_Calendar);
            this.Controls.Add(this.panel_Chat);
            this.Controls.Add(this.panel_Profile);
            this.Controls.Add(this.pn_header);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(1100, 600);
            this.Name = "HomePage";
            this.Text = "Form1";
            this.Move += new System.EventHandler(this.HomePage_Move);
            this.Resize += new System.EventHandler(this.HomePage_Resize);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.indicator)).EndInit();
            this.panel2.ResumeLayout(false);
            this.pn_header.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picture_user_image)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuFlatButton Tab_DashBoard;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox indicator;
        private Bunifu.Framework.UI.BunifuFlatButton Tab_Calendar;
        private Bunifu.Framework.UI.BunifuFlatButton Tab_Cart;
        private Bunifu.Framework.UI.BunifuFlatButton Tab_Chat;
        private Bunifu.Framework.UI.BunifuFlatButton Tab_Profile;
        private Bunifu.Framework.UI.BunifuFlatButton Tab_Games;
        private Bunifu.Framework.UI.BunifuFlatButton btn_create_new;
        private System.Windows.Forms.Panel pn_header;
        private Bunifu.Framework.UI.BunifuTextbox textbox_Search;
        private System.Windows.Forms.PictureBox picture_user_image;
        private System.Windows.Forms.Label label_Fullname;
        private Panel_Profile panel_Profile;
        private Panel_Chat panel_Chat;
        private Panel_Calendar panel_Calendar;
        private Panel_Cart panel_Cart;
        private Panel_Dashboard panel_Dashboard;
        private Panel_Games panel_Games;
        private Panel_Settings panel_Settings;
        private BunifuFlatButton Tab_Settings;
        private Panel_Search panel_Search1;
        private onlineList onlineList1;
    }
}

