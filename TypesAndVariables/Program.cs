using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypesAndVariables
{
    class Program
    {
        static void Main(string[] args)
        {
            ////Data tipleri ve değişkenler
            ///*
            //  1 byte = 8 bits (Örnek:10000101)
            //*/
            //#region Value Types
            //#region Integer
            //int number1 = 10; // 32 bits: -2 billion to 2 billion
            //Console.WriteLine("Number 1 is: " + number1);
            //Console.WriteLine("int max value: {0}, int min value: {1}", int.MaxValue, int.MinValue);
            //uint number2 = 20; // 32 bits: 0 to 4 billiion
            //Console.WriteLine("Number 2 is: " + number2);
            //#endregion

            //#region Long
            //long number3 = 1827383738; // 64 bits: -9 quintnllion to 9 quintillion
            //Console.WriteLine("Number 3: " + number3);
            //ulong number4 = 40; // 0-18 quintillion sadece pozitif
            //Console.WriteLine("Number 4: " + number4);
            //#endregion

            //#region Short
            //short number5 = -19; // 16 bits: -32,768 to 32,767
            //ushort number6 = 19; // 0 to 65,535
            //#endregion

            //#region Byte 
            //byte number7 = 255; // 8 bits: 0 - 255
            //sbyte number8 = -128; // -128 to 127
            //#endregion

            //#region Boolean
            //bool condition = true; // 1 bit: 0- 1
            //Console.WriteLine("Condition: " + condition);
            //#endregion

            //#region Char
            //char character = 'A'; // ASCII characters (8 bits), Unicode characters (16 bits) in C#
            //Console.WriteLine("Character: " + character + " ASCII code: " + (int)character);
            //#endregion

            //#region Double
            //double number9 = 1.7; // 64 bits. 15 significant digits
            //Console.WriteLine("Number 9: " + number9);
            //#endregion

            //#region Float
            //float number10 = -12.2352f; // 32 bits 7significant digits
            //Console.WriteLine("Number 10: " + number10);
            //#endregion

            //#region Decimal
            //decimal number11 = 11.77M; // 24 * 8 bits. 28 to 29 significant digits
            //#endregion

            //#region Enum
            //// string gun = "Monday" olmaz
            //// console.writeline(gum) olmaz
            //// int gun = 1; Pazartesiolmaz

            //Console.WriteLine(Days.Monday +" "+ (int)Days.Monday);
            //#endregion

            #region Referans Types
            #region String
            string characters = "Ankara"; // 4 byte address. Length up to 2 billion bytes.
            Console.WriteLine("Şehir: " + characters);
            #endregion

            #region Var
            var number12 = 12;
            var isim = "Özcan";
            Console.WriteLine(isim + "-" + number12);
            #endregion

            #region Extras
            string ad = "\"Özcan\"";
            Console.WriteLine(ad);
            string soyad = @"\Nakkaş\";
            Console.WriteLine(soyad);
            var path = "C:\\BilgeAdam\\CsharpGiris";
            path = @"C:\BilgeAdam\CsharpGiris";
            Console.WriteLine(path);

            /*
                \": çift tırnak
                \n: new line (alt satır)
                \r: satır başı carrieg return
                \\: slash
                \t: tab
             */

            //string a;
            //String b;

            //int c;
            //Int32 d;

            //long e;
            //Int64 f;

            // Mantıksal tip (doğruluk tip)
            bool deger1 = true;
            Boolean deger2 = false;
            bool sonuc1 = deger1 || deger2; // veya
            Console.WriteLine("Değer1: " + deger1 + " || Değer2: " + deger2 + " = " + sonuc1);
            bool sonuc2 = deger1 && deger2; // ve
            bool sonuc3 = !sonuc2; // not tersini alır

            /*
            p   q   ve (p && q)
            -------------------
            1   1   1
            1   0   0
            0   1   0
            0   0   0


            p   q   veya (p || q)
            ---------------------
            1   1   1
            1   0   1
            0   1   1
            0   0   0

             */



            #endregion

            #endregion
            Console.ReadLine();
        }

        enum Days
        {
            Monday = 1,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturdat,
            Sunday,
        }


        enum Roller
        {
            Admin = 1,
            Kullanici = 2,
        }
    }
}
