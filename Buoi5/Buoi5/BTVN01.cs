using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi5
{
    class BTVN01
    {
        class Student
        {
            public string HoTen { get; set; }
            public double DiemTB { get; set; }
        }
        public void InHocLucHocSinh()
        {
            List<Student> students = new List<Student>();

            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Nhap ten hoc sinh thu {i + 1}: ");
                string hoTen = Console.ReadLine();

                Console.Write($"Nhap diem trung binh cua hoc sinh {hoTen}: ");
                double diemTB = double.Parse(Console.ReadLine());

                students.Add(new Student { HoTen = hoTen, DiemTB = diemTB });
            }
            List<Student> xuatSac = new List<Student>();
            List<Student> gioi = new List<Student>();
            List<Student> kha = new List<Student>();
            List<Student> trungBinh = new List<Student>();
            List<Student> yeu = new List<Student>();
            foreach(Student hocsinh in students)
            {
                if(hocsinh.DiemTB >= 9)
                {
                    xuatSac.Add(hocsinh);
                }
                else if(hocsinh.DiemTB >= 8)
                {
                    gioi.Add(hocsinh);
                }
                else if(hocsinh.DiemTB>= 6.5)
                {
                    kha.Add(hocsinh);
                }
                else if(hocsinh.DiemTB >= 5)
                {
                    trungBinh.Add(hocsinh);
                }
                else
                {
                    yeu.Add(hocsinh);
                }
            }
            Console.Write("Danh sach hoc sinh xuat sac: ");
            foreach(Student student in xuatSac)
            {
                Console.Write(student.HoTen + " ");
            }
            Console.Write("\nDanh sach hoc sinh gioi: ");
            foreach (Student student in gioi)
            {
                Console.Write(student.HoTen + " ");
            }
            Console.Write("\nDanh sach hoc sinh kha: ");
            foreach (Student student in kha)
            {
                Console.Write(student.HoTen + " ");
            }
            Console.Write("\nDanh sach hoc sinh trung binh: ");
            foreach (Student student in trungBinh)
            {
                Console.Write(student.HoTen + " ");
            }
            Console.Write("\nDanh sach hoc sinh yeu: ");
            foreach (Student student in yeu)
            {
                Console.Write(student.HoTen + " ");
            }
            Console.ReadLine();
          
        }
    }
}
