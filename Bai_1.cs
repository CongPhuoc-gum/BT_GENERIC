using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT_GENERIC
{
    class Bai_1
    {
        const string Ho_Ten = "Phan Cong Phuoc";
        const string MSSV = "22115141122115";

        static void Main()
        {
            List<int> numbers = new List<int>();

            Console.WriteLine("Nhap 5 so nguyen: ");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"  So thu {i + 1}: ");
                numbers.Add(int.Parse(Console.ReadLine()));
            }

            Console.WriteLine("\nDanh sach cac phan tu:");
            foreach (int n in numbers)
            {
                Console.WriteLine($"  {n}");
            }

            Console.WriteLine("Ho va ten: " + Ho_Ten);
            Console.WriteLine("MSSV: " + MSSV);
        }
    }
}
