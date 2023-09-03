using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi4
{
    class Bai5
    {
        public void TestB5()
        {
            Console.WriteLine("Nhap so nguyen a: ");
            int a = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Nhap so nguyen b: ");
            int b = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Truoc khi hoan doi a va b");
            Console.WriteLine("a = {0}, b = {1}", a, b);

            int temp = a;
            a = b;
            b = temp;
            Console.WriteLine("Sau khi hoan doi a va b");
            Console.WriteLine("a = {0}, b = {1}", a, b);
            Console.ReadKey();
        }
    }
}
