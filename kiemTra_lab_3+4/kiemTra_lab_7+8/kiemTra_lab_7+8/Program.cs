using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kiemTra_lab_7_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.GetEncoding("UTF-8");
            QuanLiSinhVien cn = new QuanLiSinhVien();
            int n;

            T:
            Console.Clear();
            Console.WriteLine("MENU");
            Console.WriteLine("1: Nhập danh sách sinh viên.");
            Console.WriteLine("2: Xuất danh sách. ");
            Console.WriteLine("3: Danh sách SV quan môn C#.");
            Console.WriteLine("4: Tìm sinh viên theo mã");
            Console.WriteLine("0: Thoát .");

            do
            {
                Console.Write("Mời bạn chọn chức năng: ");
                n = Convert.ToInt32(Console.ReadLine());

                switch (n)
                {
                    case 1:
                        Console.Clear();
                        cn.nhapDanhSach();
                        Console.ReadKey();
                        goto T;
                    case 2:
                        Console.Clear();
                        cn.xuatDanhSach();
                        Console.ReadKey();
                        goto T;
                    case 3:
                        Console.Clear();
                        cn.xuatDanhSachQuaMon();
                        Console.ReadKey();
                        goto T;
                    case 4:
                        Console.Clear();
                        cn.timSinhVienTheoMa();
                        Console.ReadKey();
                        goto T;
                    case 0:
                        Console.WriteLine("THANK YOU ...");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Bạn chọn sai chức năng, Vui lòng nhập lại !");
                        break;
                }
            } while (!(n == 0));

        }
    }
}
