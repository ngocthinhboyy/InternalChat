namespace Internal_Society
{
    partial class IncorrectAlert
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IncorrectAlert));
            this.elipseIncorrect = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.btnRepresentIncorrect = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnIncorrect = new Bunifu.Framework.UI.BunifuTileButton();
            this.SuspendLayout();
            // 
            // elipseIncorrect
            // 
            this.elipseIncorrect.ElipseRadius = 20;
            this.elipseIncorrect.TargetControl = this;
            // 
            // btnRepresentIncorrect
            // 
            this.btnRepresentIncorrect.BackColor = System.Drawing.Color.Transparent;
            this.btnRepresentIncorrect.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnRepresentIncorrect.Location = new System.Drawing.Point(300, 0);
            this.btnRepresentIncorrect.Name = "btnRepresentIncorrect";
            this.btnRepresentIncorrect.Size = new System.Drawing.Size(0, 0);
            this.btnRepresentIncorrect.TabIndex = 5;
            this.btnRepresentIncorrect.UseVisualStyleBackColor = false;
            this.btnRepresentIncorrect.Click += new System.EventHandler(this.BtnRepresentIncorrect_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(36, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Username or password is incorrect.";
            // 
            // btnIncorrect
            // 
            this.btnIncorrect.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.btnIncorrect.BackColor = System.Drawing.Color.Green;
            this.btnIncorrect.color = System.Drawing.Color.Green;
            this.btnIncorrect.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.btnIncorrect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIncorrect.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnIncorrect.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIncorrect.ForeColor = System.Drawing.Color.White;
            this.btnIncorrect.Image = ((System.Drawing.Image)(resources.GetObject("btnIncorrect.Image")));
            this.btnIncorrect.ImagePosition = 14;
            this.btnIncorrect.ImageZoom = 50;
            this.btnIncorrect.LabelPosition = 30;
            this.btnIncorrect.LabelText = "OK";
            this.btnIncorrect.Location = new System.Drawing.Point(0, 82);
            this.btnIncorrect.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnIncorrect.Name = "btnIncorrect";
            this.btnIncorrect.Size = new System.Drawing.Size(310, 38);
            this.btnIncorrect.TabIndex = 3;
            this.btnIncorrect.Click += new System.EventHandler(this.BtnIncorrect_Click);
            // 
            // IncorrectAlert
            // 
            this.AcceptButton = this.btnRepresentIncorrect;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 120);
            this.Controls.Add(this.btnRepresentIncorrect);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnIncorrect);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "IncorrectAlert";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IncorrectAlert";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse elipseIncorrect;
        private System.Windows.Forms.Button btnRepresentIncorrect;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuTileButton btnIncorrect;
    }
}