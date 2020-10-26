using System.Windows.Forms;
using E7S.Models;
using E7S.Presenters;
using E7S.ViewInterfaces;

namespace E7S.UserControls
{
    public partial class ArrowUserControl : UserControl, IArrowUserControl
    {
        #region Properties
        private static bool IsTeleportDirectionButtonsEnabled { get; set; }
        public string DebuffDirection { get; private set; }
        public string DirectionWanted { get; private set; }
        #endregion

        public ArrowUserControl()
        {
            InitializeComponent();
            LoadUserControlDefaults();
        }

        #region Events
        private void btnUpDebuffDirection_Click(object sender, System.EventArgs e)
        {
            if(!IsTeleportDirectionButtonsEnabled)
                EnableDebuffDirectionButtons();

            DebuffDirection = string.Empty;
            DebuffDirection = Cardinals.NorthDebuffDirection;
            this.txtBoxDebuffDirection.Text = Cardinals.NorthDebuffDirection;
            this.txtBoxDirectionWanted.Text = string.Empty;
            this.txtBoxResultDirectionToFace.Text = string.Empty;

        }

        private void btnLeftDebuffDirection_Click(object sender, System.EventArgs e)
        {
            if (!IsTeleportDirectionButtonsEnabled)
                EnableDebuffDirectionButtons();

            DebuffDirection = string.Empty;
            DebuffDirection = Cardinals.WestDebuffDirection;
            this.txtBoxDebuffDirection.Text = Cardinals.WestDebuffDirection;
            this.txtBoxDirectionWanted.Text = string.Empty;
            this.txtBoxResultDirectionToFace.Text = string.Empty;
        }

        private void btnRightDebuffDirection_Click(object sender, System.EventArgs e)
        {
            if (!IsTeleportDirectionButtonsEnabled)
                EnableDebuffDirectionButtons();

            DebuffDirection = string.Empty;
            DebuffDirection = Cardinals.EastDebuffDirection;
            this.txtBoxDebuffDirection.Text = Cardinals.EastDebuffDirection;
            this.txtBoxDirectionWanted.Text = string.Empty;
            this.txtBoxResultDirectionToFace.Text = string.Empty;
        }

        private void btnDownDebuffDirection_Click(object sender, System.EventArgs e)
        {
            if (!IsTeleportDirectionButtonsEnabled)
                EnableDebuffDirectionButtons();

            DebuffDirection = string.Empty;
            DebuffDirection = Cardinals.SouthDebuffDirection;
            this.txtBoxDebuffDirection.Text = Cardinals.SouthDebuffDirection;
            this.txtBoxDirectionWanted.Text = string.Empty;
            this.txtBoxResultDirectionToFace.Text = string.Empty;
        }

        private void btnUpDirectionWanted_Click(object sender, System.EventArgs e)
        {

            DirectionWanted = string.Empty;
            DirectionWanted = Cardinals.NorthDirectionWanted;
            this.txtBoxDirectionWanted.Text = Cardinals.NorthDirectionWanted;

            SolveResults();
        }

        private void btnLeftDirectionWanted_Click(object sender, System.EventArgs e)
        {
            DirectionWanted = string.Empty;
            DirectionWanted = Cardinals.WestDirectionWanted;
            this.txtBoxDirectionWanted.Text = Cardinals.WestDirectionWanted;
            
            SolveResults();
        }

        private void btnDownDirectionWanted_Click(object sender, System.EventArgs e)
        {
            DirectionWanted = string.Empty;
            DirectionWanted = Cardinals.SouthDirectionWanted;
            this.txtBoxDirectionWanted.Text = Cardinals.SouthDirectionWanted;

            SolveResults();
        }

        private void btnRightDirectionWanted_Click(object sender, System.EventArgs e)
        {
            DirectionWanted = string.Empty;
            DirectionWanted = Cardinals.EastDirectionWanted;
            this.txtBoxDirectionWanted.Text = Cardinals.EastDirectionWanted;

            SolveResults();
        }
        
        #endregion

        #region Methods

        /// <summary>
        /// Enables second set of arrow buttons. 
        /// </summary>
        private void EnableDebuffDirectionButtons()
        {
            this.btnUpTeleportDirection.Enabled = true;
            this.btnDownTeleportDirection.Enabled = true;
            this.btnLeftTeleportDirection.Enabled = true;
            this.btnRightTeleportDirection.Enabled = true;
            IsTeleportDirectionButtonsEnabled = true;
        }
        
        private void LoadUserControlDefaults()
        {
            this.btnLeftTeleportDirection.Enabled = false;
            this.btnRightTeleportDirection.Enabled = false;
            this.btnUpTeleportDirection.Enabled = false;
            this.btnDownTeleportDirection.Enabled = false;
            this.txtBoxDebuffDirection.Enabled = false;
            this.txtBoxDirectionWanted.Enabled = false;
            this.txtBoxResultDirectionToFace.Enabled = false;
            this.btnUpFacingDirection.Image = E7S.Properties.Resources.UpArrow;
            this.btnRightFacingDirection.Image = E7S.Properties.Resources.RightArrow;
            this.btnDownFacingDirection.Image = E7S.Properties.Resources.DownArrow;
            this.btnLeftFacingDirection.Image = E7S.Properties.Resources.LeftArrow;
            this.btnUpTeleportDirection.Image = E7S.Properties.Resources.UpArrow;
            this.btnRightTeleportDirection.Image = E7S.Properties.Resources.RightArrow;
            this.btnDownTeleportDirection.Image = E7S.Properties.Resources.DownArrow;
            this.btnLeftTeleportDirection.Image = E7S.Properties.Resources.LeftArrow;
        }

        public void SolveResults()
        {
            ArrowMainPresenter p = new ArrowMainPresenter(this);
            p.ShowResults();
        }

        public void DirectionToFace(string result)
        {
            this.txtBoxResultDirectionToFace.Text = string.Empty;
            this.txtBoxResultDirectionToFace.Text = result;
        }

        #endregion
    }
}
