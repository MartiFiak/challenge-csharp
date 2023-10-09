using System.Text.RegularExpressions;

namespace CSharpDiscovery.Quest01
{
    public class ContainsSpecificSubstring_Exercice
    {
        public static bool ContainsSpecificSubstring(string str, string pattern)
        {
           return Regex.IsMatch(str, pattern);
        }
    }
}