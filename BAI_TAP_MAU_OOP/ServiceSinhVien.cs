using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_TAP_MAU_OOP
{
    class ServiceSinhVien//Là nơi code các chứng năng của đối tượng
    {
        //Bien toan cuc 
        int _input;
        SinhVien[] _arrSinhViens;//Khai báo mảng Sinh Viên
        public ServiceSinhVien()
        {

        }

        //Tạo 2 đối tượng bằng bằng contructor có tham số và không tham số
        public void bai1TaoDoiTuongSuDungContructor()
        {
            Console.WriteLine("Bài 1: In đối tượng sẵn có do mk lập trình trong máy .");
            //Cách 1: Contrcutor có tham số
            SinhVien sv1 = new SinhVien("Tiến", "PH00555", 2000, 5.6);

            //Cách 2: Contrcutor không tham số
            SinhVien sv2 = new SinhVien();
            sv2.Ten = "Long";
            sv2.Msv = "PH00556";
            sv2.NamSinh = 2001;
            sv2.DiemCsharp = 5.9;

            sv1.inRaManHinh();
            sv2.inRaManHinh();
        }
        private string getIndexValue(string mess)
        {
            Console.Write("Mời bạn nhập " + mess);
            return Console.ReadLine();
        }
        //Tạo nhiều đối tượng sử dụng Array
        public void bai3TaoNhieuDoiTuongArray()
        {

            Console.WriteLine("Bài 3: Tạo nhiều đối tượng do ng dùng nhập từ bàn phím (Array) .");
            Console.WriteLine(" Bạn muốn nhập vào bao nhiêu sinh viên: ");
            _input = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("--------------------------------------------------------");
            //Sau khi nhận được số lượng người dùng muốn
            _arrSinhViens = new SinhVien[_input];//Khởi tạo mảng Sinh viên theo mong muốn người dùng
            for (int i = 0; i < _input; i++)
            {
                _arrSinhViens[i] = new SinhVien();//KHởi tạo đối tượng tại index
                _arrSinhViens[i].Ten = getIndexValue("tên: ");
                _arrSinhViens[i].Msv = getIndexValue("mã sv: ");
                _arrSinhViens[i].NamSinh = Convert.ToInt32(getIndexValue("năm sinh: "));
                _arrSinhViens[i].DiemCsharp = Convert.ToDouble(getIndexValue("điểm C#1: "));
                Console.WriteLine("----------------------------------------");
            }
        }
        public void inDsSinhVien()
        {
            if (_arrSinhViens.Length < 0)
            {
                return;
            }
            for (int i = 0; i < _arrSinhViens.Length; i++)
            {
                Console.WriteLine("---------------------------------------------------");
                _arrSinhViens[i].inRaManHinh();//In từng sinh viên ra màn hình
            }
        }
        public void themSinhVienList()
        {
            //Khai báo list SinhVien
            List<SinhVien> lstsinhViens = new List<SinhVien>();
            SinhVien sv1;
            Console.Write(" Bạn muốn thêm vào bao nhiêu sinh viên: ");
            _input = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < _input; i++)
            {
                sv1 = new SinhVien();
                sv1.Ten = getIndexValue("tên: ");
                sv1.Msv = getIndexValue("mã sv: ");
                sv1.NamSinh = Convert.ToInt32(getIndexValue("năm sinh: "));
                sv1.DiemCsharp = Convert.ToDouble(getIndexValue("điểm C#1: "));

                lstsinhViens.Add(sv1);
            }
        }
    }
}