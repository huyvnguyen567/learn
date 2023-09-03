using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi4
{
    class Bai8
    {
        public void TestB8()
        {
            Console.WriteLine("Nhap C: ");
            int doC = Convert.ToInt32(Console.ReadLine());
            double doK = doC + 273.5;
            double doF = doC * 1.8 + 32;
            Console.WriteLine("C: {0}", doC);
            Console.WriteLine("K: {0}", doK);
            Console.WriteLine("F: {0}", doF);
            Console.ReadKey();
        }
    }
}
