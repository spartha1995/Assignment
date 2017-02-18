using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sherlockvalidstring
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your string");
            String s;
            s = Console.ReadLine();
            int count, temp = 0, flag = 0;
            for (char ch = 'a'; ch <= 'z'; ch++)
            {
                count = 0;
                for (int i = 0; i < s.Length; i++)
                {
                    char ch1 = s.ElementAt(i);
                    if (ch == ch1)
                        count++;
                }
                if (ch == 'a')
                    temp = count;
                if (ch >= 'b')
                {
                    if (count != temp && count != 0)
                        flag++;
                }
                if (flag >= 2)
                {
                    Console.WriteLine("NO");
                    ch = 'z';
                }
            }
            if (flag <= 1)
                Console.WriteLine("YES");
            Console.ReadLine();
        }
    }
}
