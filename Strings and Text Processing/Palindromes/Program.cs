using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindromes
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] text = Console.ReadLine().Split(new char[] { ' ', ',', '.', '?', '!' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            var palindromes = new List<string>();
          
            for (int i = 0; i < text.Length; i++)
            {
              
               if(IsPalindrome(text[i]))
                {
                   if(!palindromes.Contains(text[i]))
                    {
                        palindromes.Add(text[i]);
                    }
                }
            }
            palindromes.Sort();
            Console.WriteLine(string.Join(", ",palindromes));
}
        private static bool IsPalindrome(string word)
        {
            int rightIndex = word.Length - 1;
            int leftIndex = 0;

            while (rightIndex >= leftIndex)
            {
                if (word[rightIndex] != word[leftIndex])
                {
                    return false;
                }

                rightIndex--;
                leftIndex++;
            }

            return true;
        }
    }
}
