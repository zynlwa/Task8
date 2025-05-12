
namespace Task8
{
    internal class Vehicle
    {
        public string Color;
        public int Year;
        public Vehicle(string color, int year)
        {
            if (year > 0)
            {
                this.Color = color;
                this.Year = year;
            }
            else
                Console.WriteLine("Buraxilis ili teyin olunmalidir");

        }
    }
}
