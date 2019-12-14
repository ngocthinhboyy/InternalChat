namespace Internal_Society
{
    partial class Panel_Search
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label_Message = new System.Windows.Forms.Label();
            this.panel_Margin = new System.Windows.Forms.Panel();
            this.panel_Main = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // label_Message
            // 
            this.label_Message.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label_Message.AutoSize = true;
            this.label_Message.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Message.ForeColor = System.Drawing.Color.Red;
            this.label_Message.Location = new System.Drawing.Point(113, 140);
            this.label_Message.Name = "label_Message";
            this.label_Message.Size = new System.Drawing.Size(1011, 52);
            this.label_Message.TabIndex = 0;
            this.label_Message.Text = "We could not find anything that matches your search.";
            // 
            // panel_Margin
            // 
            this.panel_Margin.BackColor = System.Drawing.Color.Transparent;
            this.panel_Margin.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Margin.Location = new System.Drawing.Point(0, 0);
            this.panel_Margin.Name = "panel_Margin";
            this.panel_Margin.Size = new System.Drawing.Size(1192, 96);
            this.panel_Margin.TabIndex = 2;
            // 
            // panel_Main
            // 
            this.panel_Main.AutoScroll = true;
            this.panel_Main.BackColor = System.Drawing.Color.Transparent;
            this.panel_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Main.Location = new System.Drawing.Point(0, 96);
            this.panel_Main.Name = "panel_Main";
            this.panel_Main.Size = new System.Drawing.Size(1192, 672);
            this.panel_Main.TabIndex = 4;
            this.panel_Main.Click += new System.EventHandler(this.Panel_Main_Click);
            // 
            // Panel_Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(49)))));
            this.Controls.Add(this.panel_Main);
            this.Controls.Add(this.label_Message);
            this.Controls.Add(this.panel_Margin);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Panel_Search";
            this.Size = new System.Drawing.Size(1192, 768);
            this.Resize += new System.EventHandler(this.Panel_Search_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label_Message;
        private System.Windows.Forms.Panel panel_Margin;
        private System.Windows.Forms.Panel panel_Main;
    }
}
