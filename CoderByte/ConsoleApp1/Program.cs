using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Console Apps! \n");

            //Console.WriteLine("CsharpAgeCounting: ");
            //CsharpAgeCounting.AgeCounting();

            //Console.WriteLine("------------------------\n");

            //Console.WriteLine("Letter Changes: ");
            //string str = "hello*3";
            //Console.WriteLine(str);
            //LetterChanges.ReplaceLetters(str);

            //Console.WriteLine("------------------------\n");            

            //Console.WriteLine("Username Validation: ");
            //string str = "aa_";
            //string str = "u__hello_world123";
            //Console.WriteLine(str);
            //UsernameValidation.CheckUsername(str);

            //Console.WriteLine("------------------------\n");

            //Console.WriteLine("Longest Word: ");
            ////string str = "fun&!! time";
            //string str = "I love dogs";
            //Console.WriteLine(str);
            //LongestWord.Find(str);            

            //Console.WriteLine("------------------------\n");

            //Console.WriteLine("First Factorial: ");
            //int num = 8;
            //Console.WriteLine(num);
            //FirstFactorial.Calculate(num);            

            //Console.WriteLine("------------------------\n");

            //Console.WriteLine("First Reverse: ");
            //string str = "coderbyte";
            //Console.WriteLine(str);
            //FirstReverse.Reverse(str);
                        
            //Console.WriteLine("------------------------\n");

            //Console.WriteLine("Find Intersection: ");
            ////string[] str = { "1, 3, 4, 7, 13", "1, 2, 4, 13, 15" };
            //string[] str = { "1, 3, 9, 10, 17, 18", "1, 4, 9, 10" };
            //FindIntersection.Find(str);
            
            Console.WriteLine("------------------------\n");
            
            Console.WriteLine("QuestionMarks: ");
            //string str = "aa6?9"; //false
            //string str = "acc?7??sss?3rr1??????5"; //true
            //string str = "arrb6???4xxbl5???eee5"; //true
            //string str = "9???1???9???1???9"; //true
            string str = "9???1???9??1???9"; //false
            QuestionMarks.Check(str);

            //Console.WriteLine("------------------------\n");

            //Console.WriteLine("Example: ");
            //TestExample.RunExample();


        }
    }
}
