using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_TAP_MAU_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.GetEncoding("UTF-8");
            ServiceSinhVien cn = new ServiceSinhVien();

            cn.bai3TaoNhieuDoiTuongArray();
            cn.inDsSinhVien();
            cn.themSinhVienList();
        }
    }
}