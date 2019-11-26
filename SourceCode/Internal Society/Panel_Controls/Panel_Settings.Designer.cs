namespace Internal_Society
{
    partial class Panel_Settings
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
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Profile_Name = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.edit_name = new System.Windows.Forms.PictureBox();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edit_name)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(46, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Time Delay";
            // 
            // txt_Profile_Name
            // 
            this.txt_Profile_Name.BackColor = System.Drawing.Color.White;
            this.txt_Profile_Name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Profile_Name.Enabled = false;
            this.txt_Profile_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Profile_Name.Location = new System.Drawing.Point(16, 1);
            this.txt_Profile_Name.Multiline = true;
            this.txt_Profile_Name.Name = "txt_Profile_Name";
            this.txt_Profile_Name.Size = new System.Drawing.Size(245, 38);
            this.txt_Profile_Name.TabIndex = 3;
            this.txt_Profile_Name.Text = "1500";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.txt_Profile_Name);
            this.panel4.Controls.Add(this.edit_name);
            this.panel4.Location = new System.Drawing.Point(182, 43);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(311, 38);
            this.panel4.TabIndex = 7;
            // 
            // edit_name
            // 
            this.edit_name.BackColor = System.Drawing.Color.White;
            this.edit_name.ImageLocation = "../../Resources/edit.png";
            this.edit_name.Location = new System.Drawing.Point(270, 3);
            this.edit_name.Name = "edit_name";
            this.edit_name.Size = new System.Drawing.Size(36, 30);
            this.edit_name.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.edit_name.TabIndex = 4;
            this.edit_name.TabStop = false;
            // 
            // Panel_Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Plum;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel4);
            this.Name = "Panel_Settings";
            this.Size = new System.Drawing.Size(610, 534);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edit_name)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Profile_Name;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox edit_name;
    }
}
