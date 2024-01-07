using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class QuestionMarks
    {
        public static void Check(string str)
        {
            bool isValid = false;

            for (int i = 0; i < str.Length; i++)
            {
                char c = str[i];
                Console.WriteLine($"index:{i} - caracter: {c}");

                if (Char.IsDigit(c))
                {
                    int n1 = int.Parse(c.ToString());

                    int skip = 1;
                    int countQuestionMark = 0;

                    while (!Char.IsDigit(str[i + skip]))
                    {
                        if (str[i + skip] == '?') countQuestionMark += 1;
                        skip++;
                    }

                    int n2 = int.Parse(str[i + skip].ToString());
                    
                    if(n1 + n2 == 10)
                    {
                        isValid = countQuestionMark == 3;
                    }

                    if (!isValid)
                    {
                        break;
                    }
                    else
                    {
                        i += skip;
                        i -= (i < str.Length - 1 ? 1 : 0);
                    }
                }
            }

            Console.WriteLine(isValid ? "true" : "false");
        }
    }
}
