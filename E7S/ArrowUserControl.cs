using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace E7S
{
    public partial class ArrowUserControl : UserControl
    {
        public ArrowUserControl()
        {
            InitializeComponent();
            LoadArrowResources();
        }

        private void LoadArrowResources()
        {
            this.btnUpFacingDirection.Image = E7S.Properties.Resources.UpArrow;
            this.btnRightFacingDirection.Image = E7S.Properties.Resources.RightArrow;
            this.btnDownFacingDirection.Image = E7S.Properties.Resources.DownArrow;
            this.btnLeftFacingDirection.Image = E7S.Properties.Resources.LeftArrow;
            this.btnUpTeleportDirection.Image = E7S.Properties.Resources.UpArrow;
            this.btnRightTeleportDirection.Image = E7S.Properties.Resources.RightArrow;
            this.btnDownTeleportDirection.Image = E7S.Properties.Resources.DownArrow;
            this.btnLeftTeleportDirection.Image = E7S.Properties.Resources.LeftArrow;
        }
    }
}
