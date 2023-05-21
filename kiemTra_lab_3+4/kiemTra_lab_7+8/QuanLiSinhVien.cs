using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kiemTra_lab_7_8
{
    class QuanLiSinhVien
    {
        private List<SinhVien> _lstSinhViens = new List<SinhVien>();
        private SinhVien _sinhVien;
        private string _input;

        public QuanLiSinhVien()
        {

        }
        public void nhapDanhSach()
        {
                Console.Write(" Mời bạn nhập số lượng cần thêm: ");
                _input = Console.ReadLine();
                
                    _sinhVien = new SinhVien();
                    Console.Write(" mời nhập tên sinh viên thứ " + ": ");
                    _sinhVien.Ten = Console.ReadLine();
                    Console.Write(" mời nhập MSV: ");
                    _sinhVien.Msv = Console.ReadLine();
                    Console.Write(" mời nhập năm sinh: ");
                    _sinhVien.NamSinh = Convert.ToInt32(Console.ReadLine());
                    Console.Write(" mời nhập điểm java: ");
                    _sinhVien.DiemJava = Convert.ToDouble(Console.ReadLine());
                    Console.Write(" mời nhập điểm C#: ");
                    _sinhVien.DiemCsharp = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("---------------------------------------------");

                    _lstSinhViens.Add(_sinhVien);
            int s;
            do
            {
                

                Console.WriteLine("Bạn có muốn thêm nữa k ?");
                Console.WriteLine("1: có");
                Console.WriteLine("2: không");
                Console.Write("Lựa chọn của bạn là: ");
                s = Convert.ToInt32(Console.ReadLine());
            } while (s == 1);
        }
        void inds(List<SinhVien> lstSinhViens)
        {
            Console.WriteLine("Danh sách sinh viên :");
            int a = 1;
            foreach (var x in lstSinhViens)
            {
                Console.WriteLine("STT: {0}", a);
                a++;
                x.inRaManHinh();
            }
        }
        public void xuatDanhSach()
        {
            inds(_lstSinhViens);
        }

        public int xuatDanhSachQuaMon()
        {
            Console.WriteLine("==> Danh sách sinh viên qua môn C#");
            for (int i = 0; i < _lstSinhViens.Count; i++)
            {
                if (_lstSinhViens[i].DiemCsharp >= 5)
                {
                    Console.WriteLine("------------------------------------------");
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
        public void timSinhVienTheoMa()
        {
            Console.Write(" Mời bạn nhập mã sinh viên cần tìm: ");
            _input = Console.ReadLine();
            int temp = getIndexMa(_input);
            if (temp == -1)
            {
                Console.WriteLine("Mã sinh viên không tồn tại ! Vui lòng nhập lại .");
                return;
            }
            _lstSinhViens[temp].inRaManHinh();
        }
    }
}
