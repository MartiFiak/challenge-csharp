namespace CSharpDiscovery.Quest04;

public class HybridCar : Car, IElectricCar, IThermalCar
{
    public HybridCar() : base() {
    }
    public int FuelLevel { get; set; }
    public int BatteryLevel { get; set; }
    public HybridCar(string model, string brand, string color, int currentSpeed = 0) : base(model, brand, color ,currentSpeed){
    }
    public int GetFuelLevel () {
        return FuelLevel;
    }
    public void FillUp() {
        FuelLevel = 100;
    }
    public void Recharge() {
        BatteryLevel = 100;
    }
    public int GetBatteryLevel() {
        return BatteryLevel;
    }
    public override string ToString()
    {
        return base.ToString()+Color+" "+Brand+" "+Model+", Battery: "+BatteryLevel+"%, Fuel: "+FuelLevel+"%";
    }
}