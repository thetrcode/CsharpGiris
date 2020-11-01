using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringDemos
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            string reversed;
            do
            {
                Console.Write("Kelime Giriniz: ");
                input = Console.ReadLine();
                input = input.Trim();
                while (input.Trim() == "") // kontrol etmek için
                {
                    Console.Write("Lütfen Kelime Giriniz: ");
                    input = Console.ReadLine();
                    input = input.Trim();
                }
                if (input != "*")
                {
                    reversed = Reverse(input);
                    Console.WriteLine("Kelimenin tersten hali: " + reversed);
                }
            } while (input != "*");
        }

        static string Reverse(string input) // tersten çevirme metodu oluşturma.
        {
            string result = "";
            for ( int i = input.Length -1; i >= 0; i--)
            {
                result += input[i]; // result = result + input[i]
            }
            return result;
        }
    }
}
