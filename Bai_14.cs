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
         public int Id { get; set; }
    }
    internal class Bai_14
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
                Console.WriteLine("Nhap thong tin sinh vien thu {0}:", i + 1);
                Console.Write("Ho ten: ");
                string name = Console.ReadLine();
                Console.Write("ID: ");
                int id = int.Parse(Console.ReadLine());
                students.Add(new Student { Name = name, Id = id });
            }

            Console.WriteLine("\nNhap ID can xoa: ");
            int idToRemove = int.Parse(Console.ReadLine());

            Student toRemove = null;
            foreach (Student s in students)
                if (s.Id == idToRemove) { toRemove = s; break; }

            if (toRemove != null)
            {
                students.Remove(toRemove);
                Console.WriteLine($"Da xoa sinh vien ID = {idToRemove}.");
            }
            else
            {
                Console.WriteLine("Khong tim thay sinh vien.");
            }

            Console.WriteLine("Danh sach con lai:");
            foreach (Student s in students)
                Console.WriteLine($"  ID: {s.Id}, Ten: {s.Name}");





            Console.WriteLine("Ho ten: {0}", HoTen);
            Console.WriteLine("MSSV: {0}", MSSV);
            Console.ReadKey();
        }
    }
}
