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
using System.Threading;
namespace словосочитание_клавиш
{   


 static class KeyboardSend
    {
        [DllImport("user32.dll")]
        private static extern void keybd_event(byte bVk, byte bScan, int dwFlags, int dwExtraInfo);

        private const int KEYEVENTF_EXTENDEDKEY = 1;
        private const int KEYEVENTF_KEYUP = 2;

        public static void KeyDown(Keys vKey)
        {
            keybd_event((byte)vKey, 0, KEYEVENTF_EXTENDEDKEY, 0);
        }

        public static void KeyUp(Keys vKey)
        {
            keybd_event((byte)vKey, 0, KEYEVENTF_EXTENDEDKEY | KEYEVENTF_KEYUP, 0);
        }
    }



    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        ConsoleKey key;
        private void button1_Click(object sender, EventArgs e)
        {
            do
            {
               

                // Key is available - read it
                key = Console.ReadKey(true).Key;

                if (key == ConsoleKey.Z){ button1.Enabled = false; }

            } while (key != ConsoleKey.Escape);
           
           // KeyboardSend.KeyDown(Keys.Space);
           // KeyboardSend.KeyUp(Keys.Space);
          // Thread.Sleep(100);
            //    for (int i = 0; i < 500; i++)
            //    {
                KeyboardSend.KeyDown(Keys.LControlKey);
            //        KeyboardSend.KeyDown(Keys.LShiftKey);
            //        KeyboardSend.KeyDown(Keys.N);
            //        KeyboardSend.KeyUp(Keys.LControlKey);
            //        KeyboardSend.KeyUp(Keys.LShiftKey);
            //        KeyboardSend.KeyUp(Keys.N);
            //        KeyboardSend.KeyDown(Keys.Enter);
            //        KeyboardSend.KeyUp(Keys.Enter);
            //        KeyboardSend.KeyDown(Keys.Tab);
            //        KeyboardSend.KeyUp(Keys.Tab);
            //        //KeyboardSend.KeyDown(Keys.Enter);
            //        //KeyboardSend.KeyUp(Keys.Enter);
            //        //Thread.Sleep(100);
        }


    }
 
}
