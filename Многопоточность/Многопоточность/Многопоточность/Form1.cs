using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Многопоточность
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        [DllImport("user32.dll")]
        private static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

        [DllImport("user32.dll")]
        private static extern bool SetForegroundWindow(IntPtr hWnd);

       
        private void button3_Click(object sender, EventArgs e)
        {
            IntPtr zero = IntPtr.Zero;
            for (int i = 0; (i < 60) && (zero == IntPtr.Zero); i++)
            {
                Thread.Sleep(30);
                Process[] proc = Process.GetProcesses(System.Environment.MachineName);
                proc = null;
                zero = FindWindow(null, "Безымянный — Блокнот"); 		

            }
            if (zero != IntPtr.Zero)
            {
                SetForegroundWindow(zero);
                SendKeys.SendWait("{1}");
                SendKeys.SendWait("{2}");
                SendKeys.SendWait("{ENTER}");
                SendKeys.Flush();
            }
        }
    }
}
