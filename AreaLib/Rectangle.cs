namespace AreaLib
{
    public class Rectangle : IAreaCountable
    {
        public double a, b;
        public Rectangle(double side1, double side2) { 
            a = side1;
            b = side2;
        }
        public Rectangle(double side) : this(side, side) { }
        public Rectangle() : this(1, 1) { }

        public double Area
        {
            get => a * b;
        }
    }
}