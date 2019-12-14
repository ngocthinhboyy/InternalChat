namespace Internal_Society
{
    partial class loading
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(loading));
            this.circle_Loading = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.SuspendLayout();
            // 
            // circle_Loading
            // 
            this.circle_Loading.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.circle_Loading.animated = true;
            this.circle_Loading.animationIterval = 7;
            this.circle_Loading.animationSpeed = 5;
            this.circle_Loading.BackColor = System.Drawing.Color.Transparent;
            this.circle_Loading.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("circle_Loading.BackgroundImage")));
            this.circle_Loading.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.circle_Loading.ForeColor = System.Drawing.Color.SeaGreen;
            this.circle_Loading.LabelVisible = false;
            this.circle_Loading.LineProgressThickness = 13;
            this.circle_Loading.LineThickness = 15;
            this.circle_Loading.Location = new System.Drawing.Point(30, 32);
            this.circle_Loading.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.circle_Loading.MaxValue = 100;
            this.circle_Loading.Name = "circle_Loading";
            this.circle_Loading.ProgressBackColor = System.Drawing.Color.Gainsboro;
            this.circle_Loading.ProgressColor = System.Drawing.Color.SeaGreen;
            this.circle_Loading.Size = new System.Drawing.Size(130, 130);
            this.circle_Loading.TabIndex = 0;
            this.circle_Loading.Value = 30;
            // 
            // loading
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.circle_Loading);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "loading";
            this.Size = new System.Drawing.Size(180, 195);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCircleProgressbar circle_Loading;
    }
}
