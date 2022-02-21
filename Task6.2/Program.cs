
using System;

namespace Task6._2
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            //2) Verilmish metnde sol terefden tek yerde dayanan simvollarin hamisi {a} simvoludurmu?
           
                      
            char a = 'b';
            bool okey = true;
            string word = "b1x1b1b1";
            for (int i = 0; i < word.Length; i++)
            {
                if (i % 2 == 0)
                {
                    if (word[i] != a)
                    {
                       okey = false;
                        break;
                    }
                    
                    
                }
               
            }

            if (okey==true)
            {
                Console.WriteLine("dogrudur");
            }
            else
            {
                Console.WriteLine("dogru deyil");
            }









        }
    }
}
