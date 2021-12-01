using System;
using System.IO;
using System.Text;

namespace DayO1
{
    class Program
    {
        static public void Exo1()
        {
            string[] lines = File.ReadAllLines(@"../../../input.txt", Encoding.UTF8);
            uint nb = 0;
            for (int i = 0, j = i + 1; j < lines.Length; ++i, ++j)
            {
                if (Int32.Parse(lines[i]) < Int32.Parse(lines[j]))
                {
                    ++nb;
                }
            }

            Console.WriteLine($"exo1 nb = {nb}");
        }

        static public void Exo2()
        {
            string[] lines = File.ReadAllLines(@"../../../input2.txt", Encoding.UTF8);
            uint nb = 0;
            for (int i = 0, j = i + 1; j < lines.Length - 2; ++i, ++j)
            {
                if (Int32.Parse(lines[i]) + Int32.Parse(lines[i + 1]) + Int32.Parse(lines[i + 2]) < Int32.Parse(lines[j]) + Int32.Parse(lines[j + 1]) + Int32.Parse(lines[j + 2]))
                {
                    ++nb;
                }
            }

            Console.WriteLine($"exo2 nb = {nb}");
        }
        static void Main(string[] args)
        {
            Exo1();
            Exo2();
        }
    }
}
