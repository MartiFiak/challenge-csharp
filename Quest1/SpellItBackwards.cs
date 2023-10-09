namespace CSharpDiscovery.Quest01
{
    public class SpellItBackwards_Exercice
    {
        public static string SpellItBackward(string str)
        {
           char[] rev = str.ToCharArray();
           Array.Reverse(rev);
           return new string(rev);
        }
    }
}