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
    internal class Bai_12
    {
        const string HoTen = "Phan Cong Phuoc";
        const string MSSV = "22115141122115";

        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            Console.WriteLine("Nhap so luong sinh vien: ");
            int count = int.Parse(Console.ReadLine());

            for(int i = 0; i < count; i++)
            {
                Student student = new Student();
                Console.WriteLine("Nhap TEN sinh vien: ");
                student.Name = Console.ReadLine();
                Console.WriteLine("Nhap ID sinh vien: ");
                student.Id = int.Parse(Console.ReadLine());
                students.Add(student);
            }  
            
            Console.WriteLine($"Danh sach sinh vien: {students.Count}");
            Console.WriteLine("Ho ten: {0}", HoTen);
            Console.WriteLine("MSSV: {0}", MSSV);
        }
    }
}
