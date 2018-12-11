using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int calories = 0, mileage = 0, pace;
            pace = calories - (mileage / 10);
        }
    }
}
