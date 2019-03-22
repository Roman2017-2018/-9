using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace Rotate
{

    public partial class Form1 : Form
    {
        Image img;
        int a;
        public Form1()
        {
            InitializeComponent();


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            img = Image.FromFile("C:\\Users\\роман\\Desktop\\ЧПУ рабочая версия\\i1.JPG");
            DoubleBuffered = true;

        }

        public void Form1_Paint(object sender, PaintEventArgs e)
        {
            //////    // Create a graphics path and add an ellipse.
            //////    GraphicsPath myPath = new GraphicsPath();
            //////    Rectangle rect = new Rectangle(100, 20, 100, 50);
            //////    myPath.AddRectangle(rect);
            //////    // Get the path's array of points.
            //////    PointF[] myPathPointArray = myPath.PathPoints;
            //////    // Create a path gradient brush.
            //////    PathGradientBrush myPGBrush = new
            //////    PathGradientBrush(myPathPointArray);
            //////    // Set the color span.
            //////    myPGBrush.CenterColor = Color.Green;
            //////    Color[] mySurroundColor = { Color.Blue };
            //////    myPGBrush.SurroundColors = mySurroundColor;
            //////    // Draw the brush to the screen prior to transformation.
            //////    e.Graphics.FillRectangle(myPGBrush, 10, 10, 200, 200);
            //////    // Apply the rotate transform to the brush.
            //////    myPGBrush.RotateTransform(a, MatrixOrder.Append);
            //////    // Draw the brush to the screen again after applying the
            //////    // transform.
            //////    e.Graphics.FillRectangle(myPGBrush, 10, 10, 200, 300);
            GraphicsPath path = new GraphicsPath(); int Wi = 0; int Hi = 0;
            path.AddEllipse(160, 70, 150, 70);

            // Use the path to construct a brush.
            PathGradientBrush pthGrBrush = new PathGradientBrush(path);

            // Set the color at the center of the path to blue.
            pthGrBrush.CenterColor = Color.FromArgb(255, 0, 0, 255);
            //pthGrBrush.FocusScales = new PointF(40, 40);
            // Set the color along the entire boundary 
            // of the path to aqua.
            Color[] colors = { Color.FromArgb(255, 0, 255, 255) };
            pthGrBrush.SurroundColors = colors;


            pthGrBrush.RotateTransform(a);

            for (int t = 0; t < 100; t++) { PointF wq = new PointF(); wq.X = 40; wq.Y = 40; pthGrBrush.TranslateTransform(1, 1); e.Graphics.FillRectangle(pthGrBrush, 0, 0, 700, 700); Invalidate(); }


            Bitmap bm = new Bitmap(img.Width, img.Height);

            if (a <= 90)
            {
                Wi = (int)(bm.Width * Math.Cos(2 * Math.PI * a / 360) + bm.Height * Math.Sin(2 * Math.PI * a / 360));
                Hi = (int)(bm.Height * Math.Cos(2 * Math.PI * a / 360) + bm.Width * Math.Sin(2 * Math.PI * a / 360));
            }
            else if (a > 90 && a <= 180)
            {
                Wi = (int)(bm.Width * -Math.Cos(2 * Math.PI * a / 360) + bm.Height * Math.Sin(2 * Math.PI * a / 360));
                Hi = (int)(bm.Height * -Math.Cos(2 * Math.PI * a / 360) + bm.Width * Math.Sin(2 * Math.PI * a / 360));
            }
            else if (a > 180 && a <= 270)
            {
                Wi = (int)(bm.Width * -Math.Cos(2 * Math.PI * a / 360) + bm.Height * -Math.Sin(2 * Math.PI * a / 360));
                Hi = (int)(bm.Height * -Math.Cos(2 * Math.PI * a / 360) + bm.Width * -Math.Sin(2 * Math.PI * a / 360));
            }
            else if (a > 270 && a <= 360)
            {
                Wi = (int)(bm.Width * Math.Cos(2 * Math.PI * a / 360) + bm.Height * -Math.Sin(2 * Math.PI * a / 360));
                Hi = (int)(bm.Height * Math.Cos(2 * Math.PI * a / 360) + bm.Width * -Math.Sin(2 * Math.PI * a / 360));
            }
            Bitmap b = new Bitmap(Wi, Hi);



            g.TranslateTransform(Wi / 2, Hi / 2);
            g.RotateTransform(a);
            g.TranslateTransform(-img.Width / 2, -img.Height / 2);

            g.InterpolationMode = InterpolationMode.HighQualityBicubic;
            g.DrawImage(img, 0, 0);
            e.Graphics.TranslateTransform(this.Width / 2, this.Height / 2);
            e.Graphics.DrawImage(b, -b.Width / 2, -b.Height / 2);

            Create the string to draw on the form.
            string text = "Roma prodakshen";

            // Create a GraphicsPath.
            System.Drawing.Drawing2D.GraphicsPath path =
                new System.Drawing.Drawing2D.GraphicsPath();

            // Add the string to the path; declare the font, font style, size, and
            // vertical format for the string.
            path.AddString(text, this.Font.FontFamily, 1, 15,
                new PointF(100.0F, 50.0F),
                new StringFormat(StringFormatFlags.DirectionVertical));

            // Declare a matrix that will be used to rotate the text.
            System.Drawing.Drawing2D.Matrix rotateMatrix =
                new System.Drawing.Drawing2D.Matrix();

            // Set the rotation angle and starting point for the text.
            rotateMatrix.RotateAt(a, new PointF(200.0F, 50.0F));

            // Transform the text with the matrix.
            path.Transform(rotateMatrix);

            // Set the SmoothingMode to high quality for best readability.
            e.Graphics.SmoothingMode =
                System.Drawing.Drawing2D.SmoothingMode.HighQuality;

            // Fill in the path to draw the string.
            e.Graphics.FillPath(Brushes.GreenYellow, path);

            // Dispose of the path.
            path.Dispose();







        }

        //public void TransformExample(PaintEventArgs e)
        //{

        //    // Create a path and add and ellipse.
        //    GraphicsPath myPath = new GraphicsPath();
        //    myPath.AddEllipse(0, 0, 100, 200);

        //    // Draw the starting position to screen.
        //    e.Graphics.DrawPath(Pens.Black, myPath);

        //    // Move the ellipse 100 points to the right.
        //    Matrix translateMatrix = new Matrix();
        //    translateMatrix.Translate(100, 0);
        //    myPath.Transform(translateMatrix);

        //    // Draw the transformed ellipse to the screen.
        //    e.Graphics.DrawPath(new Pen(Color.Red, 2), myPath);
        //}
        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            Invalidate();
        }

        //public void trackBar1_ValueChanged(object sender, EventArgs e)
        //{
           
        //}

        private void trackBar1_Scroll(object sender, EventArgs e)
        { a = trackBar1.Value; Invalidate(); 

        }
    }
}
