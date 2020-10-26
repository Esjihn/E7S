using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace E7S
{
    public partial class ArrowMainView : Form
    {
        public ArrowMainView()
        {
            InitializeComponent();
            LoadArrowUserControl();
        }

        private void LoadArrowUserControl()
        {
            ArrowUserControl auc = new ArrowUserControl();
            this.Controls.Add(auc);
            auc.Dock = DockStyle.Fill;
        }
    }
}
