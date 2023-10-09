namespace CSharpDiscovery.Quest02
{
    public class AreEquals_Exercice
    {
        public static bool AreEquals(int[] tab1, int[] tab2)
        {
            if (tab1 == null || tab2 == null) {
                return false;
            }
           return tab1.SequenceEqual(tab2);
        }
    }
}