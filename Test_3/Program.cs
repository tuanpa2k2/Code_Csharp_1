using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.GetEncoding("UTF-8");
            QLGV cn = new QLGV();
            int n;
        T:
            Console.Clear();
            Console.WriteLine("MENU");
            Console.WriteLine("1: Nhập");
            Console.WriteLine("2: Xuất ");
            Console.WriteLine("3: Khoảng nhập ");
            Console.WriteLine("4: tìm theo id ");
            Console.WriteLine("5: ke thừa");
            Console.WriteLine("0: THOÁT KHỎI MENU");
            Console.Write("Mời bạn chọn chức năng: ");
            n = Convert.ToInt32(Console.ReadLine());

            switch (n)
            {
                case 1:
                    Console.Clear();
                    cn.themDanhSach();
                    Console.ReadKey();
                    goto T;
                case 2:
                    Console.Clear();
                    cn.xuatDanhSach();
                    Console.ReadKey();
                    goto T;
                case 3:
                    Console.Clear();
                    cn.khoangNhap();
                    Console.ReadKey();
                    goto T;
                case 4:
                    Console.Clear();
                    cn.timKiemTheoID();
                    Console.ReadKey();
                    goto T;
                case 5:
                    Console.Clear();
                    cn.keThua();
                    Console.ReadKey();
                    goto T;
                case 0:
                    Console.WriteLine("  THANK YOU, SEE YOU !");
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Bạn chọn sai chức năg, Vui lòng nhập lại !");
                    break;
            }

        }
    }
}
