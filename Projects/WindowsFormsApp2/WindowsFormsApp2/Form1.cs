using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
namespace WindowsFormsApp2
{

    class ChartForm : Form
    {
        public ChartForm()
        {
           
        }

        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(12, 316);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(545, 192);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // ChartForm
            // 
            this.ClientSize = new System.Drawing.Size(966, 520);
            this.Controls.Add(this.panel1);
            this.Name = "ChartForm";
            this.Load += new System.EventHandler(this.ChartForm_Load);
            this.ResumeLayout(false);

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private Panel panel1;

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = panel1.CreateGraphics(); // создаем место для рисования
            g.TranslateTransform(3200, 200); // смещение начала координат (в пикселях)
            g.RotateTransform(180f);
            g.ScaleTransform(7f, 7f);


            List<Point> p = new List<Point>(); // список точек графика

            Pen pen = new Pen(Color.DarkRed, 0.5f); // перо, для отрисовки графика
            Pen gridPen = new Pen(Color.DeepPink, 0.0001f); //перо для отрисовки координатной сетки
            Pen penCO = new Pen(Color.Green, 2f);

            Font fo = new System.Drawing.Font(FontFamily.GenericSerif, 3f); //шрифт для выведения текстовой информации, в данном случае не используется

            g.DrawLine(penCO, new Point(-5000, 0), new Point(5000, 0));
            g.DrawLine(penCO, new Point(0, -5000), new Point(0, 5000)); // толстая зеленая линия, ось OX

            // рисуем координатную сетку
            int x = 0; //начальное значение координаты х. Постороение идет из указанной точки
            int y = -100; // начальное значение координаты у. Пояснение см выше.


            while (x <= 500) //конечное значение координаты х. Бесконечное количество линий нам не надо, ибо никакой памяти не хватит
            {
                x = x + 5; // шаг линий, параллельных оси ОУ
                y = y + 5; //шаг линий, параллельных оси ОХ
                g.DrawLine(gridPen, new Point(x, -500), new Point(x, 1000)); // рисуем линии, параллельные оси ОУ
                g.DrawLine(gridPen, new Point(-500, y), new Point(1000, y)); //рисуем линии, параллельные оси ОХ


            }

            double E = 415;  //начальная точка графика

            while (E <= 435) // цикл для создания списка точек, расчет идет до указанного значения, которое является конечной точкой графика
            {

                E = E + 0.85; // шаг расчета координаты х

                double R = (1 / (0.4 * 0.00000075 * Math.Pow(E, 0.81))); //часть расчета координаты у
                double dU = ((15 / 4) * ((R - 24767.6) / 24767.6)); // еще одна часть расчета координаты у
                double U = (820000 / 2000) * dU; //   координата у нашего графика
                Point poss = new Point((int)E, (int)U); // создаем новую точку с рассчитанными координатами
                p.Add(poss); // добавляем точку в список точек


            }
            g.DrawCurve(pen, p.ToArray()); // отрисовка графика. Так так метод DrawCurwe() не может считывать данные из листа, а только из массива, то создаем из листа массив, по данным которого и идет постороение графика
        }

        private void ChartForm_Load(object sender, EventArgs e)
        {
            Graphics g = panel1.CreateGraphics(); // создаем место для рисования
            g.TranslateTransform(3200, 200); // смещение начала координат (в пикселях)
            g.RotateTransform(180f);
            g.ScaleTransform(7f, 7f);


            List<Point> p = new List<Point>(); // список точек графика

            Pen pen = new Pen(Color.DarkRed, 0.5f); // перо, для отрисовки графика
            Pen gridPen = new Pen(Color.DeepPink, 0.0001f); //перо для отрисовки координатной сетки
            Pen penCO = new Pen(Color.Green, 2f);

            Font fo = new System.Drawing.Font(FontFamily.GenericSerif, 3f); //шрифт для выведения текстовой информации, в данном случае не используется

            g.DrawLine(penCO, new Point(-5000, 0), new Point(5000, 0));
            g.DrawLine(penCO, new Point(0, -5000), new Point(0, 5000)); // толстая зеленая линия, ось OX

            // рисуем координатную сетку
            int x = 0; //начальное значение координаты х. Постороение идет из указанной точки
            int y = -100; // начальное значение координаты у. Пояснение см выше.


            while (x <= 500) //конечное значение координаты х. Бесконечное количество линий нам не надо, ибо никакой памяти не хватит
            {
                x = x + 5; // шаг линий, параллельных оси ОУ
                y = y + 5; //шаг линий, параллельных оси ОХ
                g.DrawLine(gridPen, new Point(x, -500), new Point(x, 1000)); // рисуем линии, параллельные оси ОУ
                g.DrawLine(gridPen, new Point(-500, y), new Point(1000, y)); //рисуем линии, параллельные оси ОХ


            }

            double E = 415;  //начальная точка графика

            while (E <= 435) // цикл для создания списка точек, расчет идет до указанного значения, которое является конечной точкой графика
            {

                E = E + 0.85; // шаг расчета координаты х

                double R = (1 / (0.4 * 0.00000075 * Math.Pow(E, 0.81))); //часть расчета координаты у
                double dU = ((15 / 4) * ((R - 24767.6) / 24767.6)); // еще одна часть расчета координаты у
                double U = (820000 / 2000) * dU; //   координата у нашего графика
                Point poss = new Point((int)E, (int)U); // создаем новую точку с рассчитанными координатами
                p.Add(poss); // добавляем точку в список точек


            }
            g.DrawCurve(pen, p.ToArray()); // отрисовка графика. Так так метод
        }
    }
    public partial class Form1 : Form
    {
 


        public Form1()
        {
            InitializeComponent();

          
//создаем эл

        }


    
    };

            
        
    }

    
