using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_2
{
    class GiaoVienPoly:GiaoVien
    {
        private string nganhDay;
        public GiaoVienPoly()
        {

        }

        public GiaoVienPoly(int id, string ten, double soGioDay, string nganhDay) : base(id, ten, soGioDay)
        {
            this.NganhDay = nganhDay;
        }

        public string NganhDay { get => nganhDay; set => nganhDay = value; }

        public override void inRaManHinh()
        {
            Console.WriteLine(" Id: {1}\n Tên: {2}\n Số giờ dạy: {3}\n Ngành dạy: {0}", nganhDay, Id, Ten, SoGioDay);
        }
    }
}
