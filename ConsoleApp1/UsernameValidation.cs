using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class UsernameValidation
    {
        public static void CheckUsername(string str)
        {
            Console.WriteLine(Validate(str));
        }

        public static string Validate(string str)
        {
            int strLength = str.Length;

            bool checkLength = strLength >= 4 && strLength <= 25;
            if (!checkLength) return checkLength.ToString().ToLower();

            bool checkLetter = false;

            for (var i = 0; i < strLength; i++)
            {
                if (i == 0)
                {
                    checkLetter = Char.IsLetter(str[i]);
                    //Console.WriteLine($"Letter: {str[i]}");
                }
                else if (i == str.Length - 1) checkLetter = str[^1] != '_';
                else checkLetter = Char.IsLetterOrDigit(str[i]) || str[i] == '_';


                if (checkLetter == false) break;
            }

            return checkLetter.ToString().ToLower();
        }
    }
}
