using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT_GENERIC
{
    internal class Bai_7
    {
        const string HoTen = "Phan Cong Phuoc";
        const string MSSV = "22115141122115";

        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            Console.WriteLine("Nhap so luong phan tu: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Nhap phan tu thu " + (i + 1) + ": ");
                int element = int.Parse(Console.ReadLine());
                list.Add(element);
            }

            Console.WriteLine($"\nDanh sach goc:       {string.Join(", ", list)}");
            list.Sort();
            Console.WriteLine($"Sau khi sap xep tang dan: {string.Join(", ", list)}");

            Console.WriteLine("Ho ten: " + HoTen);
            Console.WriteLine("MSSV: " + MSSV);
        }
    }
}
