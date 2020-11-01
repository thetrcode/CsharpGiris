using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HesapMakinesi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** 4 İŞLEM HESAP MAKİNESİ ***");
            Console.WriteLine("");
            int sayi1;
            int sayi2;
            Console.Write("1. sayıyı girin:             ");
            sayi1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("2. sayıyı girin:             ");
            sayi2 = Convert.ToInt32(Console.ReadLine());

            string islem;
            Console.Write("İşlem seçiniz(+, -, *, /):   ");
            islem = Console.ReadLine();
            if (islem == "+")
            {
                Console.WriteLine("İşlemin sonucu:              " + (sayi1 + sayi2));
            }
            else if (islem == "-")
            {
                Console.WriteLine("İşlemin sonucu:              " + (sayi1 - sayi2));
            }
            else if (islem == "*")
            {
                Console.WriteLine("İşlemin sonucu:              " + (sayi1 * sayi2));
            }
            else if (islem == "/")
            {
                if (sayi2 == 0)
                Console.WriteLine("İşlemin sonucu:              " + "Tanımsız");
                else
                    Console.WriteLine("İşlemin sonucu:          " + (sayi1 / sayi2));
            }
            else
            {
                Console.WriteLine("Hatalı işlem seçtiniz!!!");
            }
            Console.ReadLine();
        }
    }
}
