using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DemoAppVeyor.Test
{
    [TestClass]
    public class TestWordHelpers
    {
        [TestMethod, TestCategory("Name")]
        public void TestMethod1()
        {
            const string expected = "Devrock Appveyor";
            const string firstname = "Devrock";
            const string lastname = "Appveyor";

            Assert.AreEqual(expected, WordHelpers.Fullname(firstname, lastname));
        }
    }
}
