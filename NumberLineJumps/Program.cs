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

    // Complete the kangaroo function below.
    static string kangaroo(int x1, int v1, int x2, int v2)
    {
        //ilk kanguru x1 lokasyonunda başlar ve v1 metre kadar zıplar
        //ikinci kanguru x2 lokasyonunda başlar ve v2 metre kadar zıplar
        //Amaç=> iki kanguruyu aynı yerde bulmak mümkünse true değilse false döndürücez.
        if (0 <= x1 && x1 < x2 && x2 < 10000 &&
             1 < v1 && v1 < 10000 &&
             1 < v2 && v2 < 10000)
        {
            for (int jumpCount = 0; jumpCount < 200; jumpCount++)
            {
                x1 += v1 * jumpCount;
                x2 += v2 * jumpCount;

                if (x1 == x2)
                {

                    return "YES";
                }

            }
        }
        else
        {
            Console.WriteLine("NO");
        }
        return "";

    }

    static void Main(string[] args)
    {
        //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string[] x1V1X2V2 = Console.ReadLine().Split(' ');

        int x1 = Convert.ToInt32(x1V1X2V2[0]);

        int v1 = Convert.ToInt32(x1V1X2V2[1]);

        int x2 = Convert.ToInt32(x1V1X2V2[2]);

        int v2 = Convert.ToInt32(x1V1X2V2[3]);

        string result = kangaroo(x1, v1, x2, v2);

        Console.WriteLine(result);
        Console.ReadKey();

        // textWriter.WriteLine(result);

        // textWriter.Flush();
        // textWriter.Close();
    }
}
