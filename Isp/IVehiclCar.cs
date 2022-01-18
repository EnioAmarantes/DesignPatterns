namespace SOLID.Isp
{
    interface IVehiclCar: IVehicle
    {
        void ConfigureCar(string color, int year, double engine, int seats, int doors);
    }
}
