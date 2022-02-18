using System;

namespace Task6._12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //12) Verilmish metinde en ilk ve en son { a}
            //simvolundan bashqa yerde qalan butun { a}
            //simvollarini yox et

            string word = "azerbaycan";
            word = word.Remove(5, 1);
            Console.WriteLine(word);
           

            

        }
    }
}
