using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class ViralAdvertising
    {
        public static void CalculatePeopleLiked(int n)
        {
            var shareToFriends = 3;
            var peopleWillReceive = 5;
            int liked;
            var cumulative = 0;

            Console.WriteLine(String.Format("{0, 10} | {1, 10} | {2, 10} | {3, 10} | ", "Day", "Shared", "Liked", "Cumulative"));
            
            for (int day = 1; day <= n; day++)
            {
                liked = peopleWillReceive / 2;
                cumulative += liked;
                
                Console.WriteLine(String.Format("{0, 10} | {1, 10} | {2, 10} | {3, 10} | ", $"{day}", $"{peopleWillReceive}", $"{liked}", $"{cumulative}"));
                peopleWillReceive = liked * shareToFriends;
            }
            Console.WriteLine(cumulative);
        }
    }
}
