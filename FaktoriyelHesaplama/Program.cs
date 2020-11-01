using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FaktoriyelHesaplama
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi;
            Console.Write("Faktoriyelini almak istediğiniz sayıyı giriniz: ");
            sayi = Convert.ToInt32(Console.ReadLine());


            for (int i = sayi - 1; i >= 1; i--)
            {
                sayi = sayi * i;
            }
            Console.WriteLine("İşlemim sonucu: " + sayi);
            Console.ReadLine();
        }
    }
}
