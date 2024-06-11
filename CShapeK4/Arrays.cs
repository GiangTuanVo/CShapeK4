//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace CShapeK4
//{
//    class Arrays
//    {
//        static int Search(int[] arr, int num)
//        {
//            int index = -1;
//            for (int i = 0; i < arr.Length; i++)
//            {
//                if (arr[i] == num)
//                    index = i;
//            }
//            return index;
//        }
//        static void Main(string[] args)
//        {
//            Console.OutputEncoding = Encoding.UTF8;
//            Random rd = new Random();
//            int index = 10;
//            int[] arr = new int[index];
//            for (int i = 0; i < index; i++)
//            {
//                arr[i] = rd.Next(0, 100);
//                Console.WriteLine($"Số{i}: {arr[i]}");
//            }
//            Console.WriteLine("\r\nNhap so can tìm");
//            int num = int.Parse(Console.ReadLine());
//            Console.WriteLine("Vị trí : {0}", Search(arr, num));
//            Console.ReadLine();



//            for (int k = 0; k < index; k++)
//            {
//                Console.WriteLine($"Số{k}: {arr[k]}");
//            }

//            Console.WriteLine("\r\nSắp xếp bé tới lớn");
//            Array.Sort(arr);

//            for (int k = 0; k < index; k++)
//            {
//                Console.WriteLine($"Số{k}: {arr[k]}");
//            }

//            Console.WriteLine("\r\nSắp xếp lớn tới bé");
//            Array.Reverse(arr);
//            for (int k = 0; k < index; k++)
//            {
//                Console.WriteLine($"Số{k}: {arr[k]}");
//            }
//            Console.ReadLine();

//            int[] number = new int[] { 11, 4, 121, 343, 656 };//tạo vùng nhớ


//            int[] Copy = number;

//            int[] Clone = new int[number.Length];

//            number.CopyTo(Clone, 0);

//            Copy[3] = 113;

//            for (int i = 2; i < number.Length; i++)
//            {
//                Console.WriteLine($"Số{i}: {number[i]}");
//            }
//            Console.ReadLine();
//        }
//    }
//}
