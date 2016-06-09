using Microsoft.VisualStudio.TestTools.UnitTesting;
using Classic.MSTests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classic.MSTests.Tests
{
    [TestClass]
    public class MyClassTests
    {
        private readonly MyClass myClass = new MyClass();

        [TestMethod]
        public void FiveTest()
        {
            Assert.AreEqual(5, myClass.Five());
        }
    }
}