using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : MaterialForm
    {
        Bitmap RotatingBlocks;
        Point DrawHere;
        Rectangle InvalidRect;
        public Form1()
        {
            InitializeComponent(); button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;





            RotatingBlocks = new Bitmap("C:\\Users\\роман\\Desktop\\CNC Machine_48px.png");
            DrawHere = new Point(0, 0);
            InvalidRect = new Rectangle(DrawHere, RotatingBlocks.Size);

            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            this.SetStyle(ControlStyles.DoubleBuffer, true);


        }
        protected override void OnPaint(PaintEventArgs e)
        {
            ImageAnimator.UpdateFrames(RotatingBlocks);

            e.Graphics.DrawImage(RotatingBlocks, DrawHere);
        }

        private void OnFrameChanged(object o, EventArgs e)
        {

            this.Invalidate(InvalidRect);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        
        private void button2_Click(object sender, EventArgs e)
        {if (ImageAnimator.CanAnimate(RotatingBlocks))
            {

                ImageAnimator.Animate(RotatingBlocks,
                                      new EventHandler(this.OnFrameChanged));

                this.Hide();

                for (int i = 0; i < 100; i++)
                {
                    Thread.Sleep(10);
                }
            }
        }
            

    }

        
    }

