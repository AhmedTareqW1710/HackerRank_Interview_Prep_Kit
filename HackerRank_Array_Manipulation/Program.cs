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

    // Complete the arrayManipulation function below.
    static long arrayManipulation(int n, int[][] queries)
    {
        long max = 0;
        int rowsIndex = 0;
        int columnsIndex = 0;

        int[] zerosArr = new int[n];

        for (rowsIndex = 0; rowsIndex < queries.Length; rowsIndex++)
        {
            for (int i = queries[rowsIndex][columnsIndex]; i <= queries[rowsIndex][columnsIndex + 1]; i++)
            {
                if (i <= n-1)
                {
                    zerosArr[i] += queries[rowsIndex][columnsIndex + 2];

                }
            }
        }

        max = zerosArr.Max();
        return max;

    }

    static void Main(string[] args)
    {
        //TextWriter textWriter = new StreamWriter(@"\\DESKTOP-LIDPIJ8\HackerRank", true);

        string[] nm = Console.ReadLine().Split(' ');

        int n = Convert.ToInt32(nm[0]);

        int m = Convert.ToInt32(nm[1]);

        int[][] queries = new int[m][];

        for (int i = 0; i < m; i++)
        {
            queries[i] = Array.ConvertAll(Console.ReadLine().Split(' '), queriesTemp => Convert.ToInt32(queriesTemp));
        }

        long result = arrayManipulation(n, queries);

        Console.WriteLine(result);
        Console.Read();
        //textWriter.WriteLine(result);

        //textWriter.Flush();
        //textWriter.Close();
    }
}
