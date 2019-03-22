using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лямблда_выражения
{
    public delegate int ArithmeticOperation(int x, int y);

    class Program
    {
        static void Main(string[] args)
        {



            Action action = null;

            for (int cycleCounter = 1; cycleCounter <= 4; cycleCounter++)
            {
                int buffer = cycleCounter;
                action += () => Console.WriteLine(buffer);
                
            }
            action();
            //Calculator1 calculator = new Calculator1();

            //Func<int, int, int> func = (x, y) => x - y;

            //Func<int, Func<int, int, int>, int> func2 = (k, f) => f(2, 3) * k;

            ////int result = func(3, 5);
            //Func<int, int> fc = null;
            //fc = i =>
            //{
            //    Console.WriteLine(i);
            //    return i == 0 ? 0 : fc(--i);
            //};
            //fc(10);

            //Console.WriteLine(func2(5,func));

            Console.ReadLine();

        }
    }
    public class Calculator
    {
        public ArithmeticOperation PlusFunction()
        {
            ArithmeticOperation func = delegate (int x, int y) { return x + y; };
            return func;
        }

        public ArithmeticOperation MinusFunction()
        {
            ArithmeticOperation func = delegate (int x, int y) { return x - y; };
            return func;
        }
    }

    public class Calculator1
    {
        public Func<int, int, int> PlusFunction()
        {
            Func<int,int,int> func = (x,y) =>x+y;
            return func;
        }

        public Func<int, int, int> MinusFunction()
        {
            Func<int, int, int> func = (x, y) => x - y;
            return func;
        }
    }
}
