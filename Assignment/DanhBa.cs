using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class DanhBa : Nguoi
    {
        public string danhxung;
        private string sdt1;
        private string sdt2;
        private string email;
        private string ghiChu;

        public DanhBa()
        {

        }

        public DanhBa(string ho, string tenDem, string ten, int namSinh, string gioiTinh, string sdt1, string sdt2, string email, string ghiChu) : base(ho, tenDem, ten, namSinh, gioiTinh)
        {
            this.Sdt1 = sdt1;
            this.Sdt2 = sdt2;
            this.Email = email;
            this.GhiChu = ghiChu;
        }

        public string Sdt1 { get => sdt1; set => sdt1 = value; }
        public string Sdt2 { get => sdt2; set => sdt2 = value; }
        public string Email { get => email; set => email = value; }
        public string GhiChu { get => ghiChu; set => ghiChu = value; }

        public override void inNguoiRaManHinh()
        {
            Console.WriteLine("{0}: {1}\n  Năm sinh: {2}\n  Giới tính: {3}\n  SĐT_1: {4}\n  SĐT_2: {5}\n  Email: {6}\n  Ghi chú: {7}",
                danhxung,(Ho + " " + TenDem + " " + Ten), NamSinh, GioiTinh, sdt1, sdt2, email, ghiChu);
        }
    }
}
