using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi5
{
    class BTVN02
    {
        public void TimMin()
        {
            Console.WriteLine("Nhap so nguyen n: ");
            int n = Int32.Parse(Console.ReadLine());
            int[] nums = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Nhap so nguyen thu {i + 1}: ");
                nums[i] = Int32.Parse(Console.ReadLine());
            }
            int min = nums[0];

            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] < min)
                {
                    min = nums[i];
                }
            }
            Console.WriteLine("So nho nhat la: {0}", min);
            Console.ReadLine();
        }
    }
}
