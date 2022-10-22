using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SahovskaTablaDame
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] table = new string[8, 8];

            int numberOfSuccesses = 0;

            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    ResetAllFields(table);
                    
                    if (!MakeAllTakenFilds(table, i, j))
                        continue;
                    
                    string[,] table1 = table;

                    for (int a = 0; a < 8; a++)
                    {
                        for (int b = 0; b < 8; b++)
                        {
                            table = table1; 
                            if (!MakeAllTakenFilds(table, a, b))
                                continue;
                            string[,] table2 = table;
                            for (int c = 0; c < 8; c++)
                            {
                                for (int d = 0; d < 8; d++)
                                {
                                    table = table2;
                                    if (!MakeAllTakenFilds(table, c, d))
                                        continue;
                                    string[,] table3 = table;
                                    for (int e = 0; e < 8; e++)
                                    {
                                        for (int f = 0; f < 8; f++)
                                        {
                                            table = table3;
                                            if (!MakeAllTakenFilds(table, e, f))
                                                continue;
                                            string[,] table4 = table;
                                            for (int g = 0; g < 8; g++)
                                            {
                                                for (int h = 0; h < 8; h++)
                                                {
                                                    table = table4;
                                                    if (!MakeAllTakenFilds(table, g, h))
                                                        continue;
                                                    string[,] table5 = table; 
                                                    for (int k = 0; k < 8; k++)
                                                    {
                                                        for (int l = 0; l < 8; l++)
                                                        {
                                                            table = table5;
                                                            if (!MakeAllTakenFilds(table, k, l))
                                                                continue;

                                                            numberOfSuccesses++; 
                                                            
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }


            Console.WriteLine(numberOfSuccesses);
            Console.ReadKey(); 
        }

        public static bool MakeAllTakenFilds(string[,] table, int i, int j)
        {
            if (table[i, j] == "Q" || table[i, j] == "*")
                return false;

            table[i, j] = "Q";

            for (int a = i+1; a < 8; a++)
            {
                table[a, j] = "*";
            }
            for (int a = i-1; a >= 0; a--)
            {
                table[a, j] = "*";
            }
            for (int a = j+1; a < 8; a++)
            {
                table[i, a] = "*";
            }
            for (int a = j-1; a >= 0; a--)
            {
                table[i, a] = "*";
            }

            int b = j + 1;
            for (int a = i+1; a < 8; a++)
            {
                if (a >= 8 || b >= 8)
                    break;

                table[a, b] = "*";
                b++;
            }
            b = j - 1;
            for (int a = i-1; a >= 0; a--)
            {
                if (a < 0 || b < 0)
                    break;

                table[a, b] = "*";
                b--;
            }
            b = j - 1;
            for (int a = i+1; a < 8; a++)
            {
                if (a >= 8 || b < 0)
                    break;

                table[a, b] = "*";
                b--;
            }

            b = j + 1;
            for (int a = i-1; a >= 0; a--)
            {
                if (a < 0 || b >= 8)
                    break;

                table[a, b] = "*";
                b++;
            }

            return true;
        }

        public static void ResetAllFields(string[,] table)
        {
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    table[i, j] = ".";
                }
            }
        }

        public static void PrintTable(string[,] table)
        {
            for (int p = 0; p < 8; p++)
            {
                for (int s = 0; s < 8; s++)
                {
                    Console.Write(table[p, s] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
