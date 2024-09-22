using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Student
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

            int soLuongHocSinh = NhapSoLuongHocSinh();

            List<Student> danhSachHocSinh = new List<Student>();


            for (int i = 0; i < soLuongHocSinh; i++)
            {
                Console.WriteLine($"Nhập thông tin học sinh thứ {i + 1}:");

                Console.Write("ID: ");
                int id = int.Parse(Console.ReadLine());

                Console.Write("Tên: ");
                string name = Console.ReadLine();

                Console.Write("Tuổi: ");
                int age = int.Parse(Console.ReadLine());

                danhSachHocSinh.Add(new Student { ID = id, Name = name, Age = age });
            }

            // A. Xuất danh sách
            Console.WriteLine("\nA. Danh sách học sinh:");
            foreach (var hocSinh in danhSachHocSinh)
            {
                Console.WriteLine($"ID: {hocSinh.ID}, Tên: {hocSinh.Name}, Tuổi: {hocSinh.Age}");
            }

            // B. Tìm và in ra danh sách các học sinh có tuổi từ 15 đến 18
            var hocSinhTrongDoTuoi = danhSachHocSinh.Where(hs => hs.Age >= 15 && hs.Age <= 18);
            Console.WriteLine("\nB. Học sinh có tuổi từ 15 đến 18:");
            foreach (var hocSinh in hocSinhTrongDoTuoi)
            {
                Console.WriteLine($"ID: {hocSinh.ID}, Tên: {hocSinh.Name}, Tuổi: {hocSinh.Age}");
            }

            // C. Tìm và in ra học sinh có tên bắt đầu bằng chữ "A"
            var hocSinhTenBatDauA = danhSachHocSinh.Where(hs => hs.Name.StartsWith("A"));
            Console.WriteLine("\nC. Học sinh có tên bắt đầu bằng chữ 'A':");
            foreach (var hocSinh in hocSinhTenBatDauA)
            {
                Console.WriteLine($"ID: {hocSinh.ID}, Tên: {hocSinh.Name}, Tuổi: {hocSinh.Age}");
            }

            // D. Tính tổng tuổi của tất cả học sinh trong danh sách
            int tongTuoi = danhSachHocSinh.Sum(hs => hs.Age);
            Console.WriteLine($"\nD. Tổng tuổi của tất cả các học sinh: {tongTuoi}");

            // E. Tìm và in ra học sinh có tuổi lớn nhất
            var hocSinhLonTuoiNhat = danhSachHocSinh.OrderByDescending(hs => hs.Age).FirstOrDefault();
            Console.WriteLine($"\nE. Học sinh có tuổi lớn nhất: ID: {hocSinhLonTuoiNhat.ID}, Tên: {hocSinhLonTuoiNhat.Name}, Tuổi: {hocSinhLonTuoiNhat.Age}");

            // F. Sắp xếp danh sách học sinh theo tuổi tăng dần và in ra danh sách đã sắp xếp
            var hocSinhSapXepTheoTuoi = danhSachHocSinh.OrderBy(hs => hs.Age);
            Console.WriteLine("\nF. Danh sách học sinh đã sắp xếp theo tuổi tăng dần:");
            foreach (var hocSinh in hocSinhSapXepTheoTuoi)
            {
                Console.WriteLine($"ID: {hocSinh.ID}, Tên: {hocSinh.Name}, Tuổi: {hocSinh.Age}");
            }
        }
        static int NhapSoLuongHocSinh()
        {
            int soLuong;
            do
            {
                Console.Write("Nhập số lượng học sinh (ít nhất là 5): ");
                soLuong = int.Parse(Console.ReadLine());
                if (soLuong < 5)
                {
                    Console.WriteLine("Số lượng học sinh phải lớn hơn hoặc bằng 5. Vui lòng nhập lại.");
                }
            } while (soLuong < 5);

            return soLuong;
        }
        class Student
        {
            public int ID { get; set; }
            public string Name { get; set; }
            public int Age { get; set; }
        }
    }
}
