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
           
            Console.WriteLine(word[index]);


            string word1;
            word1 = word.Remove(0, index + 1) ; 
            Console.WriteLine(word1);
            char[] ch1 = { 'b', 'c' };
            int index1 = word1.IndexOfAny(ch1);
            Console.WriteLine(index1);
                                  
            
            Console.WriteLine(word1[index1]);


            string word2;
            word2 = word1.Remove(0, index1 + 1);
            Console.WriteLine(word2);
            char[] ch2 = { 'b', 'c' };
            int index2 = word2.IndexOfAny(ch2);
            Console.WriteLine(index2);
           

            Console.WriteLine(word2[index2]);
            if (index>index1 && index1>index2 && index>index2)
            {
                Console.WriteLine("dogurdur");
            }
            else
            {
                Console.WriteLine("dogru deyil");
            }



        }
    }
}
