namespace Internal_Society
{
    partial class ConfirmClose
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfirmClose));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancel = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnLogOut = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(42, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Do you want to close this app?";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCancel.BackgroundImage")));
            this.btnCancel.ButtonText = "No";
            this.btnCancel.ButtonTextMarginLeft = 0;
            this.btnCancel.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.btnCancel.DisabledFillColor = System.Drawing.Color.Gray;
            this.btnCancel.DisabledForecolor = System.Drawing.Color.White;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnCancel.ForeColor = System.Drawing.Color.DeepPink;
            this.btnCancel.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnCancel.IconPadding = 10;
            this.btnCancel.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnCancel.IdleBorderColor = System.Drawing.Color.DeepPink;
            this.btnCancel.IdleBorderRadius = 30;
            this.btnCancel.IdleBorderThickness = 2;
            this.btnCancel.IdleFillColor = System.Drawing.Color.Cornsilk;
            this.btnCancel.IdleIconLeftImage = null;
            this.btnCancel.IdleIconRightImage = null;
            this.btnCancel.Location = new System.Drawing.Point(168, 69);
            this.btnCancel.Name = "btnCancel";
            stateProperties1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(250)))), ((int)(((byte)(235)))));
            stateProperties1.BorderRadius = 30;
            stateProperties1.BorderThickness = 2;
            stateProperties1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(250)))), ((int)(((byte)(235)))));
            stateProperties1.IconLeftImage = null;
            stateProperties1.IconRightImage = null;
            this.btnCancel.onHoverState = stateProperties1;
            this.btnCancel.Size = new System.Drawing.Size(106, 45);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.Transparent;
            this.btnLogOut.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLogOut.BackgroundImage")));
            this.btnLogOut.ButtonText = "Yes";
            this.btnLogOut.ButtonTextMarginLeft = 0;
            this.btnLogOut.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.btnLogOut.DisabledFillColor = System.Drawing.Color.Gray;
            this.btnLogOut.DisabledForecolor = System.Drawing.Color.White;
            this.btnLogOut.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnLogOut.ForeColor = System.Drawing.Color.White;
            this.btnLogOut.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnLogOut.IconPadding = 10;
            this.btnLogOut.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnLogOut.IdleBorderColor = System.Drawing.Color.DeepPink;
            this.btnLogOut.IdleBorderRadius = 30;
            this.btnLogOut.IdleBorderThickness = 2;
            this.btnLogOut.IdleFillColor = System.Drawing.Color.DeepPink;
            this.btnLogOut.IdleIconLeftImage = null;
            this.btnLogOut.IdleIconRightImage = null;
            this.btnLogOut.Location = new System.Drawing.Point(31, 69);
            this.btnLogOut.Name = "btnLogOut";
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(58)))), ((int)(((byte)(108)))));
            stateProperties2.BorderRadius = 30;
            stateProperties2.BorderThickness = 2;
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(58)))), ((int)(((byte)(108)))));
            stateProperties2.IconLeftImage = null;
            stateProperties2.IconRightImage = null;
            this.btnLogOut.onHoverState = stateProperties2;
            this.btnLogOut.Size = new System.Drawing.Size(106, 45);
            this.btnLogOut.TabIndex = 4;
            this.btnLogOut.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnLogOut.Click += new System.EventHandler(this.BtnLogOut_Click);
            // 
            // ConfirmClose
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(311, 143);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ConfirmClose";
            this.Text = "ConfirmClose";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnCancel;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnLogOut;
        private System.Windows.Forms.Label label1;
    }
}