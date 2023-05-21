using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kiemTra_7_8
{
    class QLSV
    {
        private List<SinhVien> _lstSinhViens = new List<SinhVien>();
        private SinhVien _sinhViens;
        private string _input;

        public QLSV()
        {

        }
        public void themDanhSach()
        {
                Console.Write("Mời bạn nhập số lượng cần thêm: ");
                _input = Console.ReadLine();


                _sinhViens = new SinhVien();
                Console.Write(" Mời bạn nhập tên: ");
                _sinhViens.Ten = Console.ReadLine();
                Console.Write(" Mời bạn nhập MSV: ");
                _sinhViens.Msv = Console.ReadLine();
                Console.Write(" Mời bạn nhập năm sinh: ");
                _sinhViens.NamSinh = Convert.ToInt32(Console.ReadLine());
                Console.Write(" Mời bạn nhập điểm Java: ");
                _sinhViens.DiemJava = Convert.ToDouble(Console.ReadLine());
                Console.Write(" Mời bạn nhập điểm C#: ");
                _sinhViens.DiemCsharp = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("----------------------------------------------");

                _lstSinhViens.Add(_sinhViens);

        }
    }
}
