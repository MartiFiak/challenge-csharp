namespace CSharpDiscovery.Quest01
{
    public class RemoveSpaces_Exercice
    {
        public static string RemoveSpaces(string str)
        {
           string res = "";
           for (int i = 0; i < str.Length; i++) {
                if (str[i] != ' ') {
                    res += str[i];
                }
           }
           return res;
        }
    }
}