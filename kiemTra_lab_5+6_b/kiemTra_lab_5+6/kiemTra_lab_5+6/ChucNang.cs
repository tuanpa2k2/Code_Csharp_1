using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kiemTra_lab_5_6
{
    class ChucNang
    {
        private List<SinhVien> _lstSinhViens = new List<SinhVien>();
        private SinhVien _sinhVien;
        private string _input;

        public ChucNang()
        {
            fakeData();
        }
        void fakeData()
        {
            SinhVien st1 = new SinhVien("Tuan", "PH18296", 8, 8);
            SinhVien st2 = new SinhVien("Thi", "PH18295", 8, 8);
            SinhVien st3 = new SinhVien("Thao", "PH18294", 8, 8);
            SinhVien st4 = new SinhVien("Tung", "PH18292", 8, 8);
            SinhVien st5 = new SinhVien("Tai", "PH18293", 8, 8);

            _lstSinhViens.Add(st1);
            _lstSinhViens.Add(st2);
            _lstSinhViens.Add(st3);
            _lstSinhViens.Add(st4);
            _lstSinhViens.Add(st5);
        }
        public void xuatDanhSach()
        {
            inds(_lstSinhViens);
        }

        void inds(List<SinhVien> lstsinhViens)
        {
            int q = 1;
            foreach (var x in lstsinhViens)
            {
                Console.WriteLine("Sinh viên thứ {0} là: ", q);
                x.inRaManHinh();
                q++;
            }
        }


        
        /// Chức năng 2.
        
        public void timKiemSinhVien()
        {
            Console.Write("Mời bạn nhập mã sinh viên cần tìm: ");
            _input = Console.ReadLine();
            int temp = getIndexSinhVien(_input);
            if (temp == -1)
            {
                Console.WriteLine("Không tìm thấy mã sinh viên, Vui lòng nhập lại !");
                return;
            }
            _lstSinhViens[temp].inRaManHinh();
        }
        public int getIndexSinhVien(string msv)
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
        public void sapXep()
        {
            inds(_lstSinhViens.OrderBy(c => c.Ten).ToList());
            //var stt = _lstSinhViens.OrderBy(P => P.Ten);
            //foreach (SinhVien x in stt)
            //{
            //    x.inRaManHinh();
            //}

        }

    }
}
