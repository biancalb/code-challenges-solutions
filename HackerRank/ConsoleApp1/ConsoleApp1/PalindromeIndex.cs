using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class PalindromeIndex
    {
        public static void Find(string s)
        {
            if(string.Concat(s.Reverse()) == s)
            {
                Console.WriteLine(-1);
            }
            else
            {
                var startIndex = 0;
                var endIndex = s.Length - 1;
                var indexesToRemove = new List<int>();

                for (int i = 0; i < (s.Length / 2); i++)
                {
                    Console.WriteLine("startIndex: " + startIndex);
                    Console.WriteLine("endIndex: " + endIndex);

#warning Not covering all cases
                    if (s[startIndex] != s[endIndex])
                    {
                        Console.WriteLine("Found Diff");
                        if (s[endIndex - 1] == s[startIndex])
                        {

                            indexesToRemove.Add(endIndex);
                            startIndex++;
                            endIndex -= 2;                            
                        }
                        else
                        {
                            indexesToRemove.Add(startIndex);
                            startIndex += 2;
                            endIndex --;
                        }
                    }
                    else
                    {
                        startIndex++;
                        endIndex--;
                    }
                    Console.WriteLine('\n');
                }
                Console.WriteLine(string.Join(' ', indexesToRemove));
            }
        }
    }
}


//10
//quyjjdcgsvvsgcdjjyq
//hgygsvlfwcwnswtuhmyaljkqlqjjqlqkjlaymhutwsnwcflvsgygh
//fgnfnidynhxebxxxfmxixhsruldhsaobhlcggchboashdlurshxixmfxxxbexhnydinfngf
//bsyhvwfuesumsehmytqioswvpcbxyolapfywdxeacyuruybhbwxjmrrmjxwbhbyuruycaexdwyfpaloyxbcpwsoiqtymhesmuseufwvhysb
//fvyqxqxynewuebtcuqdwyetyqqisappmunmnldmkttkmdlnmnumppasiqyteywdquctbeuwenyxqxqyvf
//mmbiefhflbeckaecprwfgmqlydfroxrblulpasumubqhhbvlqpixvvxipqlvbhqbumusaplulbrxorfdylqmgfwrpceakceblfhfeibmm
//tpqknkmbgasitnwqrqasvolmevkasccsakvemlosaqrqwntisagbmknkqpt
//lhrxvssvxrhl
//prcoitfiptvcxrvoalqmfpnqyhrubxspplrftomfehbbhefmotfrlppsxburhyqnpfmqlaorxcvtpiftiocrp
//kjowoemiduaaxasnqghxbxkiccikxbxhgqnsaxaaudimeowojk

//1
//8
//33
//23
//25
//44
//20
//- 1
//14
//- 1