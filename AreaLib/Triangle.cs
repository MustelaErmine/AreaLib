namespace AreaLib
{
    public class Triangle : IAreaCountable
    {
        public double a, b, c;
        const double e = 1e-5;

        public double Area { 
            get
            {
                if (IsRectangular)
                {
                    if (c > a && c > b)
                        return (a * b) / 2;
                    else if (a > b && a > c)
                        return (b * c) / 2;
                    else
                        return (a * c) / 2;
                }
                double p = (a + b + c) / 2;
                return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            }
        }
        public bool IsRectangular { 
            get => Math.Abs(c * c - a * a - b * b) < e ||
                   Math.Abs(a * a - c * c - b * b) < e ||
                   Math.Abs(b * b - a * a - c * c) < e;
        }

        public Triangle(double side1, double side2, double side3)
        {
            a = side1;
            b = side2;
            c = side3;
        }
    }
}
