using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lap7_8
{
    class Sinhvien
    {
        private string ten;
        private string msv;
        private int namSinh;

        public Sinhvien()
        {

        }

        public Sinhvien(string ten, string msv, int namSinh)
        {
            this.ten = ten;
            this.msv = msv;
            this.namSinh = namSinh;
        }

        public string Ten { get => ten; set => ten = value; }
        public string Msv { get => msv; set => msv = value; }
        public int NamSinh { get => namSinh; set => namSinh = value; }

        public virtual void inThongTin()
        {
            Console.WriteLine("");
            Console.WriteLine("Tên : {0} | MSV : {1} | Năm sinh : {2}",Ten,Msv,NamSinh);
        }
    }
}
