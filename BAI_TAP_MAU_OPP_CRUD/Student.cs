using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_TAP_MAU_OPP_CRUD
{
    class Student:Person 
    {
        private string msv;
        private double diemCsharp;
        public Student()
        {

        }

        public Student(string ho, string ten, string tenDem, string sdt, string email, string msv, double diemCsharp) : base(ho, ten, tenDem, sdt, email)
        {
            this.Msv = msv;
            this.DiemCsharp = diemCsharp;
        }

        public string Msv { get => msv; set => msv = value; }
        public double DiemCsharp { get => diemCsharp; set => diemCsharp = value; }

        public override void inPersonRaManHinhChoConSuDung()
        {
            Console.WriteLine(" Họ và Tên: {0}\n  Sđt: {1}\n  Email: {2}\n  Mã sinh viên: {3}\n  Điểm c#: {4}", (Ho + TenDem + Ten), Sdt, Email, msv, diemCsharp);
        }
    }
}
