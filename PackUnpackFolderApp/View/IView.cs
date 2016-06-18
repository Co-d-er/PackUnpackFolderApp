using System;

namespace PackUnpackFolderApp.View
{
    public interface IView
    {
        string TextBoxForFolderPath { get; }
        string TextBoxForFilePath { get; }
        string TextBoxForUnpackedFolder { get; }

        void ShowMessage();
        void Loading();
        void Done();
        void Block();
        void Unblock();
        void OpenCurrentDirectory(string directoryPath);

        event EventHandler ButtonPackClick;
        event EventHandler ButtonUnpackClick;
    }
}
