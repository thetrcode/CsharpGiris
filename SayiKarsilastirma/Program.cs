using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SayiKarsilastirma
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Lütfen 1. sayıyı giriniz: ");
            string sayi1 = Console.ReadLine();
            Console.Write("Lütfen 2. sayıyı giriniz: ");
            string sayi2 = Console.ReadLine();
            Console.Write("Lütfen 3. sayıyı giriniz: ");
            string sayi3 = Console.ReadLine();
            int sayi1int = Convert.ToInt32(sayi1);
            int sayi2int = int.Parse(sayi2);
            int sayi3int = Int32.Parse(sayi3);
            if (sayi1int == sayi2int && sayi1int == sayi3int && sayi2int == sayi3int)
            {
                Console.WriteLine("Sayıların hepsi birbirine eşittir.");
            }
            else // sayı1int != sayii2int || sayi1int != sayi3int || sayi2int != sayi3int
            {
                int EnBuyukSayi = sayi1int;
                if (sayi2int > sayi1int) // *
                {
                    if (sayi2int > sayi3int) // *
                    {
                        EnBuyukSayi = sayi2int;
                    }
                }
                if (sayi3int > sayi1int && sayi3int > sayi2int) // *: alternatif
                {
                    EnBuyukSayi = sayi3int;
                }
                Console.WriteLine("Girilen en büyük sayı: " + EnBuyukSayi);
            }

            Console.ReadLine();
        }
    }
}
