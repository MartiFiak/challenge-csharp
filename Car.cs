using System.Drawing;

namespace CSharpDiscovery.Quest04;

public class Car : Vehicule {
    public string? Model { get; set; }
    public Car() : base() {
        Model = "Unknown";
    }
    public Car(string model, string brand, string color, int currentSpeed) : base() {
        Model = model;
        Brand = brand;
        Color = color;
        CurrentSpeed = currentSpeed;
    }
    public override string ToString()
    {
        return Color + " " + Brand + " " + Model;
    }
}