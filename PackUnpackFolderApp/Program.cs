using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using PackUnpackFolderApp.Model;
using PackUnpackFolderApp.View;
using PackUnpackFolderApp.Presenter;

namespace PackUnpackFolderApp
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            MainForm form = new MainForm();
            DataManager manager = new DataManager();
            AppPresenter presenter = new AppPresenter(form, manager);

            Application.Run(form);

            //Application.Run(new MainForm());
        }
    }
}
