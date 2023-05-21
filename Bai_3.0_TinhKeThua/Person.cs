using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_3._0_TinhKeThua
{
    class Person
    {
        private string ten;
        private string ho;
        private string tenDem;
        private string sdt;
        private string email;

        public Person()
        {

        }

        public Person(string ten, string ho, string tenDem, string sdt, string email)
        {
            this.Ten = ten;
            this.Ho = ho;
            this.TenDem = tenDem;
            this.Sdt = sdt;
            this.Email = email;
        }

        public string Ten { get => ten; set => ten = value; }
        public string Ho { get => ho; set => ho = value; }
        public string TenDem { get => tenDem; set => tenDem = value; }
        public string Sdt { get => sdt; set => sdt = value; }
        public string Email { get => email; set => email = value; }

        public void inPerson()
        {
            Console.WriteLine("Ten: {0} -Ho: {1} -Ten Dem: {2} -Sdt: {3} -Email: {4}", ten, ho, tenDem, sdt, email);
        }
        public virtual void inPersonChoConSuDung()
        {
            Console.WriteLine("Ten: {0} -Ho: {1} -Ten Dem: {2} -Sdt: {3} -Email: {4}", ten, ho, tenDem, sdt, email);
        }
    }
}
