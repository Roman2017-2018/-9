using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    
    static class Program
    {
        public static Form1 Ui = null;

        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]


    
        static void Main()
        {
           
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Ui = new Form1();
            Application.Run(Ui);
        }
    }
}
