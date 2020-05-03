using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Solution
{

    // Complete the cavityMap function below.
    static void cavityMap(string[] grid)
    {
        for (int row = 1; (row < (grid.Length - 1)); row++)
        {
            for (int column = 1; (column < (grid.Length - 1)); column++)
            {
                int cellDepth = grid[row][column]; //1 1 9
                if (((cellDepth > grid[row][(column + 1)])    //1>1 9 >1
                            && ((cellDepth > grid[row][(column - 1)]) //1>1  9>1
                            && ((cellDepth > grid[(row - 1)][column]) //1>1  9>8
                            && (cellDepth > grid[(row + 1)][column]))))) //1>1 9>1
                {
                    char[] ch = grid[row].ToCharArray();
                    ch[column] = 'X';
                    grid[row] = new string(ch);
                }

            }

        }

        for (int row = 0; (row < grid.Length); row++)
        {
           // Console.WriteLine(grid[row].ToCharArray());
            Console.WriteLine(string.Join("\n\n", grid[row]));
            //Console.ReadLine();
        }
        Console.ReadLine();
        //return grid;
    }

    static void Main(string[] args)
    {
        //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine());

        string[] grid = new string[n];

        for (int i = 0; i < n; i++)
        {
            string gridItem = Console.ReadLine();
            grid[i] = gridItem;
        }

       cavityMap(grid);

        //Console.WriteLine(string.Join("\n", result));
        Console.ReadLine();
        //textWriter.Flush();
        //textWriter.Close();
    }
}
