using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class ServiceDanhBa
    {
        private List<DanhBa> _lstDanhBas = new List<DanhBa>();
        private List<DanhBa> _newDanhBas = new List<DanhBa>();
        private DanhBa _danhBa;
        private string _input;

        public ServiceDanhBa()
        {
            fakedata();
        }
        void fakedata()
        {
            DanhBa st1 = new DanhBa("Phi", "Anh", "Tuan", 2002, "Nam", "0365269311", "0000000000", "tuanpaph@gmail.com", "abcdef");
            DanhBa st2 = new DanhBa("Phi", "Anh", "Anh", 2003, "Nam", "0365269312", "0000000000", "anhpaph@gmail.com", "No");
            DanhBa st3 = new DanhBa("Phi", "Anh", "Em", 2004, "Nam", "0365269313", "0000000000", "empaph@gmail.com", "abcdef");
            DanhBa st4 = new DanhBa("Ngo", "Dinh", "Tiep", 2005, "Nam", "0865953212", "0000000000", "tiepndph@gmail.com", "No");
            DanhBa st5 = new DanhBa("Ngo", "Dinh", "Anh", 2001, "Nam", "0365269312", "0000000000", "anhndph@gmail.com", "abcdef");
            DanhBa st6 = new DanhBa("Ngo", "Dinh", "Em", 2000, "Nam", "0365269313 ", "0000000000", "empand@gmail.com", "No");
            DanhBa st7 = new DanhBa("Bui", "Tuan", "Anh", 2001, "Nam", "0389839506", "0000000000", "anhbtph@gmail.com", "abcdef");
            DanhBa st8 = new DanhBa("Bui", "Tuan", "Em", 2002, "Nu", "0365269312", "0000000000", "embtph@gmail.com", "No");
            DanhBa st9 = new DanhBa("Tran", "Thi", "Thao", 2002, "Nu", "0375872186", "0000000000", "thaottph@gmail.com", "abcdef");
            _lstDanhBas.Add(st1);
            _lstDanhBas.Add(st2);
            _lstDanhBas.Add(st3);
            _lstDanhBas.Add(st4);
            _lstDanhBas.Add(st5);
            _lstDanhBas.Add(st6);
            _lstDanhBas.Add(st7);
            _lstDanhBas.Add(st8);
            _lstDanhBas.Add(st9);
        }
        public void xuatDanhSach()
        {
            inds(_lstDanhBas);
        }
        void inds(List<DanhBa> lstStudents)
        {
            int o = 1;
            foreach (var x in lstStudents)
            {
                Console.WriteLine("\nSTT: {0}", o);
                o++;
                if (x.NamSinh == 2002)
                {
                    x.danhxung = "Bạn";
                }
                else
                {
                    bool a = x.NamSinh < 2002;
                    x.danhxung = "Em";
                    if (a == true)
                    { x.danhxung = x.GioiTinh == "Nam" ? "Anh" : "Chị"; }
                }
                x.inNguoiRaManHinh();
            }
        }

        private string getValueIndex(string mess)
        {
            Console.Write("Mời bạn nhập " + mess);
            return Console.ReadLine();
        }
        public void themNguoi()
        {
            do
            {
                _input = getValueIndex("số lượng cần thêm: ");
                for (int i = 0; i < Convert.ToInt32(_input); i++)
                {
                    Console.WriteLine("------------------------------------------");
                    _danhBa = new DanhBa();
                    Console.WriteLine("Thông tin sinh viên thứ " + (i + 1) + ":");
                    _danhBa.Ho = getValueIndex("họ: ");
                    _danhBa.TenDem = getValueIndex("tên đệm: ");
                    _danhBa.Ten = getValueIndex("tên: ");
                    _danhBa.NamSinh = Convert.ToInt32(getValueIndex("năm sinh: "));
                    _danhBa.GioiTinh = getValueIndex("giới tính: ");
                    _danhBa.Sdt1 = getValueIndex("SĐT_1: ");
                    _danhBa.Sdt2 = getValueIndex("SĐT_2: ");
                    _danhBa.Email = getValueIndex("email: ");
                    _danhBa.GhiChu = getValueIndex("ghi chú: ");

                    _lstDanhBas.Add(_danhBa);
                }
                Console.WriteLine("Bạn có muốn thêm nữa k (y|n)?");
                _input = Console.ReadLine();
            } while (!(_input.ToLower() == "n"));
            Console.WriteLine("---> Bạn đã thêm thành công !");
        }
        public void suaNguoi()
        {
            _input = getValueIndex("tên cần sửa: ");
            int temp = getIndexNguoi(_input);
            if (temp == -1)
            {
                Console.WriteLine("==> Tên không tồn tại trong danh bạ.");
                return;
            }
            Console.OutputEncoding = Encoding.GetEncoding("UTF-8");
            Console.WriteLine("--------------------------------------------------------------");
            Console.WriteLine("Các phần được phép sửa: ");
            Console.WriteLine(" 1. Họ: " + _lstDanhBas[temp].Ho);
            Console.WriteLine(" 2. Tên đệm: " + _lstDanhBas[temp].TenDem);
            Console.WriteLine(" 3. Tên: " + _lstDanhBas[temp].Ten);
            Console.WriteLine(" 4. Năm sinh: " + _lstDanhBas[temp].NamSinh);
            Console.WriteLine(" 5. Giới tính: " + _lstDanhBas[temp].GioiTinh);
            Console.WriteLine(" 6. SĐT_1: " + _lstDanhBas[temp].Sdt1);
            Console.WriteLine(" 8. Email: " + _lstDanhBas[temp].Email);
            Console.WriteLine(" 9. Ghi chú: " + _lstDanhBas[temp].GhiChu);
            Console.Write("Bạn muốn sửa phần nào: ");
            _input = Console.ReadLine();

            switch (_input)
            {
                case "1":
                    _lstDanhBas[temp].Ho = getValueIndex("Họ cần thay đổi: ");
                    break;
                case "2":
                    _lstDanhBas[temp].TenDem = getValueIndex("Tên đệm cần thay đổi: ");
                    break;
                case "3":
                    _lstDanhBas[temp].Ten = getValueIndex("tên cần sửa: ");
                    break;
                case "4":
                    _lstDanhBas[temp].NamSinh = Convert.ToInt32(getValueIndex("Năm sinh cần thay đổi: "));
                    break;
                case "5":
                    _lstDanhBas[temp].GioiTinh = getValueIndex("Giới tính cần thay đổi: ");
                    break;
                case "6":
                    _lstDanhBas[temp].Sdt1 = getValueIndex("SĐT_1 cần sửa: ");
                    break;
                case "8":
                    _lstDanhBas[temp].Email = getValueIndex("Email cần sửa: ");
                    break;
                case "9":
                    _lstDanhBas[temp].GhiChu = getValueIndex("Ghi chú cần sửa: ");
                    break;
                case "10":
                    Console.WriteLine("___Thanks You___");
                    break;
                default:
                    Console.WriteLine("==> Bạn nhập sai chức năng của bài, Vui lòng nhập lại <3.");
                    Console.ReadKey();
                    break;
            }
            Console.WriteLine("---> Bạn đã sửa thành công !");
        }
        public void xoaNguoi()
        {
            _input = getValueIndex("Tên cần xóa khỏi danh bạ: ");
            int temp = getIndexNguoi(_input);
            if (temp == -1)
            {
                Console.WriteLine("==> Tên cần xóa không có trong danh bạ, Vui lòng nhập lại !");
                return;
            }
            //_lstDanhBas[temp].inNguoiRaManHinh();
            _lstDanhBas.RemoveAt(temp);
            Console.WriteLine("---> Bạn đã xóa thành công !");
        }
        public void timKiemNguoi()
        {
            _input = getValueIndex("Tên cần tìm kiếm: ");
            int temp = getIndexNguoi(_input);
            if (temp == -1)
            {
                Console.WriteLine("Tên cần tìm không có trong danh bạ, Vui lòng nhập lại !");
                return;
            }
            _lstDanhBas[temp].inNguoiRaManHinh();
        }
        public int getIndexNguoi(string ten)
        {
            for (int i = 0; i < _lstDanhBas.Count; i++)
            {
                if (_lstDanhBas[i].Ten == ten)
                {
                    return i;
                }
            }
            return -1;
        }
        //public void timKiemNguoi()
        //{
        //    Console.Write("Mời bạn nhập Tên cần tìm kiếm trong danh bạ: ");
        //    string tens = Console.ReadLine();

        //    _lstDanhBas.Where(c => c.Ten == tens).FirstOrDefault().inNguoiRaManHinh();
        //}
        public void timKiemsdt()
        {
            _input = getValueIndex("Sđt cần tìm kiếm: ");
            int temp = getIndexsdt(_input);
            if (temp == -1)
            {
                Console.WriteLine("SĐT cần tìm không có trong danh bạ.");
                return;
            }
            _lstDanhBas[temp].inNguoiRaManHinh();
        }
        public int getIndexsdt(string sdt)
        {
            for (int i = 0; i < _lstDanhBas.Count; i++)
            {
                if (_lstDanhBas[i].Sdt1 == sdt)
                {
                    return i;
                }
                if (_lstDanhBas[i].Sdt2 == sdt)
                {
                    return i;
                }
            }
            return -1;
        }

        public void TimSDTgandung()
        {
            _input = getValueIndex("Sđt gợi ý cần tìm: ");

            foreach (var x in _lstDanhBas.Where(c => c.Sdt1.StartsWith(_input) || c.Sdt2.StartsWith(_input)))
            {
                Console.WriteLine("----------------------");
                x.inNguoiRaManHinh();
            }
        }
        public void TimTengandung()
        {
            _input = getValueIndex("Tên gợi ý cần tìm kiếm: ");
            foreach (var x in _lstDanhBas.Where(c => c.Ten.StartsWith(_input)))
            {
                Console.WriteLine("----------------------");
                x.inNguoiRaManHinh();
            }
        }
        public void sapXepTheoTenXuoi()
        {
            _newDanhBas = _lstDanhBas.OrderBy(c => c.Ten).ToList();
            _lstDanhBas.Clear();
            _lstDanhBas = _newDanhBas;
            Console.WriteLine("Sắp xếp thành công !");
        }
        public void sapXepTheoTenNguoc()
        {
            _newDanhBas = _lstDanhBas.OrderByDescending(c => c.Ten).ToList();
            _lstDanhBas.Clear();
            _lstDanhBas = _newDanhBas;
            Console.WriteLine("Sắp xếp thành công !");
        }
    }
}
