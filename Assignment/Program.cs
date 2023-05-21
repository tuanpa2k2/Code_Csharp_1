using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    //Viết 1 chương trình quản lý danh bạ điện thoại FPOLY dựa theo các yêu cầu sau
    //Cấu trúc Project bao gồm:

    //Main.Class(Bao gồm hàm main, menu)
    //Nguoi.Class(Lớp cha - Bao gồm các thuộc tính: Ho, Ten, TenDem, NamSinh, GioITinh - inRaManHinh())
    //DanhBa.Class(Lớp con - Kế thừa các thuộc tính của lớp cha Bao gồm các thuộc tính riêng của đối tượng như: Sdt1, Sdt2, Email, GhiChu, - Hàm ToString() và kế thừa hàm inRaManHinh() từ lớp cha)
    //ServiceDanhBa.Class(Bao gồm các chức năng của bài toán)

    //Các chức năng chương trình cần có:
    //THÊM - SỬA - XÓA NGƯỜI TRONG DANH BẠ
    //THÊM 15 NGƯỜI TẠO SẴN VÀO TRONG DANH BẠ
    //TÌM KIẾM NGƯỜI THEO TÊN HOẶC SỐ ĐIỆN THOẠI
    //LOAD TẤT TT CẢ NGƯỜI TRONG DANH BẠ - (Lưu ý: Khi hiển thị những người nào lớn tuổi hơn mình dựa theo năm sinh thì hiện thị là ANH - CHỊ - EM trước Tên)
    //TÌM KIẾM THEO SỐ ĐIỆN THOẠI GẦN ĐÚNG
    //TÌM KIẾM THEO TÊN GẦN ĐÚNG
    //SẮP XẾP DANH BẠ THEO NGƯỢC VÀ XUÔI DO NGƯỜI DÙNG CHỌN

    //Cách thức lấy điểm
    //Áp dụng kiến thức được học và List || ArrayList đối tượng trong bài toán tối đa 8 điểm.
    //Áp dụng các kiến thức được học như check lỗi nhập vào của người dùng, Viết hoa chữ cái đầu Họ & Tên và sử List || ArrayList đối tượng trong bài toán tối đa 10 điểm.
    //Vấn đáp code!
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.GetEncoding("UTF-8");
            ServiceDanhBa dB = new ServiceDanhBa();
            int n;
        T:
            Console.Clear();  // clear sang tab mới.
            Console.WriteLine("      ----- MENU CÁC CHỨC NĂNG TRONG DANH BẠ -----");
            Console.WriteLine(" +-------------------------------------------------------------+");
            Console.WriteLine("| 1: THÊM - SỬA - XÓA NGƯỜI TRONG DANH BẠ.                      |");
            Console.WriteLine("| 2: TÌM KIẾM NGƯỜI THEO TÊN HOẶC SỐ ĐIỆN THOẠI.                |");
            Console.WriteLine("| 3: LOADIND TẤT THÔNG TIN CẢ NGƯỜI TRONG DANH BẠ.              |");
            Console.WriteLine("| 4: TÌM KIẾM THEO SỐ ĐIỆN THOẠI GẦN ĐÚNG.                      |");
            Console.WriteLine("| 5: TÌM KIẾM THEO TÊN NGƯỜI GẦN ĐÚNG.                          |");
            Console.WriteLine("| 6: SẮP XẾP DANH BẠ THEO NGƯỢC VÀ XUÔI DO NGƯỜI DÙNG CHỌN.     |");
            Console.WriteLine("| 7: THOÁT KHỎI MENU ...!                                       |");
            Console.WriteLine("*---------------------------------------------------------------*");

            do
            {
                Console.Write(" --> Mời bạn chọn chức năng: ");
                n = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("--------------------------------------------------------------------------------------");

                switch (n)
                {
                    case 1:
                        Console.Clear();
                        int a;
                    P:
                        Console.Clear();
                        Console.WriteLine("--------------------------------------------------------------");
                        Console.WriteLine(" 1: Thêm người vào trong danh bạ.");
                        Console.WriteLine(" 2: Sửa người vào trong danh bạ.");
                        Console.WriteLine(" 3: Xóa người vào trong danh bạ.");
                        Console.WriteLine(" 4: Thoát.");
                        do
                        {
                            Console.Write(" --> Mời bạn chọn chức năng: ");
                            a = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("--------------------------------------------------------------");
                            switch (a)
                            {
                                case 1:
                                    Console.Clear();
                                    dB.themNguoi();
                                    Console.ReadKey();
                                    goto P;
                                case 2:
                                    Console.Clear();
                                    dB.suaNguoi();
                                    Console.ReadKey();
                                    goto P;
                                case 3:
                                    Console.Clear();
                                    dB.xoaNguoi();
                                    Console.ReadKey();
                                    goto P;
                                case 4:
                                    Console.WriteLine("---> Thanks You .");
                                    break;
                                default:
                                    Console.WriteLine("Bạn chọn sai chức năng, Vui lòng nhập lại !");
                                    break;
                            }
                        } while (!(a == 4));
                        goto T;
                    case 2:
                        int b;
                    K:
                        Console.Clear();
                        Console.WriteLine("--------------------------------------------------------------");
                        Console.WriteLine(" 1: Tìm theo Tên.");
                        Console.WriteLine(" 2: Tìm theo SĐT.");
                        Console.WriteLine(" 3: Thoát.");
                        do
                        {
                            Console.Write(" --> Mời bạn chọn chức năng: ");
                            b = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("--------------------------------------------------------------");
                            switch (b)
                            {
                                case 1:
                                    dB.timKiemNguoi();
                                    Console.ReadKey();
                                    goto K;
                                case 2:
                                    dB.timKiemsdt();
                                    Console.ReadKey();
                                    goto K;
                                case 3:
                                    Console.WriteLine("---> Thanks You.");
                                    break;
                                default:
                                    Console.WriteLine("Bạn chọn sai chức năng, Vui lòng nhập lại !");
                                    break;
                            }
                        } while (!(b == 3));
                        goto T;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("LOADING ALL THÔNG TIN");
                        dB.xuatDanhSach();
                        Console.ReadKey();
                        Console.Clear();
                        goto T;
                    case 4:
                        Console.Clear();
                        dB.TimSDTgandung();
                        Console.ReadKey();
                        goto T;
                    case 5:
                        Console.Clear();
                        dB.TimTengandung();
                        Console.ReadKey();
                        goto T;
                    case 6:
                        int p;
                        Console.Clear();
                        Console.WriteLine("--------------------------------------------------------------");
                        Console.WriteLine("1: Sắp xếp theo tên xuôi từ A-Z");
                        Console.WriteLine("2: Sắp xếp theo tên ngược từ Z-A");
                        Console.Write("Mời bạn chọn chức năng: ");
                        p = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("--------------------------------------------------------------");
                        switch (p)
                        {
                            case 1:
                                dB.sapXepTheoTenXuoi();
                                Console.ReadKey();
                                break;
                            case 2:
                                dB.sapXepTheoTenNguoc();
                                Console.ReadKey();
                                break;
                            default:
                                Console.WriteLine("Bạn chọn sai chức năg, Vui lòng nhập lại !");
                                break;
                        }
                        goto T;

                    case 7:
                        Console.WriteLine("---> Thanks You .");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("===> Bạn chọn sai chức năng, Vui lòng nhập lại !\n");
                        Console.ReadKey();
                        break;
                }
            } while (!(n == 7));
        }
    }
}
