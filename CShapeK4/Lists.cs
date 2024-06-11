using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CShapeK4
{
    class Student
    {
        public string Name;
        public string BirthDay;
    }
    class Lists
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            Student SV1 = new Student();
            SV1.Name = "Nguen Van A";
            SV1.BirthDay = "12/10/2000";
            Student SV2 = new Student();
            SV2.Name = "Cao Van C";
            SV2.BirthDay = "5/10/1998";
            students.Add(SV1);
            students.Add(SV2);

            List<string> ls = new List<string> { "Quang", "Cuong" };
            Console.OutputEncoding = Encoding.UTF8;
            List<string> ds = new List<string>();
            ds.Add("Teo");
            ds.Add("Tí");
            //ds.Insert(1, "Tủn");
            ds.InsertRange(1, ls);
            foreach (var item in ds)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\r\nDanh sách sau khi xoá");
            ds.Remove("Teo");
            foreach (var item in ds)
            {
                Console.WriteLine(item);
            }
            ds.Sort();
            Console.WriteLine("\r\nDanh sách sau sort");
            foreach (var item in ds)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
