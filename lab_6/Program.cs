using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            string longest_word = "";
            foreach (string s  in word.Split())
            {
                int n = 0;
                if (s.Length > n)
                {
                    longest_word = s;
                    n = s.Length;
                }
            }
            Console.WriteLine(longest_word);
            Console.ReadKey();
        }
    }
}
