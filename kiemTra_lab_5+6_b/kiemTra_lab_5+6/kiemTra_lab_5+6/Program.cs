using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kiemTra_lab_5_6
{
    //    Đề 1: Viết 1 chương trình các chức năng sau: (SwitchCase - While)

    //1.      Thêm 5 sinh viên bằng contructor không tham số(Tên,
    //Mã, Điểm Java - double, Điểm Csharp - double) – (5 Điểm)

    //2.      Tìm kiếm sinh viên theo mã(3- Điểm) – Sử dụng List

    //3.      Sắp xếp tăng dần(1 - Điểm)

    //4.      Thoát

    //Triển khai bài: Có lớp đối tượng riêng, lớp chức năng riêng,
    //và main riêng. 1 Điểm còn lại các thành phần nhỏ trong bài.
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.GetEncoding("UTF-8");
            ChucNang cn = new ChucNang();
            int n;
        T:
            Console.Clear();
            Console.WriteLine("----MENU----");
            Console.WriteLine("1: Thêm 5 đối tượng .");
            Console.WriteLine("2: Tim kiếm sinh viên theo mã .");
            Console.WriteLine("3: Sắp xếp tăng dần .");
            Console.WriteLine("4: Thoát .");

            do
            {
                Console.Write("Mời bạn chọn chức năng: ");
                n = Convert.ToInt32(Console.ReadLine());
                switch (n)
                {
                    case 1:
                        Console.Clear();
                        cn.xuatDanhSach();
                        Console.ReadKey();
                        goto T;
                    case 2:
                        Console.Clear();
                        cn.timKiemSinhVien();
                        Console.ReadKey();
                        goto T;
                    case 3:
                        Console.Clear();
                        cn.sapXep();
                        Console.ReadKey();
                        goto T;
                    case 4:
                        Console.WriteLine("Thank you ...");
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Bạn chọn sai chức năg, Vui lòng nhập lại.");
                        break;
                }
            } while (!(n == 4));
        }
    }
}
