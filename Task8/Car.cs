using System.Diagnostics;
using System.Xml.Linq;
using System.Text;

namespace Task8
{
    internal class Car:Vehicle
    {
        public string Brand;
        public string Model;
        public double FuelCapacity;
        public double FuelFor1Km;
        public double CurrentFuel;
        public Car(string color,int year,string brand, string model, double fuelCapacity, double fuelFor1Km, double currentFuel):
            base(color,year)
        {
            if(fuelCapacity>0 && fuelFor1Km>0 & !string.IsNullOrWhiteSpace(brand) && !string.IsNullOrWhiteSpace(model)) {
                this.Brand = brand;
                this.Model = model;
                FuelCapacity = fuelCapacity;
                FuelFor1Km = fuelFor1Km;
                CurrentFuel = currentFuel;
            }else
                Console.WriteLine("Deyerler duzgun daxil edilmeyib");
        }
        public void ShowInfo()
        {
            var info = new StringBuilder();
            info.AppendLine($"Brand: {Brand}");
            info.AppendLine($"Model: {Model}");
            info.AppendLine($"Year: {Year}");
            info.AppendLine($"Color: {Color}");
            info.AppendLine($"Fuel Capacity: {FuelCapacity} L");
            info.AppendLine($"Current Fuel: {CurrentFuel} L");
            info.AppendLine($"Fuel for 1 km: {FuelFor1Km} L");

            Console.WriteLine(info.ToString());
        }


        public void Drive(double km)
        {
            double f = km * FuelFor1Km;
            if (f <= CurrentFuel)
            {
                CurrentFuel -= f;
                Console.WriteLine($"Qalan benzin: {CurrentFuel}");
            }
            else
                Console.WriteLine("Kifayet qeder benzin yoxdur");
        }
    }
}
