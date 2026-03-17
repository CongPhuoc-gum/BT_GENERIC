using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT_GENERIC
{
    internal class Bai_10
    {
        const string HoTen = "Phan Cong Phuoc";
        const string MaSV = "22115141122115";

        static void Main(string[] args)
        {
            List<int> numbers = new List<int> ();
            Console.WriteLine("Nhap so luong phan tu: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Nhap phan tu thu " + (i + 1) + ": ");
                int num = int.Parse(Console.ReadLine());
                numbers.Add(num);
            }

            int min = numbers.Min();
            foreach (int num in numbers)
            {
                if (num == min)
                {
                    Console.WriteLine("Phan tu nho nhat: " + num);
                }
            }


            Console.WriteLine("Ho ten: " + HoTen);
            Console.WriteLine("Ma SV: " + MaSV);
            Console.ReadKey();
        }
    }
}

