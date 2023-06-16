namespace ClassyAdsWinApp.Forms
{
    partial class CategoryGridViewForm
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
            this.CategoryGridView = new System.Windows.Forms.DataGridView();
            this.PrintCategoryButtons = new System.Windows.Forms.Button();
            this.GoBackToMain = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CategoryGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // CategoryGridView
            // 
            this.CategoryGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CategoryGridView.Location = new System.Drawing.Point(16, 15);
            this.CategoryGridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CategoryGridView.Name = "CategoryGridView";
            this.CategoryGridView.RowHeadersWidth = 51;
            this.CategoryGridView.Size = new System.Drawing.Size(1035, 384);
            this.CategoryGridView.TabIndex = 0;
            // 
            // PrintCategoryButtons
            // 
            this.PrintCategoryButtons.Location = new System.Drawing.Point(16, 421);
            this.PrintCategoryButtons.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PrintCategoryButtons.Name = "PrintCategoryButtons";
            this.PrintCategoryButtons.Size = new System.Drawing.Size(193, 54);
            this.PrintCategoryButtons.TabIndex = 1;
            this.PrintCategoryButtons.Text = "Print";
            this.PrintCategoryButtons.UseVisualStyleBackColor = true;
            this.PrintCategoryButtons.Click += new System.EventHandler(this.PrintCategoryButtons_Click);
            // 
            // GoBackToMain
            // 
            this.GoBackToMain.Location = new System.Drawing.Point(898, 421);
            this.GoBackToMain.Name = "GoBackToMain";
            this.GoBackToMain.Size = new System.Drawing.Size(153, 54);
            this.GoBackToMain.TabIndex = 2;
            this.GoBackToMain.Text = "Go back to main";
            this.GoBackToMain.UseVisualStyleBackColor = true;
            this.GoBackToMain.Click += new System.EventHandler(this.GoBackToMain_Click);
            // 
            // CategoryGridViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.GoBackToMain);
            this.Controls.Add(this.PrintCategoryButtons);
            this.Controls.Add(this.CategoryGridView);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "CategoryGridViewForm";
            this.Text = "CategoryAnalytics";
            ((System.ComponentModel.ISupportInitialize)(this.CategoryGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView CategoryGridView;
        private System.Windows.Forms.Button PrintCategoryButtons;
        private System.Windows.Forms.Button GoBackToMain;
    }
}