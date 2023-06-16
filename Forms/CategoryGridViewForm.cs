
using System;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;
using ClassyAdsWinApp.Interfaces;
using ClassyAdsWinApp.Services;
using ClassyAdsWinApp.Utils;

namespace ClassyAdsWinApp.Forms
{
    public partial class CategoryGridViewForm : Form
    {
        private ICategoryService categoryService;

        public CategoryGridViewForm()
        {
            InitializeComponent();
            this.Load += CategoryAnalytics_Load;
        }

        private async void CategoryAnalytics_Load(object sender, System.EventArgs e)
        {
            categoryService = new CategoryService();

            var categories = await categoryService.GetAllCategories();

            if (categories != null)
            {
                var analyticsData = DataSetHelper.CreateDataSet(categories, "categories");

                if (analyticsData.Tables.Count > 0)
                {
                    CategoryGridView.DataSource = analyticsData.Tables[0];
                    CategoryGridView.Refresh();
                }
            }
        }

        private void PrintCategoryButtons_Click(object sender, System.EventArgs e)
        {
            PrintDocument printDoc = new PrintDocument();

            printDoc.PrintPage += PrintDoc_PrintPage;
            printDoc.Print();
        }

        private void PrintDoc_PrintPage(object sender, PrintPageEventArgs e)
        {
            Rectangle printArea = e.MarginBounds;

            Font font = new Font("Arial", 12);
            Brush brush = Brushes.Black;

            float y = printArea.Top;

            foreach (DataGridViewRow row in CategoryGridView.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    string cellValue = cell.Value?.ToString() ?? "";

                    e.Graphics.DrawString(cellValue, font, brush, printArea.Left, y);

                    printArea.X += printArea.Width / CategoryGridView.Columns.Count;
                }

                printArea.X = e.MarginBounds.Left;
                y += 20;
            }
        }

        private void GoBackToMain_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            this.Hide();
            mainForm.Show();
        }
    }
}
