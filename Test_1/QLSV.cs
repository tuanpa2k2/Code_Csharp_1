using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_1
{
    class QLSV
    {
        private List<SinhVien> _lstSinhViens = new List<SinhVien>();
        private List<SinhVien> _newDanhSach = new List<SinhVien>();
        private SinhVien _sinhVien;
        private string _input;

        public QLSV()
        {
            _sinhVien = new SinhVien(8, 8.5, 9, "Tuấn", "PH18296", 2002);
            _lstSinhViens.Add(_sinhVien);
            _sinhVien = new SinhVien(7, 8.5, 7, "Anh", "PH18295", 2001);
            _lstSinhViens.Add(_sinhVien);
            _sinhVien = new SinhVien(9, 8.5, 8, "Phí", "PH18294", 2003);
            _lstSinhViens.Add(_sinhVien);

        }
        void inds(List<SinhVien> lstStudents)
        {
            int n = 1;
            Console.WriteLine("Danh sách sinh viên:\n");
            foreach (var x in lstStudents)
            {
                Console.WriteLine("Sinh viên thứ {0}", n);
                x.inRaManHinh();
                n++;
            }
        }
        public void xuatDanhSach()
        {
            inds(_lstSinhViens);
        }
        public void khoangNhap()
        {
            int a, b;
            Console.Write("Mời bạn nhập khoảng bắt đầu từ: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Mời bạn nhập khoảng kết thúc: ");
            b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("DANH SÁCH SO GIỜ LÀM .");
            foreach (var x in _lstSinhViens)
            {
                if (x.SoGioDay >= a && x.SoGioDay <= b)
                {
                    Console.WriteLine("\n");
                    x.inRaManHinh();
                }
            }
        }
        public int danhSachQM()
        {
            Console.WriteLine("Danh sách sinh viên qua môn C# :");
            for (int i = 0; i < _lstSinhViens.Count; i++)
            {
                if (_lstSinhViens[i].DiemJava >= 5)
                {
                    Console.WriteLine("Chúc mừng bạn qua môn C#");
                    _lstSinhViens[i].inRaManHinh();
                }
            }
            return -1;
        }
        public int getIndexMa(string msv)
        {
            for (int i = 0; i < _lstSinhViens.Count; i++)
            {
                if (_lstSinhViens[i].Msv == msv)
                {
                    return i;
                }
            }
            return -1;
        }
        public void timKiemMa()
        {
            Console.Write("Mời bạn nhập mã sinh viên cần tìm: ");
            _input = Console.ReadLine();
            int temp = getIndexMa(_input);
            if (temp == -1)
            {
                Console.WriteLine("Mã sinh viên k tồn tại !");
                return;
            }
            _lstSinhViens[temp].inRaManHinh();
        }
        public void tuoi20()
        {
            foreach (var x in _lstSinhViens)
            {
                if (DateTime.Now.Year - x.NamSinh >= 20)
                {
                    x.inRaManHinh();
                }
            }
        }
        public void sapXepSinhVien()
        {
            //_newDanhSach = _lstSinhViens.OrderBy(c => c.Ten).ToList();
            //_lstSinhViens.Clear();
            //_lstSinhViens = _newDanhSach;
            _lstSinhViens.OrderBy(c => c.Ten).ToList();
            Console.WriteLine("Sắp xếp thành công !");
        }
        public int getIndexNguoi(string ten)
        {
            for (int i = 0; i < _lstSinhViens.Count; i++)
            {
                if (_lstSinhViens[i].Ten == ten)
                {
                    return i;
                }
            }
            return -1;
        }
        public void xoaSinhVien()
        {
            Console.Write("Mời bạn nhập tên cần xóa: ");
            _input = Console.ReadLine();
            int temp = getIndexNguoi(_input);
            if (temp == -1)
            {
                Console.WriteLine("Không tìm thấy sinh viên này, Vui lòng nhập lại !");
                return;
            }
            _lstSinhViens.RemoveAt(temp);
            Console.WriteLine("Đã xóa thành công !");
        }
        public void timSinhVien()
        {
            Console.Write("Mời bạn nhập tên cần tìm: ");
            _input = Console.ReadLine();
            int tempp = getIndexNguoi(_input);
            if (tempp == -1)
            {
                Console.WriteLine("Không tìm thấy sinh viên này, Vui lòng nhập lại !");
                return;
            }
            _lstSinhViens[tempp].inRaManHinh();
        }
    }
}
