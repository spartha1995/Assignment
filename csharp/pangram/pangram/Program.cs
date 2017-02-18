using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pangram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter sentence to test : ");
            bool b = IsPangram(Console.ReadLine());
            Console.WriteLine(b);
            Console.ReadKey();
        }
        static bool IsPangram(string s)
        {
            s = s.ToLower();
            if (s.Length < 26) return false;
            bool[] isUsed = new bool[26];
            int total = 0;

            foreach (char c in s)
            {
                if (c >= 'a' && c <= 'z')
                {
                    int index = c - 97;
                    if (!isUsed[index])
                    {
                        isUsed[index] = true;
                        total++;
                    }
                }
            }

            return total == 26;
        }
    }
}
