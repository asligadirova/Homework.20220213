using System;

namespace Task6._13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //13) Verilimish metinde butun simvollari ardicil shekilde biri balaca, biri boyuk formada cap et.
            string word = "baycan";
            
            for (int i = 0; i < word.Length; i++)
            {
                if (i%2==0)
                {
                    Console.Write(word.ToUpper()[i]);
                    
                }
                else if (i%2==1)
                {
                    Console.Write(word.ToLower()[i]);
                }
            }
           
           
        }
    }
}
