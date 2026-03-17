using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT_GENERIC
{
    internal class Bai_11
    {
        class Student
        {
            public string Name { get; set; }
            public int ID { get; set; }
        }
        const string HoTen = "Phan Cong Phuoc";
        const string MaSV = "22115141122115";

        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            Console.WriteLine("Nhap so luong sinh vien: ");
            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                Student s = new Student();
                Console.Write($"  Nhap ID sinh vien {i + 1}: ");
                s.ID = int.Parse(Console.ReadLine());
                Console.Write($"  Nhap ten sinh vien {i + 1}: ");
                s.Name = Console.ReadLine();
                students.Add(s);
            }



            Console.WriteLine("\nDanh sach sinh vien:");
            Console.WriteLine($"  {"ID",-5} {"Ho Ten",-25}");
            Console.WriteLine("  " + new string('-', 30));
            foreach (Student s in students)
                Console.WriteLine($"  {s.ID,-5} {s.Name,-25}");





            Console.WriteLine("Ho ten: " + HoTen);
            Console.WriteLine("Ma SV: " + MaSV);
            Console.ReadKey();
        }
    }   
}
