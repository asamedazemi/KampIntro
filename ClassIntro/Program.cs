using System;
using System.Globalization;
using System.Xml;

namespace ClassIntro
    
{

    class program
    {
        static void Main(string[] args)
        {
            string adi = "A.Samed";

            int yas = 27;

            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.Egitmen = "A.Samed";
            kurs1.IzlenmeOrani = 16;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Java";
            kurs2.Egitmen = "Ali";
            kurs2.IzlenmeOrani = 06;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Python";
            kurs3.Egitmen = "Veli";
            kurs3.IzlenmeOrani = 26;

            Kurs kurs4 = new Kurs();
            kurs4.KursAdi = "SQL";
            kurs4.Egitmen = "Emin";
            kurs4.IzlenmeOrani = 36;



            //Console.WriteLine(kurs1.KursAdi + " : " + kurs1.Egitmen);

            Kurs[] kurslar = new Kurs[] {kurs1,kurs2,kurs3,kurs4 };

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi + " : " + kurs.Egitmen);
            }



            //Console.WriteLine("Hello World");
        }
    }
    class Kurs
    {
        public string KursAdi { get; set; }
        
        public string Egitmen { get; set; }

        public int IzlenmeOrani { get; set; }  
    }
}