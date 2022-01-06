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
            WheeledVehicle test = new WheeledVehicle();
            test.Color = "Red";
            while (true)
            {
                test.drive();
            }
            Console.ReadLine();
        }
    }

    public abstract class Vehicle
    {
        protected String color;
        protected int price;
        protected bool isEngineOn = false;
        protected int seat_capacity;
        protected int tank_capacity;
        protected double current_fuel_liters;

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
            get; set;
        }

        public abstract int SeatCapacity
        {
            get; set;
        }
        public abstract void startEngine();
        public abstract void stopEngine();
        public abstract void refuel(int fuelInLiters);
    }

    class WheeledVehicle : Vehicle
    {
        protected double fuel_consumption_constant = 0.093; // Based on latest statistics, average consumption of fuel is 9.3L/100km, which is 0.093L per kilometer.
        // CHANGE BASED ON TYPE OF VEHICLE
        protected int current_speed = 0;
        protected int max_speed = 100; // TODO: Set on actual vehicle
        protected int minimum_driving_speed = 30; // TODO: Set on actual vehicle
        protected String current_direction = "North";
        protected double distance_travelled = 0;
        protected double total_displacement = 0;

        // for calculating the displacement
        private double north_distance = 0;
        private double south_distance = 0;
        private double east_distance = 0;
        private double west_distance = 0;

        public WheeledVehicle()
        {
            current_fuel_liters = 50; // TODO: Set on actual vehicle
        }
        
        public String Engine
        {
            get; set;
        }

        public override int TankCapacity
        {
            get
            {
                return tank_capacity;
            }
            set
            {
                tank_capacity = value;
            }
        }

        public override int SeatCapacity
        {
            get
            {
                return seat_capacity;
            }
            set
            {
                seat_capacity = value;
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

        public override void startEngine()
        {
            isEngineOn = true;
        }

        public override void stopEngine()
        {
            isEngineOn = false;
        }

        public override void refuel(int fuel_in_liters)
        {
            if (!(tank_capacity > 0))
            {
                throw new Exception("Please initialize the capacity of the tank before refueling");
            }

            if (current_fuel_liters + fuel_in_liters > tank_capacity)
            {
                current_fuel_liters = tank_capacity;
            }
            else
            {
                current_fuel_liters += fuel_in_liters;
            }
        }

        public void drive()
        {
            Console.WriteLine("[1] Up");
            Console.WriteLine("[2] Down");
            Console.WriteLine("[3] Left");
            Console.WriteLine("[4] Right");
            Console.Write("Pick a direction: ");
            int direction = int.Parse(Console.ReadLine());
            Console.WriteLine();

            if (direction == 1)
            {
                if (current_speed == 0)
                {
                    Console.WriteLine("Driving from initial speed of 0kph to 30kph");
                    current_speed = 30;
                }
                else if (current_speed + 10 >= max_speed)
                {
                    current_speed = max_speed;
                }
                else
                {
                    current_speed += 10;
                }
            }
            else if (direction == 2)
            {
                if (current_direction == "North")
                {
                    current_direction = "South";
                }
                else if (current_direction == "South")
                {
                    current_direction = "North";
                }
                else if (current_direction == "East")
                {
                    current_direction = "West";
                }
                else if (current_direction == "West")
                {
                    current_direction = "East";
                }
                Console.WriteLine("Making a U-turn. Speed reduced to 30kph");
                current_speed = 30;
            }
            else if (direction == 3)
            {
                if (current_direction == "North")
                {
                    current_direction = "West";
                }
                else if (current_direction == "South")
                {
                    current_direction = "East";
                }
                else if (current_direction == "East")
                {
                    current_direction = "North";
                }
                else if (current_direction == "West")
                {
                    current_direction = "South";
                }

                Console.WriteLine("Making a turn, slowing down.");
                if (current_speed - 10 <= minimum_driving_speed)
                {
                    current_speed = minimum_driving_speed;
                }
                else
                {
                    current_speed -= 10;
                }
            }
            else if (direction == 4)
            {
                if (current_direction == "North")
                {
                    current_direction = "East";
                }
                else if (current_direction == "South")
                {
                    current_direction = "West";
                }
                else if (current_direction == "East")
                {
                    current_direction = "South";
                }
                else if (current_direction == "West")
                {
                    current_direction = "North";
                }

                Console.WriteLine("Making a turn, slowing down.");
                if (current_speed - 5 <= minimum_driving_speed)
                {
                    current_speed = minimum_driving_speed;
                }
                else
                {
                    current_speed -= 5;
                }
            }

            double current_distance_travelled = current_speed / 3;
            // TODO: implement logic if gas is less than expected fuel consumption for the current_distance_travelled
            // That is, there is not enough gas for the expected distance to travel
            if (current_distance_travelled * fuel_consumption_constant <= current_fuel_liters)
            {
                current_fuel_liters -= current_distance_travelled * fuel_consumption_constant; // subtract fuel
            }
            else 
            {
                current_distance_travelled = current_fuel_liters / fuel_consumption_constant;
                current_fuel_liters = 0;
            }
            add_displacement(current_distance_travelled);

            double disp = Math.Sqrt(((north_distance - south_distance) * (north_distance - south_distance)) + ((west_distance - east_distance) * (west_distance - east_distance)));
            Console.WriteLine(String.Format("Current direction is due {0}.", current_direction));
            Console.WriteLine(String.Format("Current speed is {0} kph.", current_speed));
            Console.WriteLine(String.Format("Total distance travelled is {0:F2} km.", distance_travelled));
            Console.WriteLine(String.Format("Total displacement from origin is {0:F2} km.", disp));
            Console.WriteLine(String.Format("Total remaining gas is {0:F2}", current_fuel_liters));
            Console.WriteLine();

        }

        // An extra feature I wanted to put, just for a little bit of touch
        public void add_displacement(double displacement)
        {
            if(current_direction == "North")
            {
                north_distance += displacement;
            }else if(current_direction == "South")
            {
                south_distance += displacement;
            }else if(current_direction == "West")
            {
                west_distance += displacement;
            }else if (current_direction == "East")
            {
                east_distance += displacement;
            }

            distance_travelled += displacement;
        }
    }

}
