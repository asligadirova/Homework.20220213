using System;

namespace Task6._10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //10) Verilmish metinde butun reqemleri legv et.
            string word = "10) Verilmish metinde butun reqemleri legv et.";
            word = word.Remove(0,2);
            Console.WriteLine(word);
        }
    }
}
