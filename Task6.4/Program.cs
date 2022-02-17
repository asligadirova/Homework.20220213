using System;

namespace Task6._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //4) Verilmish metnde sol terefden ilk rast gelinen {a} simvolunun yeri tek ededdi yoxsa cut ?
            string word = "Verilmish metnde sol terefden ilk rast gelinen {a} simvolunun yeri tek ededdi yoxsa cut";
            char[] x = { 'a' };
            int index =word.IndexOfAny(x);
            Console.WriteLine(index);
            if (index%2 == 1) 
            {
                Console.WriteLine("tekdir");

            }
            else
            {
                Console.WriteLine("cutdur");
            }
        }
    }
}
