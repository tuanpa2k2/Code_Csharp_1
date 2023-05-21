using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_3
{
    class GiaoVienPoly:GiaoVien
    {
        private string nganhDay;

        public GiaoVienPoly()
        {

        }

        public GiaoVienPoly(int id, string ten, int soGioLam, string nganhDay) : base(id, ten, soGioLam)
        {
            this.NganhDay = nganhDay;
        }

        public string NganhDay { get => nganhDay; set => nganhDay = value; }
        public override void inRaManHinh()
        {
            Console.WriteLine(" Id: {0}\n Tên: {1}\n Số giờ làm: {2}\n Ngành dạy: {3}", Id, Ten, SoGioLam, nganhDay);
        }
    }
}
