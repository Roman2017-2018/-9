using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using TextEditor_BL;


namespace Test_Text_Editor
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            MainForm s = new MainForm();
            MessageServise we = new MessageServise();
            FileManager ed = new FileManager();
            MainPresenter presenter = new MainPresenter(s, ed, we);
            
            Application.Run(s);
        }
    }
}
