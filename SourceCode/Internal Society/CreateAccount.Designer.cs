namespace Internal_Society
{
    partial class CreateAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateAccount));
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblNullPassword = new System.Windows.Forms.Label();
            this.lblNullUsername = new System.Windows.Forms.Label();
            this.lblExistedAlert = new System.Windows.Forms.Label();
            this.txtRepassword = new System.Windows.Forms.TextBox();
            this.txtPasswordCreate = new System.Windows.Forms.TextBox();
            this.txtUsernameCreate = new System.Windows.Forms.TextBox();
            this.lblUnmatchedAlert = new System.Windows.Forms.Label();
            this.btnNext = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnCancel = new Bunifu.Framework.UI.BunifuThinButton2();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblShortPassword = new System.Windows.Forms.Label();
            this.bunifuGradientPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.panel1);
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(88)))), ((int)(((byte)(208)))));
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(726, 468);
            this.bunifuGradientPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.lblShortPassword);
            this.panel1.Controls.Add(this.lblNullPassword);
            this.panel1.Controls.Add(this.lblNullUsername);
            this.panel1.Controls.Add(this.lblExistedAlert);
            this.panel1.Controls.Add(this.txtRepassword);
            this.panel1.Controls.Add(this.txtPasswordCreate);
            this.panel1.Controls.Add(this.txtUsernameCreate);
            this.panel1.Controls.Add(this.lblUnmatchedAlert);
            this.panel1.Controls.Add(this.btnNext);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(71, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(570, 349);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1_Paint);
            // 
            // lblNullPassword
            // 
            this.lblNullPassword.AutoSize = true;
            this.lblNullPassword.ForeColor = System.Drawing.Color.Red;
            this.lblNullPassword.Location = new System.Drawing.Point(248, 184);
            this.lblNullPassword.Name = "lblNullPassword";
            this.lblNullPassword.Size = new System.Drawing.Size(156, 13);
            this.lblNullPassword.TabIndex = 25;
            this.lblNullPassword.Text = "That password is null. Try again";
            this.lblNullPassword.Visible = false;
            // 
            // lblNullUsername
            // 
            this.lblNullUsername.AutoSize = true;
            this.lblNullUsername.ForeColor = System.Drawing.Color.Red;
            this.lblNullUsername.Location = new System.Drawing.Point(248, 120);
            this.lblNullUsername.Name = "lblNullUsername";
            this.lblNullUsername.Size = new System.Drawing.Size(157, 13);
            this.lblNullUsername.TabIndex = 24;
            this.lblNullUsername.Text = "That username is null. Try again";
            this.lblNullUsername.Visible = false;
            // 
            // lblExistedAlert
            // 
            this.lblExistedAlert.AutoSize = true;
            this.lblExistedAlert.ForeColor = System.Drawing.Color.Red;
            this.lblExistedAlert.Location = new System.Drawing.Point(248, 120);
            this.lblExistedAlert.Name = "lblExistedAlert";
            this.lblExistedAlert.Size = new System.Drawing.Size(171, 13);
            this.lblExistedAlert.TabIndex = 23;
            this.lblExistedAlert.Text = "That username is taken. Try again.";
            this.lblExistedAlert.Visible = false;
            // 
            // txtRepassword
            // 
            this.txtRepassword.Location = new System.Drawing.Point(248, 215);
            this.txtRepassword.Multiline = true;
            this.txtRepassword.Name = "txtRepassword";
            this.txtRepassword.PasswordChar = '*';
            this.txtRepassword.Size = new System.Drawing.Size(210, 32);
            this.txtRepassword.TabIndex = 3;
            // 
            // txtPasswordCreate
            // 
            this.txtPasswordCreate.Location = new System.Drawing.Point(248, 149);
            this.txtPasswordCreate.Multiline = true;
            this.txtPasswordCreate.Name = "txtPasswordCreate";
            this.txtPasswordCreate.PasswordChar = '*';
            this.txtPasswordCreate.Size = new System.Drawing.Size(210, 32);
            this.txtPasswordCreate.TabIndex = 2;
            this.txtPasswordCreate.Leave += new System.EventHandler(this.TxtPasswordCreate_Leave);
            // 
            // txtUsernameCreate
            // 
            this.txtUsernameCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsernameCreate.Location = new System.Drawing.Point(248, 85);
            this.txtUsernameCreate.Multiline = true;
            this.txtUsernameCreate.Name = "txtUsernameCreate";
            this.txtUsernameCreate.Size = new System.Drawing.Size(210, 32);
            this.txtUsernameCreate.TabIndex = 1;
            this.txtUsernameCreate.Leave += new System.EventHandler(this.TxtUsernameCreate_Leave);
            // 
            // lblUnmatchedAlert
            // 
            this.lblUnmatchedAlert.AutoSize = true;
            this.lblUnmatchedAlert.ForeColor = System.Drawing.Color.Red;
            this.lblUnmatchedAlert.Location = new System.Drawing.Point(248, 251);
            this.lblUnmatchedAlert.Name = "lblUnmatchedAlert";
            this.lblUnmatchedAlert.Size = new System.Drawing.Size(210, 13);
            this.lblUnmatchedAlert.TabIndex = 20;
            this.lblUnmatchedAlert.Text = "Those passwords did not match. Try again.";
            this.lblUnmatchedAlert.Visible = false;
            // 
            // btnNext
            // 
            this.btnNext.ActiveBorderThickness = 1;
            this.btnNext.ActiveCornerRadius = 20;
            this.btnNext.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnNext.ActiveForecolor = System.Drawing.Color.White;
            this.btnNext.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnNext.BackColor = System.Drawing.SystemColors.Control;
            this.btnNext.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNext.BackgroundImage")));
            this.btnNext.ButtonText = "Next";
            this.btnNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnNext.IdleBorderThickness = 1;
            this.btnNext.IdleCornerRadius = 20;
            this.btnNext.IdleFillColor = System.Drawing.Color.White;
            this.btnNext.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnNext.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnNext.Location = new System.Drawing.Point(446, 282);
            this.btnNext.Margin = new System.Windows.Forms.Padding(5);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(85, 49);
            this.btnNext.TabIndex = 19;
            this.btnNext.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnNext.Click += new System.EventHandler(this.BtnNext_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.ActiveBorderThickness = 1;
            this.btnCancel.ActiveCornerRadius = 20;
            this.btnCancel.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnCancel.ActiveForecolor = System.Drawing.Color.White;
            this.btnCancel.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnCancel.BackColor = System.Drawing.SystemColors.Control;
            this.btnCancel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCancel.BackgroundImage")));
            this.btnCancel.ButtonText = "Cancel";
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnCancel.IdleBorderThickness = 1;
            this.btnCancel.IdleCornerRadius = 20;
            this.btnCancel.IdleFillColor = System.Drawing.Color.White;
            this.btnCancel.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnCancel.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnCancel.Location = new System.Drawing.Point(43, 282);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(85, 49);
            this.btnCancel.TabIndex = 18;
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(99, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 18);
            this.label4.TabIndex = 12;
            this.label4.Text = "Confirm password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(101, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 18);
            this.label3.TabIndex = 11;
            this.label3.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(101, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 18);
            this.label2.TabIndex = 10;
            this.label2.Text = "Username";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(180, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 24);
            this.label1.TabIndex = 9;
            this.label1.Text = "Create your account";
            // 
            // lblShortPassword
            // 
            this.lblShortPassword.AutoSize = true;
            this.lblShortPassword.ForeColor = System.Drawing.Color.Red;
            this.lblShortPassword.Location = new System.Drawing.Point(249, 184);
            this.lblShortPassword.Name = "lblShortPassword";
            this.lblShortPassword.Size = new System.Drawing.Size(262, 13);
            this.lblShortPassword.TabIndex = 26;
            this.lblShortPassword.Text = "Your password must be between 6 and 30 characters.";
            this.lblShortPassword.Visible = false;
            // 
            // CreateAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 468);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CreateAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CreateAccount";
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblUnmatchedAlert;
        private Bunifu.Framework.UI.BunifuThinButton2 btnNext;
        private Bunifu.Framework.UI.BunifuThinButton2 btnCancel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRepassword;
        private System.Windows.Forms.TextBox txtPasswordCreate;
        private System.Windows.Forms.TextBox txtUsernameCreate;
        private System.Windows.Forms.Label lblExistedAlert;
        private System.Windows.Forms.Label lblNullUsername;
        private System.Windows.Forms.Label lblNullPassword;
        private System.Windows.Forms.Label lblShortPassword;
    }
}