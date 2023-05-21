using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_3._0_TinhKeThua
{
    /*
    * Muốn sử dụng kế thừa sử dụng dấu : <Tên lớp cha>
    * 1 con thì chỉ có 1 cha
    * Khi đã kế thừa lớp con hoàn toàn kế thừa lại những thuộc tính và phương thức mà cha nó cho phép
    */
    class SinhVien :Person
    {
        private string msv;
        private double diemJava;
        private double diemCsharp;

        public SinhVien()
        {

        }

        // chuột phải vào Person, sau đó : 
        /*
         * Bước 1: Chuột phải vào Class Cha kế thừa ở trên chọn Quick Action.... -->Contructor
         * Bước 2: Bôi vào thuộc tính của lớp con chọn Add Param...-->Chọn đến contructor vừa tạo
         */
        public SinhVien(string ten, string ho, string tenDem, string sdt, string email, string msv, double diemJava, double diemCsharp) : base(ten, ho, tenDem, sdt, email)
        {
            this.Msv = msv;
            this.DiemJava = diemJava;
            this.DiemCsharp = diemCsharp;
            //this: Dùng để tham chiếu đến thuộc tính và phương thức của lớp hiện tại
            //base: Dùng để tham chiếu đến thuộc tính và phương thức của lớp cha
        }

        public string Msv { get => msv; set => msv = value; }
        public double DiemJava { get => diemJava; set => diemJava = value; }
        public double DiemCsharp { get => diemCsharp; set => diemCsharp = value; }

        public void inRaManHinhSinhVien()
        {
            Console.WriteLine(" -Họ và Tên: {0}\n -SĐT: {1}\n -Email: {2}\n -Mã Sinh Viên: {3}\n -Diem Java: {4}\n -Diem Csharp: {5}",(Ho + " " + TenDem + " " + Ten), Sdt, Email, Msv, DiemJava, DiemCsharp);
        }
        //public override void inPersonChoConSuDung()
        //{
        //    //base.inPersonChoConSuDung();
        //    Console.WriteLine("Đây là text in ra inRaManHinhCuaChaChoConSuDung() nằm ở bên lớp Con");
        //}
    }
}
