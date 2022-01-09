using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActivityVehicle

    /*
     I made it so that there will be exceptions thrown if there are logical errors.
     This will stop the program completely to throw the exception if needed.
     Example:
     -driving a vehicle without starting the engine first

    P.S. The program is over a thousand lines, done over the course of 3 days. Sorry if it's a little bit too much 人(_ _*)
     */

    /*
     Author: John Isaac Delgado
     */
{
    class Program
    {
        static void Main(string[] args)
        {
            bool continue_loop = true;
            Console.WriteLine("Welcome to Vehicle Tryouts!");
            
            int choice;

            while (continue_loop)
            {
                Console.WriteLine("What vehicle would you like to try out?");
                Console.WriteLine("[1] Two Wheeled Vehicle");
                Console.WriteLine("[2] Four Wheeled Vehicle");
                Console.WriteLine("[3] Submarine");
                Console.WriteLine("[4] Yacht");
                Console.WriteLine("[5] Helicopter");
                Console.WriteLine("[6] Airline");
                Console.WriteLine("[7] Quit");
                Console.Write("Select a number: ");

                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        TWV();
                        break;
                    case 2:
                        FWV();
                        break;
                    case 3:
                        Submarine();
                        break;
                    case 4:
                        Yacht();
                        break;
                    case 5:
                        Helicopter();
                        break;
                    case 6:
                        Airlines();
                        break;
                    case 7:
                        continue_loop = false;
                        break;
                    default:
                        Console.WriteLine("Input not in choices. Retrying... \n");
                        break;
                }
            }

            Console.WriteLine("Thanks for using the program! Until next time.");
            Console.ReadLine();
        }

        static void TWV()
        {
            bool continue_loop = true;

            TwoWheeledVehicle v;
            Console.WriteLine("\nYou've chosen a two-wheeled vehicle!");
            Console.WriteLine("Would you like to go with the default configuration or make your own?");
            Console.Write("[1] Yes [2] No. Select a number: ");
            int choice = int.Parse(Console.ReadLine());
            if(choice != 1 && choice != 2)
            {
                Console.WriteLine("Input not in choices. Stopping the configuration...\n");
                return;
            }
            if(choice == 1)
            {
                Console.Write("\nWhat's the color of the vehicle? ");
                string color = Console.ReadLine();
                Console.Write("What's your price for the vehicle? ");
                int price = int.Parse(Console.ReadLine());
                Console.WriteLine("What's the engine type? Manual or Automatic? ");
                string engine_type = Console.ReadLine();
                Console.WriteLine("Configuring vehicle...");
                v = new TwoWheeledVehicle(color, price, engine_type);
            }
            else
            {
                v = new TwoWheeledVehicle();
            }

            int option;
            while (continue_loop)
            {
                Console.WriteLine("\nWhat would you like to do with the vehicle? ");
                Console.WriteLine("[1] Start engine");
                Console.WriteLine("[2] Stop engine");
                Console.WriteLine("[3] Drive");
                Console.WriteLine("[4] Refuel");
                Console.WriteLine("[5] Add passenger");
                Console.WriteLine("[6] Print Vehicle Specifications");
                Console.WriteLine("[7] Quit");
                Console.Write("Choose a number: ");

                option = int.Parse(Console.ReadLine());
                Console.WriteLine();
                switch (option)
                {
                    case 1:
                        v.startEngine();
                        break;
                    case 2:
                        v.stopEngine();
                        break;
                    case 3:
                        v.drive();
                        break;
                    case 4:
                        v.refuel();
                        break;
                    case 5:
                        v.addPassenger();
                        break;
                    case 6:
                        v.printSpecs();
                        break;
                    case 7:
                        continue_loop = false;
                        break;
                    default:
                        Console.WriteLine("Input not in choices. Retrying... \n");
                        break;
                }
            }

            Console.WriteLine("Thank you for trying out this vehicle! \n");
        }

        static void FWV()
        {
            bool continue_loop = true;

            FourWheeledVehicle v;
            Console.WriteLine("\nYou've chosen a four-wheeled vehicle!");
            Console.WriteLine("Would you like to go with the default configuration or make your own?");
            Console.Write("[1] Yes [2] No. Select a number: ");
            int choice = int.Parse(Console.ReadLine());
            if (choice != 1 && choice != 2)
            {
                Console.WriteLine("Input not in choices. Stopping the configuration...\n");
                return;
            }
            if (choice == 1)
            {
                Console.Write("\nWhat's the color of the vehicle? ");
                string color = Console.ReadLine();
                Console.Write("What's your price for the vehicle? ");
                int price = int.Parse(Console.ReadLine());
                Console.WriteLine("What's the engine type? Manual or Automatic? ");
                string engine_type = Console.ReadLine();
                Console.WriteLine("Configuring vehicle...");
                v = new FourWheeledVehicle(color, price, engine_type);
            }
            else
            {
                v = new FourWheeledVehicle();
            }

            int option;
            while (continue_loop)
            {
                Console.WriteLine("\nWhat would you like to do with the vehicle? ");
                Console.WriteLine("[1] Start engine");
                Console.WriteLine("[2] Stop engine");
                Console.WriteLine("[3] Drive");
                Console.WriteLine("[4] Refuel");
                Console.WriteLine("[5] Add passenger");
                Console.WriteLine("[6] Print Vehicle Specification");
                Console.WriteLine("[7] Quit");
                Console.Write("Choose a number: ");

                option = int.Parse(Console.ReadLine());
                Console.WriteLine();
                switch (option)
                {
                    case 1:
                        v.startEngine();
                        break;
                    case 2:
                        v.stopEngine();
                        break;
                    case 3:
                        v.drive();
                        break;
                    case 4:
                        v.refuel();
                        break;
                    case 5:
                        v.addPassenger();
                        break;
                    case 6:
                        v.printSpecs();
                        break;
                    case 7:
                        continue_loop = false;
                        break;
                    default:
                        Console.WriteLine("Input not in choices. Retrying... \n");
                        break;
                }
            }

            Console.WriteLine("Thank you for trying out this vehicle! \n");
        }

        static void Submarine()
        {
            bool continue_loop = true;

            Submarine v;
            Console.WriteLine("\nYou've chosen a Submarine!");
            Console.WriteLine("Would you like to go with the default configuration or make your own?");
            Console.Write("[1] Yes [2] No. Select a number: ");
            int choice = int.Parse(Console.ReadLine());
            if (choice != 1 && choice != 2)
            {
                Console.WriteLine("Input not in choices. Stopping the configuration...\n");
                return;
            }
            if (choice == 1)
            {
                Console.Write("\nWhat's the color of the vehicle? ");
                string color = Console.ReadLine();
                Console.Write("What's your price for the vehicle? ");
                int price = int.Parse(Console.ReadLine());
                Console.WriteLine("Configuring vehicle...");
                v = new Submarine(color, price);
            }
            else
            {
                v = new Submarine();
            }

            int option;
            while (continue_loop)
            {
                Console.WriteLine("\nWhat would you like to do with the vehicle? ");
                Console.WriteLine("[1] Start engine");
                Console.WriteLine("[2] Stop engine");
                Console.WriteLine("[3] Drive");
                Console.WriteLine("[4] Refuel");
                Console.WriteLine("[5] Add passenger");
                Console.WriteLine("[6] Print Vehicle Specification");
                Console.WriteLine("[7] Quit");
                Console.Write("Choose a number: ");

                option = int.Parse(Console.ReadLine());
                Console.WriteLine();
                switch (option)
                {
                    case 1:
                        v.startEngine();
                        break;
                    case 2:
                        v.stopEngine();
                        break;
                    case 3:
                        v.drive();
                        break;
                    case 4:
                        v.refuel();
                        break;
                    case 5:
                        v.addPassenger();
                        break;
                    case 6:
                        v.printSpecs();
                        break;
                    case 7:
                        continue_loop = false;
                        break;
                    default:
                        Console.WriteLine("Input not in choices. Retrying... \n");
                        break;
                }
            }

            Console.WriteLine("Thank you for trying out this vehicle! \n");
        }

        static void Yacht()
        {
            bool continue_loop = true;

            Yacht v;
            Console.WriteLine("\nYou've chosen a Yacht!");
            Console.WriteLine("Would you like to go with the default configuration or make your own?");
            Console.Write("[1] Yes [2] No. Select a number: ");
            int choice = int.Parse(Console.ReadLine());
            if (choice != 1 && choice != 2)
            {
                Console.WriteLine("Input not in choices. Stopping the configuration...\n");
                return;
            }
            if (choice == 1)
            {
                Console.Write("\nWhat's the color of the vehicle? ");
                string color = Console.ReadLine();
                Console.Write("What's your price for the vehicle? ");
                int price = int.Parse(Console.ReadLine());
                Console.WriteLine("Configuring vehicle...");
                v = new Yacht(color, price);
            }
            else
            {
                v = new Yacht();
            }

            int option;
            while (continue_loop)
            {
                Console.WriteLine("\nWhat would you like to do with the vehicle? ");
                Console.WriteLine("[1] Start engine");
                Console.WriteLine("[2] Stop engine");
                Console.WriteLine("[3] Drive");
                Console.WriteLine("[4] Refuel");
                Console.WriteLine("[5] Add passenger");
                Console.WriteLine("[6] Print Vehicle Specification");
                Console.WriteLine("[7] Quit");
                Console.Write("Choose a number: ");

                option = int.Parse(Console.ReadLine());
                Console.WriteLine();
                switch (option)
                {
                    case 1:
                        v.startEngine();
                        break;
                    case 2:
                        v.stopEngine();
                        break;
                    case 3:
                        v.drive();
                        break;
                    case 4:
                        v.refuel();
                        break;
                    case 5:
                        v.addPassenger();
                        break;
                    case 6:
                        v.printSpecs();
                        break;
                    case 7:
                        continue_loop = false;
                        break;
                    default:
                        Console.WriteLine("Input not in choices. Retrying... \n");
                        break;
                }
            }

            Console.WriteLine("Thank you for trying out this vehicle! \n");
        }

        static void Helicopter()
        {
            bool continue_loop = true;

            Helicopter v;
            Console.WriteLine("\nYou've chosen a Helicopter!");
            Console.WriteLine("Would you like to go with the default configuration or make your own?");
            Console.Write("[1] Yes [2] No. Select a number: ");
            int choice = int.Parse(Console.ReadLine());
            if (choice != 1 && choice != 2)
            {
                Console.WriteLine("Input not in choices. Stopping the configuration...\n");
                return;
            }
            if (choice == 1)
            {
                Console.Write("\nWhat's the color of the vehicle? ");
                string color = Console.ReadLine();
                Console.Write("What's your price for the vehicle? ");
                int price = int.Parse(Console.ReadLine());
                Console.WriteLine("Configuring vehicle...");
                v = new Helicopter(color, price);
            }
            else
            {
                v = new Helicopter();
            }

            int option;
            while (continue_loop)
            {
                Console.WriteLine("\nWhat would you like to do with the vehicle? ");
                Console.WriteLine("[1] Start engine");
                Console.WriteLine("[2] Stop engine");
                Console.WriteLine("[3] Drive");
                Console.WriteLine("[4] Refuel");
                Console.WriteLine("[5] Add passenger");
                Console.WriteLine("[6] Print Vehicle Specification");
                Console.WriteLine("[6] Quit");
                Console.Write("Choose a number: ");

                option = int.Parse(Console.ReadLine());
                Console.WriteLine();
                switch (option)
                {
                    case 1:
                        v.startEngine();
                        break;
                    case 2:
                        v.stopEngine();
                        break;
                    case 3:
                        v.drive();
                        break;
                    case 4:
                        v.refuel();
                        break;
                    case 5:
                        v.addPassenger();
                        break;
                    case 6:
                        v.printSpecs();
                        break;
                    case 7:
                        continue_loop = false;
                        break;
                    default:
                        Console.WriteLine("Input not in choices. Retrying... \n");
                        break;
                }
            }

            Console.WriteLine("Thank you for trying out this vehicle! \n");
        }

        static void Airlines()
        {
            bool continue_loop = true;

            Airlines v;
            Console.WriteLine("\nYou've chosen an Airline!");
            Console.WriteLine("Would you like to go with the default configuration or make your own?");
            Console.Write("[1] Yes [2] No. Select a number: ");
            int choice = int.Parse(Console.ReadLine());
            if (choice != 1 && choice != 2)
            {
                Console.WriteLine("Input not in choices. Stopping the configuration...\n");
                return;
            }
            if (choice == 1)
            {
                Console.Write("\nWhat's the color of the vehicle? ");
                string color = Console.ReadLine();
                Console.Write("What's your price for the vehicle? ");
                int price = int.Parse(Console.ReadLine());
                Console.WriteLine("Configuring vehicle...");
                v = new Airlines(color, price);
            }
            else
            {
                v = new Airlines();
            }

            int option;
            while (continue_loop)
            {
                Console.WriteLine("\nWhat would you like to do with the vehicle? ");
                Console.WriteLine("[1] Start engine");
                Console.WriteLine("[2] Stop engine");
                Console.WriteLine("[3] Drive");
                Console.WriteLine("[4] Refuel");
                Console.WriteLine("[5] Add passenger");
                Console.WriteLine("[6] Print Vehicle Specification");
                Console.WriteLine("[7] Quit");
                Console.Write("Choose a number: ");

                option = int.Parse(Console.ReadLine());
                Console.WriteLine();
                switch (option)
                {
                    case 1:
                        v.startEngine();
                        break;
                    case 2:
                        v.stopEngine();
                        break;
                    case 3:
                        v.drive();
                        break;
                    case 4:
                        v.refuel();
                        break;
                    case 5:
                        v.addPassenger();
                        break;
                    case 6:
                        v.printSpecs();
                        break;
                    case 7:
                        continue_loop = false;
                        break;
                    default:
                        Console.WriteLine("Input not in choices. Retrying... \n");
                        break;
                }
            }

            Console.WriteLine("Thank you for trying out this vehicle! \n");
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
        public abstract void refuel();
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
            if (isEngineOn == true)
            {
                Console.WriteLine("Engine is already on");
                return;
            }
            Console.WriteLine("Engine started.");
            isEngineOn = true;
            number_person_riding += 1;
        }

        public override void stopEngine()
        {
            if(isEngineOn == false)
            {
                Console.WriteLine("Engine is already off.");
                return;
            }
            Console.WriteLine("Engine stopped.");
            isEngineOn = false;
            number_person_riding = 0;
        }

        public override void refuel()
        {
            /*
             * Refuel assumes that you are at a gas refueling station already.
             */
            if (!(tank_capacity > 0))
            {
                throw new Exception("Please initialize the capacity of the tank before refueling");
            }
            if(isEngineOn == true)
            {
                Console.WriteLine("Please turn off engine first");
                return;
            }
            Console.Write("Please say how much fuel you want to put: ");
            int liters = int.Parse(Console.ReadLine());
            if (current_fuel_liters + liters > tank_capacity)
            {
                current_fuel_liters = tank_capacity;
            }
            else
            {
                current_fuel_liters += liters;
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
                Console.WriteLine("Please start the engine first");
                return;
            }
            if(EngineType == null)
            {
                throw new Exception("Please initialize engine type first");
            }
            if(current_fuel_liters == 0)
            {
                Console.WriteLine("Please refuel first");
                current_speed = 0;
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
            Console.WriteLine(String.Format("Total remaining gas is {0:F2} liters out of {1:F2} liters.", current_fuel_liters, TankCapacity));
            Console.WriteLine();

        }

        // An extra feature I wanted to put, just for a little bit of touch
        private void add_displacement(double displacement)
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
        protected int number_person_riding = 0;
        protected double fuel_consumption_constant;
        // CHANGE FCC BASED ON TYPE OF VEHICLE
        protected int current_speed = 0;
        protected int max_speed; // TODO: Set on actual vehicle
        protected int minimum_driving_speed; // TODO: Set on actual vehicle
        protected String current_direction = "North";
        protected double distance_travelled = 0;
        protected double total_displacement = 0;

        // for calculating the displacement
        private double north_distance = 0;
        private double south_distance = 0;
        private double east_distance = 0;
        private double west_distance = 0;

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
            Console.WriteLine("Engine started.");
            isEngineOn = true;
            number_person_riding += 1;
        }

        public override void stopEngine()
        {
            if (isEngineOn == false)
            {
                Console.WriteLine("Engine is already off.");
                return;
            }
            Console.WriteLine("Engine stopped.");
            isEngineOn = false;
        }

        public override void refuel()
        {
            if (!(tank_capacity > 0))
            {
                throw new Exception("Please initialize the capacity of the tank before refueling");
            }
            if (isEngineOn == true)
            {
                Console.WriteLine("Please turn off engine first");
                return;
            }
            Console.Write("Please say how much fuel you want to put: ");
            int liters = int.Parse(Console.ReadLine());

            if (current_fuel_liters + liters > tank_capacity)
            {
                current_fuel_liters = tank_capacity;
            }
            else
            {
                current_fuel_liters += liters;
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
                Console.WriteLine("Please start the engine first");
                return;
            }
            if (!(NumberOfEngine > 0))
            {
                throw new Exception("Please initialize number of engines first");
            }
            if (current_fuel_liters == 0)
            {
                Console.WriteLine("Please refuel first");
                current_speed = 0;
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
            Console.WriteLine(String.Format("Total remaining gas is {0:F2} liters out of {1:F2} liters.", current_fuel_liters, TankCapacity));

        }

        // An extra feature I wanted to put, just for a little bit of touch
        private void add_displacement(double displacement)
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
        protected double fuel_consumption_constant;
        protected int number_person_riding;
        // CHANGE FCC BASED ON TYPE OF VEHICLE
        protected int current_speed = 0;
        protected int max_speed; // TODO: Set on actual vehicle
        protected int minimum_driving_speed; // TODO: Set on actual vehicle
        protected String current_direction = "North";
        protected double distance_travelled = 0;
        protected double total_displacement = 0;

        // for calculating the displacement
        private double north_distance = 0;
        private double south_distance = 0;
        private double east_distance = 0;
        private double west_distance = 0;

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
            Console.WriteLine("Engine started.");
            isEngineOn = true;
        }

        public override void stopEngine()
        {
            if (isEngineOn == false)
            {
                Console.WriteLine("Engine is already off.");
                return;
            }
            isEngineOn = false;
            Console.WriteLine("Engine stopped.");
        }

        public override void refuel()
        {
            if (!(tank_capacity > 0))
            {
                throw new Exception("Please initialize the capacity of the tank before refueling");
            }
            if (isEngineOn == true)
            {
                Console.WriteLine("Please turn off engine first");
                return;
            }

            Console.Write("Please say how much fuel you want to put: ");
            int liters = int.Parse(Console.ReadLine());

            if (current_fuel_liters + liters > tank_capacity)
            {
                current_fuel_liters = tank_capacity;
            }
            else
            {
                current_fuel_liters += liters;
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
                Console.WriteLine("Please start the engine first");
                return;
            }
            if (!(NumberOfEngine > 0))
            {
                throw new Exception("Please initialize number of engines first");
            }
            if (current_fuel_liters == 0)
            {
                Console.WriteLine("Please refuel first");
                current_speed = 0;
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
            Console.WriteLine(String.Format("Total remaining gas is {0:F2} liters out of {1:F2} liters.", current_fuel_liters, TankCapacity));
            Console.WriteLine();

        }

        // An extra feature I wanted to put, just for a little bit of touch
        private void add_displacement(double displacement)
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

        public TwoWheeledVehicle(string color = "Black", int price = 80000, string engineType = "manual")
        {
            Color = color;
            Price = price;
            EngineType = engineType;
            max_speed = 100;
            minimum_driving_speed = 10;
            TankCapacity = 12;
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
            Console.WriteLine("Passenger added");
            number_person_riding += 1;
        }
        public void printSpecs()
        {
            Console.WriteLine("\n---------------------------");
            Console.WriteLine(String.Format("Vehicle: Two-Wheeled"));
            Console.WriteLine(String.Format("Color: {0}", Color));
            Console.WriteLine(String.Format("Price: {0}", Price));
            Console.WriteLine(String.Format("Seat Capacity: {0}", SeatCapacity));
            Console.WriteLine(String.Format("Number of people riding: {0}", number_person_riding));
            Console.WriteLine("---------------------------\n");
        }
    }
    // TODO: ENGINE TYPE
    class FourWheeledVehicle : WheeledVehicle
    {
        // TODO: Create constructor
        // TODO: Change FCC, max speed, min speed, current fuel liters

        // constructor

        public FourWheeledVehicle(string color = "Black", int price = 500000, string engine_type = "manual")
        {
            EngineType = engine_type;
            Color = color;
            Price = price;
            max_speed = 100;
            minimum_driving_speed = 10;
            TankCapacity = 50;
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
            Console.WriteLine("Passenger added");
            number_person_riding += 1;
        }

        public void printSpecs()
        {
            Console.WriteLine("\n---------------------------");
            Console.WriteLine(String.Format("Vehicle: Four-Wheeled"));
            Console.WriteLine(String.Format("Color: {0}", Color));
            Console.WriteLine(String.Format("Price: {0}", Price));
            Console.WriteLine(String.Format("Seat Capacity: {0}", SeatCapacity));
            Console.WriteLine(String.Format("Number of people riding: {0}", number_person_riding));
            Console.WriteLine("---------------------------\n");
        }
    }

    class Submarine : WaterVehicle
    {
        // TODO: Create constructor
        // TODO: Change FCC, max speed, min speed, current fuel liters
        // price is over $400 million, default will be 20 billion pesos
        // constructor

        public Submarine(string color = "Black", int price = 2000000000)
        {
            Color = color;
            Price = price;
            NumberOfEngine = 1; // most submarines have 1 engine
            max_speed = 60;
            minimum_driving_speed = 10;
            TankCapacity = 17500;
            SeatCapacity = 50;
            fuel_consumption_constant = 40;
            current_fuel_liters = TankCapacity / 3;
        }

        public void addPassenger()
        {
            if (number_person_riding == SeatCapacity)
            {
                Console.WriteLine("Vehicle is already full");
                return;
            }
            Console.WriteLine("Passenger added");
            number_person_riding += 1;
        }
        public void printSpecs()
        {
            Console.WriteLine("\n---------------------------");
            Console.WriteLine(String.Format("Vehicle: Submarine"));
            Console.WriteLine(String.Format("Color: {0}", Color));
            Console.WriteLine(String.Format("Price: {0}", Price));
            Console.WriteLine(String.Format("Seat Capacity: {0}", SeatCapacity));
            Console.WriteLine(String.Format("Number of people riding: {0}", number_person_riding));
            Console.WriteLine("---------------------------\n");
        }
    }

    class Yacht : WaterVehicle
    {
        // TODO: Create constructor
        // TODO: Change FCC, max speed, min speed, current fuel liters
        // price averages around $500k, defaults to 25 million pesos
        // constructor

        public Yacht(string color = "Black", int price = 25000000)
        {
            Color = color;
            Price = price;
            NumberOfEngine = 2; // most submarines have 2 engines
            max_speed = 40;
            minimum_driving_speed = 10;
            TankCapacity = 12500;
            SeatCapacity = 8;
            fuel_consumption_constant = 28;
            current_fuel_liters = TankCapacity / 3;
        }

        public void addPassenger()
        {
            if (number_person_riding == SeatCapacity)
            {
                Console.WriteLine("Vehicle is already full");
                return;
            }
            Console.WriteLine("Passenger added");
            number_person_riding += 1;
        }
        public void printSpecs()
        {
            Console.WriteLine("\n---------------------------");
            Console.WriteLine(String.Format("Vehicle: Yacht"));
            Console.WriteLine(String.Format("Color: {0}", Color));
            Console.WriteLine(String.Format("Price: {0}", Price));
            Console.WriteLine(String.Format("Seat Capacity: {0}", SeatCapacity));
            Console.WriteLine(String.Format("Number of people riding: {0}", number_person_riding));
            Console.WriteLine("---------------------------\n");
        }
    }

    class Helicopter : AerialVehicle
    {
        // TODO: Create constructor
        // TODO: Change FCC, max speed, min speed, current fuel liters
        // price averages around $1.5 million, defaults to 75 million pesos
        // constructor

        public Helicopter(string color = "Black", int price = 75000000)
        {
            NumberOfEngine = 3; // default number of engines in helicopters is 3
            Color = color;
            Price = price;
            max_speed = 300;
            minimum_driving_speed = 30;
            TankCapacity = 100; 
            SeatCapacity = 12;
            fuel_consumption_constant = 0.18;
            current_fuel_liters = TankCapacity / 3;
        }

        public void addPassenger()
        {
            if (number_person_riding == SeatCapacity)
            {
                Console.WriteLine("Vehicle is already full");
                return;
            }
            Console.WriteLine("Passenger added");
            number_person_riding += 1;
        }

        public void printSpecs()
        {
            Console.WriteLine("\n---------------------------");
            Console.WriteLine(String.Format("Vehicle: Helicopter"));
            Console.WriteLine(String.Format("Color: {0}", Color));
            Console.WriteLine(String.Format("Price: {0}", Price));
            Console.WriteLine(String.Format("Seat Capacity: {0}", SeatCapacity));
            Console.WriteLine(String.Format("Number of people riding: {0}", number_person_riding));
            Console.WriteLine("---------------------------\n");
        }
    }

    class Airlines : AerialVehicle
    {
        // TODO: Create constructor
        // TODO: Change FCC, max speed, min speed, current fuel liters
        // a commercial airplane price averages around $40million, defaults to 2 billion pesos
        // constructor

        public Airlines(string color = "White", int price = 2000000000)
        {
            NumberOfEngine = 4; // default number of engine for planes is 4
            Color = color;
            Price = price;
            max_speed = 800;
            minimum_driving_speed = 100;
            TankCapacity = 5000; 
            SeatCapacity = 400;
            fuel_consumption_constant = 10;
            current_fuel_liters = TankCapacity / 3;
        }

        public void addPassenger()
        {
            if (number_person_riding == SeatCapacity)
            {
                Console.WriteLine("Vehicle is already full");
                return;
            }

            Console.WriteLine("How many passengers will be onboarding?");
            int onboarding_passenger = int.Parse(Console.ReadLine());

            if (number_person_riding + onboarding_passenger >= SeatCapacity)
            {
                Console.WriteLine("Vehicle is full after last onboarding passenger.");
                number_person_riding = SeatCapacity;
            }
            else
            {
                Console.WriteLine("Passenger added");
                number_person_riding += number_person_riding;
            }
        }

        public void printSpecs()
        {
            Console.WriteLine("\n---------------------------");
            Console.WriteLine(String.Format("Vehicle: Airline"));
            Console.WriteLine(String.Format("Color: {0}", Color));
            Console.WriteLine(String.Format("Price: {0}", Price));
            Console.WriteLine(String.Format("Seat Capacity: {0}", SeatCapacity));
            Console.WriteLine(String.Format("Number of people riding: {0}", number_person_riding));
            Console.WriteLine("---------------------------\n");
        }
    }
}
