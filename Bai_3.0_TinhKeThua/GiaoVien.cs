using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_3._0_TinhKeThua
{
    class GiaoVien:Person
    {
        private string mgv;
        private string gioDay;

        public GiaoVien()
        {

        }

        public GiaoVien(string ten, string ho, string tenDem, string sdt, string email, string mgv, string gioDay) : base(ten, ho, tenDem, sdt, email)
        {
            this.Mgv = mgv;
            this.GioDay = gioDay;
        }

        public string Mgv { get => mgv; set => mgv = value; }
        public string GioDay { get => gioDay; set => gioDay = value; }
        public void inRaManHinhGiaoVien()
        {
            Console.WriteLine(" -Họ và Tên: {0}\n -SĐT: {1}\n -Email: {2}\n -Mã Giáo Viên: {3}\n -Số giờ dạy: {4}", (Ho + " " + TenDem + " " + Ten), Sdt, Email, Mgv, GioDay);
        }

    }
}
