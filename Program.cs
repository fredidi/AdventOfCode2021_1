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

            //PART ONE
            int[] list = new int[textFile.Length];
            for (int i = 0; i < textFile.Length; i++)
            {
                list[i] = Convert.ToInt32(textFile[i]);
            }
            //for (int i = 0; i < list.Length -1; i++)
            //{
            //    if (list[i+1] > list[i])
            //    {
            //        count++;
            //    }
            //}
            //Console.WriteLine(count);




            //PART TWO

            //a = i
            //b = i+1
            //c = i+2
            //sum = (a+b+c)

            for (int i = 0; i < list.Length - 3; i++)
            {
                int sum1 = (list[i]) + (list[i + 1]) + (list[i + 2]);
                int sum2 = (list[i + 1]) + (list[i + 2]) + (list[i + 3]);

                if (sum1 < sum2)
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }
    }
}
