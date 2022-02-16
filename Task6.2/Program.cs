
using System;

namespace Task6._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = "aoaec"
;
            //2) Verilmish metnde sol terefden tek yerde dayanan simvollarin hamisi {a} simvoludurmu?

            for (int i = 0; i < word.Length; i++)
            {
                if (i%2==0 )
                {
                    Console.WriteLine(word[i]);
                    
                   
                }
                

            }
           
            

            







        }
    }
}
