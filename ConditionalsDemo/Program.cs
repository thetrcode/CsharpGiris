using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Girilen plaka sayı değerine göre adını getiren program.
            Console.WriteLine("Plaka kodu girin: ");
            string giris = Console.ReadLine();
            string sonuc;
            if (giris == "06")
            {
                sonuc = "Ankara";
            }
            else if (giris == "34")
            {
                sonuc = "istanbul";
            }
            else if (giris == "35")
            {
                sonuc = "izmir";
            }
            else
            {
                sonuc = "Girdiğiniz plaka sistemde bulunamadı.";
            }

            //switch (giris)
            //{
            //    case "06": sonuc = "Ankara";
            //        break;
            //    case "34":
            //        sonuc = "İstanbul";
            //        break;
            //    case "35":
            //        sonuc = "İzmir";
            //        break;
            //    default: sonuc = "Girdiğiniz plaka sistemde bulunamadı.";
            //        break;

            //}

            Console.WriteLine("Şehir: " + sonuc); 
            Console.ReadLine();
        }
    }
}
