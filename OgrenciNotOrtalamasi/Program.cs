using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgrenciNotOrtalamasi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("1. vize: ");
            double vize1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("2. vize: ");
            double vize2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("final: ");
            double final = Convert.ToInt32(Console.ReadLine());
            //int ortalama = (int)((vize1 + vize2) * 0.2 + final * 0.6); // casting (tehlikeli)
            double ortalama = ((vize1 + vize2) * 0.2 + final * 0.6);
            if (ortalama >= 60)
                Console.WriteLine("Ortalamanız " + ortalama + ", geçtiniz.");
            else
                Console.WriteLine("Ortalamanız " + ortalama + ", kaldınız.");

            // test
            Console.WriteLine((vize1 + vize2) * 0.2 + final * 0.6);

            // int * double = double
            // int * int    = int

            Console.ReadLine();
        }
    }
}
