using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace брезенгер
{
    public partial class Form1 : Form
    {  
        public Form1()
        {
            InitializeComponent();
        }



        public static void PutPixel(Graphics g, Color col, int x, int y, int alpha)
        {
            g.FillRectangle(new SolidBrush(Color.FromArgb(alpha, col)), x, y, 1, 1);
        }

         public void Bresenham4Line(Graphics g, Color clr, int x0, int y0,
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
                int y = y0;int start = y0;int flag = 0; int tick = 0; int x11 = 0; int y11 = 0; int x22 = 0; int y22 = 0;
                for (int i = 1; i <= dx; i++)
                {   tick++;
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
                        flag = 0; x11 = tick; y11 = sx; tick = 0;
                    }
                   richTextBox1.AppendText("X="+x11.ToString() + "Y="+y11.ToString() + "\n");
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



        private void button1_Click_1(object sender, EventArgs e)
        {
            Graphics g = pictureBox1.CreateGraphics();
            Bresenham4Line(g, Color.ForestGreen,0,0,55,17);
               
            //draw_br_line2(g, Color.Black, 300, 300, 100, 100);
               


        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}


