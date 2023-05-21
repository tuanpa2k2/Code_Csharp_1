using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kiemTra_lab_3_4
{
//    Đề 1: Viết 1 chương trình các chức năng sau: (SwitchCase - While)

//1.      
//Thêm 1 sinh viên bằng contructor không tham số(Tên,
//Mã, Điểm Java - double, Điểm Csharp - double) – (5 Điểm)

//2.      
//Thêm nhiều sinh viên(3- Điểm) – Sử dụng List

//3.      
//Xuất sinh viên ra màn hình. (1 - Điểm)

//4.      
//Thoát

//Triển khai bài: Có lớp đối tượng riêng, lớp chức năng riêng,
//và main riêng. 1 Điểm còn lại các thành phần nhỏ trong bài.
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.GetEncoding("UTF-8");
            int n;
            Console.WriteLine("----MENU CHƯƠNG TRÌNH----");
            Console.WriteLine("1: Thêm 1 sinh viên bằng contructor không tham số.");
            Console.WriteLine("2: Thêm nhiều sinh viên – Sử dụng List");
            Console.WriteLine("3: Xuất sinh viên ra màn hình.");
            Console.WriteLine("4: Thoát .");
            
            do
            {
                Console.Write("Mời bạn chọn chức năng: ");
                n = Convert.ToInt32(Console.ReadLine());
            } while (n < 1 || n > 4);
            Console.WriteLine("-------------------------------------------------------------");

            switch (n)
            {
                case 1:
                    Console.WriteLine("=> Welcome to CN1 .");
                    Functions serviceB_1 = new Functions();
                    serviceB_1.bai1_ThemMotSinhVien();
                    Console.ReadKey();
                    break;
                case 2:
                    Console.WriteLine("=> Welcome to CN2 .");
                    Functions serviceB_2 = new Functions();
                    serviceB_2.bai2_ThemNhieuSinhVienSuDung_List();
                    Console.ReadKey();
                    break;
                case 3:
                    Console.WriteLine("=> Welcome to CN3 .");

                    Console.ReadKey();
                    break;
                case 4:
                    Console.WriteLine("Cảm ơn bạn đã dùng MENU này - See you !");
                    Environment.Exit(0);
                    break;
                default:
                    break;
            }

        }
    }
}
