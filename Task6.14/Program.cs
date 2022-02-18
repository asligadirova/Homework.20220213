using System;

namespace Task6._14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //14) Verilmish metinde butun tek yerde dayanan simvollari ondan sonra gelen
            //simvolun BOYUK formasi ile evez et.
            string word = "azerbaycan";
            for (int i = 0; i < word.Length; i++)
            {
                if (i%2==0)
                {
                    word = word.Replace(word[i], word[i + 1]);
                }
               
                if (i % 2 == 0)
                {
                    Console.Write(word.ToUpper()[i]);

                }
                else if (i % 2 == 1)
                {
                    Console.Write(word.ToLower()[i]);
                }


            }
            
            
        }
    }
}
