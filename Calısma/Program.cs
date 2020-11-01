using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calısma
{
    class Program
    {
        static void Main(string[] args)
        {
            //string ad;
            //{
            //    Console.Write("Lütfen adınızı yazınız: ");
            //    ad = Console.ReadLine();
            //}
            //Console.WriteLine("Teşekkürler, " + ad + " :)");
            //Console.ReadLine();

            //int x = 2;
            //switch(x)
            //{
            //    case 0:
            //        Console.WriteLine("değişken değeri 0");
            //        break;
            //    case 1:
            //        Console.WriteLine("değişken değeri 1");
            //        break;
            //    case 2:
            //        Console.WriteLine("değişken değeri 2");
            //        break;
            //    default:
            //        Console.WriteLine("değişken farklı 0, 1 veya 2 olmalıdır.");
            //        break;
            //}
            //Console.ReadLine();

            int x, y, s1;

            x = Convert.ToInt32(Console.ReadLine());
            s1 = Convert.ToInt32(Console.ReadLine());
            y = Convert.ToInt32(Console.ReadLine());
            switch(s1)
            {
                case 1:
                    Console.WriteLine(x + y);
                    break;
            }
            Console.ReadLine();


            //int s1 = 2;
            //switch(s1)
            //{
            //    case 2:
            //        Console.WriteLine("=" + (x + y));
            //        break;
            //    default:
            //        Console.WriteLine("hatalı");
            //        break;

            //}

        }
    }
}
