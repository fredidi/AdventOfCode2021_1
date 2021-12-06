using System;
using System.IO;
using System.Text;

namespace _1
{
    class Program
    {

        static void Main(string[] args)
        {
            int count = 0;
            string[] textFile = File.ReadAllLines(@"C:\Users\fredd\OneDrive\.NET Developer\AdventOfCode\1\input.txt");

            //foreach (var text in textFile)
            //{
            //    Console.WriteLine(text);
            //}

            int[] list = new int[textFile.Length];
            for (int i = 0; i < textFile.Length; i++)
            {
                list[i] = Convert.ToInt32(textFile[i]);
            }
            for (int i = 0; i < list.Length -1; i++)
            {
                if (list[i+1] > list[i])
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }
    }
}
