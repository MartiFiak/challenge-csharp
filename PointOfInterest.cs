using System.Drawing;
using System.Dynamic;
using System.Formats.Asn1;
using System.Runtime.Intrinsics.X86;

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
    public override string ToString() {
        return Name+" (Lat="+Latitude+", Long="+Longitude+")";
    }

    public static double ConvertDegreesToRadians(double degrees)
        {
            return degrees * (Math.PI / 180);
        }

public int GetDistance(PointOfInterest other)
        {
            int R = 6371; // Rayon de la Terre en km

            var latDiff = ConvertDegreesToRadians(other.Latitude) - ConvertDegreesToRadians(this.Latitude);
            var lonDiff = ConvertDegreesToRadians(other.Longitude) - ConvertDegreesToRadians(this.Longitude);

            var h = Math.Sin(latDiff / 2) * Math.Sin(latDiff / 2) +
                    Math.Cos(ConvertDegreesToRadians(this.Latitude)) * Math.Cos(ConvertDegreesToRadians(other.Latitude)) *
                    Math.Sin(lonDiff / 2) * Math.Sin(lonDiff / 2);

            var distance = 2 * R * Math.Asin(Math.Sqrt(h));

            return Convert.ToInt32(Math.Round(distance));
        }

public static int GetDistance(PointOfInterest p1, PointOfInterest p2)
    {
        int R = 6371; // Rayon de la Terre en km

            var latDiff = ConvertDegreesToRadians(p2.Latitude) - ConvertDegreesToRadians(p1.Latitude);
            var lonDiff = ConvertDegreesToRadians(p2.Longitude) - ConvertDegreesToRadians(p1.Longitude);

            var h = Math.Sin(latDiff / 2) * Math.Sin(latDiff / 2) +
                    Math.Cos(ConvertDegreesToRadians(p1.Latitude)) * Math.Cos(ConvertDegreesToRadians(p2.Latitude)) *
                    Math.Sin(lonDiff / 2) * Math.Sin(lonDiff / 2);

            var distance = 2 * R * Math.Asin(Math.Sqrt(h));

            return Convert.ToInt32(Math.Round(distance));
    }
}