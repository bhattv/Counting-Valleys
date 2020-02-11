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
using Microsoft.VisualBasic;

class Solution
{

    // Complete the countingValleys function below.
    static int countingValleys(int n, string s)
    {
        Console.WriteLine("Total Steps: " + n);
        var NumberOfValleys = 0;

        var locationTotal = 0;
        foreach (char c in s)
        {
            if ((locationTotal == -1) && (c.ToString() == "U"))
            {
                NumberOfValleys += 1;
            }
            if (c.ToString() == "U")
            {
                locationTotal += 1;
            }
            else
            {
                locationTotal -= 1;
            }
        }

        Console.WriteLine("Number of Valleys: " + NumberOfValleys);
        return NumberOfValleys;
    }



    static void Main(string[] args)
    {


        int n = 8;
        string s = "UDDDUDUU";

        n = 13;
        s = "UDDUUDDDUUUDU";

        int result = countingValleys(n, s);

    }
}