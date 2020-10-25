using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditionals
{
    class Program
    {
        static void Main(string[] args)
        {
            // Assigment oparator: =
            // Logical operators: &&, ||, !
            // Relational oparators: ==, !=, >=, <=, >, <
            // Arithmetic oparators: +, -, *, /, %
            #region If ELse
            var number1 = 10;
            if (number1 == 10)
            {
                Console.WriteLine("Sayı: 10");
            }

            number1 = 20;
            if (number1 == 10)
            {
                Console.WriteLine("Sayı: 10");
            }
            else // number1 != 10
            {
                Console.WriteLine("Sayı: 10 değil.");
            }

            var number2 = 10;

            string result12 = number1 == number2 ? "Sayı 10" : "Sayı 10 değil"; // ternary operator if else nin alternatifi
            Console.WriteLine(result12);

            if (number1 == number2)
            {
                Console.WriteLine("number1 = number2");
            }
            else //if (number1 != number2)
            {
                Console.WriteLine("number1 != number2");
            }

            number1 = 25;
            if (number1 == 10)
            {
                Console.WriteLine("S10");
            }
            else if (number1 == 20)
            {
                Console.WriteLine("20");
            }
            else
            {
                Console.WriteLine("10 veya 20 değil");
            }
            #endregion

            #region Switch
            number2 = 20;
            switch (number2)
            {
                case 10: Console.WriteLine("On");
                    break;
                case 20: Console.WriteLine("Yirmi");
                    break;
                default: Console.WriteLine("On veya Yirmi değil");
                    break;
            }
            #endregion


            Console.ReadLine();
        }
    }
}
