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
    public class RectangleTests
    {
        [TestMethod()]
        public void RectangleTest()
        {
            if (new Rectangle(5290,4238).Area - 22419020 > 1e-5)
                Assert.Fail();
        }

        [TestMethod()]
        public void RectangleTest1()
        {
            if (new Rectangle(347, 794).Area - 275518 > 1e-5)
                Assert.Fail();
        }
    }
}