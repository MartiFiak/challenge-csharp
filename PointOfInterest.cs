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
}