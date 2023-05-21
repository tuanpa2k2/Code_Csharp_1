using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_TAP_MAU_OPP_CRUD
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.GetEncoding("UTF-8");
            ServiceSinhVien sv = new ServiceSinhVien();
            int n;
            do
            {
                Console.WriteLine("----- MENU các chức năng danh bạ của bạn -----");
                Console.WriteLine("1: THÊM - SỬA - XÓA NGƯỜI TRONG DANH BẠ.");
                Console.WriteLine("2: THÊM 15 NGƯỜI TẠO SẴN VÀO TRONG DANH BẠ.");
                Console.WriteLine("3: TÌM KIẾM NGƯỜI THEO TÊN HOẶC SỐ ĐIỆN THOẠI.");

                Console.Write(" --> Mời bạn chọn chức năng: ");
                n = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("--------------------------------------------------------------------------------------");

                switch (n)
                {
                    case 1:
                        Console.OutputEncoding = Encoding.GetEncoding("UTF-8");
                        int a;
                        do
                        {
                            Console.WriteLine(" 1: Thêm người vào trong danh bạ.");
                            Console.WriteLine(" 2: Sửa người vào trong danh bạ.");
                            Console.WriteLine(" 3: Xóa người vào trong danh bạ.");
                            Console.WriteLine(" 4: Thoát.");
                            Console.Write(" --> Mời bạn chọn chức năng: ");
                            a = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("--------------------------------------------------------------");
                            switch (a)
                            {
                                case 1:
                                    sv.themSV();
                                    break;
                                case 2:
                                    sv.suaSV();
                                    break;
                                case 3:
                                    sv.xoaSV();
                                    break;
                                default:
                                    Console.WriteLine("Bạn chọn sai chức năng, Vui lòng nhập lại !");
                                    break;
                            } 
                        } while (!(a == 4));
                        Console.WriteLine("---> Thanks You.");
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.OutputEncoding = Encoding.GetEncoding("UTF-8");
                        int b;
                        do
                        {
                            Console.WriteLine(" 1: Tìm theo tên.");
                            Console.WriteLine(" 2: Tìm theo SĐT.");
                            Console.WriteLine(" 3: Thoát.");
                            Console.Write(" --> Mời bạn chọn chức năng: ");
                            b = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("--------------------------------------------------------------");
                            switch (b)
                            {
                                case 1:
                                    sv.timKiemSV();
                                    break;
                                case 2:
                                    
                                    break;
                                default:
                                    Console.WriteLine("Bạn chọn sai chức năng, Vui lòng nhập lại !");
                                    break;
                            }
                        } while (!(b == 3));
                        Console.WriteLine("---> Thanks You.");
                        Console.ReadKey();
                        break;
                    default:
                        Console.WriteLine("Bạn chọn sai chức năng, Vui lòng nhập lại !");
                        break;
                }
            } while (!(n == 7));
            Console.WriteLine("---> Thanks You.");
            Console.ReadKey();
        }
    }
}
