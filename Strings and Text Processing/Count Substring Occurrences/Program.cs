using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Count_Substring_Occurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine().ToLower();
            string searchText = Console.ReadLine().ToLower();
            int count = 0;
            int index = text.IndexOf(searchText);
           while(index != -1)
            {
                count++;
                index = text.IndexOf(searchText, index + 1);
            }
            Console.WriteLine(count);
        }
    }
}
