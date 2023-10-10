namespace CSharpDiscovery.Quest03;

public class HistoricalMonument : PointOfInterest {
    public int BuildYear {get; set;}
    public HistoricalMonument() {
    }
    public HistoricalMonument(string name, double latitude, double longitude, int buildYear) : base() {
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