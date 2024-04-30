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
            

            foreach (Dolgozo item in dolgozok)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Program vége");
            Console.ReadKey();
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
