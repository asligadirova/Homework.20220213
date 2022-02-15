using System;

namespace Task6._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Latin1;

            string word = "1) Verilmish metnde {a} simvolun sayi {b} simvolun sayinda nece defe coxdur?"
;
            int countA = 0;
            int countB = 0;
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == 'a')
                {
                    countA++;
                }
                else if (word[i] == 'b')
                {
                    countB++;
                }
            }
            Console.WriteLine(countB);
            Console.WriteLine(countA);

            Console.WriteLine("******");

            int c = countA / countB;
            Console.WriteLine(c);


        }
    }
}
