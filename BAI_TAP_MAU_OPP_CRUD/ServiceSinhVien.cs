using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_TAP_MAU_OPP_CRUD
{
    class ServiceSinhVien
    {
        private List<Student> _lstStudents = new List<Student>();
        private Student _student;
        private string _input;

        public ServiceSinhVien()
        {
            Student sv1 = new Student("Phí", "Anh", "Tuan", "036 526 9311", "PH18296", "Tuanpaph18296", 6.5);
            Student sv2 = new Student("Trần", "Anh", "Thứ", "036 526 9311", "PH18297", "thaopaph18296", 7.5);
            Student sv3 = new Student("Phí", "Anh", "Em", "036 526 9311", "PH18298", "Thupaph18296", 8.5);

            _lstStudents.Add(sv1);
            _lstStudents.Add(sv2);
            _lstStudents.Add(sv3);
        }
        private string getIndexValue(string mess)
        {
            Console.Write("Mời bạn nhập "+ mess);
            return Console.ReadLine();
        }
        public void themSV()
        {
            _input = getIndexValue("số lượng cần thêm: ");
            for (int i = 0; i < Convert.ToInt32(_input); i++)
            {
                _student = new Student();
                _student.Ho = getIndexValue("Họ: ");
                _student.TenDem = getIndexValue("Tên đệm: ");
                _student.Ten = getIndexValue("Tên: ");
                _student.Sdt = getIndexValue("SĐT: ");
                _student.Email = getIndexValue("Email: ");
                _student.Msv = getIndexValue("Mã sinh viên: ");
                _student.DiemCsharp = Convert.ToDouble(getIndexValue("Điểm C#: "));

                _lstStudents.Add(_student);
            }
        }

        public void xuatDanhSachSv()
        {
            inds(_lstStudents);//gọi phương thức "inds" để in danh sách sinh viên
        }
        //Tìm kiếm .
        public void timKiemSV()
        {
            _input = getIndexValue("Mã sinh viên cần tìm: ");
            int temp = getIndexSV(_input);
            if (temp == -1)
            {
                Console.WriteLine("Mã sinh viên không tồn tại !");
                return;
            }
            _lstStudents[temp].inPersonRaManHinhChoConSuDung();
        }
        // xóa giống tìm kiếm.
        public void xoaSV()
        {
            _input = getIndexValue("Tên cần xóa: ");
            int temp = getIndexSV(_input);
            if (temp == -1)
            {
                Console.WriteLine("Tên sinh viên không tồn tại !");
                return;
            }
            _lstStudents.RemoveAt(temp);
            Console.WriteLine("Bạn đã xóa thành công !");
            _lstStudents[temp].inPersonRaManHinhChoConSuDung();
        }
        //Sửa 
        public void suaSV()
        {
            _input = getIndexValue("Tên cần sửa: ");
            int temp = getIndexSV(_input);
            if (temp == -1)
            {
                Console.WriteLine("Mã sinh viên không tồn tại !");
                return;
            }
            Console.OutputEncoding = Encoding.GetEncoding("UTF-8");
            Console.WriteLine("1: Họ");
            Console.WriteLine("2: Tên đệm");
            Console.WriteLine("3: Tên");
            Console.WriteLine("4: SĐT");
            Console.WriteLine("5: Thoát");
            Console.Write("Bạn muốn sửa gì: ");
            _input = Console.ReadLine();

            switch (_input)
            {
                case "1":
                    Console.WriteLine("Họ cũ: "+ _lstStudents[temp].Ho);
                    _lstStudents[temp].Ho = getIndexValue("họ cần sửa: ");
                    break;
                case "2":
                    Console.WriteLine("Tên đệm cũ: " + _lstStudents[temp].TenDem);
                    _lstStudents[temp].TenDem = getIndexValue("tên đệm cần sửa: ");
                    break;
                case "3":
                    Console.WriteLine("Tên cũ: " + _lstStudents[temp].Ten);
                    _lstStudents[temp].Ten = getIndexValue("tên cần sửa: ");
                    break;
                case "4":
                    Console.WriteLine("SĐT cũ: " + _lstStudents[temp].Sdt);
                    _lstStudents[temp].Sdt = getIndexValue("sđt cần sửa: ");
                    break;
                default:
                    Console.WriteLine("Chức năng không tồn tại , mời bạn nhập lại !");
                    break;
            }
            _lstStudents[temp].inPersonRaManHinhChoConSuDung();
        }
        public void sapXepDanhSachSv()
        {
            inds(_lstStudents.OrderBy(c=>c.Ten).ToList());
        }

        public void inds(List<Student> lstStudents)
        {
            foreach (var x in lstStudents)
            {
                x.inPersonRaManHinhChoConSuDung();
            }
        }

        //Phương thức trả ra "index" dựa vào mã sv nhập vào 
        public int getIndexSV(string msv)
        {
            for (int i = 0; i < _lstStudents.Count; i++)
            {
                if (_lstStudents[i].Msv == msv)
                {
                    return i; // Tìm thấy thì sẽ trả về "index" trong danh sách
                }
            }
            return -1; ///Không tìn thấy thì trả về -1
        }
    }
}
