using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BalancedDelimiters
{
    class Program
    {
        Stack<Char> stack;

        Program()
        {
            stack = new Stack<char>();
        }


        static void Main(string[] args)
        {
            Program programObject = new Program();

            Console.WriteLine("Enter the string: ");
            string input = Console.ReadLine();

            char bracket = ' ', poppedBracket = ' ';

            for (int i = 0; i < input.Length; i++)
            {
                bracket = input.ElementAt(i);

                if (programObject.IsOpenBracket(bracket))
                {
                    programObject.stack.Push(bracket);
                }
                else if (programObject.IsCloseBracket(bracket))
                {
                    if (!(programObject.stack.Count == 0))
                    {
                        poppedBracket = programObject.stack.Pop();
                    }
                    else
                    {
                        Console.WriteLine("False");
                        break;
                    }

                    if (!MatchBracket(poppedBracket, bracket))
                    {
                        Console.WriteLine("False");
                        break;
                    }
                }

                if (programObject.stack.Count == 0 && i == (input.Length - 1))
                {
                    Console.WriteLine("True");
                    break;
                }
                else if (programObject.stack.Count > 0 && i == (input.Length - 1))
                {
                    Console.WriteLine("False");
                    break;
                }
            }
            Console.Read();
        }

       
        private static bool MatchBracket(char open, char close)
        {
            switch (open)
            {
                case '(':
                    if (close == ')')
                        return true;
                    break;
                case '{':
                    if (close == '}')
                        return true;
                    break;
                case '[':
                    if (close == ']')
                        return true;
                    break;
            }
            return false;
        }

        
        private bool IsCloseBracket(char bracket)
        {
            switch (bracket)
            {
                case ')': return true;
                case '}': return true;
                case ']': return true;
                default: return false;
            }
        }

      
        private bool IsOpenBracket(char bracket)
        {
            switch (bracket)
            {
                case '(': return true;
                case '{': return true;
                case '[': return true;
                default: return false;
            }

        }
    }
}