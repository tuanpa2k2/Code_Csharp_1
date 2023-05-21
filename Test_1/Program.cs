using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.GetEncoding("UTF-8");
            QLSV cn = new QLSV();
            int s;

            T:
            Console.Clear();
            Console.WriteLine("MENU ");
            Console.WriteLine("1: Thêm danh sách");
            Console.WriteLine("2: Xuất danh sách");
            Console.WriteLine("3: Xuất danh sách qua môn C#");
            Console.WriteLine("4: Tìm theo mã");
            Console.WriteLine("5: Xuất danh sách theo số h dạy");
            Console.WriteLine("6: Xuất danh sách tuổi 20");
            Console.WriteLine("7: Sắp xếp sinh viên");
            Console.WriteLine("8: Xóa sinh viên");
            Console.WriteLine("9: Tìm sinh viên");
            Console.WriteLine("0: Thoát khỏi MENU");
            Console.Write("Mời bạn chọn chức năng: ");
            s = Convert.ToInt32(Console.ReadLine());

            switch (s)
            {
                case 2:
                    Console.Clear();
                    cn.xuatDanhSach();
                    Console.ReadKey();
                    goto T;
                case 3:
                    Console.Clear();
                    cn.danhSachQM();
                    Console.ReadKey();
                    goto T;
                case 4:
                    Console.Clear();
                    cn.timKiemMa();
                    Console.ReadKey();
                    goto T;
                case 5:
                    Console.Clear();
                    cn.khoangNhap();
                    Console.ReadKey();
                    goto T;
                case 6:
                    Console.Clear();
                    cn.tuoi20();
                    Console.ReadKey();
                    goto T;
                case 7:
                    Console.Clear();
                    cn.sapXepSinhVien();
                    Console.ReadKey();
                    goto T;
                case 8:
                    Console.Clear();
                    cn.xoaSinhVien();
                    Console.ReadKey();
                    goto T;
                case 9:
                    Console.Clear();
                    cn.timSinhVien();
                    Console.ReadKey();
                    goto T;
                case 0:
                    Console.WriteLine("Cảm ơn và hẹn gặp lại ...");
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Bạn chọn sai chức năng, Vui lòng nhập lại !");
                    break;
            }

        }
    }
}
