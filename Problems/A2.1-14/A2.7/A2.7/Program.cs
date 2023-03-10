using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace A27
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите трехзначное число");
            double N = Convert.ToInt32(Console.ReadLine());
            if (N > 99 && N < 1000)
            {
                double s = Math.Truncate(N / 100);
                double d = Math.Truncate((N - s * 100) / 10);
                double e = N - s * 100 - d * 10;
                Console.WriteLine("Число, получающееся при перестановке первой и второй цифр, равно " + (d*100 + s*10 + e));
            }
            else
            {
                Console.WriteLine("Это не трехзначное число!");
            }
            Console.ReadKey();
        }
    }
}