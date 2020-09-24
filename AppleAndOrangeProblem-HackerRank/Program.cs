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

    static void countApplesAndOranges(int s, int t, int a, int b, int[] apples, int[] oranges)
    {   //s samin evinin başlanıgç noktası 
        //t samin evinin başlangıç noktası
        //a elma ağacının konumu
        //b portakal ağacının konumu
        //apples[] elmaların konumu .Lenght kaç elma olduğu
        //orange[] portakalların konumu .Lenght kaç portakal olduğu
        /*
         *  7 11    s-t
            5 15    a-b
            3 2     m n (elma-portakal sayısı)
            -2 2 1  m sırayla her elmanın a noktasına uzaklığını gösterir
            5 -6    n sırayla her portakalın b noktaısna uzaklığını gösterir.
         */
        int applesCount = 0;
        int orangesCount = 0;

        // Calculate fruit landings and store in new arrays
        for (int x = 0; x < apples.Length; x++)
            if (s <= apples[x] + a && t >= apples[x] + a)
                applesCount++;
        for (int x = 0; x < oranges.Length; x++)
            if (s <= oranges[x] + b && t >= oranges[x] + b)
                orangesCount++;
        Console.WriteLine(applesCount);
        Console.WriteLine(orangesCount);




    }

    static void Main(string[] args)
    {
        string[] st = Console.ReadLine().Split(' ');

        int s = Convert.ToInt32(st[0]); //sam ev başlangıç konumu

        int t = Convert.ToInt32(st[1]); //sam ev bitiş konumu

        string[] ab = Console.ReadLine().Split(' '); 

        int a = Convert.ToInt32(ab[0]); // elma ağacı konumu

        int b = Convert.ToInt32(ab[1]); // portakal aağacı konumu

        string[] mn = Console.ReadLine().Split(' ');

        int m = Convert.ToInt32(mn[0]); //elma sayısı

        int n = Convert.ToInt32(mn[1]); // portakal sayısı

        int[] apples = Array.ConvertAll(Console.ReadLine().Split(' '), applesTemp => Convert.ToInt32(applesTemp))
        ;// elmaların konum dizsi

        int[] oranges = Array.ConvertAll(Console.ReadLine().Split(' '), orangesTemp => Convert.ToInt32(orangesTemp))
        ;// portakalaların konum dizisi
        countApplesAndOranges(s, t, a, b, apples, oranges);
        Console.ReadKey();
    }
}
