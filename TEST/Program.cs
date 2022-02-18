using System;

namespace TEST
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //11) Verilmish metinde butun {a} simvollarinin qabagina {b} simvolunu ve eyni zamandan butun { b}
            //simvollarinin qabagina { a} simvolunu yaz.
            string word = "bycan";
            word = word.Insert(1, "a");
            Console.WriteLine(word);
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i]=='a')
                {
                    word = word.Insert(word[i], "b");
                }
                Console.WriteLine(word);
            }
        }
    }
}
