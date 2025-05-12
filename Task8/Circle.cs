using System.Runtime.CompilerServices;

namespace Task8
{
    internal class Circle:Shape1
    {
        public double Radius;
        public Circle(string color, double radius):base(color) 
        {
            Radius = radius;
            Area=3.14 * radius * radius;
        }
        
    }
}
