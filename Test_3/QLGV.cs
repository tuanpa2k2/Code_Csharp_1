using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_3
{
    class QLGV
    {
        private List<GiaoVienPoly> _lstGiaoVienPL = new List<GiaoVienPoly>();
        private GiaoVienPoly _giaoVienPLs;
        private string _input;

        public QLGV()
        {

        }
        public void themDanhSach()
        {
            int s;
            do
            {
                Console.Write("Mời bạn hập số lượng cần thêm: ");
                _input = Console.ReadLine();

                for (int i = 0; i < Convert.ToInt32(_input); i++)
                {
                    Console.WriteLine("Thông tin giao viên " + (i + 1) + ":");
                    _giaoVienPLs = new GiaoVienPoly();
                    //Console.Write(" Mời bạn nhập ID giáo viên: ");
                    //_giaoVienPLs.Id = Convert.ToInt32(Console.ReadLine());
                    _giaoVienPLs.Id = i;
                    Console.Write(" Mời bạn nhập tên giáo viên: ");
                    _giaoVienPLs.Ten = Console.ReadLine();
                    Console.Write(" Mời bạn nhập số giờ dạy giáo viên: ");
                    _giaoVienPLs.SoGioLam = Convert.ToInt32(Console.ReadLine());
                    Console.Write(" Mời bạn nhập ngành dạy giáo viên: ");
                    _giaoVienPLs.NganhDay = Console.ReadLine();

                    _lstGiaoVienPL.Add(_giaoVienPLs);
                }
                Console.WriteLine("BẠN CÓ MUỐN NHẬP TIẾP K ?");
                Console.WriteLine("1: Có");
                Console.WriteLine("2: Không");
                Console.Write("Lựa chọn của bạn là: ");
                s = Convert.ToInt32(Console.ReadLine());

            } while (s == 1);
            Console.WriteLine("Bạn đã thêm thành công !");
        }

        void inds(List<GiaoVienPoly> lstGiaoVien)
        {
            foreach (var x in lstGiaoVien)
            {
                x.inRaManHinh();
            }
        }
        public void xuatDanhSach()
        {
            inds(_lstGiaoVienPL);
        }

        public void khoangNhap()
        {
            int a, b;
            Console.Write("Mời bạn nhập khoảng bắt đầu: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Mời bạn nhập khoảng kết thúc: ");
            b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Danh sách số h làm :");
            foreach (var x in _lstGiaoVienPL)
            {
                if (x.SoGioLam >= a && x.SoGioLam <= b)
                {
                    x.inRaManHinh();
                }
            }
        }

        public int getIndexID(int id)
        {
            for (int i = 0; i < _lstGiaoVienPL.Count; i++)
            {
                if (_lstGiaoVienPL[i].Id == id)
                {
                    return i;
                }
            }
            return -1;
        }
        public void timKiemTheoID()
        {
            Console.Write("Mời bạn nhập ID cần tìm: ");
            _input = Console.ReadLine();
            int temp = getIndexID(Convert.ToInt32(_input));
            if (temp == -1)
            {
                Console.WriteLine("KHÔNG TÌM THẤY ID NÀY, VUI LÒNG NHẬP LẠI !");
                return;
            }
            _lstGiaoVienPL[temp].inRaManHinh();
        }

        public void keThua()
        {
            GiaoVienPoly gv1 = new GiaoVienPoly(5, "TUAN", 5, "UDPM");
            gv1.inRaManHinh();
        }

 
    }
}
