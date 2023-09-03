using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi4
{
    class Bai7
    {
        public void TestB7()
        {
            Console.WriteLine("Nhap so nguyen a: ");
            int a = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Nhap so nguyen b: ");
            int b = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Nhap so nguyen c: ");
            int c = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Nhap so nguyen d: ");
            int d = Int32.Parse(Console.ReadLine());
            double TBC = (double)(a + b + c + d) / 4;
            Console.WriteLine("Trung binh cong cua {0}, {1}, {2} va {3} la: {4}", a, b, c, d, TBC);
            Console.ReadKey();
        }
    }
}
