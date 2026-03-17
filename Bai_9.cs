using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT_GENERIC
{
    internal class Bai_9
    {
        const string HoTen = "Phan Cong Phuoc";
        const string MSSV = "22115141122115";
        static void Main(string[] args)
        {
            List<int> numbers = new  List<int>();
            Console.WriteLine("Nhap so luong phan tu: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Nhap phan tu thu " + (i + 1) + ": ");
                int num = int.Parse(Console.ReadLine());
                numbers.Add(num);
            }

            List<int> unique = new List<int>();
            foreach (int num in numbers)
                if (!unique.Contains(num)) unique.Add(num);

            Console.WriteLine($"\nDanh sach goc:          {string.Join(", ", numbers)}");
            Console.WriteLine($"Danh sach khong trung:  {string.Join(", ", unique)}");
            Console.WriteLine("Ho ten: " + HoTen);
            Console.WriteLine("MSSV: " + MSSV);
            Console.ReadKey();
        }
    }
}
