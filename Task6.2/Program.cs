
using System;

namespace Task6._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = "aoaeb"
;
            //2) Verilmish metnde sol terefden tek yerde dayanan simvollarin hamisi {a} simvoludurmu?

            for (int i = 0; i < word.Length; i++)
            {
                if (i%2==0 )
                {
                    Console.WriteLine(word[i]);
                    if (word[i] != 'a')
                    {
                        Console.WriteLine($"Tek yerde dayanan {i}-ci element a sivoluna beraber deyil");
                    }
                    else
                    {
                        Console.WriteLine($"Tek yerde dayanan {i}-ci element a sivoluna beraberir");
                    }
                    

                }

               
            }

            









        }
    }
}
