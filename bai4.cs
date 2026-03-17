using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT_GENERIC
{
    class bai4
    {
        const string Ho_Ten = "Phan Cong Phuoc";
        const string MSSV = "22115141122115";

        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();

            Console.WriteLine("Nhập vào số lượng phần tử của mảng: ");
            int count = int.Parse(Console.ReadLine());
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("Nhập vào phần tử thứ " + (i + 1) + ": ");
                int number = int.Parse(Console.ReadLine());
                numbers.Add(number);
            }

            int countEven = 0;
            foreach (int number in numbers)
            {
                if (number % 2 == 0)
                {
                    countEven++;
                }
            }

            Console.WriteLine("Số lượng phần tử chẵn trong mảng: " + countEven);
            Console.WriteLine("Ho va ten: " + Ho_Ten);
            Console.WriteLine("MSSV: " + MSSV);

        }
    }
}
