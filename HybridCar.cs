namespace CSharpDiscovery.Quest04;

public class HybridCar : Car, IElectricCar, IThermalCar
{
    public HybridCar() : base() {
    }
    public HybridCar(string model, string brand, string color, int currentSpeed = 0) : base(model, brand, color ,currentSpeed){
    }
    public int FuelLevel {get;set;}
    public int BatteryLevel { get; set; }
    public int GetFuelLevel () {
        FuelLevel = 100;
        return FuelLevel;
    }
    public void FillUp() {
    }
    public void Recharge() {
    }
    public int GetBatteryLevel() {
        BatteryLevel = 100;
        return BatteryLevel;
    }
    public override string ToString()
    {
        return Color+" "+Brand+" "+Model+", Battery: "+BatteryLevel+"%, Fuel: "+FuelLevel+"%";
    }
}