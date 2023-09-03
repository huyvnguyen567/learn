using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi5
{
    class BTVN03
    {
        public void TimMax()
        {
            Console.WriteLine("Nhap so nguyen n: ");
            int n = Int32.Parse(Console.ReadLine());
            int[] nums = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Nhap so nguyen thu {i + 1}: ");
                nums[i] = Int32.Parse(Console.ReadLine());
            }
            int max = nums[0];

            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] > max)
                {
                    max = nums[i];
                }
            }
            Console.WriteLine("So lon nhat la: {0}", max);
            Console.ReadLine();
        }
    }
}
