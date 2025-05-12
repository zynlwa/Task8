namespace Task8
{
    internal class Rectangle: Shape1
    { 
        public double Length;
        public Rectangle(string color, double length) : base(color)
        {
            Length = length;
            Area = length * length;
        }
    }
}
