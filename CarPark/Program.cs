using System;

namespace CarPark
{
    class Engine
    {
        public double power;
        public double volume;
        public string type;
        public string serialNumber;
        public Engine(double enginePower, double engineVolume,string engineType, string engineSeria)
        {
            power = enginePower;
            volume = engineVolume;
            type = engineType;
            serialNumber = engineSeria;
        }
    }   
    class Chassis
    {
        public int wheels;
        public string number;
        public int permissibleLoad;
        public Chassis(int chassisWheels, string chassisNumber, int chassisLoad)
        {
            wheels = chassisWheels;
            number = chassisNumber;
            permissibleLoad = chassisLoad;
        }
    }   
    class Transmission
    {
        public int gears;
        public string type;
        public string manufacturer;
        public Transmission( string transType, int transGears,string transManufact)
        {
            gears = transGears;
            type = transType;
            manufacturer = transManufact;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            bool endApp = false;
            // Display title as the C# console calculator app.
            Console.WriteLine("Car Park in C#\r");
            Console.WriteLine("------------------------\n");

            while (!endApp)
            {
                Engine PassengerCarEngine = new Engine(200, 20, "VEE", "PJ12345U123456P");
                Engine TruckEngine = new Engine(550, 60, "PX-9", "4MG12345");
                Engine BusEngine = new Engine(380, 40, "CNG", "1200cc");
                Engine ScooterEngine = new Engine(100, 10, "CVT", "157QMJ");

                Chassis PassengerCarChassis = new Chassis(4, "VEE", 300);
                Chassis TruckChassis = new Chassis(8, "VEE", 1000);
                Chassis BusChassis = new Chassis(4, "VEE", 600);
                Chassis ScooterChassis = new Chassis(2, "VEE", 100);

                Transmission PassengerCarTransmis = new Transmission( "Any Type", 4,"Any manufacturer");
                Transmission TruckTransmis = new Transmission("Any Type", 8,  "Any manufacturer");
                Transmission BusTransmis = new Transmission("Any Type", 4,  "Any manufacturer");
                Transmission ScooterTransmis = new Transmission("Any Type", 2, "Any manufacturer");

                string vehicle = "";
                Console.WriteLine("Please, enter a vehicle (Passenger car, truck, bus, scooter or all): ");
                vehicle = Console.ReadLine();

                try
                {
                    switch (vehicle)
                    {
                        case "Passenger car" or "passenger car" or "Passenger Car" or "PASSENGER CAR":
                            Console.WriteLine("  Engine: " + PassengerCarEngine.power + " " + PassengerCarEngine.volume + " " + PassengerCarEngine.type + " " + PassengerCarEngine.serialNumber);
                            Console.WriteLine("  Chassis: " + PassengerCarChassis.wheels + " " + PassengerCarChassis.number + " " + PassengerCarChassis.permissibleLoad);
                            Console.WriteLine("  Transmission: " + PassengerCarTransmis.gears + " " + PassengerCarTransmis.type + " " + PassengerCarTransmis.manufacturer);
                            Console.WriteLine("------------------------\n");
                            break;
                        case "Truck" or "truck" or "TRUCK":
                            Console.WriteLine(" Engine: " + TruckEngine.power + " " + TruckEngine.volume + " " + TruckEngine.type + " " + TruckEngine.serialNumber);
                            Console.WriteLine(" Chassis: " + TruckChassis.wheels + " " + TruckChassis.number + " " + TruckChassis.permissibleLoad);
                            Console.WriteLine(" Transmission: " + TruckTransmis.gears + " " + TruckTransmis.type + " " + TruckTransmis.manufacturer);
                            Console.WriteLine("------------------------\n");
                            break;
                        case "Bus" or "bus" or "BUS":
                            Console.WriteLine(" Engine: " + BusEngine.power + " " + BusEngine.volume + " " + BusEngine.type + " " + BusEngine.serialNumber);
                            Console.WriteLine(" Chassis: " + BusChassis.wheels + " " + BusChassis.number + " " + BusChassis.permissibleLoad);
                            Console.WriteLine(" Transmission: " + BusTransmis.gears + " " + BusTransmis.type + " " + BusTransmis.manufacturer);
                            Console.WriteLine("------------------------\n");
                            break;
                        case "Scooter" or "scooter" or "SCOOTER":
                            Console.WriteLine(" Engine: " + ScooterEngine.power + " " + ScooterEngine.volume + " " + ScooterEngine.type + " " + ScooterEngine.serialNumber);
                            Console.WriteLine(" Chassis: " + ScooterChassis.wheels + " " + ScooterChassis.number + " " + ScooterChassis.permissibleLoad);
                            Console.WriteLine(" Transmission: " + ScooterTransmis.gears + " " + ScooterTransmis.type + " " + ScooterTransmis.manufacturer);
                            Console.WriteLine("------------------------\n");
                            break;
                        case "All" or "all" or "ALL":
                            Console.WriteLine("Engines:");
                            Console.WriteLine("Passenger car Engine: " + PassengerCarEngine.power + " " + PassengerCarEngine.volume + " " + PassengerCarEngine.type + " " + PassengerCarEngine.serialNumber);
                            Console.WriteLine("Truck Engine: " + TruckEngine.power + " " + TruckEngine.volume + " " + TruckEngine.type + " " + TruckEngine.serialNumber);
                            Console.WriteLine("Bus Engine: " + BusEngine.power + " " + BusEngine.volume + " " + BusEngine.type + " " + BusEngine.serialNumber);
                            Console.WriteLine("Scooter Engine: " + ScooterEngine.power + " " + ScooterEngine.volume + " " + ScooterEngine.type + " " + ScooterEngine.serialNumber);
                            Console.WriteLine("------------------------\n");
                            Console.WriteLine("Chassis:");
                            Console.WriteLine("Passenger car Chassis: " + PassengerCarChassis.wheels + " " + PassengerCarChassis.number + " " + PassengerCarChassis.permissibleLoad);
                            Console.WriteLine("Truck Chassis: " + TruckChassis.wheels + " " + TruckChassis.number + " " + TruckChassis.permissibleLoad);
                            Console.WriteLine("Bus Chassis: " + BusChassis.wheels + " " + BusChassis.number + " " + BusChassis.permissibleLoad);
                            Console.WriteLine("Scooter Chassis: " + ScooterChassis.wheels + " " + ScooterChassis.number + " " + ScooterChassis.permissibleLoad);
                            Console.WriteLine("------------------------\n");
                            Console.WriteLine("Transmission:");
                            Console.WriteLine("Passenger car Transmission: " + PassengerCarTransmis.gears + " " + PassengerCarTransmis.type + " " + PassengerCarTransmis.manufacturer);
                            Console.WriteLine("Truck Transmission: " + TruckTransmis.gears + " " + TruckTransmis.type + " " + TruckTransmis.manufacturer);
                            Console.WriteLine("Bus Transmission: " + BusTransmis.gears + " " + BusTransmis.type + " " + BusTransmis.manufacturer);
                            Console.WriteLine("Scooter Transmission: " + ScooterTransmis.gears + " " + ScooterTransmis.type + " " + ScooterTransmis.manufacturer);
                            Console.WriteLine("------------------------\n");
                            break;
                        default:
                            Console.WriteLine("Something went wrong...");
                            break;

                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Oh no! Something went wrong...\n - Details: " + e.Message);
                }


                // Wait for the user to respond before closing.
                Console.Write("Press 'n' and Enter to close the app, or press any other key and Enter to continue: ");
                if (Console.ReadLine() == "n") endApp = true;

                Console.WriteLine("\n"); // Friendly linespacing.
            }
            return;
        }
    }
}