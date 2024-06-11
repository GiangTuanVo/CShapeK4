//using System;
//using System.Collections.Generic;
//using System.IO;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace CShapeK4
//{
//    class Chuoi
//    {
//        static int CompareChar(char kt1, char kt2)
//        {
//            return kt1.CompareTo(kt2);
//        }
//        static bool Equals(char kt1, char kt2)
//        {
//            return kt1.Equals(kt2);
//        }




//        static void Main(string[] args)
//        {
//            Console.OutputEncoding = Encoding.UTF8;
//            string text = "Hello";
//            char[] kt = new char[5];
//            text.CopyTo(0, kt, 0, 5);

//            string txt1 = "Xin chao";
//            string txt2 = "Nguyen Van A";

//            string[] split = txt2.Split(' ');
//            foreach (var item in split)
//            {
//                Console.WriteLine(item);
//            }

//            Console.WriteLine(string.Join(" ", split));

//            string ret = txt1.Insert(3, txt2);
//            Console.WriteLine(ret);

//            string padleft = txt1.PadRight(15,'_'); //tong chieu dai
//            Console.WriteLine(padleft);

//            string remov = txt1.Remove(3, txt1.Length - 3);
//            Console.WriteLine(remov);

//            string replace = txt1.Replace("chao", "Viet Nam");
//            Console.WriteLine(replace);

//            string substring = txt1.Substring(4, 4);
//            Console.WriteLine(substring);

//            Console.WriteLine(txt1.ToLower());
//            Console.WriteLine(txt1.ToUpper());

//            string txt = string.Format("{0},{1}", txt1, txt2);
//            txt = $"{txt1},{txt2}";
//            txt = txt1 + "," + txt2;

//            string s = string.Format("Giá thành sản phẩm = {0:C}", 200);

//            int hex = 1234;
//            string HEX = hex.ToString("X4");//16

//            DateTime dt = DateTime.Now;
//            string date = dt.ToString("yyyy/MM/dd");
//            string time = dt.ToString("HH:mm:ss");
//            Console.WriteLine(txt);
//            Console.WriteLine(s);
//            Console.WriteLine(HEX);
//            Console.WriteLine(date);
//            Console.WriteLine(time);
//            Console.ReadLine();

//            if (text.StartsWith("o"))
//            {
//                //code
//            }
//            else
//            {

//            }


//            //string text = "4103131881@00002812692@GKFPBNAGG3-P4-L2-B2-E1-R10-DRC";
//            //if (text.Contains("@"))
//            //{
//            //    string[] spl = text.Split('@');
//            //    foreach (var item in spl)
//            //    {
//            //        Console.WriteLine(item);
//            //    }
//            //}
//            //string text = "Hello";

//            //for (int i = 0; i < text.Length; i++)
//            //{
//            //    Console.WriteLine(text[i]);
//            //}
//            //char[] kt = text.ToCharArray();

//            //for (int i = 0; i < kt.Length; i++)
//            //{
//            //    Console.WriteLine(kt[i]);
//            //}

//            //DateTime dt = DateTime.Now;
//            //string text = dt.ToString("HH:mm:ss");
//            //string text = Convert.ToString(dt);
//            //string path = @"D:\C Shape\Train\CShapeK4\CShapeK4";
//            //string path = "D:\\C Shape\\Train\\CShapeK4\\CShapeK4\\text.txt";
//            //string text = File.ReadAllText(path);
//            Console.WriteLine(text);
//            Console.ReadLine();
//            //label:
//            //    Console.WriteLine("Nhap KT1:");
//            //    char kt1 = Char.Parse(Console.ReadLine());
//            //    Console.WriteLine("Nhap KT1:");
//            //    char kt2 = Char.Parse(Console.ReadLine());
//            //    Console.WriteLine("KQ : {0}", Equals(kt1, kt2));
//            //    //Console.WriteLine("KQ : {0}", CompareChar(kt1, kt2));
//            //    goto label;

//        }
//    }
//}
