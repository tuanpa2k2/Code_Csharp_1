using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_TAP_MAU_OOP
{
    class SinhVien
    {
        private string ten;
        private string msv;
        private int namSinh;
        private double diemCsharp;

        public SinhVien()
        {

        }
        public SinhVien(string ten, string msv, int namSinh, double diemCsharp)
        {
            this.Ten = ten;
            this.Msv = msv;
            this.NamSinh = namSinh;
            this.DiemCsharp = diemCsharp;
        }

        public string Ten { get => ten; set => ten = value; }
        public string Msv { get => msv; set => msv = value; }
        public int NamSinh { get => namSinh; set => namSinh = value; }
        public double DiemCsharp { get => diemCsharp; set => diemCsharp = value; }

        public void inRaManHinh()
        {
            Console.WriteLine("    Tên Sinh Viên: {0}\n    Mã Sinh Viên: {1}\n    Năm Sinh: {2} \n    Điểm C#1: {3}"
                , ten, msv, namSinh, diemCsharp);
        } 
    }
}
