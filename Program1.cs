using System;

namespace ConsoleApp383
{
    class Program
    {
        static void Main(string[] args)
        {
            string s, l = "";
            s = Console.ReadLine();
            char[] x = new char[s.Length];
            for (int i = 0; i < s.Length; i++)
            {
                x[i] = s[s.Length - i - 1];
            }
            foreach (var t in x)
            {
                l += t;
            }
            Console.WriteLine(l);
            Console.ReadKey();
        }
    }
}
