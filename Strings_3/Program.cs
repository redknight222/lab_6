using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            int start_index = 0;
            while (true)
            {
                start_index = word.IndexOf('{', start_index);
                if (start_index == -1 | start_index == word.Length - 1)
                {
                    break;
                }
                else if (word[start_index + 1] == '{')
                {
                    start_index += 1;
                    continue; 
                }
                int end_index = word.IndexOf('}', start_index);
                word = word.Remove(start_index + 1, end_index - start_index - 1);
                start_index += 1;
            }
            Console.WriteLine(word);
            Console.ReadKey();
        }
    }
}
