using System;

namespace TEST
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //11) Verilmish metinde butun {a} simvollarinin qabagina {b} simvolunu ve eyni zamandan butun { b}
            //simvollarinin qabagina { a} simvolunu yaz.
           
            string word = "beraber"; //abrbaaber
            char[] ch = { 'a' };

            int firsrindex = word.IndexOfAny(ch);
            int lastindex = word.LastIndexOfAny(ch);
            Console.WriteLine(firsrindex);
            Console.WriteLine(lastindex);

            word = word.Insert(firsrindex, "@");
            Console.WriteLine(word);
            word = word.Insert(lastindex+2, "@");
            word = word.Insert(lastindex -2, "@");

            Console.WriteLine(word);
            word = word.Replace('a', 'b');
            Console.WriteLine(word);
            
        } 
    }
}
