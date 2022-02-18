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
            char[] ch = { 'a' };

            int firsrindex =word.IndexOfAny(ch);          
            int lastindex = word.LastIndexOfAny(ch);
            Console.WriteLine(firsrindex);
            Console.WriteLine(lastindex);

            word = word.Insert(firsrindex, "@");            
            word = word.Insert(lastindex+2, "@");            
            word = word.Replace('a', '-');           
            word = word.Replace('@', 'a');
            Console.WriteLine(word);
            

        }
    }
}
