using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CSV_console_app
{
    class Program
    {
        static List<Dolgozo> dolgozok = new List<Dolgozo>();
        static void Main(string[] args)
        {
            
            beolvas();
            
            /*
            foreach (Dolgozo item in dolgozok)
            {
                Console.WriteLine(item);
            }*/

            feladat01();
            feladat02();
            feladat03();
            feladat04();

            Console.WriteLine("Program vége");
            Console.ReadKey();
        }

        private static void feladat04()
        {
            Console.WriteLine("4. feladat:");
            foreach (var item in dolgozok.FindAll(a => a.Reszle == "asztalosműhely"))
            {
                Console.WriteLine($"\t{item.Nev}");
            }
        }

        private static void feladat03()
        {
            Console.WriteLine("3. feladat:");
            foreach (var item in dolgozok.GroupBy(a => a.Reszle).Select(b => new { reszleg = b.Key, letszam = b.Count() }))
            {
                Console.WriteLine($"\t{item.reszleg}: {item.letszam}");
            }
        }

        private static void feladat02()
        {
            Console.WriteLine("2. feladat: legmagasabb bérű dolgozó: "+ dolgozok.Find( a => a.Ber == dolgozok.Max(b => b.Ber)));
        }

        private static void feladat01()
        {
            Console.WriteLine("\t1. feladat: dolgozók száma: "+dolgozok.Count());
        }

        private static void beolvas()
        {
            using (StreamReader sr = new StreamReader("dolgozok.csv"))
            {
                sr.ReadLine(); //első sor átugrása
                while (!sr.EndOfStream)
                {
                    string[] line = sr.ReadLine().Replace('"',' ').Split(',');
                    Dolgozo dolgozo = new Dolgozo(line[0].Trim(), line[1].Trim(), line[2].Trim(), int.Parse(line[3].Trim()), int.Parse(line[4].Trim()));
                    dolgozok.Add(dolgozo);
                }
            }
        }
    }
}
