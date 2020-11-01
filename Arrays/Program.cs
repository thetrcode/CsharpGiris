using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string student1 = "Özcan";
            string student2 = "Leo";
            string student3 = "Angel";

            // one dimensional array
            string[] students = new string[3]; // initialization
            students[0] = "Özcan";
            students[1] = "Leo";
            students[2] = "Angel";

            int[] numbers = new[] { 1, 2, 3, 4 }; // indeks 0 1 2 3

            decimal[] decimals = new decimal[5] { 1.1M, 2.2M, 3.3M, 4.4M, 5.5M };

            char[] characters = { 'T', 'Ü', 'R', 'K', 'İ', 'Y', 'E' };

            // Console.WriteLine(characters);

            //Console.Write(characters[0]);
            //Console.Write(characters[1]);
            //Console.Write(characters[2]);
            //Console.Write(characters[3]);
            //Console.Write(characters[4]);
            //Console.Write(characters[5]);
            //Console.Write(characters[6]);
            // Console.WriteLine(characters[7]); // index out of range expection (hata)
            foreach (char character in characters)
            {
                Console.Write(character);
            }

            // multi dimensional arrays
            string[,] SehirlerVeBolgeler = new string[4, 2]
            {
                { "Ankara", "İç Anadolu" },
                { "İstanbul", "Marmara" },
                { "İzmir", "Ege" },
                { "Eskişehir", "İç Anadolu" }
            };
            Console.WriteLine();
            foreach (string s in SehirlerVeBolgeler)
            {
                Console.WriteLine("Kayıt: " + s);
            }

            Console.WriteLine(SehirlerVeBolgeler[0, 0]);
            Console.WriteLine(SehirlerVeBolgeler[2, 1]);

            for (int i = 0; i < 7; i++) // i++ = i = i + 1
            {
                Console.WriteLine(characters[i]);
            }

            Console.WriteLine();
            string[,] PlakalarVeSehirler = new string[3, 2];
            PlakalarVeSehirler[0, 0] = "06";
            PlakalarVeSehirler[0, 1] = "Ankara";
            PlakalarVeSehirler[1, 0] = "34";
            PlakalarVeSehirler[1, 1] = "İstanbbul";
            PlakalarVeSehirler[2, 0] = "35";
            PlakalarVeSehirler[2, 1] = "İzmir";

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Plaka: " + PlakalarVeSehirler[i, 0] + " , Şehir: " + PlakalarVeSehirler[i, 1]);
            }


            Console.ReadLine();


        }
    }
}
