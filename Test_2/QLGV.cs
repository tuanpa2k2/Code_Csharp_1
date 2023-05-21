using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_2
{
    class QLGV
    {
        private List<GiaoVienPoly> _lstGiaoVien = new List<GiaoVienPoly>();
        private GiaoVienPoly _giaoViens;
        private string _input;

        public QLGV()
        {

        }
        public void themGiaoVien()
        {
            int s;
            do
            {
                Console.Write("Mời nhập số lượng giáo viên cần thêm: ");
                _input = Console.ReadLine();

                for (int i = 0; i < Convert.ToInt32(_input); i++)
                {
                    Console.WriteLine("Thông tin giáo viên thứ " + (i + 1) + ":");
                    _giaoViens = new GiaoVienPoly();
                    Console.Write("Mời nhập ID: ");
                    _giaoViens.Id = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Mời nhập tên: ");
                    _giaoViens.Ten = Console.ReadLine();
                    Console.Write("Mời nhập số giờ dạy: ");
                    _giaoViens.SoGioDay = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Mời nhập ngành dạy: ");
                    _giaoViens.NganhDay = Console.ReadLine();

                    _lstGiaoVien.Add(_giaoViens);
                }
                Console.WriteLine("Bạn có muốn nhập tiếp k ? ");
                Console.WriteLine("1: có");
                Console.WriteLine("2: không");
                Console.Write("Lựa chọn của bạn là: ");
                s = Convert.ToInt32(Console.ReadLine());

            } while (s == 1);
            Console.WriteLine("Thêm danh sách thành công !");
        }

        void inds(List<GiaoVienPoly> lstgiaoVien)
        {
            int z = 1;
            Console.WriteLine("DANH SÁCH GIÁO VIÊN POLY :");
            foreach (var x in lstgiaoVien)
            {
                Console.WriteLine("Giáo viên thứ {0}:", z);
                x.inRaManHinh();
                z++;
            }
        }
        public void xuatDanhSach()
        {
            inds(_lstGiaoVien);
        }

        public void khoangNhap()
        {
            int a, b;
            Console.Write("Mời bạn nhập khoảng bắt đầu: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Mời bạn nhập khoảng kết thúc: ");
            b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Danh sách số giờ làm :");
            foreach (var x in _lstGiaoVien)
            {
                if (x.SoGioDay >= a && x.SoGioDay <= b)
                {
                    x.inRaManHinh();
                }
            }
        }


        public int getIndexMa(int id)
        {
            for (int i = 0; i < _lstGiaoVien.Count; i++)
            {
                if (_lstGiaoVien[i].Id == id)
                {
                    return i;
                }
            }
            return -1;
        }
        public void timKiemTheoMa()
        {
            Console.Write("Mời bạn nhập ID giáo viên cần tìm: ");
            _input = Console.ReadLine();
            int temp = getIndexMa(Convert.ToInt32(_input));
            if (temp == -1)
            {
                Console.WriteLine("KHÔNG TÌM THẤY ID GIÁO VIÊN NÀY !");
                return;
            }
            _lstGiaoVien[temp].inRaManHinh();
        }

        public void keThua()
        {
            GiaoVienPoly gv1 = new GiaoVienPoly(8, "TUAN", 8, "TOAN");
            gv1.inRaManHinh();
        }
    }
}
