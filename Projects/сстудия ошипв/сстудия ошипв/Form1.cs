using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace сстудия_ошипв
{
    public partial class Form1 : Form
    {
        public long i1;
        public static double i;
        public static int counter;
        public static long c ;
        int minute ;
        public Form1()
        {
            minute = 2;
               i = -20;
            i1 = 0;
            counter = 0;
            InitializeComponent();
        }





        private void chart1_Click_1(object sender, EventArgs e)
        {
            timer2.Enabled = true;
            timer1.Enabled = true;

        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
           
            //double a1 = 0+(-0.086*Math.Pow(10,-6)*minute);
            //double b1 = 0.4*Math.Pow(10,-9) + (-0.0785 * Math.Pow(10, -9) * minute);
            //double c1 = 109.5 * Math.Pow(10, -12) + (-0.0334 * Math.Pow(10, -12) * minute);

            //Point sdf = new Point(30,2);
            
            //if (i < 71)
            //{
            //    //if (i == 27.000)
            //    //{
            //    //    chart1.Series[0].Label = "dgdf";
            //    //}
            //   // chart1.Series[0].Points.DataBind(datasource, "xField", "yField", "Label={somevalue}");


            //    chart1.Series[0].Points.AddXY(i,(a1*(i-25)+b1*Math.Pow((i-25),2)+c1*Math.Pow((i-25),3))*Math.Pow(10,6));
               

            //    i += 1;
                
            //}

            //i1++;
        }



        private void chart1_DoubleClick(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            chart1.Series[0].Points.Clear();
            i = 0;
            button1.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            counter++;
          
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (counter == 2)
            {
                button1.Enabled = false;
                timer1.Enabled = false;
                chart1.Series[0].Points.Clear();
                i = 0;
               
            }
            button1.Text = minute.ToString();
            counter = 0;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            minute = trackBar1.Value;
            double a1 = 0 + (-0.086 * Math.Pow(10, -6) * minute);
            double b1 = 0.4 * Math.Pow(10, -9) + (-0.0785 * Math.Pow(10, -9) * minute);
            double c1 = 109.5 * Math.Pow(10, -12) + (-0.0334 * Math.Pow(10, -12) * minute);


            for (double ii= -20; ii< 71;ii++)
            {
                chart1.Series[0].Points.AddXY(ii, (a1 * (ii - 25) + b1 * Math.Pow((ii - 25), 2) + c1 * Math.Pow((ii - 25), 3)) * Math.Pow(10, 6));
                i += 1;

            }

            i1++;
        }
    }
}
