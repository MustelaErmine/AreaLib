using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaLib
{
    public class Circle : IAreaCountable
    {
        public double radius;
        public Circle(double radius) { this.radius = radius; }
        public double Area { get => Math.PI * radius * radius; }
    }
}
