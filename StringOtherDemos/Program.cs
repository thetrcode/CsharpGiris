using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringOtherDemos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Lütfen cümle giriniz: ");
            string cumle = Console.ReadLine();
            Console.Write("Lütfen aranacak kelimeyi giriniz: ");
            string kelime = Console.ReadLine();
            Console.Write("Harf duyarlı mı arama yapacaksınız? (e: evet, h: hayır) ");
            string duyarli = Console.ReadLine();
            if (kelime.StartsWith("\"") && kelime.EndsWith("\""))
            {
                TamKelimeAra(cumle, kelime, duyarli);
            }
            else
            {
                KelimeAra(cumle, kelime, duyarli);
            }
            
            Console.ReadLine();
        }

        static void TamKelimeAra(string cumle, string kelime, string duyarli)
        {
            string kelimesonuc = kelime;
            string cumlesonuc = cumle;
            if (duyarli == "h")
            {
                kelime = kelime.ToLower();
                cumle = cumle.ToLower();
            }
            string[] kelimeler = cumle.Split(' ');
            bool bulundu = false;
     
            foreach (var k in kelimeler)
            {
                if (k == kelime.Trim(new char[] { '"' })) // trim " karakterlerini temizliyor
                    bulundu = true;
                break;
            }

            if (bulundu)
                Console.WriteLine("\"" + kelimesonuc + "\"" + "'" + cumlesonuc + "' içerisinde bulundu.");
            else
                Console.WriteLine("\"" + kelimesonuc + "\" '" + cumlesonuc + "' içerisinde bulunamadı.");
        }
        static void KelimeAra(string cumle, string kelime, string duyarli)
        {
            string kelimesonuc = kelime;
            string cumlesonuc = cumle;
            if (duyarli == "h")
            {
                kelime = kelime.ToLower();
                cumle = cumle.ToLower();
            }
            if (cumle.Contains(kelime))
                Console.WriteLine("\"" + kelimesonuc + "\"" + "'" + cumlesonuc + "' içerisinde bulundu.");
            else
                Console.WriteLine("\"" + kelimesonuc + "\" '" + cumlesonuc + "' içerisinde bulunamadı.");
        }
    }
}
