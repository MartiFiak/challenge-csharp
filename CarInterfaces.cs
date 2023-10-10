namespace CSharpDiscovery.Quest04;

public interface IThermalCar {
    int FuelLevel();
    void FillUp();
    int GetFuelLevel ();
}

public interface IElectricCar {
    int BatteryLevel();
    void Recharge();
    int GetBatteryLevel();
}