using System;

namespace Ch06Ex01
{
    class Program
    {
        static void Write()
        {
            //Console.WriteLine("Text output from function.");

            Console.WriteLine("myString = {0}", myString);
        }
        static void Main(string[] args)
        {
            string myString = "String defined in Main()";
            Write();
            Console.ReadKey();
        }
    }
}
