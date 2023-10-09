namespace CSharpDiscovery.Quest02
{
    public class ContainsThisValue_Exercice
    {
        public static bool ContainsThisValue(int[] tab, int value)
        {
            if (value == 0) {
                return false;
            }
            return tab.Contains(value);
        }
    }
}