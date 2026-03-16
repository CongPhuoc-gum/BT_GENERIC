using System;
using System.Collections.Generic;

namespace BT_GENERIC
{
    class Bai_2
    {
        const string Ho_Ten = "Phan Cong Phuoc";
        const string MSSV = "22115141122115";

        static void Main()
        {
            List<int> numbers = new List<int>();
            Console.WriteLine("Nhap so luong phan tu: ");
            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"  So thu {i + 1}: ");
                numbers.Add(int.Parse(Console.ReadLine()));
            }

            int sum = 0;
            foreach (int n in numbers)
            {
                sum += n;
            }

            Console.WriteLine("\nTong cac phan tu: " + sum);

            Console.WriteLine("Ho va ten: " + Ho_Ten);
            Console.WriteLine("MSSV: " + MSSV);
        }
    }
}
