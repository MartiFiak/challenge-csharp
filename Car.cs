using System.Drawing;

namespace CSharpDiscovery.Quest04;

public class Car : Vehicule {
    public string? Model { get; set; }
    public Car() : base() {
        Model = "Unknown";
    }
    public override void Accelerate(int Speed)
    {
       if ((CurrentSpeed + Speed) >= 180) {
        CurrentSpeed = 180;
       }
       else {
        CurrentSpeed += Speed;
       }
    }
    public override void Brake(int BrakePower)
    {
        if (CurrentSpeed - BrakePower < 0) {
            CurrentSpeed = 0;
        }
        else {
            CurrentSpeed -= BrakePower;
        }
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