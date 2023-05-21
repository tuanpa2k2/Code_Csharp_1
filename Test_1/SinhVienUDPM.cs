using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_1
{
    class SinhVienUDPM
    {
        private int soGioDay;
        private double diemJava;
        private double diemCsharp;

        public SinhVienUDPM()
        {

        }

        public SinhVienUDPM(int soGioDay, double diemJava, double diemCsharp)
        {
            this.SoGioDay = soGioDay;
            this.DiemJava = diemJava;
            this.DiemCsharp = diemCsharp;
        }

        public int SoGioDay { get => soGioDay; set => soGioDay = value; }
        public double DiemJava { get => diemJava; set => diemJava = value; }
        public double DiemCsharp { get => diemCsharp; set => diemCsharp = value; }

        public virtual void inRaManHinh()
        {
            Console.WriteLine(" Số giờ dạy: {0}\n Điểm Java: 0\n Điểm C#: {1}",SoGioDay, DiemJava, DiemCsharp);
        }
    }
}
