using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_3._1_LINQ_COBAN
{
    class Service
    {
        private List<SinhVien> lstSinhViens = new List<SinhVien>();
        public Service()
        {
            fakeData();
        }
        void fakeData()
        {
            SinhVien sv1 = new SinhVien("Tiến", "PH00555", 2000, 1);
            SinhVien sv2 = new SinhVien("Long", "PH00556", 2000, 2);
            SinhVien sv3 = new SinhVien("Hoàng", "PH00557", 2000, 3);
            SinhVien sv4 = new SinhVien("Anh", "PH00558", 2000, 4);
            SinhVien sv5 = new SinhVien("Dũng", "PH00559", 2000, 5);
            lstSinhViens.Add(sv1);
            lstSinhViens.Add(sv2);
            lstSinhViens.Add(sv3);
            lstSinhViens.Add(sv4);
            lstSinhViens.Add(sv5);
        }

        void sortSinhVien()
        {
            var lstTempSort = lstSinhViens.OrderBy(c => c.Ten);
            // Sử dụng sắp xếp bằng LINQ
            foreach (var x in lstSinhViens.OrderBy(c => c.Ten))
            {
                x.inRaManHinh();
            }
        }

        void timKiemTheoMa()
        {
            Console.WriteLine("Mời bạn nhập mã sinh viên: ");
            string msv = Console.ReadLine();
            //Cách tìm kiếm sử dụng vòng lặp
            foreach (var x in lstSinhViens)
            {
                if (x.Msv == msv)
                {
                    x.inRaManHinh();
                }
            }
            //Sử dụng Linq để in 1 đối tượng ra màn hình dựa vào điều kiện tìm kiếm
            lstSinhViens.Where(c => c.Msv == msv).FirstOrDefault().inRaManHinh();
        }
    }
}
