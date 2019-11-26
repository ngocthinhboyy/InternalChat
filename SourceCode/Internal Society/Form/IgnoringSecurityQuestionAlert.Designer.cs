namespace Internal_Society
{
    partial class IgnoringSecurityQuestionAlert
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IgnoringSecurityQuestionAlert));
            this.elipseIgnoring = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnGiveBack = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnSkip = new Bunifu.Framework.UI.BunifuTileButton();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // elipseIgnoring
            // 
            this.elipseIgnoring.ElipseRadius = 20;
            this.elipseIgnoring.TargetControl = this;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.btnSkip);
            this.panel1.Controls.Add(this.btnGiveBack);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 82);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(310, 38);
            this.panel1.TabIndex = 0;
            // 
            // btnGiveBack
            // 
            this.btnGiveBack.BackColor = System.Drawing.Color.SeaGreen;
            this.btnGiveBack.color = System.Drawing.Color.SeaGreen;
            this.btnGiveBack.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.btnGiveBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGiveBack.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnGiveBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGiveBack.ForeColor = System.Drawing.Color.White;
            this.btnGiveBack.Image = ((System.Drawing.Image)(resources.GetObject("btnGiveBack.Image")));
            this.btnGiveBack.ImagePosition = 14;
            this.btnGiveBack.ImageZoom = 50;
            this.btnGiveBack.LabelPosition = 30;
            this.btnGiveBack.LabelText = "Give me back";
            this.btnGiveBack.Location = new System.Drawing.Point(0, 0);
            this.btnGiveBack.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGiveBack.Name = "btnGiveBack";
            this.btnGiveBack.Size = new System.Drawing.Size(154, 38);
            this.btnGiveBack.TabIndex = 0;
            this.btnGiveBack.Click += new System.EventHandler(this.BtnGiveBack_Click);
            // 
            // btnSkip
            // 
            this.btnSkip.BackColor = System.Drawing.Color.SeaGreen;
            this.btnSkip.color = System.Drawing.Color.SeaGreen;
            this.btnSkip.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.btnSkip.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSkip.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSkip.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSkip.ForeColor = System.Drawing.Color.White;
            this.btnSkip.Image = ((System.Drawing.Image)(resources.GetObject("btnSkip.Image")));
            this.btnSkip.ImagePosition = 14;
            this.btnSkip.ImageZoom = 50;
            this.btnSkip.LabelPosition = 30;
            this.btnSkip.LabelText = "Skip";
            this.btnSkip.Location = new System.Drawing.Point(156, 0);
            this.btnSkip.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSkip.Name = "btnSkip";
            this.btnSkip.Size = new System.Drawing.Size(154, 38);
            this.btnSkip.TabIndex = 1;
            this.btnSkip.Click += new System.EventHandler(this.BtnSkip_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(55, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "You are ignoring security step.";
            // 
            // IgnoringSecurityQuestionAlert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 120);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "IgnoringSecurityQuestionAlert";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IgnoringSecurityQuestionAlert";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse elipseIgnoring;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuTileButton btnSkip;
        private Bunifu.Framework.UI.BunifuTileButton btnGiveBack;
    }
}