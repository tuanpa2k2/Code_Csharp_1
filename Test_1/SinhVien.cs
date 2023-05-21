using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_1
{
    class SinhVien:SinhVienUDPM
    {
        private string ten;
        private string msv;
        private int namSinh;

        public SinhVien()
        {

        }

        public SinhVien(int soGioDay, double diemJava, double diemCsharp, string ten, string msv, int namSinh) : base(soGioDay, diemJava, diemCsharp)
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
            Console.WriteLine(" Tên: {3}\n Mã: {4}\n Năm sinh: {5}\n Số h dạy: {0}\n Điểm Java: {1}\n Điểm C#: {2}",
                SoGioDay,DiemCsharp, DiemJava, ten, msv, namSinh);
        }
    }
}
