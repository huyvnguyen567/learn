using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi3
{
    class Bai2
    {
        struct BangDiem
        {
            public double Toan;
            public double Ly;
            public double Hoa;
        }

        struct SinhVien
        {
            public string HoTen;
            public DateTime NamSinh;
            public string QueQuan;
            public BangDiem Diem;
        }

        public void TestB2()
        {
            SinhVien sinhVien1;
            SinhVien sinhVien2;
            SinhVien sinhVien3;

            Console.WriteLine("Nhập thông tin cho sinh viên thứ 1:");
            Console.Write("Họ và tên: ");
            sinhVien1.HoTen = Console.ReadLine();

            Console.Write("Ngày tháng năm sinh (dd/mm/yyyy): ");
            sinhVien1.NamSinh = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);

            Console.Write("Quê quán: ");
            sinhVien1.QueQuan = Console.ReadLine();

            Console.Write("Điểm Toán: ");
            sinhVien1.Diem.Toan = double.Parse(Console.ReadLine());

            Console.Write("Điểm Lý: ");
            sinhVien1.Diem.Ly = double.Parse(Console.ReadLine());

            Console.Write("Điểm Hóa: ");
            sinhVien1.Diem.Hoa = double.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine("Nhập thông tin cho sinh viên thứ 2:");
            Console.Write("Họ và tên: ");
            sinhVien2.HoTen = Console.ReadLine();

            Console.Write("Ngày tháng năm sinh (dd/mm/yyyy): ");
            sinhVien2.NamSinh = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);

            Console.Write("Quê quán: ");
            sinhVien2.QueQuan = Console.ReadLine();

            Console.Write("Điểm Toán: ");
            sinhVien2.Diem.Toan = double.Parse(Console.ReadLine());

            Console.Write("Điểm Lý: ");
            sinhVien2.Diem.Ly = double.Parse(Console.ReadLine());

            Console.Write("Điểm Hóa: ");
            sinhVien2.Diem.Hoa = double.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine("Nhập thông tin cho sinh viên thứ 3:");
            Console.Write("Họ và tên: ");
            sinhVien3.HoTen = Console.ReadLine();

            Console.Write("Ngày tháng năm sinh (dd/mm/yyyy): ");
            sinhVien3.NamSinh = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);

            Console.Write("Quê quán: ");
            sinhVien3.QueQuan = Console.ReadLine();

            Console.Write("Điểm Toán: ");
            sinhVien3.Diem.Toan = double.Parse(Console.ReadLine());

            Console.Write("Điểm Lý: ");
            sinhVien3.Diem.Ly = double.Parse(Console.ReadLine());

            Console.Write("Điểm Hóa: ");
            sinhVien3.Diem.Hoa = double.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine("Thông tin của 3 sinh viên:");
            Console.WriteLine("Sinh viên thứ 1:");
            Console.WriteLine($"Họ và tên: {sinhVien1.HoTen}");
            Console.WriteLine($"Ngày tháng năm sinh: {sinhVien1.NamSinh.ToString("dd/MM/yyyy")}");
            Console.WriteLine($"Quê quán: {sinhVien1.QueQuan}");
            Console.WriteLine($"Điểm Toán: {sinhVien1.Diem.Toan}");
            Console.WriteLine($"Điểm Lý: {sinhVien1.Diem.Ly}");
            Console.WriteLine($"Điểm Hóa: {sinhVien1.Diem.Hoa}");
            Console.WriteLine();

            Console.WriteLine("Sinh viên thứ 2:");
            Console.WriteLine($"Họ và tên: {sinhVien2.HoTen}");
            Console.WriteLine($"Ngày tháng năm sinh: {sinhVien2.NamSinh.ToString("dd/MM/yyyy")}");
            Console.WriteLine($"Quê quán: {sinhVien2.QueQuan}");
            Console.WriteLine($"Điểm Toán: {sinhVien2.Diem.Toan}");
            Console.WriteLine($"Điểm Lý: {sinhVien2.Diem.Ly}");
            Console.WriteLine($"Điểm Hóa: {sinhVien2.Diem.Hoa}");
            Console.WriteLine();

            Console.WriteLine("Sinh viên thứ 3:");
            Console.WriteLine($"Họ và tên: {sinhVien3.HoTen}");
            Console.WriteLine($"Ngày tháng năm sinh: {sinhVien3.NamSinh.ToString("dd/MM/yyyy")}");
            Console.WriteLine($"Quê quán: {sinhVien3.QueQuan}");
            Console.WriteLine($"Điểm Toán: {sinhVien3.Diem.Toan}");
            Console.WriteLine($"Điểm Lý: {sinhVien3.Diem.Ly}");
            Console.WriteLine($"Điểm Hóa: {sinhVien3.Diem.Hoa}");
            Console.WriteLine();
        }
    }
}
