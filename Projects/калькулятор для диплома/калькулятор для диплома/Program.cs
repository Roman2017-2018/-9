using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace калькулятор_для_диплома
{
    class Program1
    {
        static void Main(string[] args)
        {
           double Cy = 10.359 * Math.Pow(10, -12);
           double deldafc =-422.0;
#region 
            double f1 = 12795200;
            double C0 = 2.184*Math.Pow(10, -12);
                double C1 = 10.09*Math.Pow(10, -15);
                
                 double  fnob = 12800000;



            Console.WriteLine(String.Format("чатота генератора при заданной ёмкости Су {0}   абсолютном отклонении частоты при заданной ёмкости {1} ",
                Math.Round((f1 * Math.Pow((1 + (C1 / (C0 + Cy))), 0.5)), 3),
                 (f1 * Math.Pow((1 + (C1 / (C0 + Cy))), 0.5))-12800000));
            Console.WriteLine("управляющая ёмкость при заданнойотстройке частоты");
           Console.WriteLine(Math.Round((C1 / (Math.Pow(((fnob + deldafc) / f1), 2) - 1) - C0), 15));
            Console.WriteLine("Проверка частоы призаданном отклолнении");
              Console.WriteLine(f1*Math.Pow((1+(C1/(C0+ (C1 / (Math.Pow(((fnob + deldafc) / f1), 2) - 1) - C0)))),0.5));
           
         
               Console.ReadKey();
#endregion       
        }
    }
}
