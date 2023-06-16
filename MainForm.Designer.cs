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
            this.SuspendLayout();
            // 
            // GoToLoginButton
            // 
            this.GoToLoginButton.Location = new System.Drawing.Point(106, 165);
            this.GoToLoginButton.Name = "GoToLoginButton";
            this.GoToLoginButton.Size = new System.Drawing.Size(75, 23);
            this.GoToLoginButton.TabIndex = 0;
            this.GoToLoginButton.Text = "Login now";
            this.GoToLoginButton.UseVisualStyleBackColor = true;
            this.GoToLoginButton.Click += new System.EventHandler(this.GoToLoginButton_Click);
            // 
            // GoToRegisterButton
            // 
            this.GoToRegisterButton.Location = new System.Drawing.Point(209, 165);
            this.GoToRegisterButton.Name = "GoToRegisterButton";
            this.GoToRegisterButton.Size = new System.Drawing.Size(113, 23);
            this.GoToRegisterButton.TabIndex = 1;
            this.GoToRegisterButton.Text = "Register account";
            this.GoToRegisterButton.UseVisualStyleBackColor = true;
            this.GoToRegisterButton.Click += new System.EventHandler(this.GoToRegisterButton_Click);
            // 
            // SelectLoginOrRegisterLabel
            // 
            this.SelectLoginOrRegisterLabel.AutoSize = true;
            this.SelectLoginOrRegisterLabel.Location = new System.Drawing.Point(187, 170);
            this.SelectLoginOrRegisterLabel.Name = "SelectLoginOrRegisterLabel";
            this.SelectLoginOrRegisterLabel.Size = new System.Drawing.Size(16, 13);
            this.SelectLoginOrRegisterLabel.TabIndex = 2;
            this.SelectLoginOrRegisterLabel.Text = "or";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 200);
            this.Controls.Add(this.SelectLoginOrRegisterLabel);
            this.Controls.Add(this.GoToRegisterButton);
            this.Controls.Add(this.GoToLoginButton);
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
    }
}

