using System.Text.RegularExpressions;

namespace CSharpDiscovery.Quest01
{
    public class BeginsWithSpecificCharacter_Exercice
    {
        public static bool BeginsWithSpecificCharacter(string str, char begin)
        {
           return Regex.IsMatch(str, $"^{begin}");
        }
    }
}