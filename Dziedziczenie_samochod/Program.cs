using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
      static void Main(string[] args)
        {
            Car MyCar = new Car(450, 3500, "Diesel", "Red", 4, "Car", "Mustang");
            MyCar.ShowInfo();
            Console.ReadKey();
        }
    }
    class Engine
    {
        int Power;
        int Volume;
        string FuelType;
        public Engine(int power, int volume, string fuelType)
        {
            Power = power;
            Volume = volume;
            FuelType = fuelType;
        }

        public void ShowInfo()
        {
            Console.WriteLine("Power: {0}", Power);
            Console.WriteLine("Volume: {0}", Volume);
            Console.WriteLine("Fuel type: {0}", FuelType);
        }

    }
    class DriveType : Engine
    {
        string CarDriveType;
        public DriveType(int power, int volume, string type) : base(power, volume, type)
        {
            if (type == "Petrol" || type == "Diesel")
            {
                CarDriveType = "Combustion";
            }
            else
            {
                CarDriveType = "Electric";
            }
        }

        public void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine("Drive type: {0}", CarDriveType);
        }

    }
    class Vehicle : DriveType
    {
        string Color;
        int WheelsNum;
        string CarOrTruck;
        public Vehicle(int power, int volume, string type, string color, int wheelsnum, string carOrTruck) : base (power, volume, type)
        {
            Color = color;
            WheelsNum = wheelsnum;
            CarOrTruck = carOrTruck;
        }
        public void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine("Color: {0}", Color);
            Console.WriteLine("Wheels number: {0}", WheelsNum);
            Console.WriteLine("Vehicle type: {0}", CarOrTruck);
        }
    }
    class Car : Vehicle
    {
        string Brand;
        public Car(int power, int volume, string type, string color, int wheelsnum, string carOrTruck, string brand) : base (power, volume, type, color, wheelsnum, carOrTruck)
         {
             Brand = brand;
         }

        public void ShowInfo()
        { 
        base.ShowInfo();
            Console.WriteLine("Brand: {0}", Brand);
        }

    }


}