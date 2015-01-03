using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public class Test
    {
        [TestMethod]
        public void It_Works()
        {
        }

        [TestMethod]
        public void It_Might_Work()
        {
            Assert.Inconclusive();
        }

        [TestMethod]
        public void It_Wont_Work()
        {
            //Assert.Fail();
        }
    }
}
