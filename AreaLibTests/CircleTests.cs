using Microsoft.VisualStudio.TestTools.UnitTesting;
using AreaLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaLib.Tests
{
    [TestClass()]
    public class CircleTests
    {
        const double e = 1e-5;
        [TestMethod()]
        public void CircleTest()
        {
            if (new Circle(639).Area - 1282778.2539064 > e)
                Assert.Fail();
        }
        [TestMethod()]
        public void CircleTest1()
        {
            if (new Circle(83).Area - 21642.431790580 > e)
                Assert.Fail();
        }
    }
}