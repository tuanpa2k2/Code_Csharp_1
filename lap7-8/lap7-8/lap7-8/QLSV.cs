using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lap7_8
{
    class QLSV
    {
        List<Sinhvien> lstSinhVien = new List<Sinhvien>();
        List<Sinhvien> lstIn = new List<Sinhvien>();
        DateTime today = new DateTime();
        public QLSV()
        {

        }

        public void them()
        {
            Sinhvien sv0 = new Sinhvien("Anh", "1", 1990);
            int a = 1;
            bool b = true;
            for (int i = 0; i < a; i++)
            {
                Sinhvien sv = new Sinhvien();
                Console.Write("{0}.Nhập tên : ", (i + 1));
                sv.Ten = Console.ReadLine();
                Console.Write("{0}.Nhập Msv : ", (i + 1));
                sv.Msv = Console.ReadLine();
                Console.Write("{0}.Nhập năm sinh : ", (i + 1));
                sv.NamSinh = Convert.ToInt32(Console.ReadLine());
                lstSinhVien.Add(sv);
                Console.WriteLine("Nhập thêm sinh viên");
                Console.WriteLine("1.Có");
                Console.WriteLine("2.Không");
                Console.Write("Chọn chức năng : ");
                string number = Console.ReadLine();
                while (b)
                {
                    if (number == "1")
                    {
                        a++;
                        b = false;
                    }
                    else if (number == "2")
                    {
                        Console.WriteLine("Thêm thành công");
                        b = false;
                    }
                    else
                    {
                        Console.WriteLine("Chức năng không tồn tại");
                    }
                }
            }
        }


        public void xuat()
        {
            Console.WriteLine("1.Xuất 1 đối tượng ");
            Console.WriteLine("2.Xuất danh sách đối tượng");
            Console.Write("Chọn chức năng : ");
            string press = Console.ReadLine();
            switch (press)
            {
                case "1":
                    Console.Write("Nhập mã sinh viên đối tượng muốn in : ");
                    string number = Console.ReadLine();
                    for (int i = 0; i < lstSinhVien.Count; i++)
                    {
                        if(lstSinhVien[i].Msv == number)
                        {
                            lstSinhVien[i].inThongTin();
                        }
                    }
                    break;
                case "2":
                    Console.Write("Số lượng đối tượng muốn in : ");
                    int number1 = Convert.ToInt32(Console.ReadLine());
                    for (int i = 0; i < number1; i++)
                    {
                        Console.Write("Nhập mã sinh viên: ");
                        string msv1 = Console.ReadLine();
                        for (int x = 0; x < lstSinhVien.Count; x++)
                        {
                            if (lstSinhVien[x].Msv == msv1)
                            {
                                lstIn.Add(lstSinhVien[i]);
                            }
                        }
                    }

                    foreach (var item in lstIn)
                    {
                        item.inThongTin();
                    }
                    break;
                default:
                    Console.WriteLine("Chức năng không tồn tại");
                    break;
            }
        }

        public void tuoi20()
        {
            foreach (var item in lstSinhVien)
            {
                if (today.Year - item.NamSinh >= 20 )
                {
                    item.inThongTin();
                }
            }
        }

        public void tim()
        {
            Console.Write("Nhập Msv muốn tìm : ");
            string msv2 = Console.ReadLine();
            foreach (var item in lstSinhVien)
            {
                if(item.Msv == msv2)
                {
                    item.inThongTin();
                }
            }
        }

        public void udpm()
        {
            SinhvienUDPM sv1 = new SinhvienUDPM("Hải Anh", "PH17289", 2002, 9, 9);
            sv1.inThongTin();
        }
    }
}
