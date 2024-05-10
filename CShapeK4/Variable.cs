//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace CShapeK4
//{
//    class Variable
//    {
//        static void Main(string[] args)
//        {
//            bool kieu_bool = true; //0,1
//            char kieu_char = 'A'; //8bit
//            string kieu_string = "Hello";// 40bit
//            short kieu_short = 120;//16bit
//            ushort kieu_ushort = 213;//16bit
//            Int16 kieu_Int16 = 120;
//            UInt16 kieu_UInt16 = 1210;
//            int kieu_int = -324264735;//32bit
//            uint kieu_uint = 34567;
//            Int32 kieu_Int32 = -45678;
//            UInt32 kieu_UInt32 = 3456789;
//            long kieu_long = 1234567890;//64bit
//            ulong kieu_ulong = 23456789;
//            Int64 kieu_Int64 = 2345890;
//            UInt64 kieu_UInt64 = 34567890;
//            float kieu_float = 12.34f;

//            double kieu_double = 12.335;

//            Cách 1
//            short nSize = 5; //16bit
//            string strName = "";

//            float num = (float)nSize / 2;//=0->0.5
//            Console.WriteLine(num);

//            float fSize = 5.0f;//32bit kiểu dấu pa
//            int uRet = (int)fSize / 2; //32bit
//            Console.WriteLine(uRet);
//            Console.ReadLine();

//            Cách 2
//            string str_read = Console.ReadLine();
//            bool type_bool = Convert.ToBoolean(str_read);
//            Int16 type_Int16 = Convert.ToInt16(str_read);
//            Int32 type_Int32 = Convert.ToInt32(str_read);
//            Int64 type_Int64 = Convert.ToInt64(str_read);
//            float type_float = Convert.ToSingle(str_read);
//            double type_double = Convert.ToDouble(str_read);

//            Cách 3

//            bool type_bool = bool.Parse(str_read);
//            Int16 type_Int16 = Int16.Parse(str_read);
//            Int32 type_Int32 = Int32.Parse(str_read);
//            Int64 type_Int64 = Int64.Parse(str_read);
//            float type_float = float.Parse(str_read);
//            double type_double = double.Parse(str_read);

//            Cách 4
//            bool.TryParse(str_read, out bool ret_bool);
//            Int16.TryParse(str_read, out Int16 ret_int16);
//            Int32.TryParse(str_read, out Int32 ret_int32);
//            Int64.TryParse(str_read, out Int64 ret_int64);
//            float.TryParse(str_read, out float ret_float);
//            double.TryParse(str_read, out double ret_double);

//            Kiểm tra vùng giá trị
//            Console.WriteLine($"Min: {float.MinValue}, Max: {float.MaxValue}");

//            var vNumber = 1.34567;
//            Console.WriteLine(vNumber.GetType());
//            Console.ReadLine();


//            const double PI = 3.14;//Chú ý tên viết hoa

//            Console.WriteLine("Nhap so thu nhat");
//            string strNumber1 = Console.ReadLine();
//            Console.WriteLine("Nhap so thu hai");
//            string strNumber2 = Console.ReadLine();

//            int nNumber1 = Convert.ToInt32(strNumber1);
//            int nNumber2 = Convert.ToInt32(strNumber2);

//            int result = nNumber1 + nNumber2;
//            Console.WriteLine($"Ket qua: {result}");


//        }
//    }
//}
