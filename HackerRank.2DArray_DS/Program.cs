﻿using System.CodeDom.Compiler;
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

    // Complete the rotLeft function below.
    static int[] rotLeft(int[] a, int d)
    {
        List<int> result = a.ToList();
        int tempValue = 0;

        for (int i = 0; i < d; i++)
        {
            tempValue = a[i];
            result.Add(tempValue);
            result.RemoveAt(0);

        }


        return result.ToArray();
    }

    static void Main(string[] args)
    {

        string[] nd = Console.ReadLine().Split(' ');

        int n = Convert.ToInt32(nd[0]);

        int d = Convert.ToInt32(nd[1]);

        int[] a = Array.ConvertAll(Console.ReadLine().Split(' '), aTemp => Convert.ToInt32(aTemp))
        ;
        int[] result = rotLeft(a, d);

        Console.WriteLine(result);
        Console.Read();
    }
}