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

class Result
{

    /*
     * Complete the 'gradingStudents' function below.
     *
     * The function is expected to return an INTEGER_ARRAY.
     * The function accepts INTEGER_ARRAY grades as parameter.
     * 
     * 40tan küçükse fail notlar 0-100 arası
     */

    public static List<int> gradingStudents(List<int> grades)
    {
        int[] results = new int[grades.Count];

        for (int i = 0; i < grades.Count; i++)
        {
        
            if (grades[i] % 5 > 2 && !(grades[i] < 38))
                results[i] = grades[i] + (5 - grades[i] % 5);
            else
                results[i] = grades[i];
        }
        return results.ToList();

    }

}

class Solution
{
    public static void Main(string[] args)
    {
        //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);
        int gradesCount = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> grades = new List<int>();

        for (int i = 0; i < gradesCount; i++)
        {
            int gradesItem = Convert.ToInt32(Console.ReadLine().Trim());
            grades.Add(gradesItem);
        }

        List<int> result = Result.gradingStudents(grades);
        foreach (var item in result)
        {
            Console.WriteLine(item);

        }
        Console.ReadKey();

        // textWriter.WriteLine(String.Join("\n", result));

        //textWriter.Flush();
        //textWriter.Close();
    }
}
