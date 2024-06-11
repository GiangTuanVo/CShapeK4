using Inheritance.Inheritance;
using Inheritance.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class HinhHoc
    {
        protected double ChuVi { get; set; }
        protected double DienTich { get; set; }
        public HinhHoc()
        {

        }
        public HinhHoc(double chuVi, double dienTich)
        {
            ChuVi = chuVi;
            DienTich = dienTich;
        }
        public virtual void SetValue(double chuvi,double dientich)
        {
            ChuVi = chuvi;
            DienTich = dientich;
        }
        public void SetValue(double chuvi)
        {
            ChuVi = chuvi;
        }
        public void SetValue()
        {
            ChuVi = 10;
            DienTich = 10;
        }
        public override string ToString()
        {
            return $"ChuVi= {ChuVi}, DienTich= {DienTich}";
        }
    }
    class HinhTron : HinhHoc
    {
        public double PI = 3.14;
        public HinhTron(double chuVi, double dienTich)
            : base(chuVi, dienTich)
        {
        }
    }
    class HinhVuong : HinhHoc
    {
        public HinhVuong(double chuVi, double dienTich) : base(chuVi, dienTich)
        {
        }
        public override void SetValue(double chuvi, double dientich)
        {
            ChuVi = chuvi;
            DienTich = dientich;
        }
    }

    interface ILamViec
    {
        string LamViec(string tenViec);
    }

    class SinhVien : ILamViec
    {
        public string MSSV { get; set; }
        public string Nganh { get; set; }
        public string HoTen { get; set; }

        public string LamViec(string tenViec)
        {
            return "Sinh Vien " + HoTen + " dang " + tenViec;
        }
    }
    class NhanVien : ILamViec
    {
        public string MSNV { get; set; }
        public string Phong { get; set; }
        public string HoTen { get; set; }
        public int HsLuong { get; set; }
        public virtual int Luong
        {
            get { return HsLuong * 800000; }
        }

        public string LamViec(string tenViec)
        {
            return "NhanVien " + HoTen + " dang " + tenViec;
        }
    }



    class Program
    {
        static void Main(string[] args)
        {
            DellComputers dell = new DellComputers();
            dell.GetLaptops();
            dell.GetMark();
            Console.WriteLine(dell.ToString());
            IComputer computer1 = dell as IComputer;

            IComputer computer = new DellComputers();
            computer.GetDesktops();
            Console.WriteLine(computer.ToString());
            if(computer is IDellComputer)
            {

            }
            Console.ReadLine();

            IDellComputer dellComputer = new DellComputers();
            dellComputer.GetMark();


            HinhHoc hh = new HinhTron(12,10);
            Console.WriteLine(hh.ToString());


            HinhTron hinhTron = new HinhTron(12, 24);
            Console.WriteLine(hinhTron.ToString());
            HinhVuong hinhVuong = new HinhVuong(56, 45);
            hinhVuong.SetValue(10, 13);
            Console.WriteLine(hinhVuong.ToString());
            Console.ReadLine();




            Console.OutputEncoding = Encoding.UTF8;
            Employee nv = new Employee();
            nv.SetValve("Nguyễn Văn Tèo", 9503, "Nam", 25);
            nv.SetValue2();
            Console.WriteLine(nv.ToString());

            Teacher teacher = new Teacher();
            teacher.SetValve("Nguyễn Văn Tèo", 9503, "Nam", 25);
            teacher.FindSalary();
            teacher.SetPosition();
            Console.WriteLine(teacher.ToString());
            Console.ReadLine();





            PhanSo phanSoA = new PhanSo(2, 4);
            PhanSo phanSoB = new PhanSo(4, 5);
            PhanSo phanSoC = new PhanSo();
            PhanSo ret = phanSoC.Cong(phanSoA, phanSoB);
            Console.WriteLine(ret);



            Product product1 = new Product();
            //Product product2 = new Product("Táo", "Xanh", "Nhỏ");
            //Console.WriteLine(product2.name);
            //Console.WriteLine(product2.GetColor());
            Product product3 = new Product("Xoài");
            product3.Color = Color.Blue;
            product3.Size = "Lớn";
            Console.WriteLine(product3.ToString());

            //Product SamSung = new Product("Phone", "Silver", "Small");
            //Console.WriteLine(SamSung.ToString());

            //Product Apple = new Product();
            //Apple.Color = "Blue";
            //Apple.Name = "Apple";
            //Apple.Size = "Big";
            //Console.WriteLine(Apple.ToString());

            //WriteFile.number = 10;
            //WriteFile.WriteText("Hello Everyone!");

            //Console.OutputEncoding = Encoding.UTF8;


            //PhanSo phanSo = new PhanSo();
            //phanSo.tuSo = 10;
            //phanSo.mauSo = 5;
            //Console.WriteLine(phanSo.ToString());
            //Console.WriteLine(phanSo.PhepChia());

            Console.ReadLine();
        }
    }
}
