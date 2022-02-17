using System;

namespace Task6._9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = "Verilmish metinde ilk 3 simvol, son 3 simvolun tersine formasina beraberdirmi";
            string word1;
            word1 = word.Substring(0,3);
            Console.WriteLine($"ilk 3 simvol:{word1}");
            string word2;
            word2 = word.Substring(word.Length - 3);
            Console.Write($"son 3 simvol: {word2}\n");
            
            

            char first;


            do
            {               
                first = word2[word2.Length-1];                
                word2 = word2.Substring(0);
            } while (word2.Length<0);
              
             
                Console.WriteLine($"son 3 simvolun tersi:{word2}");
            if (word2==word1)
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
