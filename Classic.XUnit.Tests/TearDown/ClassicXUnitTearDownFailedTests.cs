using System;
using Xunit;

namespace Classic.XUnit.Tests.TearDown
{
    public class ClassicXUnitTearDownFailedTests : IDisposable
    {
        [Fact]
        public void ClassicXUnitTearDown_Failed_Test1() => Assert.Equal(true, true);

        [Fact]
        public void ClassicXUnitTearDown_Failed_Test2() => Assert.Equal(true, true);

        [Fact]
        public void ClassicXUnitTearDown_Failed_Test3() => Assert.Equal(true, true);

        [Fact]
        public void ClassicXUnitTearDown_Failed_Test4() => Assert.Equal(true, true);

        public void Dispose()
        {
            throw new Exception("Dispose: Critical error!");
        }
    }
}