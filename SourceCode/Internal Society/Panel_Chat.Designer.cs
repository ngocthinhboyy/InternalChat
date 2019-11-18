namespace Internal_Society
{
    partial class Panel_Chat
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
            this.chatbox2 = new Internal_Society.chatbox();
            this.SuspendLayout();
            // 
            // chatbox2
            // 
            this.chatbox2.BackColor = System.Drawing.Color.White;
            this.chatbox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chatbox2.Location = new System.Drawing.Point(0, 0);
            this.chatbox2.Margin = new System.Windows.Forms.Padding(1);
            this.chatbox2.Name = "chatbox2";
            this.chatbox2.Size = new System.Drawing.Size(775, 619);
            this.chatbox2.TabIndex = 1;
            // 
            // Panel_Chat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chatbox2);
            this.Name = "Panel_Chat";
            this.Size = new System.Drawing.Size(775, 619);
            this.ResumeLayout(false);

        }

        #endregion

        private chatbox chatbox2;
    }
}
