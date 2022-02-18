using System;

namespace Task2._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //3) Verilmish metnde sol terefden tek yerde dayanan simvollardan necesi {b} -ye beraberdir.
            string word = "kitab";
            
            
            
               
                int countb = 0;
                for (int i = 0; i < word.Length; i++)
                {
                     if (i % 2 !=1 && word[i] == 'b')
                     {
                        countb++;
                     }
                                             
                
                
                }
            Console.WriteLine($"tek yerde dayanan elementlerden {countb} ededi b-e beraverdir");
        }
    }
}
