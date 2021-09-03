using System;
using System.IO;

namespace ProgrammingChallenge
{
    class Program
    {
        static void Main(string[] args)
        {             
            string[] input = File.ReadAllLines(@"C:\Users\Daniyar\Documents\GitHub\DevelopingWindowsApps\ProgrammingChallenge\expenses.txt.txt");
            int n1 = int.Parse(input[1]);
            double sum1 = 0;
            double sum2 = 0;
            double sum3 = 0;
            for (int i = 2; i < 2 + n1; i++)
            {
                sum1 += double.Parse(input[i]);
            }
            int n2 = int.Parse(input[n1 + 2]);
            for (int j = n1 + 3; j < n1 + n2 + 3; j++)
            {
                sum2 += double.Parse(input[j]);
            }
            int n3 = int.Parse(input[n1 + n2 + 3]);
            for (int k = n1 + n2 + 4; k < n1 + n2 + n3 + 4; k++)
            {
                sum3 += double.Parse(input[k]);
            }
            double avg = (sum1 + sum2 + sum3) / 3;
            Console.WriteLine(avg);


        }
    }
}
