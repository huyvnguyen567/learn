using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi6
{
    class Bai1
    {
        public void InPhanTu()
        {
            string[] names = { "huy", "quang", "trong", "tuan anh" };
            Console.WriteLine("Thu tu ten thuan chieu: ");
            foreach(var name in names)
            {
                Console.Write(name + " ");
            }
            Console.WriteLine("\nThu tu ten nguoc chieu: ");
            for (int i = names.Length; i > 0; i--)
            {
                Console.Write(names[i] + " ");
            }
            Console.ReadLine();
        }
        public void TongPhanTu()
        {
            int[] numbers = { -2, 5, 6, 3, 7 };
            int count = 0;
            for(int i = 0; i < numbers.Length; i++)
            {
                count += numbers[i];
            }
            Console.WriteLine("Tong cac phan tu la: " + count);
            int countChan = 0;
            int countLe = 0;
            int countDuong = 0;

            foreach (int num in numbers)
            {
                if(num % 2 == 0)
                {
                    countChan += num;
                }
                else
                {
                    countLe += num;
                }
            }
            Console.WriteLine("Tong cac phan tu chan la: " + countChan);
            Console.WriteLine("Tong cac phan tu le la: " + countLe);
            foreach(int num in numbers)
            {
                if (num > 0)
                {
                    countDuong += num;
                }
            }
            Console.WriteLine("Tong cac phan tu duong la: " + countDuong);
            Console.ReadLine();
        }
        public void DemPhanTu()
        {
            int[] numbers = { -2, 5, 6, 3, 7 };
            int demChan = 0;
            int demLe = 0;
            foreach (int num in numbers)
            {
                if (num > 0)
                {
                    demChan ++;
                }
                else
                {
                    demLe++;
                }
            }
            Console.WriteLine("\nTong cac phan tu am la: " + demLe);
            Console.ReadLine();
        }
        public void TimPhanTuMaxMin()
        {
            int[] numbers = { -2, 5, 6, 3, 7, 8, 0 };
            int min = numbers[0];

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] < min)
                {
                    min = numbers[i];
                }
            }
            Console.WriteLine("So nho nhat la: {0}", min);
            int max = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] > max)
                {
                    max = numbers[i];
                }
            }
            Console.WriteLine("So lon nhat la: {0}", max);
            int n = 3;
            Array.Sort(numbers);

            Console.WriteLine("So lon thu {0} la: {1}", n, numbers[numbers.Length - n]);
            Console.WriteLine("So nho thu {0} la: {1}", n, numbers[n - 1]);

            Console.ReadLine();
        

        }
        public void ChenPhanTu()
        {
            int[] numbers = { -2, 5, 6, 3, 7, 8, 0 };
            int elementToInsert = 10; // Phần tử cần chèn
            int positionToInsert = 2; // Vị trí cần chèn

            // Tạo mảng mới với kích thước tăng lên 1 đơn vị
            int[] newArr = new int[numbers.Length + 1];

            // Sao chép các phần tử từ mảng cũ vào mảng mới cho đến vị trí cần chèn
            for (int i = 0; i < positionToInsert; i++)
            {
                newArr[i] = numbers[i];
            }

            // Chèn phần tử vào vị trí cần chèn
            newArr[positionToInsert] = elementToInsert;

            // Sao chép các phần tử còn lại từ mảng cũ vào mảng mới
            for (int i = positionToInsert + 1; i < newArr.Length; i++)
            {
                newArr[i] = numbers[i - 1];
            }

            // In ra mảng sau khi chèn
            foreach (int i in newArr)
            {
                Console.Write(i + " ");
            }
            Console.ReadLine();
        }
        public void XoaPhanTu()
        {
            int[] numbers = { -2, 5, 6, 3, 7, 8, 0 };
            int positionToRemove = 2; // Vị trí cần xóa

            // Tạo mảng mới với kích thước giảm đi 1 đơn vị
            int[] newArr = new int[numbers.Length - 1];

            // Sao chép các phần tử từ mảng cũ vào mảng mới, bỏ qua phần tử cần xóa
            int newIndex = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (i != positionToRemove)
                {
                    newArr[newIndex] = numbers[i];
                    newIndex++;
                }
            }

            // In ra mảng sau khi xóa
            foreach (int i in newArr)
            {
                Console.Write(i + " ");
            }
            Console.ReadLine();

        }
        public void TimViTriDauTien()
        {
            int[] numbers = { -2, 5, 6, 3, 7, 8, 0 };
            int targetValue = 3; // Giá trị cần tìm

            int index = Array.IndexOf(numbers, targetValue);

            if (index != -1)
            {
                Console.WriteLine($"Vị trí đầu tiên của giá trị {targetValue} trong mảng là: {index}");
            }
            else
            {
                Console.WriteLine($"Giá trị {targetValue} không tồn tại trong mảng.");
            }
            Console.ReadLine();
        }
        public void MangChanLe()
        {
            int[] numbers = { -2, 5, 6, 3, 7, 8, 0 };
            int[] mangchan, mangLe;

            // Xác định kích thước của hai mảng con
            int demChan = 0, demLe = 0;
            foreach (int element in numbers)
            {
                if (element % 2 == 0)
                    demChan++;
                else
                    demLe++;
            }

            mangchan = new int[demChan];
            mangLe = new int[demLe];

            // Sao chép các phần tử vào mảng chẵn và mảng lẻ
            int indexChan = 0, indexLe = 0;
            foreach (int element in numbers)
            {
                if (element % 2 == 0)
                    mangchan[indexChan++] = element;
                else
                    mangLe[indexLe++] = element;
            }

            Console.WriteLine("Mảng chẵn:");
            foreach (int element in mangchan)
            {
                Console.Write(element + " ");
            }

            Console.WriteLine("\nMảng lẻ:");
            foreach (int element in mangLe)
            {
                Console.Write(element + " ");
            }
            Console.ReadLine();
        }
        public void SapXepTangGiam()
        {
            int[] numbers = { -2, 5, 6, 3, 7, 8, 0 };

            Array.Sort(numbers);

            Console.WriteLine("Mảng tăng dần:");
            foreach (int element in numbers)
            {
                Console.Write(element + " ");
            }
            Array.Reverse(numbers);

            Console.WriteLine("\nMảng giảm dần:");
            foreach (int element in numbers)
            {
                Console.Write(element + " ");
            }
            Console.ReadLine();
        }
    }
    
}
