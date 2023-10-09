namespace CSharpDiscovery.Quest02
{
    public class SortTable_Exercice
    {
        public static int[] SortTable(int[] tab)
        {
            if (tab == null) {
                return new int[0];
            }
            Array.Sort(tab);
            return tab;
        }
    }
}