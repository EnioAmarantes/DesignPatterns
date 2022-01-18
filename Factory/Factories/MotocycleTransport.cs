using Factory.Vehicles;

namespace Factory.Factories
{
    class MotocycleTransport : Transport
    {
        protected override IVehicle CreateTransport()
        {
            return new Motorcycle();
        }
    }
}
