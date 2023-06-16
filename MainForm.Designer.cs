namespace ClassyAdsWinApp
{
    partial class MainForm
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
            this.GoToLoginButton = new System.Windows.Forms.Button();
            this.GoToRegisterButton = new System.Windows.Forms.Button();
            this.SelectLoginOrRegisterLabel = new System.Windows.Forms.Label();
            this.UsernameDetailLabel = new System.Windows.Forms.Label();
            this.GoToCategoriesGrid = new System.Windows.Forms.Button();
            this.LogoutButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // GoToLoginButton
            // 
            this.GoToLoginButton.Location = new System.Drawing.Point(141, 203);
            this.GoToLoginButton.Margin = new System.Windows.Forms.Padding(4);
            this.GoToLoginButton.Name = "GoToLoginButton";
            this.GoToLoginButton.Size = new System.Drawing.Size(100, 28);
            this.GoToLoginButton.TabIndex = 0;
            this.GoToLoginButton.Text = "Login now";
            this.GoToLoginButton.UseVisualStyleBackColor = true;
            this.GoToLoginButton.Click += new System.EventHandler(this.GoToLoginButton_Click);
            // 
            // GoToRegisterButton
            // 
            this.GoToRegisterButton.Location = new System.Drawing.Point(279, 203);
            this.GoToRegisterButton.Margin = new System.Windows.Forms.Padding(4);
            this.GoToRegisterButton.Name = "GoToRegisterButton";
            this.GoToRegisterButton.Size = new System.Drawing.Size(151, 28);
            this.GoToRegisterButton.TabIndex = 1;
            this.GoToRegisterButton.Text = "Register account";
            this.GoToRegisterButton.UseVisualStyleBackColor = true;
            this.GoToRegisterButton.Click += new System.EventHandler(this.GoToRegisterButton_Click);
            // 
            // SelectLoginOrRegisterLabel
            // 
            this.SelectLoginOrRegisterLabel.AutoSize = true;
            this.SelectLoginOrRegisterLabel.Location = new System.Drawing.Point(249, 209);
            this.SelectLoginOrRegisterLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SelectLoginOrRegisterLabel.Name = "SelectLoginOrRegisterLabel";
            this.SelectLoginOrRegisterLabel.Size = new System.Drawing.Size(19, 16);
            this.SelectLoginOrRegisterLabel.TabIndex = 2;
            this.SelectLoginOrRegisterLabel.Text = "or";
            // 
            // UsernameDetailLabel
            // 
            this.UsernameDetailLabel.AutoSize = true;
            this.UsernameDetailLabel.Location = new System.Drawing.Point(138, 23);
            this.UsernameDetailLabel.Name = "UsernameDetailLabel";
            this.UsernameDetailLabel.Size = new System.Drawing.Size(105, 16);
            this.UsernameDetailLabel.TabIndex = 3;
            this.UsernameDetailLabel.Text = "User: Username";
            // 
            // GoToCategoriesGrid
            // 
            this.GoToCategoriesGrid.Location = new System.Drawing.Point(141, 62);
            this.GoToCategoriesGrid.Name = "GoToCategoriesGrid";
            this.GoToCategoriesGrid.Size = new System.Drawing.Size(289, 40);
            this.GoToCategoriesGrid.TabIndex = 4;
            this.GoToCategoriesGrid.Text = "Go to categories";
            this.GoToCategoriesGrid.UseVisualStyleBackColor = true;
            this.GoToCategoriesGrid.Click += new System.EventHandler(this.GoToCategoriesGrid_Click);
            // 
            // LogoutButton
            // 
            this.LogoutButton.Location = new System.Drawing.Point(355, 23);
            this.LogoutButton.Name = "LogoutButton";
            this.LogoutButton.Size = new System.Drawing.Size(75, 23);
            this.LogoutButton.TabIndex = 5;
            this.LogoutButton.Text = "Logout";
            this.LogoutButton.UseVisualStyleBackColor = true;
            this.LogoutButton.Click += new System.EventHandler(this.LogoutButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 246);
            this.Controls.Add(this.LogoutButton);
            this.Controls.Add(this.GoToCategoriesGrid);
            this.Controls.Add(this.UsernameDetailLabel);
            this.Controls.Add(this.SelectLoginOrRegisterLabel);
            this.Controls.Add(this.GoToRegisterButton);
            this.Controls.Add(this.GoToLoginButton);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "MainForm";
            this.Text = "Welcome";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button GoToLoginButton;
        private System.Windows.Forms.Button GoToRegisterButton;
        private System.Windows.Forms.Label SelectLoginOrRegisterLabel;
        private System.Windows.Forms.Label UsernameDetailLabel;
        private System.Windows.Forms.Button GoToCategoriesGrid;
        private System.Windows.Forms.Button LogoutButton;
    }
}

