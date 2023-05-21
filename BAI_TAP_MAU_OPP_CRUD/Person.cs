using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_TAP_MAU_OPP_CRUD
{
    class Person
    {
        private string ho;
        private string ten;
        private string tenDem;
        private string sdt;
        private string email;

        public Person()
        {

        }

        public Person(string ho, string ten, string tenDem, string sdt, string email)
        {
            this.Ho = ho;
            this.Ten = ten;
            this.TenDem = tenDem;
            this.Sdt = sdt;
            this.Email = email;
        }

        public string Ho { get => ho; set => ho = value; }
        public string Ten { get => ten; set => ten = value; }
        public string TenDem { get => tenDem; set => tenDem = value; }
        public string Sdt { get => sdt; set => sdt = value; }
        public string Email { get => email; set => email = value; }

        public virtual void inPersonRaManHinhChoConSuDung()
        {
            Console.WriteLine(" Họ: {0}\n  Tên: {1}\n  Tên đệm: {2}\n  Sđt: {3}\n  Email: {4}", Ho, Ten, TenDem, Sdt, Email);
        }
    }
}
