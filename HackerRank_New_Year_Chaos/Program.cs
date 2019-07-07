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

    // Complete the minimumBribes function below.
    static void minimumBribes(int[] q)
    {


        #region 60 % test cases passed 
        int bribesCount = 0;

        for (int i = q.Length - 1; i >= 0; i--)
        {
            if (q[i] - (i + 1) > 2)
            {
                Console.WriteLine("Too chaotic");
                return;
            }
            for (int j = 0 >  q[i]-2 ? 0: q[i] - 2; j < i; j++)
            {
                if (q[i] < q[j])
                {
                   
                    bribesCount++;

                }
            }
        }
        Console.WriteLine(bribesCount);
        #endregion
        #region Old solution
        //if (tempList[i] == -100)
        //{
        //    continue;

        //}
        //if ((tempList[i] - (i)) <= 0)
        //{
        //    continue;
        //}
        //else
        //{
        //    if ((tempList[i] - (i)) <= 2)
        //    {
        //        bribesCount = bribesCount + (tempList[i] - (i));
        //    }
        //    else
        //    {
        //        Console.WriteLine("Too chaotic");
        //        return;
        //    }
        //}
        #endregion



        return;

    }

    static void Main(string[] args)
    {
        int t = Convert.ToInt32(Console.ReadLine());

        for (int tItr = 0; tItr < t; tItr++)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int[] q = Array.ConvertAll(Console.ReadLine().Split(' '), qTemp => Convert.ToInt32(qTemp))
            ;
            minimumBribes(q);
        }

        Console.Read();

    }
}
