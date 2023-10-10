namespace CSharpDiscovery.Quest03;

internal class HistoricalMonument : PointOfInterest {
    public int BuildYear {get; set;}
    public HistoricalMonument(string name, double longitude, double latitude, int buildYear) : base() {
        Latitude = latitude;
        Longitude = longitude;
        Name = name;
        BuildYear = buildYear;
    }
    public override string ToString()
    {
        return Name + " is a historical monument built in " + BuildYear;
    }
}