using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi5
{
    class Bai4
    {
        public void TestB4()
        {
            Console.WriteLine("Nhap so nguyen duong n:");
            int n = Int32.Parse(Console.ReadLine());
            int tong = 0;
            for (int i = 1; i <= n; i++)
            {
                tong += i;
            }
            Console.WriteLine("Tong tu 1 den {0} la {1}: ", n, tong);
            while (n != 0)
            {
                tong += n;
                n--;
            }
            Console.WriteLine("Tong tu 1 den {0} la {1}: ", n, tong);
            do
            {
                tong += n;
                n--;
            }
            while (n != 0);
            Console.WriteLine("Tong tu 1 den {0} la {1}: ", n, tong);
            Console.ReadLine();
        }
    }
}
