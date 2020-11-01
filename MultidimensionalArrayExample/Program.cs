using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultidimensionalArrayExample
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] sehirler = new string[3, 2] // 0, 1
            {
                {"06", "Ankara" },
                {"34", "İstanbul" },
                {"35", "İzmir" }
            };
            string plakayaGoreSehir;
            for ( int r = 0; r <= sehirler.GetUpperBound(1); r++) // row, 0 1. boyut (3)
            {
                plakayaGoreSehir + "";
                for (int c = 0; c <= sehirler.GetUpperBound(1); c++) // column 1 2. boyut(2)
                {
                    plakayaGoreSehir += sehirler[r, c] + " ";
                }
                Console.WriteLine(plakayaGoreSehir);
            }
            Console.ReadLine();


        }
    }
}
