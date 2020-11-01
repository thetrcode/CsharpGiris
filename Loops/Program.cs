using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            // for

            //int i;
            //for (i = 1; i <= 20; i++)
            //{
            //    if (i % 2 == 1)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}
            for (int i = 1; i < 21; i = i + 2)
            {
                Console.WriteLine("Sayılar: " + i);
            }

            for (int i = 2; i < 21; i += 2)
            {
                Console.WriteLine("Sayılar: " + i);
            }

            // ters-- : ters = ters- 2 : ters -= 2

            int ters;
            for (ters = 20; ters >= 2; ters -= 2)
            {
                Console.WriteLine(ters);
            }
            Console.WriteLine("tersin loop dışındaki son değeri: " + ters);

            //int s1 = 1;
            //int s2 = 1;
            //Console.WriteLine("s++" + s1++); // 1 yazdırdı, s = 2
            //Console.WriteLine("++s" + ++s2); // s = 2, 2 yazdırdı

            /*
             * 
             **
             ***
             ****
             *****
            */

            for (int i = 1; i <= 5; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            // sonsuz döngü: infinite loop
            //for (int i = 1; i >= 1; i++)
            //{
            //    Console.WriteLine(i);
            //}


            // while

            int number = 1;
            while (number <= 10)
            {
                Console.WriteLine(number);
                number++;
            }

            int no = 11;
            do
            {
                Console.WriteLine(no); // false olsa da bir kere yazdırır.
                no++;
            } while (no <= 10);

            string[] sehirler = new string[4] { "Ankara", "İstanbul", "İzmir", "Konya" };
            for (int i = 0; i <= sehirler.Length - 1; i++)
            {
                sehirler[i] = "Van";
                Console.WriteLine(sehirler[i]);
            }


            Console.ReadLine();
        }
    }
}
