using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string stringToCheck        = Console.ReadLine();

            int stringLength            = stringToCheck.Length;

            string brackets             = string.Empty;
            int lastIndex               = 0;
            bool stringToCheckIsCorrect = true;
            
            for (int i = 0; i < stringLength; i++) 
            {
                if ('('.Equals(stringToCheck[i]) == true)
                {
                    brackets += '(';
                }
                else if ('['.Equals(stringToCheck[i]) == true)
                {
                    brackets += '[';
                }
                else if ('{'.Equals(stringToCheck[i]) == true)
                {
                    brackets += '{';
                }
                else if (')'.Equals(stringToCheck[i]) == true)
                {
                    lastIndex = brackets.Length - 1;

                    if (lastIndex < 0 || '('.Equals(brackets[lastIndex]) == false)
                    {
                        stringToCheckIsCorrect = false;
                        break;
                    }
                    else
                    {
                        brackets = brackets.Remove(lastIndex);
                    }
                }
                else if (']'.Equals(stringToCheck[i]) == true)
                {
                    lastIndex = brackets.Length - 1;

                    if (lastIndex < 0 || '['.Equals(brackets[lastIndex]) == false)
                    {
                        stringToCheckIsCorrect = false;
                        break;
                    }
                    else
                    {
                        brackets = brackets.Remove(lastIndex);
                    }
                }
                else if ('}'.Equals(stringToCheck[i]) == true)
                {
                    lastIndex = brackets.Length - 1;

                    if (lastIndex < 0 || '{'.Equals(brackets[lastIndex]) == false)
                    {
                        stringToCheckIsCorrect = false;
                        break;
                    }
                    else
                    {
                        brackets = brackets.Remove(lastIndex);
                    }
                }
            }

            if (stringToCheckIsCorrect == true)
                stringToCheckIsCorrect = brackets.Length == 0;

            Console.WriteLine(stringToCheckIsCorrect);
        }
    }
}