using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace ClassyAdsWinApp.Forms
{
    public partial class BaseForm : Form
    {
        protected Panel contentPanel;

        public BaseForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.White;

        }
    }
}
