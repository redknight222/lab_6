using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            word = word.Replace(" ", "").ToLower();
            bool result = true;
            int n = word.Length;
            for (int i = 0; i < n; i++)
            {
                result = word[i] == word[n - i - 1];
            }
            if (result)
            {
                Console.WriteLine("palindrome");
            }
            else
            {
                Console.WriteLine("not palindrome");
            }
            Console.ReadKey();
            
        }
    }
}
