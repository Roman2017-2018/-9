using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;
using System.Threading;
using System.IO.Ports;
namespace DiplomProject
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            string[] ports = SerialPort.GetPortNames();
            toolStripComboBox2.Items.AddRange(ports);
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        Point lastPoint;
        private void MainForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) { this.Left += e.X-lastPoint.X ; this.Top += e.Y-lastPoint.Y ; }
        }
        
        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {

            OpenFileDialog op = new OpenFileDialog();
            op.InitialDirectory = "С:\\";
            op.Filter = "Txt files (*.txt)|*.txt|All Fiels(*.*)|*.*";
            op.FilterIndex = 2;
            op.RestoreDirectory = true;

            if (op.ShowDialog() == DialogResult.OK)
            {

                string path = op.FileName;
                StringBuilder sb = new StringBuilder();
                using (StreamReader sr = new StreamReader(path))
                {
                    while (sr.Peek() >= 0)
                    {
                        sb.Append(sr.ReadLine());
                    }
                }
                int d = sb.Length;

                richTextBox1.Text = sb.ToString();
                Regex code = new Regex("[gxyzfXYZF][+-]?[0-9]*\\.?[0-9]*");
                Match mG = code.Match(richTextBox1.Text);

                int Xi = 0; int Yi = 0; int Zi = 0; int Fi = 0;
                while (mG.Success)
                {
                    if (mG.Value.StartsWith("X"))
                    {
                        Xi++;
                        mG = mG.NextMatch();
                    }
                    if (mG.Value.StartsWith("Y"))
                    {
                        Yi++;
                        mG = mG.NextMatch();
                    }
                    if (mG.Value.StartsWith("Z"))
                    {
                        Zi++;
                        mG = mG.NextMatch();
                    }


                    if (mG.Value.StartsWith("F"))
                    {
                        Fi++;
                        mG = mG.NextMatch();

                    }





                }
                richTextBox1.Text = sb.ToString();
                int[] Array = new int[(Xi*3) ]; int Xx = 0; int Yx = 1; int Zx = 2; int Fx = 3;
                Regex Gcode = new Regex("[gxyzfXYZF][+-]?[0-9]*\\.?[0-9]*");
                Match m = Gcode.Match(richTextBox1.Text);

                string X = ""; string Y = ""; string Z = ""; 
                      int i =0;int b=0;int a=0; int c=0;
               while (m.Success)
                {


                    if (m.Value.StartsWith("X"))
                    {


                        Char no = 'X'; char decimalSepparator;
                         double testNum = 0.5; decimalSepparator = testNum.ToString()[1];

                        string[] Xxs = m.Value.Split(no);
                        foreach (var X1 in Xxs)





                            testNum = double.Parse(Xxs[1].Replace('.', decimalSepparator).Replace(',', decimalSepparator));
                        a = Convert.ToInt32(testNum*1000);
                   
                        X = Convert.ToString(a);
                      
                        m = m.NextMatch();
                    }


                    if (m.Value.StartsWith("Y"))
                    {

                       
                        Char no = 'Y'; char decimalSepparator;
                        double testNum = 0.5; decimalSepparator = testNum.ToString()[1];

                        string[] Xxs = m.Value.Split(no);
                        foreach (var X1 in Xxs)





                            testNum = double.Parse(Xxs[1].Replace('.', decimalSepparator).Replace(',', decimalSepparator));
                        b = Convert.ToInt32(testNum * 1000);
                       
                        Y = Convert.ToString(b);
                     
                        m = m.NextMatch(); 

                    }

                    if (m.Value.StartsWith("Z"))
                    {

                        Char no = 'Z'; char decimalSepparator;
                        double testNum = 0.5; decimalSepparator = testNum.ToString()[1];

                        string[] Xxs = m.Value.Split(no);
                        foreach (var X1 in Xxs)





                            testNum = double.Parse(Xxs[1].Replace('.', decimalSepparator).Replace(',', decimalSepparator));
                        c = Convert.ToInt32(testNum * 1000);

                        Z = Convert.ToString(c);

                        m = m.NextMatch();


                    }


                    //if (m.Value.StartsWith("F"))
                    //{

                    //        Char no = 'F';
                    //        Char no1 = '.';
                    //        string[] Xxs = m.Value.Split(no, no1);
                    //        foreach (var X1 in Xxs)
                    //            Array[Fx] = Int32.Parse(Xxs[1]);
                    //        F = Convert.ToString(Array[Fx]);


                    //       Fx += 3; m = m.NextMatch(); 

                    //}


                    richTextBox2.AppendText(X + "\r\n" + Y + "\r\n" + Z + "\r\n" ); Array[Xx] = Convert.ToInt32(X);
                    //Array[Yx] = Convert.ToInt32(Y); Array[Zx] = Convert.ToInt32(Z);
                    if (((Xx+3)< Array.Length)&& ((Yx+3) < Array.Length)&&((Zx+3) < Array.Length)) {
                    Xx += 3; Yx += 3; Zx += 3; }
                }
                
               
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (toolStripComboBox2.Text == "" || toolStripComboBox1.Text == "")


                {
                    MessageBox.Show("введите настройки порта");
                }
                else
                {
                    serialPort1.PortName = toolStripComboBox2.Text;
                    serialPort1.BaudRate = Convert.ToInt32(toolStripComboBox1.Text);
                    serialPort1.Open(); button1.Enabled = false; button3.Enabled = true;
                }
            }
            catch (UnauthorizedAccessException) { MessageBox.Show("Error"); }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            serialPort1.Close(); button3.Enabled=false; button1.Enabled = true;
        }
        public static void PutPixel(Graphics g, Color col, int x, int y, int alpha)
        {
            g.FillRectangle(new SolidBrush(Color.FromArgb(alpha, col)), x, y, 1, 1);
        }

        public void Bresenhem4Line(Graphics g, Color clr, int x0, int y0,
                                                              int x1, int y1)
        {
            //Изменения координат
            int dx = (x1 > x0) ? (x1 - x0) : (x0 - x1);
            int dy = (y1 > y0) ? (y1 - y0) : (y0 - y1);
            //Направление приращения
            int sx = (x1 >= x0) ? (1) : (-1);
            int sy = (y1 >= y0) ? (1) : (-1);


            if (dy < dx)
            {
                int d = (dy << 1) - dx;
                int d1 = dy << 1;
                int d2 = (dy - dx) << 1;
                PutPixel(g, clr, x0, y0, 255);
                int x = x0 + sx;
                int y = y0; int start = y0; int flag = 0; int tick = 0; int x11 = 0; int y11 = 0; int x22 = 0; int y22 = 0;
                for (int i = 1; i <= dx; i++)
                {
                    tick++;
                    if (d > 0)
                    {
                        d += d2;
                        y += sy; flag = 1;
                    }
                    else
                        d += d1;
                    PutPixel(g, clr, x, y, 255);
                    if (flag == 1)
                    {
                        flag = 0; x11 = tick; y11 = sx; tick = 0; richTextBox3.AppendText("X=" + x11.ToString() + "Y=" + y11.ToString() + "\n");
                    }

                    x++;
                }
            }
            else
            {
                int d = (dx << 1) - dy;
                int d1 = dx << 1;
                int d2 = (dx - dy) << 1;
                PutPixel(g, clr, x0, y0, 255);
                int x = x0;
                int y = y0 + sy;
                for (int i = 1; i <= dy; i++)
                {
                    if (d > 0)
                    {
                        d += d2;
                        x += sx;
                    }
                    else
                        d += d1;
                    PutPixel(g, clr, x, y, 255);
                    y++;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            Graphics g = pictureBox1.CreateGraphics();
            Bresenhem4Line(g, Color.ForestGreen, Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox3.Text), Convert.ToInt32(textBox4.Text));
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
