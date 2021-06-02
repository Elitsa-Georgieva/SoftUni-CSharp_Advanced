using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.Serialization;

namespace _9._Miner
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            char[,] field = new char[size, size];

            string[] commands = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            List<int> startCooridanets = new List<int>();
            List<int> currCoordinates = new List<int>();

            int coals = 0;
            int getCoals = 0;

            for (int row = 0; row < field.GetLength(0); row++)
            { 
                char[] line = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(char.Parse).ToArray();

                for (int col = 0; col < field.GetLength(1); col++)
                {
                    field[row, col] = line[col];

                    if (line[col] == 'c')
                    {
                        coals++;
                    }
                }

            }

            for (int row = 0; row < field.GetLength(0); row++)
            {
                for (int col = 0; col < field.GetLength(1); col++)
                {
                    int colLength = field.GetLength(1);
                    int rowLength = field.GetLength(0);

                    if (field[row, col] == 's')
                    {
                        startCooridanets.Add(row);
                        startCooridanets.Add(col);
                        
                        currCoordinates.Add(startCooridanets[0]);
                        currCoordinates.Add(startCooridanets[1]);

                        for (int i = 0; i < commands.Length; i++)
                        {
                            string command = commands[i];

                            if (command == "left")
                            {
                                if (currCoordinates[1] - 1 >= 0)
                                {
                                    currCoordinates[1] -= 1;
                                }

                                if (field[currCoordinates[0], currCoordinates[1]] == 'c')
                                {
                                    field[currCoordinates[0], currCoordinates[1]] = '*';
                                    getCoals++;
                                }
                            }
                            else if (command == "right")
                            {
                                if (currCoordinates[1] + 1 < colLength)
                                {
                                    currCoordinates[1] += 1;
                                }

                                if (field[currCoordinates[0], currCoordinates[1]] == 'c')
                                {
                                    field[currCoordinates[0], currCoordinates[1]] = '*';
                                    getCoals++;
                                }
                            }
                            else if (command == "up")
                            {
                                if (currCoordinates[0] - 1 >= 0)
                                {
                                    currCoordinates[0] -= 1;
                                }
                                
                                if (field[currCoordinates[0], currCoordinates[1]] == 'c')
                                {
                                    field[currCoordinates[0], currCoordinates[1]] = '*';
                                    getCoals++;
                                }
                            }
                            else if (command == "down")
                            {
                                if (currCoordinates[0] + 1 < rowLength)
                                {
                                    currCoordinates[0] += 1;
                                }

                                if (field[currCoordinates[0], currCoordinates[1]] == 'c')
                                {
                                    field[currCoordinates[0], currCoordinates[1]] = '*';
                                    getCoals++;
                                }
                            }

                            if (field[currCoordinates[0], currCoordinates[1]] == 'e')
                            {
                                Console.WriteLine($"Game over! ({string.Join(", ", currCoordinates)})");
                                return;
                            }

                            if(coals <= getCoals)
                            {
                                Console.WriteLine($"You collected all coals! ({string.Join(", ", currCoordinates)})");
                                return;
                            }

                        }

                        
                        if (coals > getCoals)
                        { 
                            Console.WriteLine($"{coals - getCoals} coals left. ({string.Join(", ", currCoordinates)})");
                            return;
                        }
                        else
                        {
                            Console.WriteLine($"You collected all coals! ({string.Join(", ", currCoordinates)})");
                            return;
                        }

                    }


                }

            }

        

            Console.WriteLine(getCoals);

        }
    }
}
