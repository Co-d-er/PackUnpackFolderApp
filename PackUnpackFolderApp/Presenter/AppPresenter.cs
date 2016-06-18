using System;
using PackUnpackFolderApp.Model;
using PackUnpackFolderApp.View;

namespace PackUnpackFolderApp.Presenter
{
    public class AppPresenter
    {
        readonly IView _view;
        readonly DataManager _manager;

        public AppPresenter(IView view, DataManager manager)
        {
            this._view = view;
            this._manager = manager;

            _view.ButtonPackClick += _view_ButtonPackClick;
            _view.ButtonUnpackClick += _view_ButtonUnpackClick;
        }

        private async void _view_ButtonUnpackClick(object sender, EventArgs e)
        {
            _view.Block();
            _view.Loading();
            await _manager.Unpack(_view.TextBoxForFilePath, _view.TextBoxForUnpackedFolder);
            _view.ShowMessage();           
            _view.Done();
            _view.OpenCurrentDirectory(_view.TextBoxForUnpackedFolder);
            _view.Unblock();
        }

        private async void _view_ButtonPackClick(object sender, EventArgs e)
        {
            _view.Block();
            _view.Loading();
            await _manager.Pack(_view.TextBoxForFolderPath);
            _view.ShowMessage();
            _view.Done();
            _view.OpenCurrentDirectory(_manager.CurrentDirectory);          
            _view.Unblock();
        }
    }
}
