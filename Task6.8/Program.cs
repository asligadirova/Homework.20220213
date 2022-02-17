using System;

namespace Task6._8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = "8) Verilmish metnde ilk qabagima cixan {a} simvolundan sonra gelen simvolu 10 defe dalbadal cap et";

            char[] ch = {'a'};
            int index =word.IndexOfAny(ch);
            int countA = 1;
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"{countA}){word[index+1]}");
                countA++;
                
            }

        }

    }
}
