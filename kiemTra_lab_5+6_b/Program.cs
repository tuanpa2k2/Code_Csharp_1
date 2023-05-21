using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kiemTra_lab_5_6_b
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.GetEncoding("UTF-8");
            ChucNang cn = new ChucNang();
            int n;
        T:

            Console.Clear();
            Console.WriteLine("   MENU");
            Console.WriteLine("1: Thêm 5 sinh viên.");
            Console.WriteLine("2: Tìm kiếm theo mã sinh viên");
            Console.WriteLine("3: Sắp xếp theo tên A-Z");
            Console.WriteLine("4: Thoát...");

            do
            {
                Console.Write("Mời bạn chọn chức năg: ");
                n = Convert.ToInt32(Console.ReadLine());

                switch (n)
                {
                    case 1:
                        Console.Clear();
                        cn.inSinhVien();
                        Console.ReadKey();
                        goto T;
                    case 2:
                        Console.Clear();
                        cn.timKiemSinhVien();
                        Console.ReadKey();
                        goto T;
                    case 3:
                        Console.Clear();
                        cn.sapXepSinhVien();
                        Console.ReadKey();
                        goto T;
                    case 4:
                        Console.WriteLine("THANK YOU ...");
                        Console.ReadKey();
                        break;
                    default:
                        Console.WriteLine("Bạn chọn sai chức năg, Vui lòng nhập lại !");
                        break;
                }

            } while (!(n == 4));

        }
    }
}
