using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi4
{
    class Bai4
    {
        public void TestB4()
        {
            Console.WriteLine("Nhap so nguyen a: ");
            int a = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Nhap so nguyen b: ");
            int b = Int32.Parse(Console.ReadLine());
            int tong = a + b;
            int hieu = a - b;
            int tich = a * b;
            double thuong = (double)a / b;

            Console.WriteLine("{0} + {1} = {2} ", a, b, tong);
            Console.WriteLine("{0} - {1} = {2} ", a, b, hieu);
            Console.WriteLine("{0} * {1} = {2} ", a, b, tich);
            Console.WriteLine("{0} / {1} = {2} ", a, b, thuong);
            Console.ReadKey();
        }
    }
}
