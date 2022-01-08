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
            TwoWheeledVehicle test = new TwoWheeledVehicle();
            Console.WriteLine(test.Color);
            test.startEngine();
            test.EngineType = "Automatic";
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
        protected double fuel_consumption_constant; // Based on latest statistics, average consumption of fuel is 9.3L/100km, which is 0.093L per kilometer.
        // CHANGE FCC BASED ON TYPE OF VEHICLE
        protected bool is_two_wheeled;
        protected int speed_decrease = 0;
        protected int number_person_riding = 0;
        protected int current_speed = 0;
        protected int max_speed = 0; // TODO: Set on actual vehicle
        protected int minimum_driving_speed = 0; // TODO: Set on actual vehicle
        protected String current_direction = "North";
        protected double distance_travelled = 0;
        protected double total_displacement = 0;

        // for calculating the displacement
        private double north_distance = 0;
        private double south_distance = 0;
        private double east_distance = 0;
        private double west_distance = 0;
        
        public String EngineType
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
            if(isEngineOn == true)
            {
                Console.WriteLine("Engine is already on");
                return;
            }
            isEngineOn = true;
            number_person_riding += 1;
        }

        public override void stopEngine()
        {
            isEngineOn = false;
            number_person_riding = 0;
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
            /***********
             The drive method assumes that 20 minutes has passed every time it is invoked,
             so the distance travelled after invoking the method is the current speed in 
             kph divided by 3. The gas/fuel consumed during this process is then calculated
             by multiplying the kilometers travelled and the fuel consumption constant.

            Directions:
            Forward - no change in direction, vehicle speeds up
            Back - Vehicle makes a 180 degree turn, slows down to the set minimum driving speed
            Left, right - makes a left/right turn. Slows down the vehicle by 10kph.

            Notes: Directions are shown using the cardinal directions (e.g. North, East, West, South). A turn
            will change the next direction with respect to the current cardinal direction. 
            Example:
               - making a left turn while facing south will make the vehicle face east.
             ***********/
            if(isEngineOn == false)
            {
                throw new Exception("Please start the engine first");
            }
            if(EngineType == null)
            {
                throw new Exception("Please initialize engine type first");
            }
            if(current_fuel_liters == 0)
            {
                Console.WriteLine("Please refuel first");
                return;
            }
            if (is_two_wheeled)
            {
                speed_decrease = number_person_riding;
            }

            Console.WriteLine("[1] Forward");
            Console.WriteLine("[2] Back");
            Console.WriteLine("[3] Left");
            Console.WriteLine("[4] Right");
            Console.Write("Pick a direction: ");
            int direction = int.Parse(Console.ReadLine());
            Console.WriteLine();

            if (direction == 1)
            {
                if (current_speed == 0)
                {
                    Console.WriteLine(String.Format("Driving from initial speed of 0kph to {0} kph.", minimum_driving_speed));
                    current_speed = minimum_driving_speed;
                }
                else if (current_speed + 20 >= max_speed)
                {
                    current_speed = max_speed;
                }
                else
                {
                    current_speed += 20;
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

                if (current_speed == 0)
                {
                    Console.WriteLine(String.Format("Driving from initial speed of 0kph to {0} kph.", minimum_driving_speed));
                    current_speed = minimum_driving_speed;
                }
                else
                {
                    Console.WriteLine(String.Format("Making a U-turn. Speed reduced to {0} kph", minimum_driving_speed));
                    current_speed = minimum_driving_speed;
                }
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
                if (current_speed - 10 <= minimum_driving_speed)
                {
                    current_speed = minimum_driving_speed;
                }
                else
                {
                    current_speed -= 10;
                }
            }

            current_speed -= speed_decrease;
            double current_distance_travelled = (current_speed) / 3;
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

    class WaterVehicle : Vehicle
    {
        protected double fuel_consumption_constant = 0.275; // Based on a 3MPG per 20 knots of travel.
        // CHANGE FCC BASED ON TYPE OF VEHICLE
        protected int current_speed = 0;
        protected int max_speed = 60; // TODO: Set on actual vehicle
        protected int minimum_driving_speed = 10; // TODO: Set on actual vehicle
        protected String current_direction = "North";
        protected double distance_travelled = 0;
        protected double total_displacement = 0;

        // for calculating the displacement
        private double north_distance = 0;
        private double south_distance = 0;
        private double east_distance = 0;
        private double west_distance = 0;

        public WaterVehicle()
        {
            current_fuel_liters = 150; // TODO: Set on actual vehicle
        }

        public int NumberOfEngine
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
                tank_capacity = value * NumberOfEngine;
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
            if (isEngineOn == true)
            {
                Console.WriteLine("Engine is already on");
                return;
            }
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
            /***********
             The drive method assumes that 20 minutes has passed every time it is invoked,
             so the distance travelled after invoking the method is the current speed in 
             kph divided by 3. The gas/fuel consumed during this process is then calculated
             by multiplying the kilometers travelled and the fuel consumption constant.

            Directions:
            Forward - no change in direction, vehicle speeds up
            Back - Vehicle makes a 180 degree turn, slows down to the set minimum driving speed
            Left, right - makes a left/right turn. Slows down the vehicle by 10kph.

            Notes: Directions are shown using the cardinal directions (e.g. North, East, West, South). A turn
            will change the next direction with respect to the current cardinal direction. 
            Example:
               - making a left turn while facing south will make the vehicle face east.
             ***********/
            if (isEngineOn == false)
            {
                throw new Exception("Please start the engine first");
            }
            if (!(NumberOfEngine > 0))
            {
                throw new Exception("Please initialize number of engines first");
            }
            if (current_fuel_liters == 0)
            {
                Console.WriteLine("Please refuel first");
                return;
            }

            Console.WriteLine("[1] Forward");
            Console.WriteLine("[2] Back");
            Console.WriteLine("[3] Left");
            Console.WriteLine("[4] Right");
            Console.Write("Pick a direction: ");
            int direction = int.Parse(Console.ReadLine());
            Console.WriteLine();

            if (direction == 1)
            {
                if (current_speed == 0)
                {
                    Console.WriteLine(String.Format("Driving from initial speed of 0kph to {0} kph.", minimum_driving_speed));
                    current_speed = minimum_driving_speed;
                }
                else if (current_speed + 6 >= max_speed)
                {
                    current_speed = max_speed;
                }
                else
                {
                    current_speed += 6;
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

                if (current_speed == 0)
                {
                    Console.WriteLine(String.Format("Driving from initial speed of 0kph to {0} kph.", minimum_driving_speed));
                    current_speed = minimum_driving_speed;
                }
                else
                {
                    Console.WriteLine(String.Format("Making a U-turn. Speed reduced to {0} kph", minimum_driving_speed));
                    current_speed = minimum_driving_speed;
                }
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
                if (current_speed - 3 <= minimum_driving_speed)
                {
                    current_speed = minimum_driving_speed;
                }
                else
                {
                    current_speed -= 3;
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
                if (current_speed - 3 <= minimum_driving_speed)
                {
                    current_speed = minimum_driving_speed;
                }
                else
                {
                    current_speed -= 3;
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
            if (current_direction == "North")
            {
                north_distance += displacement;
            }
            else if (current_direction == "South")
            {
                south_distance += displacement;
            }
            else if (current_direction == "West")
            {
                west_distance += displacement;
            }
            else if (current_direction == "East")
            {
                east_distance += displacement;
            }

            distance_travelled += displacement;
        }
    }

    class AerialVehicle : Vehicle
    {
        protected double fuel_consumption_constant = 4; // Based on a 3MPG per 20 knots of travel.
        // CHANGE FCC BASED ON TYPE OF VEHICLE
        protected int current_speed = 0;
        protected int max_speed = 800; // TODO: Set on actual vehicle
        protected int minimum_driving_speed = 240; // TODO: Set on actual vehicle
        protected String current_direction = "North";
        protected double distance_travelled = 0;
        protected double total_displacement = 0;

        // for calculating the displacement
        private double north_distance = 0;
        private double south_distance = 0;
        private double east_distance = 0;
        private double west_distance = 0;

        public AerialVehicle()
        {
            current_fuel_liters = 30000; // TODO: Set on actual vehicle
        }

        public int NumberOfEngine
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
                tank_capacity = value * NumberOfEngine;
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
            if (isEngineOn == true)
            {
                Console.WriteLine("Engine is already on");
                return;
            }
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
            /***********
             The drive method assumes that 20 minutes has passed every time it is invoked,
             so the distance travelled after invoking the method is the current speed in 
             kph divided by 3. The gas/fuel consumed during this process is then calculated
             by multiplying the kilometers travelled and the fuel consumption constant.

            Directions:
            Forward - no change in direction, vehicle speeds up
            Back - Vehicle makes a 180 degree turn, slows down to the set minimum driving speed
            Left, right - makes a left/right turn. Slows down the vehicle by 10kph.

            Notes: Directions are shown using the cardinal directions (e.g. North, East, West, South). A turn
            will change the next direction with respect to the current cardinal direction. 
            Example:
               - making a left turn while facing south will make the vehicle face east.
             ***********/
            if (isEngineOn == false)
            {
                throw new Exception("Please start the engine first");
            }
            if (!(NumberOfEngine > 0))
            {
                throw new Exception("Please initialize number of engines first");
            }
            if (current_fuel_liters == 0)
            {
                Console.WriteLine("Please refuel first");
                return;
            }

            Console.WriteLine("[1] Forward");
            Console.WriteLine("[2] Back");
            Console.WriteLine("[3] Left");
            Console.WriteLine("[4] Right");
            Console.Write("Pick a direction: ");
            int direction = int.Parse(Console.ReadLine());
            Console.WriteLine();

            if (direction == 1)
            {
                if (current_speed == 0)
                {
                    Console.WriteLine(String.Format("Driving from initial speed of 0kph to {0} kph.", minimum_driving_speed));
                    current_speed = minimum_driving_speed;
                }
                else if (current_speed + 60 >= max_speed)
                {
                    current_speed = max_speed;
                }
                else
                {
                    current_speed += 60;
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
                if (current_speed == 0)
                {
                    Console.WriteLine(String.Format("Driving from initial speed of 0kph to {0} kph.", minimum_driving_speed));
                    current_speed = minimum_driving_speed;
                }
                else
                {
                    Console.WriteLine(String.Format("Making a U-turn. Speed reduced to {0} kph", minimum_driving_speed));
                    current_speed = minimum_driving_speed;
                }
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
                if (current_speed - 30 <= minimum_driving_speed)
                {
                    current_speed = minimum_driving_speed;
                }
                else
                {
                    current_speed -= 30;
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
                if (current_speed - 30 <= minimum_driving_speed)
                {
                    current_speed = minimum_driving_speed;
                }
                else
                {
                    current_speed -= 30;
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
            if (current_direction == "North")
            {
                north_distance += displacement;
            }
            else if (current_direction == "South")
            {
                south_distance += displacement;
            }
            else if (current_direction == "West")
            {
                west_distance += displacement;
            }
            else if (current_direction == "East")
            {
                east_distance += displacement;
            }

            distance_travelled += displacement;
        }
    }

    class TwoWheeledVehicle: WheeledVehicle
    {
        // TODO: Create constructor
        // TODO: Change FCC, max speed, min speed, current fuel liters

        // constructor

        public TwoWheeledVehicle(string color = "Black", int price = 80000, int tank_capacity = 12, int max_speed = 100, int minimum_driving_speed = 10)
        {
            Color = color;
            Price = price;
            this.max_speed = max_speed;
            this.minimum_driving_speed = minimum_driving_speed;
            TankCapacity = tank_capacity;
            SeatCapacity = 3;
            fuel_consumption_constant = 0.02;
            is_two_wheeled = true;
            current_fuel_liters = TankCapacity / 3;
        }

        public void addPassenger()
        {
            if(number_person_riding == SeatCapacity)
            {
                Console.WriteLine("Vehicle is already full");
                return;
            }
            number_person_riding += 1;
        }
    }

    class FourWheeledVehicle : WheeledVehicle
    {
        // TODO: Create constructor
        // TODO: Change FCC, max speed, min speed, current fuel liters

        // constructor

        public FourWheeledVehicle(string color = "Black", int price = 80000, int tank_capacity = 50, int max_speed = 100, int minimum_driving_speed = 10)
        {
            Color = color;
            Price = price;
            this.max_speed = max_speed;
            this.minimum_driving_speed = minimum_driving_speed;
            TankCapacity = tank_capacity;
            SeatCapacity = 6;
            fuel_consumption_constant = 0.093;
            is_two_wheeled = true;
            current_fuel_liters = TankCapacity / 3;
        }
        public void addPassenger()
        {
            if (number_person_riding == SeatCapacity)
            {
                Console.WriteLine("Vehicle is already full");
                return;
            }
            number_person_riding += 1;
        }
    }

}
