namespace Internal_Society
{
    partial class CreateAccount_PersonalInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateAccount_PersonalInfo));
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.question2 = new Bunifu.Framework.UI.BunifuDropdown();
            this.question1 = new Bunifu.Framework.UI.BunifuDropdown();
            this.txtAnswer2 = new System.Windows.Forms.TextBox();
            this.txtAnswer1 = new System.Windows.Forms.TextBox();
            this.txtNickname = new System.Windows.Forms.TextBox();
            this.btnFinish = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnSkip = new Bunifu.Framework.UI.BunifuThinButton2();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
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
            this.panel1.Controls.Add(this.question2);
            this.panel1.Controls.Add(this.question1);
            this.panel1.Controls.Add(this.txtAnswer2);
            this.panel1.Controls.Add(this.txtAnswer1);
            this.panel1.Controls.Add(this.txtNickname);
            this.panel1.Controls.Add(this.btnFinish);
            this.panel1.Controls.Add(this.btnSkip);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(71, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(570, 349);
            this.panel1.TabIndex = 0;
            // 
            // question2
            // 
            this.question2.BackColor = System.Drawing.Color.Transparent;
            this.question2.BorderRadius = 3;
            this.question2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.question2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.question2.ForeColor = System.Drawing.Color.Black;
            this.question2.Items = new string[] {
        "Bạn thích nuôi con vật nào nhất?",
        "Gia đình bạn có bao nhiêu người",
        "Món ăn yêu thích của bạn",
        "Tên người bạn thân nhất của bạn là gì?"};
            this.question2.Location = new System.Drawing.Point(251, 195);
            this.question2.Margin = new System.Windows.Forms.Padding(6);
            this.question2.Name = "question2";
            this.question2.NomalColor = System.Drawing.SystemColors.Window;
            this.question2.onHoverColor = System.Drawing.SystemColors.Window;
            this.question2.selectedIndex = -1;
            this.question2.Size = new System.Drawing.Size(280, 32);
            this.question2.TabIndex = 12;
            // 
            // question1
            // 
            this.question1.BackColor = System.Drawing.Color.Transparent;
            this.question1.BorderRadius = 3;
            this.question1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.question1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.question1.ForeColor = System.Drawing.Color.Black;
            this.question1.Items = new string[] {
        "Bạn thích ăn món gì nhất?",
        "Quê bạn ở đâu?",
        "Con vật bạn thích nhất là gì?",
        "Gia đình bạn có bao nhiêu người?"};
            this.question1.Location = new System.Drawing.Point(251, 116);
            this.question1.Margin = new System.Windows.Forms.Padding(4);
            this.question1.Name = "question1";
            this.question1.NomalColor = System.Drawing.SystemColors.Window;
            this.question1.onHoverColor = System.Drawing.SystemColors.Window;
            this.question1.selectedIndex = -1;
            this.question1.Size = new System.Drawing.Size(280, 32);
            this.question1.TabIndex = 11;
            // 
            // txtAnswer2
            // 
            this.txtAnswer2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAnswer2.Location = new System.Drawing.Point(251, 236);
            this.txtAnswer2.Multiline = true;
            this.txtAnswer2.Name = "txtAnswer2";
            this.txtAnswer2.Size = new System.Drawing.Size(280, 32);
            this.txtAnswer2.TabIndex = 10;
            // 
            // txtAnswer1
            // 
            this.txtAnswer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAnswer1.Location = new System.Drawing.Point(251, 155);
            this.txtAnswer1.Multiline = true;
            this.txtAnswer1.Name = "txtAnswer1";
            this.txtAnswer1.Size = new System.Drawing.Size(280, 32);
            this.txtAnswer1.TabIndex = 9;
            // 
            // txtNickname
            // 
            this.txtNickname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNickname.Location = new System.Drawing.Point(251, 74);
            this.txtNickname.Multiline = true;
            this.txtNickname.Name = "txtNickname";
            this.txtNickname.Size = new System.Drawing.Size(280, 32);
            this.txtNickname.TabIndex = 8;
            // 
            // btnFinish
            // 
            this.btnFinish.ActiveBorderThickness = 1;
            this.btnFinish.ActiveCornerRadius = 20;
            this.btnFinish.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnFinish.ActiveForecolor = System.Drawing.Color.White;
            this.btnFinish.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnFinish.BackColor = System.Drawing.SystemColors.Control;
            this.btnFinish.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFinish.BackgroundImage")));
            this.btnFinish.ButtonText = "Finish";
            this.btnFinish.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFinish.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinish.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnFinish.IdleBorderThickness = 1;
            this.btnFinish.IdleCornerRadius = 20;
            this.btnFinish.IdleFillColor = System.Drawing.Color.White;
            this.btnFinish.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnFinish.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnFinish.Location = new System.Drawing.Point(446, 282);
            this.btnFinish.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(85, 49);
            this.btnFinish.TabIndex = 7;
            this.btnFinish.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnFinish.Click += new System.EventHandler(this.BtnFinish_Click);
            // 
            // btnSkip
            // 
            this.btnSkip.ActiveBorderThickness = 1;
            this.btnSkip.ActiveCornerRadius = 20;
            this.btnSkip.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnSkip.ActiveForecolor = System.Drawing.Color.White;
            this.btnSkip.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnSkip.BackColor = System.Drawing.SystemColors.Control;
            this.btnSkip.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSkip.BackgroundImage")));
            this.btnSkip.ButtonText = "Skip";
            this.btnSkip.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSkip.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSkip.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnSkip.IdleBorderThickness = 1;
            this.btnSkip.IdleCornerRadius = 20;
            this.btnSkip.IdleFillColor = System.Drawing.Color.White;
            this.btnSkip.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnSkip.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnSkip.Location = new System.Drawing.Point(43, 282);
            this.btnSkip.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSkip.Name = "btnSkip";
            this.btnSkip.Size = new System.Drawing.Size(85, 49);
            this.btnSkip.TabIndex = 6;
            this.btnSkip.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSkip.Click += new System.EventHandler(this.BtnSkip_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(73, 245);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Answer";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(73, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Security question 2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(73, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Answer";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(73, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Security question 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(73, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nickname";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(106, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(355, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome [username] to Internal Chat";
            // 
            // CreateAccount_PersonalInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 468);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CreateAccount_PersonalInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CreateAccount_PersonalInfo";
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuThinButton2 btnSkip;
        private Bunifu.Framework.UI.BunifuThinButton2 btnFinish;
        private System.Windows.Forms.TextBox txtNickname;
        private Bunifu.Framework.UI.BunifuDropdown question1;
        private System.Windows.Forms.TextBox txtAnswer2;
        private System.Windows.Forms.TextBox txtAnswer1;
        private Bunifu.Framework.UI.BunifuDropdown question2;
    }
}