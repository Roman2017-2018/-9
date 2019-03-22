using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace аааааааааааааааааааааааааа
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = panel1.CreateGraphics(); // создаем место для рисования
            g.TranslateTransform(3200, 200); // смещение начала координат (в пикселях)
            g.RotateTransform(180f);
            g.ScaleTransform(7f, 7f);


            List<Point> p = new List<Point>(); // список точек графика

            Pen pen = new Pen(Color.Black, 2f); // перо, для отрисовки графика
            Pen gridPen = new Pen(Color.DarkGray, 0.01f); //перо для отрисовки координатной сетки
            Pen penCO = new Pen(Color.Beige, 0.6f);

            Font fo = new System.Drawing.Font(FontFamily.GenericSerif, 3f); //шрифт для выведения текстовой информации, в данном случае не используется

            g.DrawLine(penCO, new Point(-5000, 0), new Point(5000, 0));
            g.DrawLine(penCO, new Point(0, -5000), new Point(0, 5000)); // толстая зеленая линия, ось OX

            // рисуем координатную сетку
            int x = 0; //начальное значение координаты х. Постороение идет из указанной точки
            int y = -110; // начальное значение координаты у. Пояснение см выше.


            while (x <= 500) //конечное значение координаты х. Бесконечное количество линий нам не надо, ибо никакой памяти не хватит
            {
                x = x + 2; // шаг линий, параллельных оси ОУ
                y = y + 2; //шаг линий, параллельных оси ОХ
                g.DrawLine(gridPen, new Point(x, -50), new Point(x, 100)); // рисуем линии, параллельные оси ОУ
                g.DrawLine(gridPen, new Point(-50, y), new Point(100, y)); //рисуем линии, параллельные оси ОХ


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
}
