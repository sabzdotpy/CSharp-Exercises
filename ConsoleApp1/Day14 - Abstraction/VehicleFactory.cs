using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Day_14___Abstraction
{
    public abstract class FactoryVehicle
    {
        public abstract void Assemble(int totalParts = 50);
        public abstract void TestDrive(double distance, double fuelUsed);
        public abstract void Deliver(double baseCost, double taxRate);
    }

    public class FactoryCar : FactoryVehicle
    {
        public override void Assemble(int totalParts = 50)
        {
            Console.WriteLine($"The factory car is made of {totalParts} parts");
        }

        public override void TestDrive(double distance = 100, double fuelUsed = 49)
        {
            Console.WriteLine($"Factory Car mileage: {distance / fuelUsed}km/l");
        }

        public override void Deliver(double baseCost = 50000, double taxRate = 18)
        {
            Console.WriteLine($"Factory Car Base Cost = {baseCost}, Tax Rate = {taxRate}%, Total = {baseCost + (taxRate / 100) * baseCost}");
        }
    }

    public class FactoryBike : FactoryVehicle
    {
        public override void Assemble(int totalParts = 34)
        {
            Console.WriteLine($"The factory Bike is made of {totalParts} parts");
        }

        public override void TestDrive(double distance = 100, double fuelUsed = 28)
        {
            Console.WriteLine($"Factory Bike mileage: {distance / fuelUsed}km/l");
        }

        public override void Deliver(double baseCost = 20000, double taxRate = 16)
        {
            Console.WriteLine($"Factory Bike Base Cost = {baseCost}, Tax Rate = {taxRate}%, Total = {baseCost + (taxRate / 100) * baseCost}");
        }
    }

    public class FactoryTruck : FactoryVehicle
    {
        public override void Assemble(int totalParts = 990)
        {
            Console.WriteLine($"The factory truck is made of {totalParts} parts");
        }

        public override void TestDrive(double distance = 100, double fuelUsed = 94)
        {
            Console.WriteLine($"Factory Truck mileage: {distance / fuelUsed}km/l");
        }

        public override void Deliver(double baseCost = 300000, double taxRate = 18)
        {
            Console.WriteLine($"Factory Truck Base Cost = {baseCost}, Tax Rate = {taxRate}%, Total = {baseCost + (taxRate / 100) * baseCost}");
        }
    }

    public class VehicleFactory
    {
        public static FactoryVehicle GetVehicle(string type)
        {
            if (type == "car") return new FactoryCar();
            else if (type == "bike") return new FactoryBike();
            else if (type == "truck") return new FactoryTruck();
            else throw new Exception("Invalid vehicle type entered");
        }
    }
}
