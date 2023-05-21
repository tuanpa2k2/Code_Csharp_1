using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kiemTra_lab_7_8
{
    class KeThuaSinhVien
    {
        private double diemJava;
        private double diemCsharp;
        public KeThuaSinhVien()
        {

        }

        public KeThuaSinhVien(double diemJava, double diemCsharp)
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
