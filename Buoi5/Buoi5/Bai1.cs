using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi5
{
    class Bai1
    {
        public void TestB1()
        {
            int i = 0;
            lap:
            Console.WriteLine("Welcom to HBAcademy!");
            i++;
            if (i < 10)
                goto lap;
            Console.ReadLine();
        }
    }
}
