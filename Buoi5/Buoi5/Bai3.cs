using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi5
{
    class Bai3
    {
        public void TestB3()
        {
            Console.WriteLine("Nhap so nguyen a: ");
            int a = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Nhap so nguyen b: ");
            int b = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Nhap dau toan tu: ");
            string dau = Console.ReadLine();
            switch (dau)
            {
                case "+": 
                    Console.WriteLine("Ket qua: " + (a + b));
                    break;
                case "-":
                    Console.WriteLine("Ket qua: " + (a - b));
                    break;
                case "*":
                    Console.WriteLine("Ket qua: " + (a * b));
                    break;
                case "/":
                    double thuong = (double)a / b; 
                    Console.WriteLine("Ket qua: " +thuong);
                    break;
                default: Console.WriteLine("Ban nhap khong dung dau toan tu");
                    break;

            }
            Console.ReadLine();
        }
    }
}
