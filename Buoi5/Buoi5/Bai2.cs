using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi5
{
    class Bai2
    {
        public void TestB2()
        {
            Console.WriteLine("Nhap so nguyen a: ");
            int a = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Nhap so nguyen b: ");
            int b = Int32.Parse(Console.ReadLine());
            if (a > 0)
            {
                if (b > 0)
                {
                    Console.WriteLine("a: {0}, b: {1}", a, b);
                }
                else
                {
                    Console.WriteLine("a: {0}", a);
                }
            }
            else
            {
                if (b > 0)
                {
                    Console.WriteLine("b: {0}", b);
                }
                else
                {
                    Console.WriteLine("Khong co so nao lon hon 0");
                }
            }
            Console.ReadLine();
        }
    }
}
