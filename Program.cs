using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stunde3
{
    class Program
    {
        static void Main(string[] args)
        {
            //    //datetypengrößen
            //    short a0 = short.MaxValue;
            //    short a1 = short.MinValue;
            //    ushort a2 = ushort.MaxValue; //ushort ist nur Positiv, deshalb gibt es doppelt zu viel Zahlen für Maximal
            //    int b = int.MaxValue;
            //    long c = long.MaxValue;

            //    //Console.WriteLine("short:" + a + "long" + c);
            //    Console.WriteLine("Short.Min:" + a1 + "Short.max" + a0 + "ushort" + a2);



            //    //Verzweigungen (if-else Anweisung)

            //    int x = 5;
            //    int y = 7;
            //    if (x + y > 10)
            //    {
            //        Console.WriteLine("Das Ergebnis ist größer als 10.");

            //    }
            //    else if (x + y == 10) // == um nicht ein int. zu machen
            //    {
            //        Console.WriteLine("Das Ergebnis ist genau 10.");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Das Ergebnis ist kleiner als 10.");
            //    }

            //    //Schleifen
            //    //Wiederholte Abäufe

            //    int zähler = 0;
            //    while (zähler < 10)
            //    {
            //        Console.WriteLine("Der Zähler ist:" + zähler);
            //        //zähler = zähler + 1;
            //        //zähler += 1 );

            //        zähler++;
            //    }


            //    int zähler2 = 0;
            //    do
            //    {
            //        Console.WriteLine("Der Zahl ist:" + zähler2);
            //        zähler2++;

            //    }
            //    while (zähler2 < 10);
            //    for (int i = 0; i < 10; i++)
            //    {
            //        Console.WriteLine(i);
            //    }

            //    //beispiel: 
            //    // Der benutzer soll nach zwei ganzen zahlen befragt werden,
            //    //falls die Summe größer als 125 ist soll das Programm beendet werden
            //    //anonsten von vorn beginnen.

            //    int a, z;
            //    do
            //    {
            //        Console.WriteLine("Bitte nacheinander ganze Zahlen eingeben");
            //        a = Convert.ToInt32(Console.ReadLine());
            //        Console.WriteLine("a=");
            //        z = Convert.ToInt32(Console.ReadLine());
            //        Console.WriteLine("z=");

            //    }
            //    while (a + z < 125);

            //    //Der Benutzer soll nach einer jahreszahl gefragt werdem und es 
            //    //soll ausgegeben werdem ob es sich um ein Schaltjahr handelt
            //    // Schaltjahr : Tailbar durch
            //    //              Nicht teilbar durch 100
            //    //              Teilbar durch 400


            //    int jahr ;
            //    string wiederholung ;
            //    do
            //    {
            //        Console.WriteLine("Jahr:");
            //        jahr = Convert.ToInt32(Console.ReadLine());
            //        if (jahr % 4 == 0)
            //        {
            //            if (jahr % 100 == 0)
            //            {
            //                if (jahr % 400 == 0)
            //                {
            //                    Console.WriteLine(jahr + " ist ein Schaltjahr");
            //                }
            //                else
            //                {
            //                    Console.WriteLine(jahr + " ist kein Schaltjahr");
            //                }

            //            }
            //            else
            //            {
            //                Console.WriteLine(jahr + " ist ein Schaltjahr");
            //            }

            //        }
            //        else
            //        {
            //            Console.WriteLine(jahr + " ist kein Schaltjahr");
            //        }
            //        Console.WriteLine("Noch Mal? (j/n)");
            //        wiederholung = Console.ReadLine();
            //    }
            //    while (wiederholung == "j");




            //     // oder: || un

            int jahr;
            string wiederholung ;
            do
            {
                Console.WriteLine("Jahr:");
                jahr = Convert.ToInt32(Console.ReadLine());

                if (jahr % 4 == 0 && (jahr % 100 != 0 || jahr % 400 == 0))
                {
                    Console.WriteLine(jahr + " ist ein Schaltjahr");
                }
                else
                {
                    Console.WriteLine(jahr + " ist kein Schaltjahr");
                }
                Console.WriteLine("Noch Mal? (j/n)");
                wiederholung = Console.ReadLine();
            }
            while (wiederholung == "j");

        }

    }
}
