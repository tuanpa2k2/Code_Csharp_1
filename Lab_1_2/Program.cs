using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1_2
{
    class Program
    {
        static int NamSinh, Tuoi;
        static string NhapNamSinh;
        static string[] arrNames = new string[3];
        public static void CN1()
        {


            Console.WriteLine("Thông tin NY cũ gồm: Tên, Năm sinh, Tuổi, Giới tính, Chiều cao.");
            Console.Write("- Nhập tên NY cũ: ");
            arrNames[0] = Console.ReadLine();

            Console.Write("- Năm sinh: ");
            NhapNamSinh = Console.ReadLine();
            int.TryParse(NhapNamSinh, out NamSinh);

            Console.Write("- Giới tính: ");
            arrNames[1] = Console.ReadLine();
            Console.Write("- Chiều cao: ");
            arrNames[2] = Console.ReadLine();

            Console.WriteLine("-------------------------------------------------------------------");
        }
        static void Main(string[] args)
        {


            Console.OutputEncoding = Encoding.GetEncoding("UTF-8");
            int n;
            Console.WriteLine("       MENU LAB1 - LAB2 ");
            Console.WriteLine(" .------------------------------------.");
            Console.WriteLine(" | 1: Nhập thông tin người yêu cũ .   |");
            Console.WriteLine(" | 2: Xuất thông tin người yêu cũ .   |");
            Console.WriteLine(" | 3: Thoát                           |");
            Console.WriteLine(" '------------------------------------'");
            while (true)
            {
                Console.Write("--> Mời bạn chọn chức năng: ");
                n = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("-------------------------------------------------------------------");

                //       Nhập thông tin nhiều người yêu cũ: Nhập các thông tin của NY Cũ thông tin sau:
                //          Tên, Năm Sinh, Giới tính, Chiều cao(Sử dụng mảng)
                //              *-Tên người yêu:
                //              *-Năm sinh:
                //              *-Tuổi người yêu:
                //              *-Giới tính:
                //              *-Chiều cao:
                switch (n)
                {
                    case 1:
                        CN1();
                        break;
                    case 2:
                        Console.WriteLine("*** Welcome CN2 ***");
                        Console.WriteLine("Thông tin NY cũ của bạn :) !");
                        Console.Write(" - 1: Tên: ");
                        Console.WriteLine(arrNames[0]);
                        Console.Write(" - 2: Năm sinh: ");
                        Console.WriteLine(NhapNamSinh);
                        Console.Write(" - 3: Tuổi: ");
                        Console.WriteLine("{0}",
                            DateTime.Now.Year - Convert.ToInt32(NamSinh));
                        Console.Write(" - 4: Giới tính: ");
                        Console.WriteLine(arrNames[1]);
                        Console.Write(" - 5: Chiều cao: ");
                        Console.Write(arrNames[2]);
                        Console.WriteLine(" cm.");
                        Console.WriteLine("-------------------------------------------------------------------");
                        break;
                    case 3:
                        Console.WriteLine("--> Thank you .");
                        Console.WriteLine("-------------------------------------------------------------------");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Bạn chọn sai chức năng của MENU - XIN NHẬP LẠI !");
                        break;
                }
            }

        }
    }
}
