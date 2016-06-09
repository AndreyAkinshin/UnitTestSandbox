using System;
using System.Runtime.CompilerServices;
using NUnit.Framework;

namespace Classic.NUnit.Tests
{
    [TestFixture]
    public class ClassicNUnitMiscTests
    {
        [Test]
        public void ClassicNUnitMisc_Simple_Passed() => Passed();

        [Test]
        public void ClassicNUnitMisc_Simple_Failed() => Failed();

        private void Passed([CallerMemberName] string caller = null)
        {
            Console.WriteLine("Output: " + caller);
            Assert.AreEqual(true, true);
        }

        private void Failed([CallerMemberName] string caller = null)
        {
            Console.WriteLine("Output: " + caller);
            Assert.AreEqual(true, false);
        }
    }
}
