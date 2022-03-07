using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorhismPractice
{
    // create base class car 2 properties power and color
    // create a constructor for setting for those 2 properties.
    // create a method ShowDetails-  power and color of the car.
    // create a another method repair method it should print car wasa repaired.
    // create 2 deriving classes tata and suzuki which have their own constructor and have an a additional property called model also a private property brand.
    // brand should be different in each of the tow classes
    // create two methods show details and repair in them as well adjust those methods accordingly.
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car("500","Black");
            car.ShowDetails();
            car.Repair();

            Tata tata = new Tata("1000", "Red", "X", "Tata");
            tata.ShowDetails();
            tata.Repair();

            Suzuki suzuki = new Suzuki("900", "Blue", "Y", "Suzuki");
            suzuki.ShowDetails();
            suzuki.Repair();

            Console.Read();
        }
    }


    class Car
    {
        string power;
        string color;
        public string Power { get { return (power); } set { power = value; } }
        public string Color { get { return (color); } set { color = value; } }
        public Car(string power, string color)
        {
            this.Power = power;
            this.Color = color;
        }
        public virtual void ShowDetails()
        {
            Console.WriteLine("Power {0},  Color {1}", Power, Color);
        }
        public virtual void Repair()
        {
            Console.WriteLine("Car was repaired");
        }
    }

    class Tata : Car
    {
        string carModel;
        private string brand;
        public string CarModel { get { return (carModel); } set { carModel = value; } }
        public string Brand { get { return (brand); } set { brand = value; } }
        public Tata(string power, string color, string carModel, string brand) : base(power, color)
        {
            this.Power = power;
            this.Color = color;
            this.CarModel = carModel;
            this.Brand = brand;
        }

        public override void ShowDetails()
        {
            Console.WriteLine("power {0}, color {1}, car model {2}, brand {3}", Power, Color, CarModel, Brand);
        }
        public override void Repair()
        {
            base.Repair();
            {
                Console.WriteLine("{0} was repaired", Brand);
            }
        }
    }
    class Suzuki : Car
    {
        string carModel;
        private string brand;

        public string Brand { get { return (brand); } set { brand = value; } }
        public string CarModel { get { return (carModel); } set { carModel = value; } }
        public Suzuki(String power, string color, string carModel, string brand) : base(power, color)
        {
            this.Power = power;
            this.Color = color;
            this.CarModel = carModel;
            this.Brand = brand;
        }
        public override void ShowDetails()
        {
            Console.WriteLine("power {0}, color {1}, car model {2}, brand {3}", Power, Color, CarModel, Brand);
        }
        public override void Repair()
        {
            base.Repair();
            {
                Console.WriteLine("{0} was repaired", Brand);
            }
        }
    }
}
