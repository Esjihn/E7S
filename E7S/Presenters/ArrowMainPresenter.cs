using System;
using System.Collections.Generic;
using System.Text;

namespace E7S.Presenters
{
    public class ArrowMainPresenter 
    {
        private IArrowUserControl _view;

        public ArrowMainPresenter(IArrowUserControl view)
        {
            this._view = view;
        }

        public void ShowResults()
        {
            //_view.GetUserSelection();


            //_view.Results();
        }
    }
}
