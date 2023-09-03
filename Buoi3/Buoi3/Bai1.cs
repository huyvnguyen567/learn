using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi3
{
    class Bai1
    {
        // Khai báo kiểu liệt kê cho các màu sắc
        enum Color
        {
            Red,
            Green,
            Blue,
            Yellow,
            Orange,
            Purple,
            Pink
            // Bạn có thể thêm các màu sắc khác vào đây
        }
        public void TestB1()
        {
            Console.WriteLine("Các màu sắc có trong liệt kê:");

            //// Lấy danh sách các giá trị của kiểu liệt kê Color
            //Color[] colors = (Color[])Enum.GetValues(typeof(Color));

            //// Hiển thị từng màu sắc
            //foreach (Color color in colors)
            //{
            //    Console.WriteLine(color);
            //}
            //Console.ReadLine();
            Console.WriteLine(Color.Red);
            Console.WriteLine(Color.Green);
            Console.WriteLine(Color.Blue);
            Console.WriteLine(Color.Yellow);
            Console.WriteLine(Color.Orange);
            Console.WriteLine(Color.Purple);
            Console.WriteLine(Color.Pink);

            Console.ReadLine();

        }
    }
}
