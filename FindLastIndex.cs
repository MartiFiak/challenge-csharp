using System;

namespace CSharpDiscovery.Quest02
{
    public class FindLastIndex_Exercice
    {
        public static int? FindLastIndex(int[] tab, int a)
        {
            if (tab == null) return null;
            if (Array.IndexOf(tab, a) < 0) {
                return null;
            }
            return Array.LastIndexOf(tab, a);
        }
    }
}