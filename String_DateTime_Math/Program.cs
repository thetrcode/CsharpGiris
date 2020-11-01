using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_DateTime_Math
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Strings

            //string city1 = "Ankara";
            //Console.WriteLine(city1[0]); // A
            //foreach (var c in city1)
            //{
            //    Console.WriteLine(c); // Ankara yı alt alta yazacak
            //}

            //string city2 = "İstanbul";
            //string result1 = city1 + " " + city2; // Ankara İstanbul
            //Console.WriteLine(result1);

            //string result3 = string.Format("{0} - {1}", city1, city2); // Ankara - İstanbul

            //string sentence = "My name is Özcan Nakkaş"; // karakter sayısı kaç?
            //int sentenceLength = sentence.Length;
            //Console.WriteLine(sentenceLength);

            //sentence = sentence.Replace("Özcan", "Leo"); // My name is Leo Nakkaş - değiştirdi

            //if (sentence.EndsWith("kaş")) // true
            //    Console.WriteLine("kaş ile bitiyor");
            //else
            //    Console.WriteLine("kaş ile bitmiyor"); // false

            //if (sentence.StartsWith("my")) // false
            //    Console.WriteLine("my ile başlıyor");
            //else
            //    Console.WriteLine("my ile başlamıyor");

            //// My name is Leo Nakkaş
            //int indexOfIs = sentence.IndexOf("is"); // -1
            //Console.WriteLine(indexOfIs);

            //int lastIndexOfSpace = sentence.LastIndexOf(" ");
            //Console.WriteLine(lastIndexOfSpace);

            //// sentence = "Hello!" + sentence;
            //sentence = sentence.Insert(0, "Hello! "); // Hello! My name is Leo Nakkaş
            //Console.WriteLine(sentence);

            //string subSentence1 = sentence.Substring(7); // 7. karakterden başlayacak
            //Console.WriteLine(subSentence1);
            //string subSentence2 = sentence.Substring(7, 2); // 7. karakterden başlayacak- 2 karakter alacak
            //Console.WriteLine(subSentence2);

            //// My name is Leo Nakkaş
            //Console.WriteLine(sentence.ToLower() + "-" + sentence.ToUpper()); // hepsi küçük harf oldu, hepsi büyük harf oldu

            //Console.WriteLine(sentence.Replace(" ", "_")); // boşluğu alt çizgi ile değiştirdi

            //sentence = sentence.Remove(5, 1); // ! i çıkardı
            //Console.WriteLine(sentence);

            //sentence = sentence.Remove(21); // Nakkaş ı remove etti sildi
            //Console.WriteLine(sentence);

            //string[] words = sentence.Split(' '); // kelimeleri parçaladı alt alta yazdı
            //foreach (var word in words)
            //{
            //    Console.WriteLine(word);
            //}
            //Console.WriteLine(words[3]); // 3. kelime yaz

            //string test1 = "Test1";
            //string test2 = "test1";
            //if ( test1 == test2)
            //{
            //    Console.WriteLine("tes1 = test2");
            //}
            //else
            //{
            //    Console.WriteLine("tes1 != test2");
            //}

            //if (test1.Equals(test2)) // == ile aynı
            //{
            //    Console.WriteLine("tes1 = test2");
            //}
            //else
            //{
            //    Console.WriteLine("tes1 != test2");
            //}

            //if (test1.Equals(test2, StringComparison.OrdinalIgnoreCase)) // büyük küçük harf duyarsız bakar
            //{
            //    Console.WriteLine("tes1 = test2");
            //}
            //else
            //{
            //    Console.WriteLine("tes1 != test2");
            //}

            //string ad = " Özcan Nakkaş ";
            //Console.WriteLine(ad.Trim()); // başındaki ve sondaki boşlukları kırpar
            //Console.WriteLine(ad.TrimStart()); // başındaki boşluk trim
            //Console.WriteLine(ad.TrimEnd()); // sondaki boşluk trim

            //string tel = "0 532 123 45 67"; // boşlukları kaldırdı
            //tel = tel.Replace(" ", "");
            //Console.WriteLine(tel);

            //ad = "\"Ali Vefa\"";
            //Console.WriteLine(ad);

            //ad = "Ferhan Şensoy";
            //Console.WriteLine("\" + ad + \"");

            //Console.WriteLine(ad.Replace(" ", "\n")); // new lina = \n, alt satıra geçti

            //string name = "Özcan";
            //string surname = "Nakkaş";
            //Console.WriteLine(name + "\t" + surname); // tab = \t   Özcan Nakkaş

            //// C:\BilgeAdam\CsharpGiris
            //string path = "C:\\BilgeAdam\\CsharpGiris"; // \ için yanına bir \ daha ekle
            //path = @"C:\BilgeAdam\CsharpGiris"; // başına @ koyarsan da aynı şey
            //Console.WriteLine(path);



            #endregion

            #region DateTime
            DateTime simdikiTarih = DateTime.Now;
            Console.WriteLine(simdikiTarih);
            Console.WriteLine(simdikiTarih.ToShortDateString());
            Console.WriteLine(simdikiTarih.ToLongDateString());
            Console.WriteLine(simdikiTarih.ToShortTimeString());
            Console.WriteLine(simdikiTarih.ToLongTimeString());
            Console.WriteLine(simdikiTarih.Day + "." + simdikiTarih.Month + "." + simdikiTarih.Year + "---" + simdikiTarih.Hour + ":" + simdikiTarih.Minute + ":" + simdikiTarih.Second);

            DateTime tarih1 = new DateTime(2020, 11, 1);
            DateTime tarih2 = new DateTime(2019, 5, 30, 13, 59, 7, 123);
            Console.WriteLine(tarih1);
            Console.WriteLine(tarih2 + ":" + tarih2.Millisecond);

            DateTime tarih3 = DateTime.Parse("30.11.2020", new CultureInfo("tr")); // string olarak tarih girişi yapılabiliyor. // ingilizce tipi olarak için "en" 
            Console.WriteLine(tarih3);
            DateTime tarih4 = DateTime.Parse("10/20/2020 15:57:3", new CultureInfo("en"));
            Console.WriteLine(tarih4);
            Console.WriteLine(tarih4.ToString("yyyy-MM-dd HH:mm:ss")); // 24hr saat dilimi için HH yazılır.

            simdikiTarih = DateTime.Now;
            Console.WriteLine(simdikiTarih);
            Console.WriteLine(simdikiTarih.AddDays(1)); // yarını yazdırır. 1 gün ekler.
            Console.WriteLine(simdikiTarih.AddDays(-7)); // 1 hafta öncesini getirir. 7 çıkarır.
            Console.WriteLine(simdikiTarih.AddMonths(6)); // 6 ay sonra
            Console.WriteLine(simdikiTarih.AddYears(-30)); // 30 sene önce
            Console.WriteLine(simdikiTarih.AddHours(-12)); // 12 saat öncesi
            Console.WriteLine(simdikiTarih.AddMinutes(30)); // 30 dakika sonrası

            var tarih11 = DateTime.Parse("01.11.2020");
            var tarih22 = DateTime.Parse("20.10.2020");
            if (tarih22.CompareTo(tarih11) > 0)
            {
                Console.WriteLine("tarih22 > tarih11");
            }
            else if (tarih22.CompareTo(tarih11) < 0)
            {
                Console.WriteLine("tarih22 < tarih11");
            }
            else // if (tarih22.CompareTo(tarih11) == 0)
            {
                Console.WriteLine("tarih22 = tarih11");
            }
            if (tarih22 > tarih11)
            {
                Console.WriteLine("tarih22 > tarih11");
            }
            else if (tarih22 < tarih11)
            {
                Console.WriteLine("tarih22 < tarih11");
            }
            else // if (tarih22 == tarih11) if (tarih22.Equals(tarih11))
            {
                Console.WriteLine("tarih22 = tarih11");
            }
            simdikiTarih = DateTime.Now;
            Console.WriteLine(simdikiTarih.DayOfWeek + "," + simdikiTarih.DayOfYear);
            Console.WriteLine(simdikiTarih.Ticks);
            Console.WriteLine(simdikiTarih.Date);
            Console.WriteLine(DateTime.Today);

            #endregion

            #region Math Kütüphanesi

            Console.WriteLine(Math.PI);
            int sayi1 = 10;
            int sayi2 = 20;
            Console.WriteLine(Math.Abs(sayi1 - sayi2)); // Abs = mutlak değer

            double sayi3 = 2.4;
            Console.WriteLine("Taban: " + Math.Floor(sayi3) + ", " + "Tavan: " + Math.Ceiling(sayi3));

            Console.WriteLine("2 ^ 4: " + Math.Pow(2, 4)); // 2 üzeri 4 işlemi

            Console.WriteLine(Math.Max(1, 2) + ", " + Math.Min(1, 2));

            double s1 = 12.50001;
            double s2 = 98.765;
            Console.WriteLine("s1: " + Math.Round(s1) + "-s2: " + Math.Round(s2));

            Console.WriteLine("s1: " + Math.Round(s1, 1) + " -s2: " + Math.Round(s2, 1)); // kaç ondalık gelecek 1 ondalık gelecek.
            Console.WriteLine("s1: " + Math.Round(s1, 2) + " -s2: " + Math.Round(s2, 2)); // double 12.50 yi 12.5 olarak getirdi.

            // 12.50 aşağı yuvarlıyor.

            Console.WriteLine(Math.Sqrt(4) + ", " + Math.Sqrt(16)); // karekök
            Console.WriteLine(Math.Pow(8.0, 1.0 / 3.0)); // sayı.0 olarak double değer girilmesi gerekiyor.

            #endregion


            Console.ReadLine();
        }
    }
}
