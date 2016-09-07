namespace AirCraft_Management_System
{
    partial class index
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
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.textusername = new MetroFramework.Controls.MetroTextBox();
            this.textpassword = new MetroFramework.Controls.MetroTextBox();
            this.SuspendLayout();
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(304, 259);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(99, 34);
            this.metroButton1.TabIndex = 0;
            this.metroButton1.Text = "Login";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(124, 146);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(68, 19);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "Username";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(124, 201);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(63, 19);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "Password";
            // 
            // textusername
            // 
            // 
            // 
            // 
            this.textusername.CustomButton.Image = null;
            this.textusername.CustomButton.Location = new System.Drawing.Point(246, 1);
            this.textusername.CustomButton.Name = "";
            this.textusername.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.textusername.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textusername.CustomButton.TabIndex = 1;
            this.textusername.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textusername.CustomButton.UseSelectable = true;
            this.textusername.CustomButton.Visible = false;
            this.textusername.Lines = new string[0];
            this.textusername.Location = new System.Drawing.Point(251, 141);
            this.textusername.MaxLength = 32767;
            this.textusername.Name = "textusername";
            this.textusername.PasswordChar = '\0';
            this.textusername.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textusername.SelectedText = "";
            this.textusername.SelectionLength = 0;
            this.textusername.SelectionStart = 0;
            this.textusername.Size = new System.Drawing.Size(268, 23);
            this.textusername.TabIndex = 3;
            this.textusername.UseSelectable = true;
            this.textusername.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textusername.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // textpassword
            // 
            // 
            // 
            // 
            this.textpassword.CustomButton.Image = null;
            this.textpassword.CustomButton.Location = new System.Drawing.Point(246, 1);
            this.textpassword.CustomButton.Name = "";
            this.textpassword.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.textpassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textpassword.CustomButton.TabIndex = 1;
            this.textpassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textpassword.CustomButton.UseSelectable = true;
            this.textpassword.CustomButton.Visible = false;
            this.textpassword.Lines = new string[0];
            this.textpassword.Location = new System.Drawing.Point(251, 201);
            this.textpassword.MaxLength = 32767;
            this.textpassword.Name = "textpassword";
            this.textpassword.PasswordChar = '\0';
            this.textpassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textpassword.SelectedText = "";
            this.textpassword.SelectionLength = 0;
            this.textpassword.SelectionStart = 0;
            this.textpassword.Size = new System.Drawing.Size(268, 23);
            this.textpassword.TabIndex = 4;
            this.textpassword.UseSelectable = true;
            this.textpassword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textpassword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 375);
            this.Controls.Add(this.textpassword);
            this.Controls.Add(this.textusername);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroButton1);
            this.Name = "Form1";
            this.Text = "Air Craft Management System";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox textusername;
        private MetroFramework.Controls.MetroTextBox textpassword;
    }
}

