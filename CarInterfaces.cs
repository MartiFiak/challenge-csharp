namespace CSharpDiscovery.Quest04;

public interface IThermalCar {
    int FuelLevel();
    void FillUp();
    void GetFuelLevel (int a);
}

public interface IElectricCar {
    int BatteryLevel();
    void Recharge();
    void GetBatteryLevel(int b);
}