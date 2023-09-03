using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi5
{
    class BTVN04
    {
        public void TimSoChan()
        {
            Console.WriteLine("Nhap so nguyen n: ");
            int n = Int32.Parse(Console.ReadLine());
            int[] nums = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Nhap so nguyen thu {i + 1}: ");
                nums[i] = Int32.Parse(Console.ReadLine());
            }
            Console.Write("Tat ca so chan: ");
            foreach(int num in nums)
            {
                if(num % 2 == 0)
                {
                    Console.Write(num + " ");
                }
            }
            Console.ReadLine();
        }
    }
}
