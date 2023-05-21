using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kiemTra_lab_3_4
{
    class Class1
    {
        private string ten;
        private string masv;
        private double diemJava;
        private double diemCsharp;
        public Class1()
        {

        }

        public Class1(string ten, string masv, double diemJava, double diemCsharp)
        {
            this.Ten = ten;
            this.Masv = masv;
            this.DiemJava = diemJava;
            this.DiemCsharp = diemCsharp;
        }

        public string Ten { get => ten; set => ten = value; }
        public string Masv { get => masv; set => masv = value; }
        public double DiemJava { get => diemJava; set => diemJava = value; }
        public double DiemCsharp { get => diemCsharp; set => diemCsharp = value; }

        public void inSinhVienKhongThamSo()
        {
            Console.WriteLine(" -Tên sinh viên: {0}\n -Mã sinh viên: {1}\n -Điểm Java: {2}\n -Điểm C#: {3}", Ten, Masv, DiemJava, DiemCsharp);
        }
       
    }
}
