using System;

namespace Task6._6
{
    internal class Program
    {
        static void Main(string[] args)
        {    //6) Verilmish metnde {a} simvolunun sol terefden ve sag terefden indexleri eydidirmi?
            string word = "academiya";
            int sol = word.IndexOf('a');
            Console.WriteLine($"sol={sol}");

            int sag = word.LastIndexOf('a');
            Console.WriteLine($"sag={sag}");
            if (sol==sag)
            {
                Console.WriteLine("beraberdir");
            }
            else
            {
                Console.WriteLine("beraber deyil");
            }
        }
    }
}
