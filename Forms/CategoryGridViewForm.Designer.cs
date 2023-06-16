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
            ((System.ComponentModel.ISupportInitialize)(this.CategoryGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // CategoryGridView
            // 
            this.CategoryGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CategoryGridView.Location = new System.Drawing.Point(12, 12);
            this.CategoryGridView.Name = "CategoryGridView";
            this.CategoryGridView.Size = new System.Drawing.Size(776, 312);
            this.CategoryGridView.TabIndex = 0;
            // 
            // PrintCategoryButtons
            // 
            this.PrintCategoryButtons.Location = new System.Drawing.Point(12, 342);
            this.PrintCategoryButtons.Name = "PrintCategoryButtons";
            this.PrintCategoryButtons.Size = new System.Drawing.Size(145, 44);
            this.PrintCategoryButtons.TabIndex = 1;
            this.PrintCategoryButtons.Text = "Print";
            this.PrintCategoryButtons.UseVisualStyleBackColor = true;
            this.PrintCategoryButtons.Click += new System.EventHandler(this.PrintCategoryButtons_Click);
            // 
            // CategoryAnalyticsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PrintCategoryButtons);
            this.Controls.Add(this.CategoryGridView);
            this.Name = "CategoryAnalyticsForm";
            this.Text = "CategoryAnalytics";
            ((System.ComponentModel.ISupportInitialize)(this.CategoryGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView CategoryGridView;
        private System.Windows.Forms.Button PrintCategoryButtons;
    }
}