using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kiemTra_lab_5_6_b
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
            SinhVien st1 = new SinhVien("Tuan", "PH18296", 8, 7);
            SinhVien st2 = new SinhVien("Thi", "PH18292", 8, 7);
            SinhVien st3 = new SinhVien("Thao", "PH18294", 8, 7);

            _lstSinhViens.Add(st1);
            _lstSinhViens.Add(st2);
            _lstSinhViens.Add(st3);
        }
        void inds(List<SinhVien> lstSinhVien)
        {
            int s = 1;
            foreach (var x in lstSinhVien)
            {
                Console.WriteLine("Sinh viên thứ {0} là:", s);
                x.inRaManHinh();
                s++;
            }
        }
        public void inSinhVien()
        {
            inds(_lstSinhViens);
        }
        public void themSV()
        {
            Console.WriteLine("Bạn nhập số lượng: ");
            _input = Console.ReadLine();
            for (int i = 0; i < Convert.ToInt32(_input); i++)
            {
                _sinhVien = new SinhVien();
                Console.WriteLine("Tên: ");
                _sinhVien.Ten = Console.ReadLine();

                _lstSinhViens.Add(_sinhVien);
            }

        }
        public int getIndexMsv(string msv)
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
        public void timKiemSinhVien()
        {
            Console.Write("Mời bạn nhập mã SV cần tìm: ");
            _input = Console.ReadLine();
            int temp = getIndexMsv(_input);
            if (temp == -1)
            {
                Console.WriteLine("KHÔNG TÌM THẤY MÃ SV NÀY...");
                return;
            }
            _lstSinhViens[temp].inRaManHinh();
        }
        public void sapXepSinhVien()
        {
            inds(_lstSinhViens.OrderBy(c => c.Ten).ToList());
        }

        
    }
}
