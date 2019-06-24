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

    // Complete the minimumSwaps function below.
    static int minimumSwaps(int[] arr)
    {
        int swapsCount = 0;
        int currentValue = 0;
        int expectedValue = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == i + 1)
            {
                continue;
            }
            else
            {
                swapsCount++;
                currentValue = arr[i];
                expectedValue = arr[arr[i] - 1];
                arr[i] = expectedValue;
                arr[currentValue - 1] = currentValue;

                if (arr[i] != i + 1)
                {
                    i--;
                }
            }
        }

        return swapsCount;
    }

    static void Main(string[] args)
    {
        //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine());

        int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
        ;
        int res = minimumSwaps(arr);

        Console.Write(res);
        Console.Read();
        //textWriter.WriteLine(res);

        //textWriter.Flush();
        //textWriter.Close();
    }
}
