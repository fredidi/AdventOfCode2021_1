using System;
using System.IO;
using System.Text;

namespace _1
{
    class Program
    {
        public static void PartOne()
        {
            int count = 0;
            string[] textFile = File.ReadAllLines(@"C:\Users\fredd\OneDrive\.NET Developer\AdventOfCode\1\input.txt");

            int[] list = new int[textFile.Length];
            for (int i = 0; i < textFile.Length; i++)
            {
                list[i] = Convert.ToInt32(textFile[i]);
            }
            for (int i = 0; i < list.Length - 1; i++)
            {
                if (list[i + 1] > list[i])
                {
                    count++;
                }
            }
            Console.WriteLine("Part 1 solution:\n" + count); //1482
        }
        public static void PartTwo()
        {
            //PART TWO

            //a = i
            //b = i+1
            //c = i+2
            //sum = (a+b+c)
            int count = 0;
            string[] textFile = File.ReadAllLines(@"C:\Users\fredd\OneDrive\.NET Developer\AdventOfCode\1\input.txt");

            int[] list = new int[textFile.Length];
            for (int i = 0; i < textFile.Length; i++)
            {
                list[i] = Convert.ToInt32(textFile[i]);
            }
            for (int i = 0; i < list.Length - 3; i++)
            {
                int sum1 = (list[i]) + (list[i + 1]) + (list[i + 2]);
                int sum2 = (list[i + 1]) + (list[i + 2]) + (list[i + 3]);

                if (sum1 < sum2)
                {
                    count++;
                }
            }
            Console.WriteLine("Part 2 solution:\n" + count);
        }
        static void Main(string[] args)
        {
            PartOne();
            Console.WriteLine();
            PartTwo();


        }
    }
}
