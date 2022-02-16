using System;

namespace Task6._7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //7) Verilmish metnde {a} simvolu {b} simvolundan qabaq ve oda {c} simvolundan qabaq gelirmi?

            string word = "Verilmish metnde {a} simvolu {b} simvolundan qabaq ve oda {c} simvolundan qabaq gelirmi?";

            char[] ch = { 'a', 'b', 'c' };
            int index= word.IndexOfAny(ch);
            Console.WriteLine(index);
            for (int i = 0; i < word.Length; i++)
            {


            }
            Console.WriteLine(word[index]);


            string word1;
            word1 = word.Remove(0, index + 1) ; 
            Console.WriteLine(word1);
            char[] ch1 = { 'b', 'c' };
            int index1 = word1.IndexOfAny(ch1);
            Console.WriteLine(index1);
            for (int k = 0; k < word1.Length; k++)
            {

            }
                             
            
            Console.WriteLine(word[index1]);


        }
    }
}
