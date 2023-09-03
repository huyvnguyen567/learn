using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi6
{
    class Bai2
    {
        public void InMangHaiChieu()
        {
            int[,] mang = new int[3, 3];

            Console.WriteLine("Nhập giá trị cho mảng :");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"mang [{i}][{j}] = ");
                    mang[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("Các giá trị trong mảng:");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(mang[i, j] + " ");
                }
                Console.WriteLine(); // Xuống dòng sau mỗi hàng
            }
            Console.ReadLine();
        } 
        public void TongDuongCheo()
        {
            int[,] mang = {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9}
        };
            int numRows = mang.GetLength(0);
            int numCols = mang.GetLength(1);

            // Tính tổng đường chéo chính
            int tongDuongCheoChinh = 0;
            for (int i = 0; i < numRows; i++)
            {
                tongDuongCheoChinh += mang[i, i];
            }

            // Tính tổng đường chéo phụ
            int tongDuongCheoPhu = 0;
            for (int i = 0; i < numRows; i++)
            {
                tongDuongCheoPhu += mang[i, numRows - 1 - i];
            }

            Console.WriteLine($"Tổng đường chéo chính: {tongDuongCheoChinh}");
            Console.WriteLine($"Tổng đường chéo phụ: {tongDuongCheoPhu}");

            // Tính tổng các hàng và in ra màn hình
            Console.WriteLine("Tổng các hàng:");
            for (int i = 0; i < numRows; i++)
            {
                int rowSum = 0;
                for (int j = 0; j < numCols; j++)
                {
                    rowSum += mang[i, j];
                }
                Console.WriteLine($"Hàng {i + 1}: {rowSum}");
            }

            // Tính tổng các cột và in ra màn hình
            Console.WriteLine("Tổng các cột:");
            for (int j = 0; j < numCols; j++)
            {
                int colSum = 0;
                for (int i = 0; i < numRows; i++)
                {
                    colSum += mang[i, j];
                }
                Console.WriteLine($"Cột {j + 1}: {colSum}");
            }
            Console.ReadLine();
        }
        
    }
    
}
