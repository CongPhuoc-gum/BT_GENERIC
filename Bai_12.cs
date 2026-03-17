using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT_GENERIC
{

    class Student
    {
        public string Name { get; set; }
        public int ID { get; set; }
    }
    internal class Bai_12
    {
        const string HoTen = "Phan Cong Phuoc";
        const string MSSV = "22115141122115";
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            Console.WriteLine("Nhap so luong sinh vien: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Nhap ten sinh vien: ");
                string name = Console.ReadLine();
                Console.WriteLine("Nhap ID: ");
                int id = int.Parse(Console.ReadLine());
                students.Add(new Student { Name = name, ID = id });
            }

            Console.WriteLine("Nhap ten sinh vien can tim: ");
            string searchName = Console.ReadLine();

            bool found = false;
            foreach (var student in students)
            {
                if (student.Name.Equals(searchName, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("Sinh vien tim thay: " + student.Name + ", ID: " + student.ID);
                    found = true;
                    break;
                }
            }

            if (!found)
            {
                Console.WriteLine("Khong tim thay sinh vien voi ten: " + searchName);
            }



            Console.WriteLine("Ho ten: " + HoTen);
            Console.WriteLine("MSSV: " + MSSV);
        }

    }
}
