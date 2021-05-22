using System;
using System.Collections.Generic;
using System.Linq;

namespace _11._Key_Revolver
{
    class Program
    {
        static void Main(string[] args)
        {
            int priceOfBullet = int.Parse(Console.ReadLine());
            int sizeOfgunBarell = int.Parse(Console.ReadLine());
            int[] bulletsArr = ReadArrayFromConsole();
            int[] locksArr = ReadArrayFromConsole();
            int intelligenceValue = int.Parse(Console.ReadLine());

            Queue<int> locks = new Queue<int>(locksArr);
            Stack<int> bullets = new Stack<int>(bulletsArr);

            int countOfShotBullets = 0;
            int sizeOfBullet = 0;
            int sizeOfLock = 0;

            int currentGunBarrel = sizeOfgunBarell;
            bool runsOutOfLocks = false;

            while (bullets.Count > 0 && locks.Count > 0)
            {
                sizeOfBullet = bullets.Peek();
                sizeOfLock = locks.Peek();

                if (sizeOfBullet <= sizeOfLock)
                {
                    Console.WriteLine("Bang!");
                    locks.Dequeue();
                }
                else
                {
                    Console.WriteLine("Ping!");
                }

                if (locks.Count <= 0)
                {
                    runsOutOfLocks = true;
                }

                bullets.Pop();
                countOfShotBullets++;
                currentGunBarrel--; 
                if (currentGunBarrel <= 0)
                {
                    if (bullets.Count > 0)
                    {
                        Console.WriteLine("Reloading!");
                    }

                    currentGunBarrel = sizeOfgunBarell;
                }
            }

            int moneyEarned = intelligenceValue - (countOfShotBullets * priceOfBullet);

            if (bullets.Count <= 0)
            {
                if (runsOutOfLocks == true)
                {
                    Console.WriteLine($"{bullets.Count} bullets left. Earned ${moneyEarned}");
                }
                else
                {
                    Console.WriteLine($"Couldn't get through. Locks left: {locks.Count}");
                }
                
            }
            else
            {
                Console.WriteLine($"{bullets.Count} bullets left. Earned ${moneyEarned}");
            }

            ;

        }

        private static int[] ReadArrayFromConsole()
        {
            return Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
        }
    }
}
