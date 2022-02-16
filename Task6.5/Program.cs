using System;

namespace Task6._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = "Verilmish metnde sol terefden saydiqda {a},{b},{c} simollarindan hansi birinci gelir";

            

            
            
            
                char[] chars = { 'a', 'b', 'c' };
                int index = word.IndexOfAny(chars);
                Console.WriteLine(index);
                Console.WriteLine("******");
                  for (int i = 0; i < word.Length; i++)
                  {
                
                  }

            Console.WriteLine(word[index]);


        }   
    }
}
