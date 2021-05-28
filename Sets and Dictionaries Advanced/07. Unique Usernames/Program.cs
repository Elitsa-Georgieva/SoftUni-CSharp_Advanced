using System;
using System.Collections.Generic;

namespace _01._Unique_Usernames
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            HashSet<string> userNames = new HashSet<string>();

            for (int i = 0; i < N; i++)
            {
                string userName = Console.ReadLine();
                userNames.Add(userName);
            }

            foreach (string username in userNames)
            {
                Console.WriteLine(username);
            }
        }
    }
}
