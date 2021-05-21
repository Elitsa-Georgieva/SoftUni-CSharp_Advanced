using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Songs_Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] sequenceOfSongs = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            Queue<string> songs = new Queue<string>(sequenceOfSongs);

            while (songs.Count > 0)
            {
                string command = Console.ReadLine();

                if (command == "Play")
                {
                    songs.Dequeue();
                }
                else if (command == "Show")
                {
                    Console.WriteLine($"{string.Join(", ", songs)}");
                }
                else
                {
                    int idx = command.IndexOf(' ');
                    string song = command.Substring(idx + 1);
                    if (songs.Contains(song))
                    {
                        Console.WriteLine($"{song} is already contained!");
                    }
                    else
                    {
                        songs.Enqueue(song);
                    }
                }
            }

            Console.WriteLine($"No more songs!");
        }
    }
}
