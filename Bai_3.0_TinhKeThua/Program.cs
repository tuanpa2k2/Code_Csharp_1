using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_3._0_TinhKeThua
{
    //Tạo 3 lớp đối tượng
    /*
     * 1. SinhVien(ten,ho,tendem,sdt,email,msv,diemJava,diemCsharp)
     * 2. GiaoVien(ten,ho,tendem,sdt,email,mgv,gioDay)
     * 3. KeToan(ten,ho,tendem,sdt,email,mnv,luong)
     */
    class Program
    {
        static void Main(string[] args)
        {
            // chương trình nhập đối tượng sinh viên
            Console.OutputEncoding = Encoding.GetEncoding("UTF-8");
            Console.WriteLine("BÀI 1: CHƯƠNG TRÌNH SINH VIÊN.\n");
            SinhVien sv1 = new SinhVien();
            Console.Write("Mời bạn nhập Họ: ");
            sv1.Ho = Console.ReadLine();
            Console.Write("Mời bạn nhập Tên đệm: ");
            sv1.TenDem = Console.ReadLine();
            Console.Write("Mời bạn nhập Tên: ");
            sv1.Ten = Console.ReadLine();
            Console.Write("Mời bạn nhập Sđt: ");
            sv1.Sdt = Console.ReadLine();
            Console.Write("Mời bạn nhập Email: ");
            sv1.Email = Console.ReadLine();
            Console.Write("mời bạn nhập Msv: ");
            sv1.Msv = Console.ReadLine();
            Console.Write("Mời bạn nhập điểm Java: ");
            sv1.DiemJava = Convert.ToDouble(Console.ReadLine());
            Console.Write("Mời bạn nhập điểm Csharp: ");
            sv1.DiemCsharp = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("------------------------------------------------------------------------");
            
            // chương trình nhập đối tượng giáo viên
            Console.WriteLine("BÀI 2: CHƯƠNG TRÌNH GIÁO VIÊN.\n");
            GiaoVien gv1 = new GiaoVien();
            Console.Write("Mời bạn nhập Họ: ");
            gv1.Ho = Console.ReadLine();
            Console.Write("Mời bạn nhập Tên đệm: ");
            gv1.TenDem = Console.ReadLine();
            Console.Write("Mời bạn nhập Tên: ");
            gv1.Ten = Console.ReadLine();
            Console.Write("Mời bạn nhập Sđt: ");
            gv1.Sdt = Console.ReadLine();
            Console.Write("Mời bạn nhập Email: ");
            gv1.Email = Console.ReadLine();
            Console.Write("Mời bạn nhập mã Giáo Viên: ");
            gv1.Mgv = Console.ReadLine();
            Console.Write("Số giờ dạy: ");
            gv1.GioDay = Console.ReadLine();
            Console.WriteLine("------------------------------------------------------------------------");

            Console.WriteLine("Kết quả bài 1: ");
            sv1.inRaManHinhSinhVien();
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine("Kết quả bài 2: ");
            gv1.inRaManHinhGiaoVien();
        }
    }
}
