using System;

namespace SOLID.Isp
{
    public abstract class AVehicle: IVehicle
    {
        protected string color;
        protected int year;
        protected double engine;

        public virtual void StartVehicle()
        {
            throw new NotImplementedException();
        }
    }
}
