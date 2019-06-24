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
        int bribesCount = 0;
        List<int> tempList = new List<int>();
        //tempList.Add(-100);
        //tempList.AddRange(q);

        // Initial position [1,2,3,4,5,6,7,8,9]

        for (int i = 0; i < q.Length - 1; i++)
        {
            if (q[i] - 1 == i)
                continue;

            if ((q[i] - 1) - i > 2)
            {
                Console.WriteLine("Too chaotic");
                return;
            }
            for (int j = i + 1; j < q.Length; j++)
            {
                if (q[i] > q[j])
                {
                    var temp = q[i];
                    q[i] = q[j];
                    q[j] = temp;
                    bribesCount++;

                }
            }
        }

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


        Console.WriteLine(bribesCount);
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
