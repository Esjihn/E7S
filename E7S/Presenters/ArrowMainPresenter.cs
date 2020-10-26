using System;
using System.Collections.Generic;
using System.Text;
using E7S.Models;
using E7S.ViewInterfaces;

namespace E7S.Presenters
{
    public class ArrowMainPresenter 
    {
        private IArrowUserControl _view;
        private const string Exception = "**exception**";

        public ArrowMainPresenter(IArrowUserControl view)
        {
            this._view = view;
        }

        public void ShowResults()
        {
            _view.DirectionToFace(RunDirectionLogic(_view.DebuffDirection, _view.DirectionWanted));
        }

        /// <summary>
        /// Takes debuff direction and direction wanted and produces result
        /// which is the direction user should face.
        /// </summary>
        public string RunDirectionLogic(string deBuff, string wanted)
        {
            if (string.IsNullOrEmpty(deBuff) || string.IsNullOrEmpty(wanted)) return Exception;

            // North Debuff (forward)
            if (deBuff.Contains(Cardinals.NorthDebuffDirection)
                && wanted.Contains(Cardinals.NorthDirectionWanted))
            {
                return Cardinals.ResultNorth;
            }

            if (deBuff.Contains(Cardinals.NorthDebuffDirection)
                && wanted.Contains(Cardinals.SouthDirectionWanted))
            {
                return Cardinals.ResultSouth;
            }

            if (deBuff.Contains(Cardinals.NorthDebuffDirection)
                && wanted.Contains(Cardinals.WestDirectionWanted))
            {
                return Cardinals.ResultWest;
            }

            if (deBuff.Contains(Cardinals.NorthDebuffDirection)
                && wanted.Contains(Cardinals.EastDirectionWanted))
            {
                return Cardinals.ResultEast;
            }

            // South Debuff (back)
            if (deBuff.Contains(Cardinals.SouthDebuffDirection)
                && wanted.Contains(Cardinals.NorthDirectionWanted))
            {
                return Cardinals.ResultSouth;
            }

            if (deBuff.Contains(Cardinals.SouthDebuffDirection)
                && wanted.Contains(Cardinals.SouthDirectionWanted))
            {
                return Cardinals.ResultNorth;
            }

            if (deBuff.Contains(Cardinals.SouthDebuffDirection)
                && wanted.Contains(Cardinals.WestDirectionWanted))
            {
                return Cardinals.ResultEast;
            }

            if (deBuff.Contains(Cardinals.SouthDebuffDirection)
                && wanted.Contains(Cardinals.EastDirectionWanted))
            {
                return Cardinals.ResultWest;
            }

            // West Debuff (left)
            if (deBuff.Contains(Cardinals.WestDebuffDirection)
                && wanted.Contains(Cardinals.NorthDirectionWanted))
            {
                return Cardinals.ResultEast;
            }

            if (deBuff.Contains(Cardinals.WestDebuffDirection)
                && wanted.Contains(Cardinals.SouthDirectionWanted))
            {
                return Cardinals.ResultWest;
            }

            if (deBuff.Contains(Cardinals.WestDebuffDirection)
                && wanted.Contains(Cardinals.WestDirectionWanted))
            {
                return Cardinals.ResultNorth;
            }

            if (deBuff.Contains(Cardinals.WestDebuffDirection)
                && wanted.Contains(Cardinals.EastDirectionWanted))
            {
                return Cardinals.ResultSouth;
            }

            // East Debuff (right)
            if (deBuff.Contains(Cardinals.EastDebuffDirection)
                && wanted.Contains(Cardinals.NorthDirectionWanted))
            {
                return Cardinals.ResultWest;
            }

            if (deBuff.Contains(Cardinals.EastDebuffDirection)
                && wanted.Contains(Cardinals.SouthDirectionWanted))
            {
                return Cardinals.ResultEast;
            }

            if (deBuff.Contains(Cardinals.EastDebuffDirection)
                && wanted.Contains(Cardinals.WestDirectionWanted))
            {
                return Cardinals.ResultSouth;
            }

            if (deBuff.Contains(Cardinals.EastDebuffDirection)
                && wanted.Contains(Cardinals.EastDirectionWanted))
            {
                return Cardinals.ResultNorth;
            }

            return Exception;
        }
    }
}
