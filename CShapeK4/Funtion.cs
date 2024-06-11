//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace CShapeK4
//{
//    class Funtion
//    {
//        static void HienThongTin()
//        {
//            Console.WriteLine("Chao buoi toi");
//        }
//        static int PhepCong(int num1, int num2)
//        {
//            HienThongTin();
//            return num1 + num2;
//        }
//        static void PhepCong(int num1, int num2, ref int num3)
//        {
//            num3 = num1 + num2;
//        }
//        static int TinhGiaiThua(int num)
//        {
//            int kq = 1;
//            for (int i = 1; i <= num; i++)
//            {
//                kq *= i;
//            }
//            return kq;
//        }

//        static void TangSo1(int num, out int value)
//        {
//            int i = 1;
//            while (i <= num)
//            {
//                i *= 2;
//            }
//            value = i;
//        }
//        static void TangSo2(int num, ref int value)
//        {
//            int i = 1;
//            while (i <= num)
//            {
//                i *= 2;
//            }
//            value = i;
//        }

//        static void ShowRandom(int num, int min, int max)
//        {
//            Random rd = new Random();
//            for (int i = 0; i < num; i++)
//            {
//                Console.WriteLine(rd.Next(min, max));
//            }
//        }
        
//        static float ConvertNumber(string num)
//        {
//            try
//            {
//                //code
//                return float.Parse(num);
//            }
//            catch (Exception ex)
//            {
//                Console.WriteLine(ex.ToString());
//                return -1;
//            }
//        }


//        static void Main(string[] args)
//        {
//            label01:
//            Console.WriteLine("Vui long nhap so:");
//            string text = Console.ReadLine();
//            Console.WriteLine($"KQ = {ConvertNumber(text)}");
//            goto label01;


//            ShowRandom(10, 0, 100);
//            DateTime dt = DateTime.Now;
//            Console.WriteLine(dt);
//            Console.WriteLine(dt.ToString("yyyy/MM/dd"));
//            double PI = Math.PI;



//            //HienThongTin();
//            int kq = PhepCong(10, 12);
//            //Console.WriteLine(kq);
//            //Console.WriteLine(TinhGiaiThua(5));

//            TangSo1(10, out int val);

//            int value = 0;

//            PhepCong(10, 12, ref value);

//            TangSo2(10, ref value);

//            Console.ReadKey();
//        }
//    }
//}
