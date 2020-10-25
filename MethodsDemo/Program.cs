using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            BaslikYaz();
            double vize1 = KullanicidanGirisAl("1. Vize ");
            double vize2 = KullanicidanGirisAl("2. Vize ");
            double final = KullanicidanGirisAl("Final   ");
            double ortalama = OrtalamaHesapla(vize1, vize2, final);
            GeçmeKalmaYazdir(ortalama);
            // GeçmeKalmaYazdır(ortalama, 70);
            Console.ReadLine();
        }

         static void GeçmeKalmaYazdir(double ortalama, double gecmeNotu = 60) // default parameter
        {
            if (ortalama >= gecmeNotu)
            {
                Console.WriteLine("Ortalamanız: " + ortalama + ", geçtiniz");
            }
            else
            {
                Console.WriteLine("Ortalamanız: " + ortalama + ", kaldınız");

            }
        }

        static double OrtalamaHesapla(double vize1, double vize2, double final)
        {
            double sonuc;
            double vizeCarpan = 0.2;
            double finalCArpan = 0.6;
            sonuc = (vize1 + vize2) * vizeCarpan + final * finalCArpan;
            return sonuc;
        }

        static void BaslikYaz()
        {
            Console.WriteLine("***Öğrenci Not Ortalaması Hesaplama***");
        }

        static double KullanicidanGirisAl(string hangiSinav)
        {
            Console.Write(hangiSinav + ": ");
            //string giris = Console.ReadLine();
            //double sonuc = Convert.ToDouble(giris);
            //return sonuc
            return Convert.ToDouble(Console.ReadLine());
        }
    }
}
