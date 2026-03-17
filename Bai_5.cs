using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT_GENERIC
{
    internal class Bai_5
    {
        const string HoTen = "Phan Cong Phuoc";
        const string MSSV = "22115141122115";

        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            Console.WriteLine("Nhap so luong phan tu: ");
            int count = int.Parse(Console.ReadLine());
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("Nhap phan tu thu " + (i + 1) + ": ");
                int element = int.Parse(Console.ReadLine());
                list.Add(element);
            }

            Console.WriteLine("Nhap phan tu can xoa: ");
            int elementToRemove = int.Parse(Console.ReadLine());
            if (list.Contains(elementToRemove))
            {
                list.Remove(elementToRemove);
                Console.WriteLine("Da xoa phan tu " + elementToRemove);
            }
            else
            {
                Console.WriteLine("Khong tim thay phan tu " + elementToRemove);
            }

            Console.WriteLine("Danh sach sau khi xoa: ");
            Console.WriteLine(string.Join(", ", list));
            Console.WriteLine("Ho ten: " + HoTen);
            Console.WriteLine("MSSV: " + MSSV);
            Console.ReadKey();
        }
    }
}
