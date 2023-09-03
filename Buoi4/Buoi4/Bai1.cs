using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi4
{
    class Bai1
    {
        public void TestB1()
        {
            Console.WriteLine("Nhap so nguyen a: ");
            int a = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Nhap so nguyen b: ");
            int b = Int32.Parse(Console.ReadLine());

            int tong = a + b;
            Console.WriteLine("Tong a va b: " + tong);
            Console.ReadKey();

        }
    }
}
