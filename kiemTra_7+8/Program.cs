using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kiemTra_7_8
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
            Console.WriteLine("MENU");
            Console.WriteLine("1: Nhập danh sách");
            Console.WriteLine("2: Xuất danh sách");
            Console.WriteLine("3: Xuất danh sách SV qua môn C#");
            Console.WriteLine("4: Tìm SV theo ma");
            Console.WriteLine("0: Thoát khỏi MENU");
            do
            {
                Console.Write("Mời bạn chọn chức năng: ");
                s = Convert.ToInt32(Console.ReadLine());

                switch (s)
                {
                    case 1:
                        Console.Clear();
                        cn.themDanhSach();
                        Console.ReadKey();
                        goto T;
                    case 2:
                        Console.Clear();

                        Console.ReadKey();
                        goto T;
                    case 3:
                        Console.Clear();

                        Console.ReadKey();
                        goto T;
                    case 4:
                        Console.Clear();

                        Console.ReadKey();
                        goto T;
                    case 0:
                        Console.WriteLine("THANKS YOU ....");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Bạn chọn sai chức năng, Vui lòng nhập lại !");
                        break;
                }

            } while (!(s == 0));
        }
    }
}
