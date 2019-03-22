
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Diagnostics;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        [return: MarshalAs(UnmanagedType.Bool)]
        [DllImport("user32.dll", SetLastError = true)]
        static extern bool PostMessage(IntPtr hWnd, uint Msg, IntPtr wParam, IntPtr lParam);
        public const Int32 WM_CHAR = 0x0102;
        public const Int32 WM_KEYDOWN = 0x0100;
        public const Int32 WM_KEYUP = 0x0101;
        public const Int32 VK_RETURN = 0x0D;

        private void button1_Click(object sender, EventArgs e)
        {
            Process[] proc = Process.GetProcessesByName(textBox2.Text);
            // Bu kadar basit kodlar Youtube acıklama kısmındadır 
            // Bir dahaki videoda görüşmek üzere :)
            if (proc[0] == null || proc.Length == 0)
            {
                Debug.WriteLine("Uygulama Bulunamadı");
                return;
            }
            foreach (char c in textBox1.Text)
            {
                int charValue = c;
                string hexValue = charValue.ToString("X");

                IntPtr val = new IntPtr((Int32)c);
                Debug.WriteLine(c + " = dec: " + charValue + ", hex: " + hexValue + ", val: " + val);
                PostMessage(proc[0].MainWindowHandle, WM_CHAR, val, new IntPtr(0));
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
             Process[] proc = Process.GetProcessesByName(textBox2.Text);
           
            // Bu kadar basit kodlar Youtube acıklama kısmındadır 
            // Bir dahaki videoda görüşmek üzere :)
            if (proc[0] == null || proc.Length == 0)
            {
                Debug.WriteLine("Uygulama Bulunamadı");
                return;
            }
            //foreach (char c in textBox1.Text)
            //{
            //    int charValue = c;
            //    string hexValue = charValue.ToString("X");

            //IntPtr val = new IntPtr((Int32)c);
            //Debug.WriteLine(c + " = dec: " + charValue + ", hex: " + hexValue + ", val: " + val);
            //PostMessage(proc[0].MainWindowHandle, WM_CHAR, (IntPtr)Keys.J, new IntPtr(0)); System.Threading.Thread.Sleep(100);
            for (int i = 0; i < 5; i++)
            {
                PostMessage(proc[0].MainWindowHandle, 0x100, (IntPtr)Keys.J, IntPtr.Zero);
                System.Threading.Thread.Sleep(100);
                PostMessage(proc[0].MainWindowHandle, 0x101, (IntPtr)Keys.J, IntPtr.Zero);
            }
            //}
        }
    }
}