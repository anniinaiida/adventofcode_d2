using System;

namespace d2
{
    class Program
    {
        static void Main(string[] args)
        {

            int first = 0, second = 0, position = 0, value = 0;
            string data = System.IO.File.ReadAllText(@"C:\temp\aoc\d2\input.txt");
            string[] tmp = data.Split(',');
            
            int addit = Int32.Parse(tmp[0]);
            int i = 0;   
   
            while (addit != 99) {
                first = Int32.Parse(tmp[i + 1]);
                second = Int32.Parse(tmp[i + 2]);
                position = Int32.Parse(tmp[i + 3]);

                first = Int32.Parse(tmp[first]);
                second = Int32.Parse(tmp[second]);

                if (addit == 1) {
                    tmp[position] = (first + second).ToString();
                }

                if (addit == 2) {
                    tmp[position] = (first * second).ToString();
                }

                i += 4;
                addit = Int32.Parse(tmp[i]);
            }
            
            Console.WriteLine(tmp[0]);
            Console.WriteLine(value);
        }
    }
}