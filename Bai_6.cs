using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT_GENERIC
{
    internal class Bai_6
    {
        const string HoTen = "Phan Cong Phuoc";
        const string MSSV = "22115141122115";

        static void Main(string[] args)
        {
            List<string> list = new List<string>();
            Console.WriteLine("Nhap so phan tu: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Nhap phan tu thu " + (i + 1) + ": ");
                string element = Console.ReadLine();
                list.Add(element);
            }

            Console.WriteLine("Nhap chuoi can tim: ");
            string searchString = Console.ReadLine();
            if (list.Contains(searchString))
            {
                Console.WriteLine("Chuoi " + searchString + " co trong danh sach.");
            }
            else
            {
                Console.WriteLine("Chuoi " + searchString + " khong co trong danh sach.");
            }

            Console.WriteLine("Họ tên: " + HoTen);
            Console.WriteLine("MSSV: " + MSSV);
            Console.ReadKey();
        }
    }
}
