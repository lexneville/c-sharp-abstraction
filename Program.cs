using System;

namespace abstraction
{
    public abstract class MovingVehicle {
        public abstract void showMeTheVehicles();
    }
    public class Car : MovingVehicle {
        public override void showMeTheVehicles() {
            Console.WriteLine("Car");
        }
    }

    public class Bike : MovingVehicle {
        public override void showMeTheVehicles() {
            System.Console.WriteLine("Bike");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MovingVehicle vehicle;
            MovingVehicle notVehicle;
            vehicle = new Car();
            notVehicle = new Bike();
            vehicle.showMeTheVehicles();
            notVehicle.showMeTheVehicles();
        }
    }
}
