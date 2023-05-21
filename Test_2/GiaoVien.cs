using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_2
{
    class GiaoVien
    {
        private int id;
        private string ten;
        private double soGioDay;

        public GiaoVien()
        {

        }

        public GiaoVien(int id, string ten, double soGioDay)
        {
            this.Id = id;
            this.Ten = ten;
            this.SoGioDay = soGioDay;
        }

        public int Id { get => id; set => id = value; }
        public string Ten { get => ten; set => ten = value; }
        public double SoGioDay { get => soGioDay; set => soGioDay = value; }

        public virtual void inRaManHinh()
        {
            Console.WriteLine(" Id: {0}\n Tên: {1}\n Số giờ dạy: {2}\n", Id, Ten, SoGioDay);
        }
    }
}
