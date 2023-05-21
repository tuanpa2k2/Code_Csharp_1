using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kiemTra_lab_5_6_b
{
    class SinhVien
    {
        private string ten;
        private string msv;
        private double diemJava;
        private double diemCsharp;

        public SinhVien(string ten, string msv, double diemJava, double diemCsharp)
        {
            this.Ten = ten;
            this.Msv = msv;
            this.DiemJava = diemJava;
            this.DiemCsharp = diemCsharp;
        }

        public string Ten { get => ten; set => ten = value; }
        public string Msv { get => msv; set => msv = value; }
        public double DiemJava { get => diemJava; set => diemJava = value; }
        public double DiemCsharp { get => diemCsharp; set => diemCsharp = value; }

        public void inRaManHinh()
        {
            Console.WriteLine(" Tên: {0}\n Mã SV: {1}\n Điểm Java: {2}\n Điểm Csharp: {3}\n ", Ten, Msv, DiemJava, DiemCsharp);
        }
    }
}
