﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bài1._3
{
    class Program
    {
        /*
       * BÀI 1.2 Nhập xuất ký tự từ bàn phím
       *  1. Xuất dữ liệu ra màn hình
       *      + Phím tắt : cw + tab
       *      + Console.WriteLine(); Ghi xong thì xuống dòng
       *      + Console.Write(); Ghi xong thì không xuống dòng
       *  2. Nhập giá trị từ bàn phím:
       *      + Console.Read(); Đọc 1 ký tự từ bàn phím nhưng là số ASII
       *      + Console.ReadLine();  Đọc nhiều ký tự từ bàn phím và kiểu dữ liệu là string - chuỗi
       */
        static void Main(string[] args)
        {
            /*
            Console.OutputEncoding = Encoding.GetEncoding("UTF-8");
            //1. Xuất dữ liệu  màn hình cw + tab
            Console.Write("Chào các bạn");//Khi in ra thì không xuống dòng
            Console.WriteLine("đến với môn Csharp 1");//Khi in ra thì xuống dòng
            Console.Write(" ở FPT POLY");
            Console.WriteLine("Chúc mừng bạn {0} đã qua môn Csharp 1 với số điểm = {1}", "Tùng", 5.6);

            //2. Nhập giá trị từ bàn phím
            string name;//Khai báo 1 biến để hứng giá trị do người dùng nhập vào
            Console.WriteLine("Mời bạn nhập tên vào đây: ");
            name = Console.ReadLine();//Lấy giá trị từ bàn phím do người dùng nhập gán vào cho biến name
            Console.WriteLine("Chào bạn {0} đã đến với lập trình Csharp", name);

            */

            //bai1: VD Test ...
            string name, id;
            int age;
            Console.OutputEncoding = Encoding.GetEncoding("UTF-8");
            Console.WriteLine("Tên của bạn :");
                name = Console.ReadLine();
            Console.WriteLine("Mã sv :");
                id = Console.ReadLine();
            Console.WriteLine("Năm sinh :");
                age = Convert.ToInt32(Console.ReadLine());
            //... Xuất ra màn hình ....
                // cach1:
                Console.WriteLine("Chào bạn {0} | {1} | {2} đến với PFT Poly", name, id, age);
                // cach2:
                Console.WriteLine($"Chào bạn {name} có masv: {id}, năm sinh: {age} đến với PFT Polytechnic");
        }
    }
}
