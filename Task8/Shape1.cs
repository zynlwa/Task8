namespace Task8
{
    internal class Shape1
    {
        public string Color;
        public double Area;


        public Shape1(string color)
        {
            Color = color;
        }

        public virtual void GetInfo()
        {
            Console.WriteLine($"Reng: {Color}");
            Console.WriteLine($"Sahe: {Area}");
        }
    }
}
