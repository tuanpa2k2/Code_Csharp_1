using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lap7_8
{
    class SinhvienUDPM : Sinhvien
    {
        private double diemCsharp;
        private double diemJava;

        public SinhvienUDPM()
        {

        }

        public SinhvienUDPM(string ten, string msv, int namSinh, double diemCsharp = 0, double diemJava = 0) : base(ten, msv, namSinh)
        {
            this.diemCsharp = diemCsharp;
            this.diemJava = diemJava;
        }

        public override void inThongTin()
        {
            base.inThongTin();
            Console.WriteLine("Điểm Csharp : {0} | Điểm Java : {1} ",diemCsharp,diemJava);
        }
    }
}
