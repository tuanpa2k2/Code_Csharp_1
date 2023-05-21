using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kiemTra_lab_3_4
{
    class Functions // Nơi code các chức năng .
    {
        int _input;
        Class1 _arrSinhViens;
        Class1 sv1;
        List<Class1> lstSinhViens = new List<Class1>();
        public void bai1_ThemMotSinhVien()
        {
            Class1 sv1 = new Class1();
            sv1.Ten = "Long";
            sv1.Masv = "PH000";
            sv1.DiemJava = 8;
            sv1.DiemCsharp = 8;

            sv1.inSinhVienKhongThamSo();
        }
        public void bai2_ThemNhieuSinhVienSuDung_List()
        {
            //khai bao list
            
            Class1 sv1;
            Console.Write("Bạn muốn thêm vào bao nhiêu sinh viên: ");
            _input = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < _input; i++)
            {
                sv1 = new Class1();
                Console.WriteLine("----------------------------------------------");
                Console.Write(" Mời bạn nhập tên sinh viên thứ " + (i + 1) + ": ");
                sv1.Ten = Console.ReadLine();
                Console.Write(" Mời bạn nhập mã Sinh Viên: ");
                sv1.Masv = Console.ReadLine();
                Console.Write(" Mời bạn nhập điểm Java: ");
                sv1.DiemJava = Convert.ToDouble(Console.ReadLine());
                Console.Write(" Mời bạn nhập điểm C#1: ");
                sv1.DiemCsharp = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("------------------------------");

                lstSinhViens.Add(sv1);
                for (int k = 0; k < lstSinhViens.Count; k++)
                {
                    lstSinhViens[k].inSinhVienKhongThamSo();
                }
            }
        }
        public void bai3_XuatThongTinRaManHinh()
        {
            sv1.inSinhVienKhongThamSo();
            for (int k = 0; k < lstSinhViens.Count; k++)
            {
                lstSinhViens[k].inSinhVienKhongThamSo();
            }
        }
    }
}
