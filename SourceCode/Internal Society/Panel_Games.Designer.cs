namespace Internal_Society
{
    partial class Panel_Games
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
            this.games_LuckyWheel1 = new Internal_Society.Games_LuckyWheel();
            this.SuspendLayout();
            // 
            // games_LuckyWheel1
            // 
            this.games_LuckyWheel1.Location = new System.Drawing.Point(21, 26);
            this.games_LuckyWheel1.Name = "games_LuckyWheel1";
            this.games_LuckyWheel1.Size = new System.Drawing.Size(498, 498);
            this.games_LuckyWheel1.TabIndex = 0;
            // 
            // Panel_Games
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.Controls.Add(this.games_LuckyWheel1);
            this.Name = "Panel_Games";
            this.Size = new System.Drawing.Size(884, 662);
            this.ResumeLayout(false);

        }

        #endregion

        private Games_LuckyWheel games_LuckyWheel1;
    }
}
