using System;
using System.Reflection.Metadata;

namespace CSharpDiscovery.Quest02
{
    public class DifferenceInMinutes_Exercice
    {
        public static double DifferenceInMinutes(DateTime start, DateTime end)
        {
            TimeSpan interval = end - start;
            return interval.TotalMinutes;
        }
    }
}