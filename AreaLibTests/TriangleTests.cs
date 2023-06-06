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
    public class TriangleTests
    {
        [TestMethod()]
        public void TriangleTest()
        {
            if (new Triangle(1f, 2f, 2.236067).Area - 1 > 1e-5)
                Assert.Fail();
            if (new Triangle(3f, 4f, 5f).Area - 6 > 1e-5)
                Assert.Fail();
        }
        [TestMethod()]
        public void TriangleTest1()
        {
            if (new Triangle(3f, 3f, 4.24264f).Area - 4.5f > 1e-5)
                Assert.Fail();
        }
        [TestMethod()]
        public void TriangleTest2()
        {
            if (new Triangle(2f, 3f, 4f).Area - 2.9047375f > 1e-5)
                Assert.Fail();
        }
    }
}