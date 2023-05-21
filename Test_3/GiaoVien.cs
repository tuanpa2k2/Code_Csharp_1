using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_3
{
    class GiaoVien
    {
        private int id;
        private string ten;
        private int soGioLam;

        public GiaoVien()
        {

        }

        public GiaoVien(int id, string ten, int soGioLam)
        {
            this.Id = id;
            this.Ten = ten;
            this.SoGioLam = soGioLam;
        }

        public int Id { get => id; set => id = value; }
        public string Ten { get => ten; set => ten = value; }
        public int SoGioLam { get => soGioLam; set => soGioLam = value; }

        public virtual void inRaManHinh()
        {
            Console.WriteLine(" Id: {0}\n Tên: {1}\n Số giờ làm: {2}\n", Id, Ten, SoGioLam);
        }
    }
}
