namespace CSharpDiscovery.Quest02
{
    public class FromStringToDateTime_Exercice
    {
        public static DateTime FromStringToDateTime(string dateStr)
        {
            if (dateStr == null) {
                return new DateTime();
            }
            return DateTime.ParseExact(dateStr, "dd/MM/yyyy HH:mm", System.Globalization.CultureInfo.InvariantCulture);
        }
    }
}