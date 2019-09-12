
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Threading;
using System.Diagnostics;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public bool flag =false;
        private delegate void MyDelegate();
        private MyDelegate md;
        private MyDelegate md1;
        public int fe;

        [DllImport("user32.dll", CharSet = CharSet.Auto, ExactSpelling = true)]
        internal static extern short GetAsyncKeyState(int vkey);
        public Form1()
        {
            Clipboard.SetDataObject(Keys.ControlKey.ToString());
            InitializeComponent();
            md1 = new MyDelegate(SetListText1);
            md = new MyDelegate(SetListText);
            BackgroundWorker bWorker = new BackgroundWorker();
            bWorker.DoWork += new DoWorkEventHandler(WaitKey);
            bWorker.RunWorkerAsync(this);
        }

        private void WaitKey(Object obj, DoWorkEventArgs arg)
        {
            Action action = () => { this.listBox1.Items.Add(fe.ToString()); };

            do
            {
                //    fe = Form1.GetAsyncKeyState((int)Keys.V);
                //    Thread.Sleep(500);
                //    Invoke(action);
                //    //if (Convert.ToBoolean(GetAsyncKeyState((int)Keys.ControlKey))&&Convert.ToBoolean(GetAsyncKeyState((int)Keys.C)))
                if (Convert.ToBoolean(GetAsyncKeyState((int)Keys.V)))
                    {
                    if (flag)
                    {
                        try
                        {
                           // Thread.Sleep(100);
                            Invoke(md);
                            
                           
                        }
                        catch (Exception o)
                        {
                            MessageBox.Show(o.ToString());
                        }
                    }
                    flag = true;
                    }
                if (Convert.ToBoolean(GetAsyncKeyState((int)Keys.B)))
                {
                    if (flag)
                    {
                        try
                        {
                            // Thread.Sleep(100);
                            Invoke(md1);


                        }
                        catch (Exception o)
                        {
                            MessageBox.Show(o.ToString());
                        }
                    }
                    flag = true;
                }
            } while (true);


        }
      
        [DllImport("user32.dll", EntryPoint = "FindWindowEx")]
        public static extern IntPtr FindWindowEx(IntPtr hwndParent, IntPtr hwndChildAfter, string lpszClass, string lpszWindow);
        [DllImport("User32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int uMsg, int wParam, string lParam);
        int f = 5;
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        public static extern int SendMessage(IntPtr hwnd, int wMsg, uint wParam, uint lParam);
        [DllImport("user32.dll", SetLastError = true)]
        static extern IntPtr FindWindow(string lpClassName, string lpWindowName);
        [DllImport("user32.dll")]
        private static extern bool SetForegroundWindow(IntPtr hWnd);

        [DllImport("user32.dll", SetLastError = true)]
        static extern bool PostMessage(IntPtr hWnd, uint Msg, IntPtr wParam, IntPtr lParam);
        public const Int32 WM_CHAR = 0x0102;
        public const Int32 WM_KEYDOWN = 0x0100;
        public const Int32 WM_KEYUP = 0x0101;
        public const Int32 VK_RETURN = 0x0D;


        private void SetListText()
        {
            IDataObject data = Clipboard.GetDataObject();
            if (data != null && data.GetDataPresent(DataFormats.Text)) {




            //   Process[] proc1 = Process.GetProcesses();

                Process [] proc = Process.GetProcessesByName("NTSD");  

                // Bu kadar basit kodlar Youtube acıklama kısmındadır 
                // Bir dahaki videoda görüşmek üzere :)
                if (proc[0] == null )
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
                //PostMessage(proc.MainWindowHandle, WM_CHAR, (IntPtr)Keys.J, new IntPtr(0)); System.Threading.Thread.Sleep(100);
                for (int i = 0; i < 1; i++)
                {
                    ////////////////////////////////////////////////////////////PostMessage(proc[0].MainWindowHandle, 0x100, (IntPtr)Keys.Oem7, IntPtr.Zero);
                    ////////////////////н//////////////////////////////////////Thread.Sleep(100);
                    ////////////////////////////////////////////////////////////PostMessage(proc[0].MainWindowHandle, 0x101, (IntPtr)Keys.W, IntPtr.Zero);
                    ////////////////////////////////////////////////////////////Thread.Sleep(30);
                    ////////////////////////////////////////////////////////////PostMessage(proc[0].MainWindowHandle, 0x100, (IntPtr)Keys.Oem5, IntPtr.Zero);
                    ////////////////////////////////////////////////////////////Thread.Sleep(100);
                    ////////////////////////////////////////////////////////////PostMessage(proc[0].MainWindowHandle, 0x101, (IntPtr)Keys.Oem5, IntPtr.Zero);
                    ////////////////////////////////////////////////////////////Thread.Sleep(94);
                    ////////////////////////////////////////////////////////////PostMessage(proc[0].MainWindowHandle, 0x100, (IntPtr)Keys.Oem7, IntPtr.Zero);
                    ////////////////////////////////////////////////////////////Thread.Sleep(98);
                    ////////////////////////////////////////////////////////////PostMessage(proc[0].MainWindowHandle, 0x101, (IntPtr)Keys.Oem7, IntPtr.Zero);
                    ////////////////////////////////////////////////////////////Thread.Sleep(70);
                    ////////////////////////////////////////////////////////////PostMessage(proc[0].MainWindowHandle, 0x100, (IntPtr)Keys.W, IntPtr.Zero);
                    ////////////////////////////////////////////////////////////PostMessage(proc[0].MainWindowHandle, 0x100, (IntPtr)Keys.Oem1, IntPtr.Zero);
                    ////////////////////////////////////////////////////////////Thread.Sleep(50);
                    ////////////////////////////////////////////////////////////PostMessage(proc[0].MainWindowHandle, 0x101, (IntPtr)Keys.W, IntPtr.Zero);
                    ////////////////////////////////////////////////////////////PostMessage(proc[0].MainWindowHandle, 0x101, (IntPtr)Keys.Oem1, IntPtr.Zero);


                    //////////////////////////////////////////////////////////////////////////////////////PostMessage(proc[0].MainWindowHandle, 0x100, (IntPtr)Keys.Oem1, IntPtr.Zero);
                    //////////////////////////////////////////////////////////////////////////////////////PostMessage(proc[0].MainWindowHandle, 0x100, (IntPtr)Keys.Oem7, IntPtr.Zero);
                    //////////////////////////////////////////////////////////////////////////////////////PostMessage(proc[0].MainWindowHandle, 0x100, (IntPtr)Keys.Oem5, IntPtr.Zero);
                    //////////////////////////////////////////////////////////////////////////////////////System.Threading.Thread.Sleep(1500);

                    //////////////////////////////////////////////////////////////////////////////////////PostMessage(proc[0].MainWindowHandle, 0x101, (IntPtr)Keys.Oem1, IntPtr.Zero);
                    //////////////////////////////////////////////////////////////////////////////////////PostMessage(proc[0].MainWindowHandle, 0x101, (IntPtr)Keys.Oem7, IntPtr.Zero);
                    //////////////////////////////////////////////////////////////////////////////////////PostMessage(proc[0].MainWindowHandle, 0x101, (IntPtr)Keys.Oem5, IntPtr.Zero);
                    
		    /* Метод для саске
		    PostMessage(proc[0].MainWindowHandle, 0x100, (IntPtr)Keys.Oem7, IntPtr.Zero);
                    Thread.Sleep(100);
                    PostMessage(proc[0].MainWindowHandle, 0x101, (IntPtr)Keys.Oem7, IntPtr.Zero);
                    Thread.Sleep(30);
                    PostMessage(proc[0].MainWindowHandle, 0x100, (IntPtr)Keys.W, IntPtr.Zero);
                    Thread.Sleep(100);
                    PostMessage(proc[0].MainWindowHandle, 0x101, (IntPtr)Keys.W, IntPtr.Zero);
                    Thread.Sleep(30);
                    PostMessage(proc[0].MainWindowHandle, 0x100, (IntPtr)Keys.Oem5, IntPtr.Zero);
                    Thread.Sleep(100);
                    PostMessage(proc[0].MainWindowHandle, 0x101, (IntPtr)Keys.Oem5, IntPtr.Zero);
                    Thread.Sleep(94);
                    PostMessage(proc[0].MainWindowHandle, 0x100, (IntPtr)Keys.Oem7, IntPtr.Zero);
                    Thread.Sleep(98);
                    PostMessage(proc[0].MainWindowHandle, 0x101, (IntPtr)Keys.Oem7, IntPtr.Zero);
                    Thread.Sleep(70);
                    PostMessage(proc[0].MainWindowHandle, 0x100, (IntPtr)Keys.W, IntPtr.Zero);
                    PostMessage(proc[0].MainWindowHandle, 0x100, (IntPtr)Keys.Oem1, IntPtr.Zero);
                    Thread.Sleep(50);
                    PostMessage(proc[0].MainWindowHandle, 0x101, (IntPtr)Keys.W, IntPtr.Zero);
                    PostMessage(proc[0].MainWindowHandle, 0x101, (IntPtr)Keys.Oem1, IntPtr.Zero);

                    //PostMessage(proc[0].MainWindowHandle, 0x100, (IntPtr)Keys.Oem7, IntPtr.Zero);
                    //Thread.Sleep(100);
                    //PostMessage(proc[0].MainWindowHandle, 0x101, (IntPtr)Keys.Oem7, IntPtr.Zero);
                    //Thread.Sleep(50);
                    //PostMessage(proc[0].MainWindowHandle, 0x100, (IntPtr)Keys.W, IntPtr.Zero);
                    //Thread.Sleep(100);
                    //PostMessage(proc[0].MainWindowHandle, 0x101, (IntPtr)Keys.W, IntPtr.Zero);
                    //Thread.Sleep(50);
                    //PostMessage(proc[0].MainWindowHandle, 0x100, (IntPtr)Keys.Oem1, IntPtr.Zero);
                    //Thread.Sleep(100);
                    //PostMessage(proc[0].MainWindowHandle, 0x101, (IntPtr)Keys.Oem1, IntPtr.Zero);
                    //Thread.Sleep(50);
		    */

                     // Метод для наруто 
                     PostMessage(proc[0].MainWindowHandle, 0x100, (IntPtr)Keys.Oem7, IntPtr.Zero);
                     Thread.Sleep(100);
                     PostMessage(proc[0].MainWindowHandle, 0x101, (IntPtr)Keys.Oem7, IntPtr.Zero);
                     Thread.Sleep(50);
                     PostMessage(proc[0].MainWindowHandle, 0x100, (IntPtr)Keys.S, IntPtr.Zero);
                     Thread.Sleep(100);
                     PostMessage(proc[0].MainWindowHandle, 0x101, (IntPtr)Keys.S, IntPtr.Zero);
                     Thread.Sleep(50);
                     PostMessage(proc[0].MainWindowHandle, 0x100, (IntPtr)Keys.Oem5, IntPtr.Zero);
                     Thread.Sleep(100);
                     PostMessage(proc[0].MainWindowHandle, 0x101, (IntPtr)Keys.Oem5, IntPtr.Zero);
                     Thread.Sleep(50);
                     PostMessage(proc[0].MainWindowHandle, 0x100, (IntPtr)Keys.Oem1, IntPtr.Zero);
                     Thread.Sleep(100);
                     PostMessage(proc[0].MainWindowHandle, 0x101, (IntPtr)Keys.Oem1, IntPtr.Zero);
                     Thread.Sleep(50);
                     PostMessage(proc[0].MainWindowHandle, 0x100, (IntPtr)Keys.Oem7, IntPtr.Zero);
                     Thread.Sleep(100);
                     PostMessage(proc[0].MainWindowHandle, 0x101, (IntPtr)Keys.Oem7, IntPtr.Zero);
                     Thread.Sleep(50);
                     //Console.WriteLine(ConsoleKey.Z.ToString());
                     //System.Threading.Thread.Sleep(150);
                     // PostMessage(proc[0].MainWindowHandle, 0x101, (IntPtr)Keys.Oem1, IntPtr.Zero);
                     // System.Threading.Thread.Sleep(150);
                     
                }

                // f++;
                // Process[] sd = Process.GetProcesses();


                //IntPtr child = FindWindow(null, "NTSD 2.4        ");
                // //SendMessage(child, 0x000C, 0, $"Hello {f} ");

                // if (child != IntPtr.Zero)
                // {
                //     SetForegroundWindow(child);
                //     Thread.Sleep(30);
                //     SendKeys.Send("{j}"); Thread.Sleep(30);
                //     //   SendKeys.SendWait("{J}"); //Thread.Sleep(30);
                //     //  SendKeys.SendWait("{ENTER}"); 
                //     PostMessage(child, 0x102, c, 1);

                //     SendKeys.Flush();
                // }


                //    KeyboardSend.KeyDown(Keys.J);
                //    KeyboardSend.KeyUp(Keys.J);
                //      MessageBox.Show("yes"); KeyboardSend.KeyDown(Keys.LControlKey);
                this.listBox1.Items.Add((string)data.GetData(DataFormats.Text));
            } // if text
            else
            {
              //  MessageBox.Show("no");
                this.listBox1.Items.Add("klipboard is empty");
            } // else not text
        } // setListText
        private void SetListText1()
        {
            IDataObject data = Clipboard.GetDataObject();
            if (data != null && data.GetDataPresent(DataFormats.Text))
            {






                Process[] proc = Process.GetProcessesByName("NTSD 2.4 ");

              
                if (proc[0] == null || proc.Length == 0)
                {
                    Debug.WriteLine("Uygulama Bulunamadı");
                    return;
                }
         
                for (int i = 0; i < 1; i++)
                {

                    PostMessage(proc[0].MainWindowHandle, 0x100, (IntPtr)Keys.Oem7, IntPtr.Zero);
                   
                  
                    
                    PostMessage(proc[0].MainWindowHandle, 0x100, (IntPtr)Keys.W, IntPtr.Zero);
                   
                   
                    PostMessage(proc[0].MainWindowHandle, 0x100, (IntPtr)Keys.Oem1, IntPtr.Zero);
                    Thread.Sleep(15);
                    
                    PostMessage(proc[0].MainWindowHandle, 0x101, (IntPtr)Keys.Oem7, IntPtr.Zero);
                 
                    PostMessage(proc[0].MainWindowHandle, 0x101, (IntPtr)Keys.W, IntPtr.Zero);
                    PostMessage(proc[0].MainWindowHandle, 0x101, (IntPtr)Keys.Oem1, IntPtr.Zero);
                  //  Thread.Sleep(50);


                }


                this.listBox1.Items.Add((string)data.GetData(DataFormats.Text));
            } // if text
            else
            {
                //  MessageBox.Show("no");
                this.listBox1.Items.Add("klipboard is empty");
            } // else not text
        } // setListText

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


        public static void SendString(string s)
        {
            // Construct list of inputs in order to send them through a single SendInput call at the end.
            List<INPUT> inputs = new List<INPUT>();

            // Loop through each Unicode character in the string.
            foreach (char c in s)
            {
                // First send a key down, then a key up.
                foreach (bool keyUp in new bool[] { false, true })
                {
                    // INPUT is a multi-purpose structure which can be used 
                    // for synthesizing keystrokes, mouse motions, and button clicks.
                    INPUT input = new INPUT
                    {
                        // Need a keyboard event.
                        type = INPUT_KEYBOARD,
                        u = new InputUnion
                        {
                            // KEYBDINPUT will contain all the information for a single keyboard event
                            // (more precisely, for a single key-down or key-up).
                            ki = new KEYBDINPUT
                            {
                                // Virtual-key code must be 0 since we are sending Unicode characters.
                                wVk = 0,

                                // The Unicode character to be sent.
                                wScan = 
                                1,

                                // Indicate that we are sending a Unicode character.
                                // Also indicate key-up on the second iteration.
                                dwFlags = KEYEVENTF_UNICODE | (keyUp ? KEYEVENTF_KEYUP : 0),

                                dwExtraInfo = GetMessageExtraInfo(),
                            }
                        }
                    };

                    // Add to the list (to be sent later).
                    inputs.Add(input);
                }
            }

            // Send all inputs together using a Windows API call.
            SendInput((uint)inputs.Count, inputs.ToArray(), Marshal.SizeOf(typeof(INPUT)));
        }

        const int INPUT_MOUSE = 0;
        const int INPUT_KEYBOARD = 1;
        const int INPUT_HARDWARE = 2;
        const uint KEYEVENTF_EXTENDEDKEY = 0x0001;
        const uint KEYEVENTF_KEYUP = 0x0002;
        const uint KEYEVENTF_UNICODE = 0x0004;
        const uint KEYEVENTF_SCANCODE = 0x0008;
        const uint XBUTTON1 = 0x0001;
        const uint XBUTTON2 = 0x0002;
        const uint MOUSEEVENTF_MOVE = 0x0001;
        const uint MOUSEEVENTF_LEFTDOWN = 0x0002;
        const uint MOUSEEVENTF_LEFTUP = 0x0004;
        const uint MOUSEEVENTF_RIGHTDOWN = 0x0008;
        const uint MOUSEEVENTF_RIGHTUP = 0x0010;
        const uint MOUSEEVENTF_MIDDLEDOWN = 0x0020;
        const uint MOUSEEVENTF_MIDDLEUP = 0x0040;
        const uint MOUSEEVENTF_XDOWN = 0x0080;
        const uint MOUSEEVENTF_XUP = 0x0100;
        const uint MOUSEEVENTF_WHEEL = 0x0800;
        const uint MOUSEEVENTF_VIRTUALDESK = 0x4000;
        const uint MOUSEEVENTF_ABSOLUTE = 0x8000;

        struct INPUT
        {
            public int type;
            public InputUnion u;
        }

        [StructLayout(LayoutKind.Explicit)]
        struct InputUnion
        {
            [FieldOffset(0)]
            public MOUSEINPUT mi;
            [FieldOffset(0)]
            public KEYBDINPUT ki;
            [FieldOffset(0)]
            public HARDWAREINPUT hi;
        }

        [StructLayout(LayoutKind.Sequential)]
        struct MOUSEINPUT
        {
            public int dx;
            public int dy;
            public uint mouseData;
            public uint dwFlags;
            public uint time;
            public IntPtr dwExtraInfo;
        }

        [StructLayout(LayoutKind.Sequential)]
        struct KEYBDINPUT
        {
            /*Virtual Key code.  Must be from 1-254.  If the dwFlags member specifies KEYEVENTF_UNICODE, wVk must be 0.*/
            public ushort wVk;
            /*A hardware scan code for the key. If dwFlags specifies KEYEVENTF_UNICODE, wScan specifies a Unicode character which is to be sent to the foreground application.*/
            public ushort wScan;
            /*Specifies various aspects of a keystroke.  See the KEYEVENTF_ constants for more information.*/
            public uint dwFlags;
            /*The time stamp for the event, in milliseconds. If this parameter is zero, the system will provide its own time stamp.*/
            public uint time;
            /*An additional value associated with the keystroke. Use the GetMessageExtraInfo function to obtain this information.*/
            public IntPtr dwExtraInfo;
        }

        [StructLayout(LayoutKind.Sequential)]
        struct HARDWAREINPUT
        {
            public uint uMsg;
            public ushort wParamL;
            public ushort wParamH;
        }

        [DllImport("user32.dll")]
        static extern IntPtr GetMessageExtraInfo();

        [DllImport("user32.dll", SetLastError = true)]
        static extern uint SendInput(uint nInputs, INPUT[] pInputs, int cbSize);

    }
}