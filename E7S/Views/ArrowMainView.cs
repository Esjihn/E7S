using System.Windows.Forms;
using E7S.UserControls;

namespace E7S.Views
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
