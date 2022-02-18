using System;

namespace Task6._11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //11) Verilmish metinde butun {a} simvollarinin qabagina {b} simvolunu ve eyni zamandan butun { b}
            //simvollarinin qabagina { a} simvolunu yaz.
            string word = "beraber'"; // aberbaaber
            word=word.Insert(3,"b"); 
            Console.WriteLine(word); //berbaber
            word = word.Insert(0, "a");
            Console.WriteLine(word); //aberbaber
            word = word.Insert(6, "a");
            Console.WriteLine(word);
        }
    }
}
