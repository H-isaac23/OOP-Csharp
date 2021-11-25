using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActivityVehicle
{
    class Program
    {
        static void Main(string[] args)
        {
            Car x = new Car();
            x.Color = "Red";
            Console.WriteLine(x.Color);
            Console.ReadLine();
        }
    }

    public abstract class Vehicle
    {
        protected String color;
        protected int price;
        protected bool engineIsOn = false;
        protected int seatCapacity;
        protected int tankCapacity;
        protected int currentFuelLiters;

        public abstract String Color
        {
            get; set;
        }

        public abstract int Price
        {
            get; set;
        }

        public abstract int TankCapacity
        {
            get;
        }

        public abstract int SeatCapacity
        {
            get;
        }
        public abstract void startEngine();
        public abstract void stopEngine();
        public abstract void refuel(int fuelInLiters);
    }

    public class Car : Vehicle
    {
        public Car()
        {
            // adsf
        }
        public Car(int capacityTank, int capacitySeat)
        {
            tankCapacity = capacityTank;
            seatCapacity = capacitySeat;
        }

        public override String Color
        {
            get
            {
                return color;
            }
            set
            {
                color = value;
            }
        }

        public override int Price
        {
            get
            {
                return price;
            }
            set
            {
                price = value;
            }
        }

        public override int TankCapacity
        {
            get
            {
                return tankCapacity;
            }
        }

        public override int SeatCapacity
        {
            get
            {
                return seatCapacity;
            }
        }

        public override void startEngine()
        {
            engineIsOn = true;
        }

        public override void stopEngine()
        {
            engineIsOn = false;
        }
        public override void refuel(int fuelInLiters)
        {
            currentFuelLiters += fuelInLiters;
        }
    }

}
