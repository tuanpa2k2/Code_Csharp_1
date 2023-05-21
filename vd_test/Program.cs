using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vd_test
{
    class Program
    {
        //   /*
        //   * Bài tập ôn tập tổng hợp:
        //   * Viết 1 chương trình có menu sử dụng switch case và vòng lặp:
        //   *         ------Chương trình 1-------
        //   *       1. In bảng cửu chương đơn
        //   *       2. In bảng cửu theo khoảng
        //   *       3. Kiểm tra học lực Sinh Viên Poly
        //   *       4. Nhập thông tin sinh viên
        //   *       5. Thoát.
        //   *
        //   * Giải thích:
        //   *1. In bảng cửu chương đơn: Mời người dùng nhập vào tên 1 bảng cửu chương mà họ muốn sau đó in ra màn hình.
        //   *
        //   * 2. In bảng cửu theo khoảng: Mời người dùng nhập vào tên bảng cửu chương theo khoảng. Ví dụ: từ bảng nhân 5 đến nhân 8.
        //   *
        //   *3. Kiểm tra học lực Sinh Viên Poly: Cho sinh viên POLY nhập vào điểm tổng kết môn C# và thông báo xếp loại học lực:
        //   *  diem<=5 --> Yếu
        //   *  diem<=7 --> Khá 
        //   *  diem<=8 --> Tiên Tiến
        //   *  diem<=9 --> Giỏi
        //   *  diem<=10 --> Xuất sắc
        //   *
        //4. Nhập thông tin nhiều sinh viên gồm các thông tin sau:Tên, Mã Sinh Viên, Năm Sinh. In thông tin sinh viên ra 
        //       Tên + Mã Sinh Viên + Năm Sinh + Tuổi.
        //   */
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.GetEncoding("UTF-8");
            int n;
            Console.WriteLine("MENU chương trình:");
            Console.WriteLine("1: In ra bảng cửu chương đơn.");
            Console.WriteLine("2: In bảng cửu theo khoảng.");
            Console.WriteLine("3: Kiểm tra học lực của sinh viên FPoly.");
            Console.WriteLine("4: Nhập thông tin sinh viên.");
            Console.WriteLine("5: Thoát chương trình");
            Console.Write("Mời bạn chọn chức năng : ");

            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("-----------------------------------------------------------");

            switch (n)
            {
                case 1:
                    //Console.WriteLine("- In ra bảng cửu chương đơn.");
                    //int a = 10, c;
                    ////Cách 1: Sử dụng for
                    //for (int i = 1; i < 10; i++)
                    //{
                    //    Console.WriteLine("{0} x {1} = {2}", a, i, a * i);
                    //}
                    Console.WriteLine("-CN1: In ra bảng cửu chương đơn.");
                    Console.ReadKey();
                    int num = 1, so_nhan;
                    do
                    {
                        so_nhan = 1;
                        do
                        {
                            Console.WriteLine("{0} x {1} = {2}", num, so_nhan, num * so_nhan);
                            so_nhan++;
                        }
                        while (so_nhan <= 10);
                        Console.WriteLine();
                        num++;

                        Console.ReadKey();
                    } while (num <= 10);

                    break;
                case 2:
                    Console.WriteLine("-CN2: In bảng cửu theo khoảng.");

                    break;
                case 3:
                    Console.WriteLine("-CN3: Kiểm tra học lực của sinh viên FPoly.");
                    double diemCsharp;
                    Console.Write("Mời bạn nhập điểm: ");
                    diemCsharp = Convert.ToDouble(Console.ReadLine());
                    if (diemCsharp < 5)
                    {
                        Console.WriteLine("==> Chúc mừng bạn học lại !");
                    }
                    else
                    {
                        if (diemCsharp <= 7)
                        {
                            Console.WriteLine("==> Học lực Khá !");
                        }
                        else
                        {
                            if (diemCsharp <= 8)
                            {
                                Console.WriteLine("Học lực Tiên Tiến !");
                            }
                            else
                            {
                                if (diemCsharp <= 9)
                                {
                                    Console.WriteLine("==> Học lực Giỏi !");
                                }
                                else
                                {
                                    if (diemCsharp <= 10)
                                    {
                                        Console.WriteLine("==> Học lực Xuất Sắc !");
                                    }
                                }
                            }
                        }
                    }

                    break;
                case 4:
                    Console.WriteLine("-CN4: Nhập thông tin sinh viên.");

                    string[] arrNames = new string[1];
                    string maSv;
                    int NamHienTai = DateTime.Now.Year;
                    int Tuoi;
                    int NhapNamSinh;

                    Console.Write("- Nhập tên Sinh Viên: ");
                    arrNames[0] = Console.ReadLine();
                    Console.Write("- Nhập mã SV: ");
                    maSv = Console.ReadLine();


                    Console.Write("- Năm sinh: ");
                    NhapNamSinh = Convert.ToInt32(Console.ReadLine());
                    Tuoi = NamHienTai - NhapNamSinh;

                    Console.WriteLine("--> Sinh viên đạt Ong Vàng là: " + arrNames[0] + ", có Mã sv " + maSv + ", sinh năm " + NhapNamSinh + ", năm nay " + Tuoi + " tuổi");

                    break;
                case 5:
                    Console.WriteLine("- Cảm ơn bạn đã dùng Menu này !");
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine(" ? Bạn chọn sai chức năng của menu, xin nhập lại !");
                    break;
            }


            //int NamHienTai = DateTime.Now.Year;                             // Biến của Năm được gọi chính xác theo hệ thống, không cần nhập vào
            //int NamSinh, Tuoi;                                              // Biến của Năm Sinh và Tuổi
            //string NhapNamSinh;                                             // Biến của Năm Sinh nhập từ người dùng

            //Console.Write("\nMoi Ban Nhap Nam Sinh Theo Dang : YYYY : ");
            //NhapNamSinh = Console.ReadLine();

            //if (int.TryParse(NhapNamSinh, out NamSinh))
            //{
            //    Tuoi = NamHienTai - NamSinh;
            //    Console.WriteLine("\nVay Nam Nay Ban Se : " + Tuoi + " Tuoi \n");

            //    if (-1 < Tuoi && Tuoi < 16)
            //    {
            //        Console.WriteLine("Ban Con La Vi Thanh Nien :> ");
            //    }
            //    else if (16 < Tuoi && Tuoi < 55)
            //    {
            //        Console.WriteLine("Ban Da La Nguoi Truong Thanh");
            //    }
            //    else if (55 < Tuoi && Tuoi < 120)
            //    {
            //        Console.WriteLine("Kinh Chao Cu Ong Cu Ba");

            //    }
            //    else
            //    {
            //        Console.WriteLine("Ban Dang Tu Tien Dung Khong ?");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("\nBan Nhap Sai Dinh Dang, Chuong Trinh Loi, Xin Thoat !");
            //};

            //Console.ReadKey();
            //Console.WriteLine();

            Console.ReadKey();
        }

    }
}
