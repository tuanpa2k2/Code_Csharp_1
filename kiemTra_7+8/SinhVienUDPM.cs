using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kiemTra_7_8
{
    class SinhVienUDPM
    {
        private double diemJava;
        private double diemCsharp;
        public SinhVienUDPM()
        {

        }

        public SinhVienUDPM(double diemJava, double diemCsharp)
        {
            this.DiemJava = diemJava;
            this.DiemCsharp = diemCsharp;
        }

        public double DiemJava { get => diemJava; set => diemJava = value; }
        public double DiemCsharp { get => diemCsharp; set => diemCsharp = value; }
        public virtual void inRaManHinh()
        {
            Console.WriteLine(" Điểm Java: {0}\n Điểm C#: {1}", DiemJava, DiemCsharp);
        }
    }
}
