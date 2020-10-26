using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using E7S.Models;

namespace E7S
{
    public partial class ArrowUserControl : UserControl
    {
        public ArrowUserControl()
        {
            InitializeComponent();
            LoadArrowResources();
            TieButtonEventsToLogic();
        }

        private void TieButtonEventsToLogic()
        {
            
        }

        private void LoadArrowResources()
        {
            this.txtBoxTeleportDirection.Enabled = false;
            this.txtBoxDirectionWanted.Enabled = false;
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
