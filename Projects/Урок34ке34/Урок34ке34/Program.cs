using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Урок34ке34
{
    class Program
    {
        static void Main(string[] args)
        {

            Func<int, int> fc = null;
            fc = i =>
            {
                Console.WriteLine(i);
                return i == 0 ? 0 : fc(--i);
            };

            fc(10);
            Console.ReadLine();
        }
    }
}
