using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi4
{
    class Bai2
    {
        public void TestB2()
        {
            Console.WriteLine("Nhap so nguyen a: ");
            int a = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Nhap so nguyen b: ");
            int b = Int32.Parse(Console.ReadLine());
            int phanNguyen = a / b;
            int phanDu = a % b;
            Console.WriteLine("{0} : {1} = {2} dư {3}", a, b, phanNguyen, phanDu);
           
            Console.ReadKey();
        }
    }
}
