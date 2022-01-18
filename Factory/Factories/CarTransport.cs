using Factory.Vehicles;

namespace Factory.Factories
{
    class CarTransport : Transport
    {
        protected override IVehicle CreateTransport()
        {
            return new Car();
        }
    }
}
