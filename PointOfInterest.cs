using System.Dynamic;

namespace CSharpDiscovery.Quest03;

public class PointOfInterest {
    public Double Latitude {
        get; set;
    }
    public Double Longitude {
        get; set;
    }
    public String? Name {
        get; set;
    }
    public static String GoogleMapsUrlTemplate {
        get; set; 
    }
    static PointOfInterest() {
        GoogleMapsUrlTemplate = "https://www.google.com/maps/place/{0}/@{1},{2},15z/";
    }

    public PointOfInterest() {
        Name = "Bordeaux Ynov Campus";
        Latitude = 44.854186;
        Longitude = -0.5663056;
    }
    public PointOfInterest(string name, double latitude, double longitude) {
        Name = name;
        Longitude = longitude;
        Latitude = latitude;

    }
    public string GetGoogleMapsUrl() {
        return "https://www.google.com/maps/place/"+Name?.Replace(" ","+")+"/@"+Latitude+","+Longitude+",15z/";
    }
}