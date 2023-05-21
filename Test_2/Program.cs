using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_2
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
            Console.WriteLine("1: Nhập sinh viên");
            Console.WriteLine("2: Xuất danh sách");
            Console.WriteLine("3: Xuất khoảng h dạy");
            Console.WriteLine("4: Tim SV theo mã");
            Console.WriteLine("5: Kế thừa");
            Console.WriteLine("0: THOÁT KHỎI MENU");
            Console.Write(" Mời bạn chọn: ");
            n = Convert.ToInt32(Console.ReadLine());

            switch (n)
            {
                case 1:
                    Console.Clear();
                    cn.themGiaoVien();
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
                    cn.timKiemTheoMa();
                    Console.ReadKey();
                    goto T;
                case 5:
                    Console.Clear();
                    cn.keThua();
                    Console.ReadKey();
                    goto T;
                case 0:
                    Console.WriteLine("THANK YOU, SEE YOU .");
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Bạn chọn sai chức năg, Vui lòng nhập lại !");
                    break;
            }


        }
    }
}
