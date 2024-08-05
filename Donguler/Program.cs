using System;
using System.Globalization;


namespace Donguler

{

    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "1.kurs";
            string kurs2 = "2.kurs";
            string kurs3 = "3.kurs";
            string kurs4 = "4.kurs";
            

            Console.WriteLine(kurs1);
            Console.WriteLine(kurs2);
            Console.WriteLine(kurs3);
            Console.WriteLine(kurs4);


            string[] kurslar = new string[] {"Kurs1","Kurs2","Kurs3" ,"Kurs4", "Kurs5"};
            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }
            Console.WriteLine("For Bitti");
            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("Sayfa Sonu");
        }
    }
}