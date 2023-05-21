using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kiemTra_lab_7_8
{
    class SinhVien:KeThuaSinhVien
    {
        private string ten;
        private string msv;
        private int namSinh;
        public SinhVien()
        {

        }

        public SinhVien(double diemJava, double diemCsharp, string ten, string msv, int namSinh) : base(diemJava, diemCsharp)
        {
            this.Ten = ten;
            this.Msv = msv;
            this.NamSinh = namSinh;
        }

        public string Ten { get => ten; set => ten = value; }
        public string Msv { get => msv; set => msv = value; }
        public int NamSinh { get => namSinh; set => namSinh = value; }

        public override void inRaManHinh()
        {
            Console.WriteLine(" Tên: {0}\n Mã sinh viên: {1}\n Năm sinh: {2}\n Điểm Java: {3}\n Điểm C#: {4}", 
                ten, msv, namSinh, DiemJava, DiemCsharp);
        }
    }
}
