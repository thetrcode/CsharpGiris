using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            string adSoyad = ""; // camel case
            string ad = AdGetir();
            Console.WriteLine(ad);

            DisplayAdd();
            int sayi1 = 1;
            int sayi2 = 3;
            AddtwoNumbers(sayi1, sayi2);
            double s1;
            int s2;
            s1 = 5.5;
            s2 = 5;
            var sonuc = IkiSayiEkle(s1, s2);

            Console.WriteLine(sonuc);

            Console.ReadLine();
        }

        // method tipleri
        static void DisplayAdd() // pascal case
        {
            Console.WriteLine("Added.");
        }

        static void AddtwoNumbers(int number1, int number2) // sırası ve veri tipi önemli
        {
            int sonuc = number1 + number2;
            Console.WriteLine(sonuc);
        }

        static double IkiSayiEkle(double number1, int number2)
        {
            //double sonuc = number1 + number2;
            //return sonuc;
            return number1 + number2;
        }

        static string AdGetir()
        {
            return ("Özcan");
        }
    }
}
