//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace CShapeK4
//{
//    class Dictionary
//    {
//        static Dictionary<string, string> TuDien()
//        {
//            Dictionary<string, string> tuvung = new Dictionary<string, string>();
//            tuvung.Add("Hello", "Xin chào");
//            tuvung.Add("Funtion", "Tính năng");
//            return tuvung;
//        }
//        static string Search(Dictionary<string,string> dic,string key)
//        {
//            if (dic.ContainsKey(key))
//                return dic[key];
//            else
//                return "";
//        }
//        static void Main(string[] args)
//        {
//            Console.OutputEncoding = Encoding.UTF8;
//            Dictionary<string, string> dic = new Dictionary<string, string>();
//            dic = TuDien();
//            Console.WriteLine(Search(dic, "Funtion"));
//            dic.Remove("Funtion");

//            //Dictionary<int, string> names = new Dictionary<int, string>();
//            //names.Add(1, "Tuan");
//            //names.Add(2, "Nam");
//            //names.Add(3, "Vu");
//            //foreach (var item in names)
//            //{
//            //    Console.WriteLine($"{item.Key}: {item.Value}");
//            //}


//            //if (names.ContainsKey(1))
//            //{
//            //    Console.WriteLine(names[1]);
//            //}
//            Console.ReadLine();
//        }
//    }
//}
