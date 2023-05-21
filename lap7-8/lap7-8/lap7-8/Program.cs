using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lap7_8
{
    class Program
    {
       
        static void Main(string[] args)
        { 
            QLSV qlsv = new QLSV();
            bool a = true;
            while (a)
            {
                Console.WriteLine("1.Nhập 1 đối tương hoặc danh sách đối tượng");
                Console.WriteLine("2.Xuất 1 đối tượng hoặc danh sách đối tượng");
                Console.WriteLine("3.Xuất danh sách sinh viên từ 20 tuổi trở lên");
                Console.WriteLine("4.Tìm Sv theo mã");
                Console.WriteLine("5.Kế thừa");
                Console.WriteLine("0.Thoát");
                Console.Write("Chọn chức năng: ") ;
                int press = Convert.ToInt32(Console.ReadLine());
                switch (press)
                {
                    case 1:
                        qlsv.them();
                        break;
                    case 2:
                        qlsv.xuat();
                        break;
                    case 3:
                        qlsv.tuoi20();
                        break;
                    case 4:
                        qlsv.tim();
                        break;
                    case 5:
                        qlsv.udpm();
                        break;
                    case 0:
                        Console.WriteLine("Đã thoát chương trình");
                        a = false;
                        break;
                    default:
                        Console.WriteLine("Chức năng không tồn tại");
                        break;
                }
            }
        }
    }
}
